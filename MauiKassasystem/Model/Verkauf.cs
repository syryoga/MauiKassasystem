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
        public DateTime Datum { get; set; } = DateTime.Now;

    }
}
