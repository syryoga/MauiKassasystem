using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using SQLite;

namespace MauiKassasystem.Model
{
    public class Verkauf
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [ForeignKey("ProduktId")]
        public int ProduktId { get; set; }
        public string ProduktName { get; set; }

        public int Anzahl { get; set; }    
        public decimal Einzelpreis { get; set; }
        public decimal Gesamtpreis { get; set; }
        public DateTime Datum { get; set; }

    }
}

