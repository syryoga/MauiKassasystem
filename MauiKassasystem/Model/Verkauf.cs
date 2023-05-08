using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MauiKassasystem.Model
{
    public class Verkauf
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public DateTime Datum { get; set; } = DateTime.Now;
        public int ProduktAnzahl { get; set; }
        public string ProduktName { get; set; }
        public decimal ProduktPreis { get; set; }
        public decimal ProduktGesamtpreis { get; set; }
    }
}
