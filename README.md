# Skladový systém (C#)

Aplikace pro správu skladových zásob v C# - Windows Forms a SQLite databáze.

---

## Funkce
- Přidání produktu  
- Úprava produktu  
- Smazání produktu  
- Vyhledávání podle názvu nebo kategorie  
- Přehled všech produktů  

---

## Použité technologie
- C# (.NET)
- Windows Forms
- SQLite
- Microsoft.Data.Sqlite (NuGet)

---

## Databáze
- Databáze se vytvoří automaticky jako soubor `sklad.db`
- Není potřeba instalovat SQL Server
- Data jsou ukládána lokálně

---

## Struktura projektu

SkladovySystem/  
│── SkladovySystem.sln  
│── SkladovySystem/  
│   │── Form1.cs  
│   │── Database.cs  
│   │── Program.cs  
│   │── sklad.db (vytvoří se automaticky)  

---

## Autor
- Ondřej Bureš
