using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MauiKassasystem.Model
{
    public class Kategorie
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string KategorieName { get; set; }
        public string KategorieBild { get; set; }
        public bool IstAktiveKategorie { get; set; } = true;
    }
}
