using System;
using System.Threading.Tasks;

namespace AsyncAwait {
	class Program {
		static void Main(string[] args) {
			Uri[] urls = new Uri[] {
				new Uri("http://bit.ly/leseprobe_schroedinger_html5"),
				new Uri("http://bit.ly/leseprobe_schroedinger_cplusplus"),
				new Uri("http://bit.ly/leseprobe_programmieren_lernen"),
				new Uri("http://bit.ly/leseprobe_schroedinger_abap")
			};
			foreach (Uri url in urls) {
				DownloadFile(url).Wait();
			}
			Console.WriteLine("Fertig");
			Console.ReadKey();
		}

		static async Task DownloadFile(Uri url) {
			using (System.Net.WebClient client = new System.Net.WebClient()) {
				string filename = url.Segments[url.Segments.Length - 1] + ".pdf";
				Console.WriteLine("Lade {0} herunter", filename);
				await client.DownloadFileTaskAsync(url, filename);
			}
		}
	}
}
