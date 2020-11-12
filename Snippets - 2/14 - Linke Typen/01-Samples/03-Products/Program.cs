using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Products {
    class Program {
        static void Main(string[] args) {
            Product[] products = new Product[] {
                new Product() { Name = "Schreckensmaske", CategoryId=2 },
                new Product() { Name = "Elitedrachen-Stulpenhandschuhe", CategoryId = 2 },
                new Product() { Name = "Lindwurmhaut", CategoryId = 1},
                new Product() { Name = "Runenstoffstück", CategoryId = 3 },
                new Product() { Name = "Luft-Zauberstab", CategoryId = 4 }
            };
            Category[] cats = new Category[] {
                new Category() { Id = 1, Name = "Handwerkszeug" },
                new Category() { Id = 2, Name = "Rüstung" },
                new Category() { Id = 3, Name = "Kleidung" }
            };

            // Gewünscht ist nun ein Objekt, welches sowohl Kategorie als auch Produktname miteinander vereint.
            var result = from p in products
                         join c in cats on p.CategoryId equals c.Id
                         orderby p.Name
                         select new {   // Ein neues anonymes Objekt erstellen.
                             ProductName = p.Name,
                             CategoryName = c.Name,
                             CategoryId = c.Id
                         };
            // Ausgabe
            foreach (var item in result) {
                Console.WriteLine("Produkt: {0}; Kategorie: {1} (ID: {2})",
                    item.ProductName,
                    item.CategoryName,
                    item.CategoryId);
            }


            // Gruppierte Produktgruppen
            var result1 = from c in cats
                          join p in products on c.Id equals p.CategoryId into productInfos
                          select new {   // Ein neues anonymes Objekt erstellen.
                              Category = c.Name,
                              Products = productInfos
                          };
            foreach (var item in result1) {
                Console.WriteLine("Kategorie: {0}", item.Category);
                foreach (Product p in item.Products)
                    Console.WriteLine("\tProdukt: {0}", p.Name);
            }

            // Left join
            var result2 = from p in products
                          join c in cats on p.CategoryId equals c.Id into catInfo
                          from item in catInfo.DefaultIfEmpty(new Category())
                          select new {
                              ProductName = p.Name,
                              CategoryName = item.Name,
                              CategoryId = item.Id
                          };
            foreach (var item in result2) {
                Console.WriteLine("Produkt: {0}; Kategorie: {1} (ID: {2})",
                    item.ProductName,
                    item.CategoryName,
                    item.CategoryId);
            }

            // Übung: Gruppieren nach ersten Buchstaben
            var result3 = from p in products
                          orderby p.Name
                          group p by p.Name[0];

            foreach (var item in result3) {
                Console.WriteLine(item.Key);
                foreach (Product p in item)
                    Console.WriteLine('\t' + p.Name);
            }

            // Übung: Gruppieren und kombinieren.
            var grouped = from item in result2
                          orderby item.ProductName
                          group item by item.ProductName[0];
            foreach (var item in grouped) {
                Console.WriteLine(item.Key);
                foreach (var p in item)
                    Console.WriteLine("\t{0} ({1})", p.ProductName, p.CategoryName);
            }

            // Übung Schwierige Aufgabe -> Produkte mit autom. generierter Produktnummer
            int i = 1;
            var items = from p in products
                        select new {
                            Number = i++,
                            Name = p.Name
                        };
            foreach (var item in items) {
                Console.WriteLine("Produkt #{0}: {1}", item.Number, item.Name);
            }
            Console.ReadKey();
        }
    }
}
