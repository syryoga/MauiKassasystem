using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiKassasystem.Model
{
    public class VerkaufProdukte
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public DateTime Datum { get; set; }

        [ForeignKey("VerkaufsId")]
        public int VerkaufsId { get; set; }
    }
}
