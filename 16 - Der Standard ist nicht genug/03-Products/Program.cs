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
			// LINQ VARIANTE
			//var result = from p in products
			//			 join c in cats on p.CategoryId equals c.Id
			//			 orderby p.Name
			//			 select new {   // Ein neues anonymes Objekt erstellen.
			//				 ProductName = p.Name,
			//				 CategoryName = c.Name,
			//				 CategoryId = c.Id
			//			 };

			// LAMBDA VARIANTE
			var result = products
				.OrderBy(prod => prod.Name)
				.Join(cats,
					product => product.CategoryId,
					cat => cat.Id,
					(product, cat) => new {
						ProductName = product.Name,
						CategoryName = cat.Name,
						CategoryId = cat.Id
					}
				);
			// Ausgabe
			foreach (var item in result) {
				Console.WriteLine("Produkt: {0}; Kategorie: {1} (ID: {2})",
					item.ProductName,
					item.CategoryName,
					item.CategoryId);
			}


			// Gruppierte Produktgruppen
			// LINQ VARIANTE
			//var result1 = from c in cats
			//			  join p in products on c.Id equals p.CategoryId into productInfos
			//			  select new {   // Ein neues anonymes Objekt erstellen.
			//				  Category = c.Name,
			//				  Products = productInfos
			//			  };
			// LAMBDA VARIANTE
			var result1 = cats.GroupJoin(products, c => c.Id, p => p.CategoryId,
										(c, productInfos) => new {	// Wieder ein anonymes Objekt
											Category = c.Name,
											Products = productInfos
										}
									);
			foreach (var item in result1) {
				Console.WriteLine("Kategorie: {0}", item.Category);
				foreach (Product p in item.Products)
					Console.WriteLine("\tProdukt: {0}", p.Name);
			}

			// Left join
			// LINQ VARIANTE
			//var result2 = from p in products
			//			  join c in cats on p.CategoryId equals c.Id into catInfo
			//			  from item in catInfo.DefaultIfEmpty(new Category())
			//			  select new {
			//				  ProductName = p.Name,
			//				  CategoryName = item.Name,
			//				  CategoryId = item.Id
			//			  };

			// LAMBDA Variante
			var result2 = products.GroupJoin(cats,
					p => p.CategoryId,
					c => c.Id,
					(x, y) => new { product = x, cat = y })
				.SelectMany(
					x => x.cat.DefaultIfEmpty(new Category()),
					(x, y) => new {
						CategoryName = y.Name,
						CategoryId = y.Id,
						ProductName = x.product.Name
					});

			foreach (var item in result2) {
				Console.WriteLine("Produkt: {0}; Kategorie: {1} (ID: {2})",
					item.ProductName,
					item.CategoryName,
					item.CategoryId);
			}

			// Übung: Gerade Zahlen
			int[] items = new int[] { 0, 2, 4, 8, 7, 10, 3, 2 };
			var evenItems = items.Skip(2).TakeWhile(n => n % 2 == 0);
			foreach (var item in evenItems)
				Console.WriteLine(item);

			Console.ReadKey();
		}
	}
}
