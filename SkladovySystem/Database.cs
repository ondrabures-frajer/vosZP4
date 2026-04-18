using Microsoft.Data.Sqlite;

namespace SkladovySystem;

public static class Database
{
    private static readonly string DbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "sklad.db");
    private static readonly string ConnectionString = $"Data Source={DbPath}";

    public static void Initialize()
    {
        using var connection = new SqliteConnection(ConnectionString);
        connection.Open();

        var command = connection.CreateCommand();
        command.CommandText = @"
            CREATE TABLE IF NOT EXISTS Produkty (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Nazev TEXT NOT NULL,
                Kategorie TEXT NOT NULL,
                Cena REAL NOT NULL,
                PocetKusu INTEGER NOT NULL
            );";
        command.ExecuteNonQuery();
    }

    public static List<Product> GetProducts(string? hledanyText = null)
    {
        var produkty = new List<Product>();

        using var connection = new SqliteConnection(ConnectionString);
        connection.Open();

        var command = connection.CreateCommand();
        command.CommandText = @"
            SELECT Id, Nazev, Kategorie, Cena, PocetKusu
            FROM Produkty
            WHERE @Text IS NULL OR Nazev LIKE '%' || @Text || '%' OR Kategorie LIKE '%' || @Text || '%'
            ORDER BY Id DESC;";
        command.Parameters.AddWithValue("@Text", string.IsNullOrWhiteSpace(hledanyText) ? DBNull.Value : hledanyText.Trim());

        using var reader = command.ExecuteReader();
        while (reader.Read())
        {
            produkty.Add(new Product
            {
                Id = reader.GetInt32(0),
                Nazev = reader.GetString(1),
                Kategorie = reader.GetString(2),
                Cena = reader.GetDecimal(3),
                PocetKusu = reader.GetInt32(4)
            });
        }

        return produkty;
    }

    public static void AddProduct(Product produkt)
    {
        using var connection = new SqliteConnection(ConnectionString);
        connection.Open();

        var command = connection.CreateCommand();
        command.CommandText = @"
            INSERT INTO Produkty (Nazev, Kategorie, Cena, PocetKusu)
            VALUES (@Nazev, @Kategorie, @Cena, @PocetKusu);";
        command.Parameters.AddWithValue("@Nazev", produkt.Nazev);
        command.Parameters.AddWithValue("@Kategorie", produkt.Kategorie);
        command.Parameters.AddWithValue("@Cena", produkt.Cena);
        command.Parameters.AddWithValue("@PocetKusu", produkt.PocetKusu);
        command.ExecuteNonQuery();
    }

    public static void UpdateProduct(Product produkt)
    {
        using var connection = new SqliteConnection(ConnectionString);
        connection.Open();

        var command = connection.CreateCommand();
        command.CommandText = @"
            UPDATE Produkty
            SET Nazev = @Nazev,
                Kategorie = @Kategorie,
                Cena = @Cena,
                PocetKusu = @PocetKusu
            WHERE Id = @Id;";
        command.Parameters.AddWithValue("@Id", produkt.Id);
        command.Parameters.AddWithValue("@Nazev", produkt.Nazev);
        command.Parameters.AddWithValue("@Kategorie", produkt.Kategorie);
        command.Parameters.AddWithValue("@Cena", produkt.Cena);
        command.Parameters.AddWithValue("@PocetKusu", produkt.PocetKusu);
        command.ExecuteNonQuery();
    }

    public static void DeleteProduct(int id)
    {
        using var connection = new SqliteConnection(ConnectionString);
        connection.Open();

        var command = connection.CreateCommand();
        command.CommandText = "DELETE FROM Produkty WHERE Id = @Id;";
        command.Parameters.AddWithValue("@Id", id);
        command.ExecuteNonQuery();
    }
}
