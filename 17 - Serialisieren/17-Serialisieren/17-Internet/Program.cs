using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _17_Internet {
	class Program {
		static void Main(string[] args) {
			System.Net.WebRequest request = System.Net.HttpWebRequest.Create("http://www.worldofwarcraft.com");
			using (System.Net.WebResponse response = request.GetResponse()) {
				using (System.IO.Stream stream = response.GetResponseStream()) {
					StreamReader reader = new StreamReader(stream);
					string htmlContent = reader.ReadToEnd();
					Console.WriteLine(htmlContent);
				}

			}

			using (System.Net.WebClient client = new System.Net.WebClient()) {
				string htmlContent = client.DownloadString("http://www.galileo-computing.de");
				Console.WriteLine(htmlContent);
			}

			using (WebClient client = new WebClient()) {
				client.DownloadFileCompleted += client_DownloadFileCompleted;
				string url = "http://www.galileocomputing.de/download/dateien/2867/galileocomputing_programmieren_lernen_2..pdf";
				client.DownloadFileAsync(new Uri(url), @"C:\Schroedinger\ProgrammierenLernenLeseprobe.pdf");
				Console.WriteLine("Herunterladen gestartet");
			}

		}

		static void client_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
			Console.WriteLine("Herunterladen fertiggestellt");
		}
	}
}
