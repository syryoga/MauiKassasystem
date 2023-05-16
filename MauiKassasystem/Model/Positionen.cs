using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiKassasystem.Model
{
    public class Positionen
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int ProduktAnzahl { get; set; }
        public string ProduktName { get; set; }
        public decimal ProduktPreis { get; set; }
        public decimal PositionGesamtpreis { get; set; }

        [ForeignKey("VerkaufsId")]
        public int VerkaufsId { get; set; }
    }
}
