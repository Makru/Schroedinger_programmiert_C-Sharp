using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Events {
	class Program {
		static void Main(string[] args) {
			Bar bar = new Bar();
			Person besucher1 = new Person() { Name = "Schrödinger" };
			Person besucher2 = new Person() { Name = "Bernhard" };
			besucher1.Eintreten(bar);
			besucher2.Eintreten(bar);
			bar.RundeAusgeben();
			bar.RundeAusgeben2();
			//DownloadWebsite();




			Console.ReadKey();
		}

		private static void DownloadWebsite() {
			System.Net.WebClient client = new System.Net.WebClient();
			client.DownloadStringCompleted += client_DownloadStringCompleted;
			client.DownloadStringAsync(new Uri("http://www.galileo-computing.de/3232"));
		}

		static void client_DownloadStringCompleted(object sender, System.Net.DownloadStringCompletedEventArgs e) {
			string html = e.Result;
			Console.WriteLine(html);
		}
	}
}
