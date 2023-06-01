using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MauiKassasystem.Model
{
    public class Produkt
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [Indexed]
        public int KategorieId { get; set; }
        [NotNull]
        public string ProduktName { get; set; }
        public string ProduktBild { get; set; }
        public decimal ProduktPreis { get; set; }
        public bool IstAktivProdukt { get; set; } = true;
    }
}

