using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_WoWShop {
    class Program {
        static void Main(string[] args) {
            /*
             *  ID *1 Beschreibung *2   Kategorie   Preis
             *  77R   Runenstoffstück   Handwerkszeug     17 
             *  RT1   Luft-Zauberstab   Waffe 2
             *  48P   Heiliger Stecken  Waffe 210
             *  VCC   Lindwurmhaut      Kleidung    3
             *  H03   Schreckensmaske   Rüstung     6
             *  WW2   Elitedrachen-Stulpenhandschuhe Rüstung     2 *3
             *  7N6   Eisenbarren Handwerkszeug     4
             *  2B9   Geburtstagskuchen Süßigkeit   3
             *  845   roter Kandis      Süßigkeit   1
             *  9Z9   grüner Kandis     Süßigkeit   1
             */

            // Verfügbare Elemente im Shop
            WoWItem[] shopItems = new WoWItem[] {
                new WoWItem() { ID = "77R", Desc = "Runenstoffstück", Cat = Category.Handwerkszeug, Price = 17 },
                new WoWItem() { ID = "RT1", Desc = "Luft-Zauberstab", Cat = Category.Waffe, Price = 2 },
                new WoWItem() { ID = "48P", Desc = "Heiliger Stecken", Cat = Category.Waffe, Price = 210 },
                new WoWItem() { ID = "VCC", Desc = "Lindwurmhaut", Cat = Category.Kleidung, Price = 3 },
                new WoWItem() { ID = "H03", Desc = "Schreckensmaske", Cat = Category.Rüstung, Price = 6 },
                new WoWItem() { ID = "WW2", Desc = "Elitedrachen-Stulpenhandschuhe", Cat = Category.Rüstung, Price = 2 },
                new WoWItem() { ID = "7N6", Desc = "Eisenbarren Handwerkszeug", Cat = Category.Handwerkszeug, Price = 4 },
                new WoWItem() { ID = "2B9", Desc = "Geburtstagskuchen", Cat = Category.Süßigkeit, Price = 3 },
                new WoWItem() { ID = "845", Desc = "roter Kandis", Cat = Category.Süßigkeit, Price = 1 },
                new WoWItem() { ID = "9Z9", Desc = "grüner Kandis", Cat = Category.Süßigkeit, Price = 1 },
            };
            Console.WriteLine("Folgende Elemente sind im Shop vorhanden");
            PrintItems(shopItems);

            int myMoney = 10; // Dein verfügbares Gold
            Console.WriteLine("\nDein verfügbares Gold: {0}", myMoney);

            // Leistbare Waffen herausfiltern.
            var buyableItems = from item in shopItems
                               where item.Price <= myMoney
                               where item.Cat == Category.Waffe
                               select item;

            // Ausgabe der verfügbaren
            Console.WriteLine("\nFolgende Waffen könntest du dir kaufen:");
            PrintItems(buyableItems);
            Console.ReadKey();
        }

        private static void PrintItems(IEnumerable<WoWItem> items) {
            foreach (var item in items)
                Console.WriteLine("{0}\t{1}\t{2}\t{3} Gold", item.ID, item.Desc, item.Cat, item.Price);
        }



        //static void Main(string[] args) {
        //    // Zutatenliste von: http://rezepte.nit.at/rezepte/wiener_schnitzel.html
        //    Ingredient[] schnitzelIngredients = new Ingredient[] {
        //        new Ingredient() { Name = "Kalbschnitzel", Unit = IngredientUnit.Stk, Amount = 1 },
        //        new Ingredient() { Name = "Salz", Unit = IngredientUnit.Etwas },
        //        new Ingredient() { Name = "Pfeffer", Unit = IngredientUnit.Etwas },
        //        new Ingredient() { Name = "Milch", Unit = IngredientUnit.Etwas },
        //        new Ingredient() { Name = "Öl", Unit = IngredientUnit.Etwas },
        //        new Ingredient() { Name = "zerdrückter Knoblauch", Unit = IngredientUnit.Etwas },
        //        new Ingredient() { Name = "Zitrone", Unit = IngredientUnit.Stk, Amount = 0.5F },
        //        new Ingredient() { Name = "Mehl", Unit = IngredientUnit.EL, Amount = 2 },
        //        new Ingredient() { Name = "Semmelbröseln", Unit = IngredientUnit.EL, Amount = 2 },
        //    };

        //    var result = from e in schnitzelIngredients
        //                 where e.Amount > 0
        //                 select e;
        //}
    }
}
