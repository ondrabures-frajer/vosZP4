namespace SkladovySystem;

partial class MainForm
{
    private System.ComponentModel.IContainer components = null!;
    private Label lblNazev;
    private Label lblKategorie;
    private Label lblCena;
    private Label lblPocetKusu;
    private TextBox txtNazev;
    private TextBox txtKategorie;
    private TextBox txtCena;
    private TextBox txtPocetKusu;
    private Button btnPridat;
    private Button btnUpravit;
    private Button btnSmazat;
    private Button btnVymazat;
    private TextBox txtHledat;
    private Label lblHledat;
    private Button btnHledat;
    private DataGridView dgvProdukty;
    private Label lblVybrano;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblNazev = new Label();
        lblKategorie = new Label();
        lblCena = new Label();
        lblPocetKusu = new Label();
        txtNazev = new TextBox();
        txtKategorie = new TextBox();
        txtCena = new TextBox();
        txtPocetKusu = new TextBox();
        btnPridat = new Button();
        btnUpravit = new Button();
        btnSmazat = new Button();
        btnVymazat = new Button();
        txtHledat = new TextBox();
        lblHledat = new Label();
        btnHledat = new Button();
        dgvProdukty = new DataGridView();
        lblVybrano = new Label();
        ((System.ComponentModel.ISupportInitialize)dgvProdukty).BeginInit();
        SuspendLayout();
        // 
        // lblNazev
        // 
        lblNazev.AutoSize = true;
        lblNazev.Location = new Point(20, 20);
        lblNazev.Name = "lblNazev";
        lblNazev.Size = new Size(39, 15);
        lblNazev.TabIndex = 0;
        lblNazev.Text = "Název";
        // 
        // lblKategorie
        // 
        lblKategorie.AutoSize = true;
        lblKategorie.Location = new Point(20, 60);
        lblKategorie.Name = "lblKategorie";
        lblKategorie.Size = new Size(57, 15);
        lblKategorie.TabIndex = 1;
        lblKategorie.Text = "Kategorie";
        // 
        // lblCena
        // 
        lblCena.AutoSize = true;
        lblCena.Location = new Point(20, 100);
        lblCena.Name = "lblCena";
        lblCena.Size = new Size(34, 15);
        lblCena.TabIndex = 2;
        lblCena.Text = "Cena";
        // 
        // lblPocetKusu
        // 
        lblPocetKusu.AutoSize = true;
        lblPocetKusu.Location = new Point(20, 140);
        lblPocetKusu.Name = "lblPocetKusu";
        lblPocetKusu.Size = new Size(65, 15);
        lblPocetKusu.TabIndex = 3;
        lblPocetKusu.Text = "Počet kusů";
        // 
        // txtNazev
        // 
        txtNazev.Location = new Point(110, 17);
        txtNazev.Name = "txtNazev";
        txtNazev.Size = new Size(220, 23);
        txtNazev.TabIndex = 4;
        // 
        // txtKategorie
        // 
        txtKategorie.Location = new Point(110, 57);
        txtKategorie.Name = "txtKategorie";
        txtKategorie.Size = new Size(220, 23);
        txtKategorie.TabIndex = 5;
        // 
        // txtCena
        // 
        txtCena.Location = new Point(110, 97);
        txtCena.Name = "txtCena";
        txtCena.Size = new Size(220, 23);
        txtCena.TabIndex = 6;
        // 
        // txtPocetKusu
        // 
        txtPocetKusu.Location = new Point(110, 137);
        txtPocetKusu.Name = "txtPocetKusu";
        txtPocetKusu.Size = new Size(220, 23);
        txtPocetKusu.TabIndex = 7;
        // 
        // btnPridat
        // 
        btnPridat.Location = new Point(20, 185);
        btnPridat.Name = "btnPridat";
        btnPridat.Size = new Size(90, 30);
        btnPridat.TabIndex = 8;
        btnPridat.Text = "Přidat";
        btnPridat.UseVisualStyleBackColor = true;
        btnPridat.Click += btnPridat_Click;
        // 
        // btnUpravit
        // 
        btnUpravit.Enabled = false;
        btnUpravit.Location = new Point(120, 185);
        btnUpravit.Name = "btnUpravit";
        btnUpravit.Size = new Size(90, 30);
        btnUpravit.TabIndex = 9;
        btnUpravit.Text = "Upravit";
        btnUpravit.UseVisualStyleBackColor = true;
        btnUpravit.Click += btnUpravit_Click;
        // 
        // btnSmazat
        // 
        btnSmazat.Enabled = false;
        btnSmazat.Location = new Point(220, 185);
        btnSmazat.Name = "btnSmazat";
        btnSmazat.Size = new Size(90, 30);
        btnSmazat.TabIndex = 10;
        btnSmazat.Text = "Smazat";
        btnSmazat.UseVisualStyleBackColor = true;
        btnSmazat.Click += btnSmazat_Click;
        // 
        // btnVymazat
        // 
        btnVymazat.Location = new Point(320, 185);
        btnVymazat.Name = "btnVymazat";
        btnVymazat.Size = new Size(100, 30);
        btnVymazat.TabIndex = 11;
        btnVymazat.Text = "Vyčistit pole";
        btnVymazat.UseVisualStyleBackColor = true;
        btnVymazat.Click += btnVymazat_Click;
        // 
        // txtHledat
        // 
        txtHledat.Location = new Point(574, 20);
        txtHledat.Name = "txtHledat";
        txtHledat.Size = new Size(220, 23);
        txtHledat.TabIndex = 12;
        txtHledat.TextChanged += txtHledat_TextChanged;
        // 
        // lblHledat
        // 
        lblHledat.AutoSize = true;
        lblHledat.Location = new Point(444, 23);
        lblHledat.Name = "lblHledat";
        lblHledat.Size = new Size(126, 15);
        lblHledat.TabIndex = 13;
        lblHledat.Text = "Hledat název/kategorii";
        // 
        // btnHledat
        // 
        btnHledat.Location = new Point(804, 18);
        btnHledat.Name = "btnHledat";
        btnHledat.Size = new Size(80, 27);
        btnHledat.TabIndex = 14;
        btnHledat.Text = "Obnovit";
        btnHledat.UseVisualStyleBackColor = true;
        btnHledat.Click += btnHledat_Click;
        // 
        // dgvProdukty
        // 
        dgvProdukty.AllowUserToAddRows = false;
        dgvProdukty.AllowUserToDeleteRows = false;
        dgvProdukty.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvProdukty.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvProdukty.Location = new Point(444, 60);
        dgvProdukty.MultiSelect = false;
        dgvProdukty.Name = "dgvProdukty";
        dgvProdukty.ReadOnly = true;
        dgvProdukty.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvProdukty.Size = new Size(440, 280);
        dgvProdukty.TabIndex = 15;
        dgvProdukty.CellClick += dgvProdukty_CellClick;
        // 
        // lblVybrano
        // 
        lblVybrano.AutoSize = true;
        lblVybrano.Location = new Point(20, 325);
        lblVybrano.Name = "lblVybrano";
        lblVybrano.Size = new Size(73, 15);
        lblVybrano.TabIndex = 16;
        lblVybrano.Text = "Vybráno: nic";
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(909, 352);
        Controls.Add(lblVybrano);
        Controls.Add(dgvProdukty);
        Controls.Add(btnHledat);
        Controls.Add(lblHledat);
        Controls.Add(txtHledat);
        Controls.Add(btnVymazat);
        Controls.Add(btnSmazat);
        Controls.Add(btnUpravit);
        Controls.Add(btnPridat);
        Controls.Add(txtPocetKusu);
        Controls.Add(txtCena);
        Controls.Add(txtKategorie);
        Controls.Add(txtNazev);
        Controls.Add(lblPocetKusu);
        Controls.Add(lblCena);
        Controls.Add(lblKategorie);
        Controls.Add(lblNazev);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Skladový systém";
        ((System.ComponentModel.ISupportInitialize)dgvProdukty).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
}
