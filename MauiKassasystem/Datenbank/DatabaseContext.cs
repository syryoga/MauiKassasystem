using MauiKassasystem.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Windows.Devices.AllJoyn;

namespace MauiKassasystem.Datenbank
{
    public class DatabaseContext
    {
        string _dbPath;

        private SQLiteAsyncConnection dbContext;

        public DatabaseContext(string dbPath)
        {
            _dbPath = dbPath;
        }

        private async Task InitDbAsync()
        {
            // Wenn DB existiert mach geh raus und mach nix
            if (dbContext != null)
            {
                // await CreateAllTablesNew();
                return;
            }
            else
            {
                // Andernfalls...

                // ...DB Instanzieren
                dbContext = new SQLiteAsyncConnection(_dbPath);


                // START: Prüfe ob die DB erzeugt wurde
                var checkDB = await dbContext.GetTableInfoAsync(
                    "Bilder");

                if (checkDB.Count > 0) {
                    return;
                }

                // END

                // ...Tabellen erstellen
                await dbContext.CreateTableAsync<Bilder>();
                await dbContext.CreateTableAsync<Kategorie>();
                await dbContext.CreateTableAsync<Money>();
                await dbContext.CreateTableAsync<Produkt>();
                await dbContext.CreateTableAsync<Verkauf>();
                await dbContext.CreateTableAsync<VkPositionen>();
                await dbContext.CreateTableAsync<Zugangsdaten>();

                // ...Standard-Kategorien und -Produkte erstellen
                await CreateDefaultCategoriesAsync();
                await CreateDefaultProductsAsync();


                await CreateFakeSaleAsync();
            }

  

        }


        #region Kategorien

        public async Task CreateCategoryAsync(string name, string bild)
        {
            await InitDbAsync();
            Kategorie kategorie = new Kategorie
            {
                KategorieName = name,
                KategorieBild = bild
            };

            await dbContext.InsertAsync(kategorie);
        }

        public async Task DeleteCategoryAsync(int id)
        {
            await InitDbAsync();
            await dbContext.DeleteAsync<Kategorie>(id);
        }

        public async Task<List<Kategorie>> AllCategoriesToListAsync()
        {
            await InitDbAsync();
            return await dbContext.Table<Kategorie>().ToListAsync();
        }

        #endregion

        #region Produkte
        public async Task CreateProductAsync(Produkt p)
        {
            await InitDbAsync();
            await dbContext.InsertAsync(p);
        }
        public async Task UpdateProductAsync(Produkt p)
        {
            await dbContext.UpdateAsync(p);
        }
        public async Task DeleteProductAsync(Produkt p)
        {
            await InitDbAsync();
            await dbContext.DeleteAsync(p);
        }
        public async Task<List<Produkt>> AllProductsToListAsync()
        {
            await InitDbAsync();
            return await dbContext.Table<Produkt>().ToListAsync();
        }
        public async Task<Produkt> GetProductByIdAsync(int id)
        {
            await InitDbAsync();
            return await dbContext.Table<Produkt>().Where(p => p.Id == id).FirstOrDefaultAsync();
        }

        #endregion

        #region Verkäufe (Sales)
        // alle verkauften Produkte

        public async Task SavePosAsync(VkPositionen p)
        {
            await InitDbAsync();
            await dbContext.InsertAsync(p);
        }

        public async Task SaveSaleAsync(Verkauf v)
        {
            await InitDbAsync();
            await dbContext.InsertAsync(v);
        }
        public async Task DeleteSaleAsync(Verkauf v)
        {
            await InitDbAsync();
            await dbContext.DeleteAsync(v);
        }
        public async Task<List<VkPositionen>> AllSalesToListAsync()
        {
            await InitDbAsync();
            return await dbContext.Table<VkPositionen>().ToListAsync();
        }

        public async Task<List<Verkauf>> AllVkPositionsToListAsync()
        {
            await InitDbAsync();
            return await dbContext.Table<Verkauf>().ToListAsync();
        }
        #endregion

        #region Default Datensätze erstellen

        private async Task CreateDefaultCategoriesAsync()
        {
            Kategorie kategorieWarm = new Kategorie { KategorieName = "Warm", KategorieBild = "kat_warm_75" };
            await dbContext.InsertAsync(kategorieWarm);
            Kategorie kategorieKalt = new Kategorie { KategorieName = "Kalt", KategorieBild = "kat_kalt_75" };
            await dbContext.InsertAsync(kategorieKalt);
            Kategorie kategorieSnack = new Kategorie { KategorieName = "Snack", KategorieBild = "kat_snack_75" };
            await dbContext.InsertAsync(kategorieSnack);
            Kategorie kategorieSonstiges = new Kategorie { KategorieName = "Sonstiges", KategorieBild = "kat_sonst_75" };
            await dbContext.InsertAsync(kategorieSonstiges);
        }

        private async Task CreateDefaultProductsAsync()
        {
            Produkt smoothie = new Produkt { KategorieId = 2, ProduktName = "Smoothie", ProduktBild = "kalt_smoothie", ProduktPreis = 1.0m };
            await dbContext.InsertAsync(smoothie);
            Produkt espresso = new Produkt { KategorieId = 1, ProduktName = "Espresso", ProduktBild = "warm_kaffee", ProduktPreis = 0.3m };
            await dbContext.InsertAsync(espresso);
            Produkt cappuccino = new Produkt { KategorieId = 1, ProduktName = "Cappuccino", ProduktBild = "warm_kaffee", ProduktPreis = 0.5m };
            await dbContext.InsertAsync(cappuccino);
            Produkt caffeLatte = new Produkt { KategorieId = 1, ProduktName = "Caffe Latte", ProduktBild = "warm_kaffee", ProduktPreis = 0.5m };
            await dbContext.InsertAsync(caffeLatte);
            Produkt kleinerBrauner = new Produkt { KategorieId = 1, ProduktName = "Kleiner Brauner", ProduktBild = "warm_kaffee", ProduktPreis = 0.5m };
            await dbContext.InsertAsync(kleinerBrauner);
            Produkt grosserBrauner = new Produkt { KategorieId = 1, ProduktName = "Großer Brauner", ProduktBild = "warm_kaffee", ProduktPreis = 0.8m };
            await dbContext.InsertAsync(grosserBrauner);
            Produkt tee = new Produkt { KategorieId = 1, ProduktName = "Tee", ProduktBild = "warm_tee", ProduktPreis = 0.3m };
            await dbContext.InsertAsync(tee);
            Produkt frischerSaft = new Produkt { KategorieId = 2, ProduktName = "frischer Saft", ProduktBild = "kalt_saft", ProduktPreis = 1.0m };
            await dbContext.InsertAsync(frischerSaft);
            Produkt shake = new Produkt { KategorieId = 2, ProduktName = "Shake", ProduktBild = "kalt_shake", ProduktPreis = 1.0m };
            await dbContext.InsertAsync(shake);
            Produkt infusedWater = new Produkt { KategorieId = 2, ProduktName = "Infused Water", ProduktBild = "kalt_infused", ProduktPreis = 0.5m };
            await dbContext.InsertAsync(infusedWater);
            Produkt apfel = new Produkt { KategorieId = 3, ProduktName = "Apfel", ProduktBild = "snack_obst", ProduktPreis = 0.5m };
            await dbContext.InsertAsync(apfel);
            Produkt birne = new Produkt { KategorieId = 3, ProduktName = "Birne", ProduktBild = "snack_obst", ProduktPreis = 0.5m };
            await dbContext.InsertAsync(birne);
            Produkt banane = new Produkt { KategorieId = 3, ProduktName = "Banane", ProduktBild = "snack_obst", ProduktPreis = 0.5m };
            await dbContext.InsertAsync(banane);
            Produkt mannerschnitte = new Produkt { KategorieId = 3, ProduktName = "Mannerschnitten", ProduktBild = "snack_schoko", ProduktPreis = 1.0m };
            await dbContext.InsertAsync(mannerschnitte);
            Produkt kaugummi = new Produkt { KategorieId = 3, ProduktName = "Kaugummi", ProduktBild = "kat_snack", ProduktPreis = 1.0m };
            await dbContext.InsertAsync(kaugummi);
            Produkt nussini = new Produkt { KategorieId = 3, ProduktName = "Nussini", ProduktBild = "snack_schoko", ProduktPreis = 1.0m };
            await dbContext.InsertAsync(nussini);
        }

        #endregion


        #region Fake-Sales 

        private async Task CreateFakeSaleAsync()
        {
            Verkauf vk1= new Verkauf { ProduktId=1, Anzahl=2, Einzelpreis=4, Gesamtpreis=8};

            await dbContext.InsertAsync(vk1);

            VkPositionen vkp1 = new VkPositionen { Datum = DateTime.Now, VerkaufsId = 1 };

            await dbContext.InsertAsync(vkp1);

        }
        #endregion


        private async Task CreateAllTablesNew()
        {
            await dbContext.DropTableAsync<Bilder>();
            await dbContext.DropTableAsync<Kategorie>();
            await dbContext.DropTableAsync<Money>();
            await dbContext.DropTableAsync<Produkt>();
            await dbContext.DropTableAsync<Verkauf>();
            await dbContext.DropTableAsync<VkPositionen>();
            await dbContext.DropTableAsync<Zugangsdaten>();

            await dbContext.CreateTableAsync<Bilder>();
            await dbContext.CreateTableAsync<Kategorie>();
            await dbContext.CreateTableAsync<Money>();
            await dbContext.CreateTableAsync<Produkt>();
            await dbContext.CreateTableAsync<Verkauf>();
            await dbContext.CreateTableAsync<VkPositionen>();
            await dbContext.CreateTableAsync<Zugangsdaten>();

        }
    }
}
