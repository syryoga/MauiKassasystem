using MauiKassasystem.Model;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiKassasystem.Datenbank;

namespace MauiKassasystem.Services
{
    public class dbServices
    {
        public dbServices()
        {

        }

        public string Password = "";
        public bool IsAuthenticated = false;

        public static decimal recivedMoney = 0;
        public static decimal summ = 0.00m;

        public static Dictionary<Produkt, int> orderList = new Dictionary<Produkt, int>();


        


    }
}
