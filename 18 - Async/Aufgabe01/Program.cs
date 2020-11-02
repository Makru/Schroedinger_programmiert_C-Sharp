using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aufgabe01 {
	class Program {
		static AutoResetEvent waiter = new AutoResetEvent(false);
		static int counter = 0;
		static Uri[] urls = new Uri[] {
				new Uri("http://bit.ly/leseprobe_schroedinger_html5"),
				new Uri("http://bit.ly/leseprobe_schroedinger_cplusplus"),
				new Uri("http://bit.ly/leseprobe_programmieren_lernen"),
				new Uri("http://bit.ly/leseprobe_schroedinger_abap")
			};
		
		static void Main(string[] args) {
			foreach (Uri url in urls) {
				using (System.Net.WebClient client = new System.Net.WebClient()) {
					string filename = url.Segments[url.Segments.Length - 1] + ".pdf";
					Console.WriteLine("Lade {0} herunter", filename);
					client.DownloadFileCompleted += client_DownloadFileCompleted;
					client.DownloadFileAsync(url, @"C:\Schroedinger\" + filename);
				}
			}
			waiter.WaitOne();
			Console.WriteLine("Fertig");
			Console.ReadKey();

		}

		static void client_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
			Console.WriteLine("Download abgeschlossen.");
			counter++;
			if (urls.Length == counter)
				waiter.Set();
		}
	}
}
