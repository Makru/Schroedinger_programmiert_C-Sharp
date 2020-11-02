using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe02_AsyncAwait {
	class Program {
		static void Main(string[] args) {
			Uri[] urls = new Uri[] {
				new Uri("http://bit.ly/leseprobe_schroedinger_html5"),
				new Uri("http://bit.ly/leseprobe_schroedinger_cplusplus"),
				new Uri("http://bit.ly/leseprobe_programmieren_lernen"),
				new Uri("http://bit.ly/leseprobe_schroedinger_abap")
			};

			// Async download
			foreach (Uri url in urls)
				DownloadFile(url).Wait();

			// Parallel download
			Task[] tasks = new Task[urls.Length];
			for (int i = 0; i < urls.Length; i++) {
				tasks[i] = DownloadFile(urls[i]);
			}
			Task.WaitAll(tasks);

			Console.WriteLine("Fertig");
			Console.ReadKey();   
		}

		static async Task DownloadFile(Uri url) {
			using (System.Net.WebClient client = new System.Net.WebClient()) {
				string filename = url.Segments[url.Segments.Length - 1];
				Console.WriteLine("Lade {0} herunter", filename);
				await client.DownloadFileTaskAsync(url, filename + ".pdf");
				Console.WriteLine("{0} gespeichert.", filename);
			}
		}
	}
}
