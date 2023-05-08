using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiKassasystem.Model
{
    public class Money
    {
        public decimal Nominal { get; set; }
        public Bilder Picture { get; set; }
        public int Counter { get; set; } = 0;
        public double PictureHeight { get; set; }
        public double PictureWidth { get; set; }

    }
}

