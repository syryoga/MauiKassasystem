﻿ using MauiKassasystem.Model;
using MauiKassasystem.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiKassasystem.Datenbank
{
    
    public static class FakeDatabase
    {
        

    //    static public decimal recivedMoney = 0;
    //    static public decimal summ = 0.00m;

    //    static public Dictionary<Produkt, int> orderList = new Dictionary<Produkt, int>();

    //    static public List<Kategorie> categorieList = new List<Kategorie>()
    //    {
    //        new Kategorie(){Id = 1, IstAktiveKategorie = true, KategorieBild = "drawable/kat_warm.png",KategorieName = "WARM" },
    //        new Kategorie(){Id = 2, IstAktiveKategorie = true, KategorieBild = "drawable/kat_kalt.png",KategorieName = "KALT"},
    //        new Kategorie(){Id = 3, IstAktiveKategorie = true, KategorieBild = "drawable/kat_snack.png",KategorieName = "SNAKS"},
    //        new Kategorie(){Id = 4, IstAktiveKategorie = true, KategorieBild = "drawable/kat_sonst.png",KategorieName = "SONSTI"},
    //    };

    //    static public List<Produkt> productList = new List<Produkt>()
    //{
    //    //Kategorie Warm
    //    new Produkt(){Id = 1, KategorieId = 1, ProduktName = "Kaffee", ProduktBild = "drawable/warm_kaffee.png", ProduktPreis = 2.50m, IstAktivProdukt = true},
    //    new Produkt(){Id = 2, KategorieId = 1, ProduktName = "Latte Macchiato", ProduktBild = "drawable/warm_kaffee.png", ProduktPreis = 3.00m, IstAktivProdukt = true},
    //    new Produkt(){Id = 3, KategorieId = 1, ProduktName = "Cappuccino", ProduktBild = "drawable/warm_kaffee.png", ProduktPreis = 2.80m, IstAktivProdukt = true},
    //    new Produkt(){Id = 4, KategorieId = 1, ProduktName = "Espresso", ProduktBild = "drawable/warm_kaffee.png", ProduktPreis = 2.20m, IstAktivProdukt = true},
    //    new Produkt(){Id = 5, KategorieId = 1, ProduktName = "Mokka", ProduktBild = "drawable/warm_kaffee.png", ProduktPreis = 2.80m, IstAktivProdukt = true},
    //    //Kategorie Kalt
    //    new Produkt(){Id = 6, KategorieId = 2, ProduktName = "Eistee", ProduktBild = "drawable/warm_kaffee.png", ProduktPreis = 2.50m, IstAktivProdukt = true},
    //    new Produkt(){Id = 7, KategorieId = 2, ProduktName = "Cola", ProduktBild = "drawable/warm_kaffee.png", ProduktPreis = 2.00m, IstAktivProdukt = true},
    //    new Produkt(){Id = 8, KategorieId = 2, ProduktName = "Sprite", ProduktBild = "drawable/warm_kaffee.png", ProduktPreis = 2.00m, IstAktivProdukt = true},
    //    new Produkt(){Id = 9, KategorieId = 2, ProduktName = "Fanta", ProduktBild = "drawable/warm_kaffee.png", ProduktPreis = 2.00m, IstAktivProdukt = true},
    //    new Produkt(){Id = 10, KategorieId = 2, ProduktName = "Limonade", ProduktBild = "drawable/warm_kaffee.png", ProduktPreis = 2.50m, IstAktivProdukt = true},
    //    //Kategorie Snaks
    //    new Produkt(){Id = 11, KategorieId = 3, ProduktName = "Chips", ProduktBild = "drawable/warm_kaffee.png", ProduktPreis = 1.50m, IstAktivProdukt = true},
    //    new Produkt(){Id = 12, KategorieId = 3, ProduktName = "Popcorn", ProduktBild = "drawable/warm_kaffee.png", ProduktPreis = 2.00m, IstAktivProdukt = true},
    //    new Produkt(){Id = 13, KategorieId = 3, ProduktName = "Erdnüsse", ProduktBild = "drawable/warm_kaffee.png", ProduktPreis = 1.80m, IstAktivProdukt = true},
    //    new Produkt(){Id = 14, KategorieId = 3, ProduktName = "Pistazien", ProduktBild = "drawable/warm_kaffee.png", ProduktPreis = 2.20m, IstAktivProdukt = true},
    //    //Kategorie Sonst
    //    new Produkt(){Id = 16, KategorieId = 4, ProduktName = "Wasser", ProduktBild = "drawable/warm_kaffee.png", ProduktPreis = 1.00m, IstAktivProdukt = true},
    //    new Produkt(){Id = 17, KategorieId = 4, ProduktName = "Orangensaft", ProduktBild = "drawable/warm_kaffee.png", ProduktPreis = 2.50m, IstAktivProdukt = true},
    //    new Produkt(){Id = 18, KategorieId = 4, ProduktName = "Apfelsaft", ProduktBild = "drawable/warm_kaffee.png", ProduktPreis = 2.50m, IstAktivProdukt = true},
    //    new Produkt(){Id = 19, KategorieId = 4, ProduktName = "Traubensaft", ProduktBild = "drawable/warm_kaffee.png", ProduktPreis = 2.50m, IstAktivProdukt = true},
    //    new Produkt(){Id = 20, KategorieId = 4, ProduktName = "Multivitaminsaft", ProduktBild = "drawable/warm_kaffee.png", ProduktPreis = 3.00m, IstAktivProdukt = true},
    //};


        

        


    //    static public void AddProduktToOrderList(Produkt produkt)
    //    {
    //        if (!orderList.ContainsKey(produkt))
    //        {
    //            orderList.Add(produkt, 1);
    //        }
    //        else
    //        {
    //            orderList[produkt] += 1;
    //        }
    //        TotalPriceCalculation();
    //    }

    //    static public void RemoveProduct(Produkt produkt)
    //    {
    //        orderList[produkt] -= 1;

    //        if (orderList[produkt] < 1)
    //        {
    //            orderList.Remove(produkt);
    //        }
    //        TotalPriceCalculation();
    //    }

    //    static public void TotalPriceCalculation()
    //    {
    //        decimal price = 0;

    //        foreach (var product in orderList)
    //        {
    //            price += product.Value * product.Key.ProduktPreis;
    //        }

    //        summ = price;
    //    }
        

        
    }
}



