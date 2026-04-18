using System.Globalization;

namespace SkladovySystem;

public partial class MainForm : Form
{
    private int? selectedProductId;

    public MainForm()
    {
        InitializeComponent();
        RefreshGrid();
    }

    private void RefreshGrid()
    {
        dgvProdukty.DataSource = null;
        dgvProdukty.DataSource = Database.GetProducts(txtHledat.Text);

        dgvProdukty.Columns[nameof(Product.Id)].HeaderText = "ID";
        dgvProdukty.Columns[nameof(Product.Nazev)].HeaderText = "Název";
        dgvProdukty.Columns[nameof(Product.Kategorie)].HeaderText = "Kategorie";
        dgvProdukty.Columns[nameof(Product.Cena)].HeaderText = "Cena";
        dgvProdukty.Columns[nameof(Product.PocetKusu)].HeaderText = "Počet kusů";

        dgvProdukty.AutoResizeColumns();
    }

    private bool TryReadForm(out Product produkt)
    {
        produkt = new Product();

        if (string.IsNullOrWhiteSpace(txtNazev.Text))
        {
            MessageBox.Show("Zadej název produktu.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (string.IsNullOrWhiteSpace(txtKategorie.Text))
        {
            MessageBox.Show("Zadej kategorii.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (!decimal.TryParse(txtCena.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out var cena) || cena < 0)
        {
            MessageBox.Show("Cena musí být platné číslo větší nebo rovno 0.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (!int.TryParse(txtPocetKusu.Text, out var pocetKusu) || pocetKusu < 0)
        {
            MessageBox.Show("Počet kusů musí být celé číslo větší nebo rovno 0.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        produkt = new Product
        {
            Id = selectedProductId ?? 0,
            Nazev = txtNazev.Text.Trim(),
            Kategorie = txtKategorie.Text.Trim(),
            Cena = cena,
            PocetKusu = pocetKusu
        };

        return true;
    }

    private void ClearForm()
    {
        selectedProductId = null;
        txtNazev.Clear();
        txtKategorie.Clear();
        txtCena.Clear();
        txtPocetKusu.Clear();
        dgvProdukty.ClearSelection();
        lblVybrano.Text = "Vybráno: nic";
        btnUpravit.Enabled = false;
        btnSmazat.Enabled = false;
    }

    private void btnPridat_Click(object sender, EventArgs e)
    {
        if (!TryReadForm(out var produkt))
            return;

        Database.AddProduct(produkt);
        RefreshGrid();
        ClearForm();
    }

    private void btnUpravit_Click(object sender, EventArgs e)
    {
        if (selectedProductId is null)
        {
            MessageBox.Show("Nejprve vyber produkt z tabulky.", "Upozornění", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        if (!TryReadForm(out var produkt))
            return;

        Database.UpdateProduct(produkt);
        RefreshGrid();
        ClearForm();
    }

    private void btnSmazat_Click(object sender, EventArgs e)
    {
        if (selectedProductId is null)
        {
            MessageBox.Show("Nejprve vyber produkt z tabulky.", "Upozornění", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        var confirm = MessageBox.Show("Opravdu chceš smazat vybraný produkt?", "Potvrzení", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (confirm != DialogResult.Yes)
            return;

        Database.DeleteProduct(selectedProductId.Value);
        RefreshGrid();
        ClearForm();
    }

    private void btnVymazat_Click(object sender, EventArgs e)
    {
        ClearForm();
    }

    private void btnHledat_Click(object sender, EventArgs e)
    {
        RefreshGrid();
    }

    private void txtHledat_TextChanged(object sender, EventArgs e)
    {
        RefreshGrid();
    }

    private void dgvProdukty_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0)
            return;

        var row = dgvProdukty.Rows[e.RowIndex];
        if (row.DataBoundItem is not Product produkt)
            return;

        selectedProductId = produkt.Id;
        txtNazev.Text = produkt.Nazev;
        txtKategorie.Text = produkt.Kategorie;
        txtCena.Text = produkt.Cena.ToString(CultureInfo.InvariantCulture);
        txtPocetKusu.Text = produkt.PocetKusu.ToString();
        lblVybrano.Text = $"Vybráno ID: {produkt.Id}";
        btnUpravit.Enabled = true;
        btnSmazat.Enabled = true;
    }
}
