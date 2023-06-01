using MauiKassasystem.Datenbank;
using MauiKassasystem.Model;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiKassasystem;



namespace MauiKassasystem.Services
{
    internal class moneyServices
    {
        static public List<Money> moneyList = new List<Money>()
    {
        new Money{Nominal = 0.01m, Counter = 0, ImageUrl = "drawable/Cent1.png",PictureHeight = 75},
        new Money{Nominal = 0.02m, Counter = 0, ImageUrl = "drawable/Cent2.png",PictureHeight = 80},
        new Money{Nominal = 0.05m, Counter = 0, ImageUrl = "drawable/Cent5.png"},
        new Money{Nominal = 0.1m, Counter = 0, ImageUrl = "drawable/Cent10.png"},
        new Money{Nominal = 0.2m, Counter = 0, ImageUrl = "drawable/Cent20.png",PictureHeight = 90},
        new Money{Nominal = 0.5m, Counter = 0, ImageUrl = "drawable/Cent50.png"},
        new Money{Nominal = 1, Counter = 0, ImageUrl = "drawable/Euro1.png"},
        new Money{Nominal = 2, Counter = 0, ImageUrl = "drawable/Euro2.png"},
        new Money{Nominal = 5, Counter = 0, ImageUrl = "drawable/Euro5.jpg"},
        new Money{Nominal = 10, Counter = 0, ImageUrl = "drawable/Euro10.png"},
        new Money{Nominal = 20, Counter = 0, ImageUrl = "drawable/Euro20.png"},

    };

        public static async void Cancel()
        {
            string timeStamp = DateTime.Now.ToString("yyyyMMddHHmmss");

            foreach (var item in dbServices.orderList)
            {
                Verkauf v = new Verkauf();
                
                v.ProduktId = item.Key.Id;
                v.TimeStamp = timeStamp;
                v.ProduktName = item.Key.ProduktName;
                v.Anzahl = item.Value;
                v.Einzelpreis = item.Key.ProduktPreis;
                v.Gesamtpreis = item.Value * v.Einzelpreis;
                v.Datum = DateTime.Now;


                DatabaseContext dbContext = new DatabaseContext(Path.Combine(FileSystem.AppDataDirectory, "kassadb.sqlite"));
                await dbContext.SaveSaleAsync(v);
            }

            dbServices.orderList.Clear();
            dbServices.summ = 0;

            foreach (var nominal in moneyList)
            {
                nominal.Counter = 0;
            }
            dbServices.recivedMoney = 0;
        }
    }
}
