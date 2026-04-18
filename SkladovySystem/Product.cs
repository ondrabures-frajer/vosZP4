namespace SkladovySystem;

public class Product
{
    public int Id { get; set; }
    public string Nazev { get; set; } = string.Empty;
    public string Kategorie { get; set; } = string.Empty;
    public decimal Cena { get; set; }
    public int PocetKusu { get; set; }
}
