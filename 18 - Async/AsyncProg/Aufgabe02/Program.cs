using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe02 {
	class Program {
		static Uri[] urls = new Uri[] {
				new Uri("http://bit.ly/leseprobe_schroedinger_html5"),
				new Uri("http://bit.ly/leseprobe_schroedinger_cplusplus"),
				new Uri("http://bit.ly/leseprobe_programmieren_lernen"),
				new Uri("http://bit.ly/leseprobe_schroedinger_abap")
			};

		static void Main(string[] args) {
			string url = "http://bit.ly/leseprobe_programmieren_lernen";
			using (WebClient client = new WebClient()) {
				Task<byte[]> t = client.DownloadDataTaskAsync(url);
				t.ContinueWith(async (task) => {
					using (FileStream stream = File.OpenWrite(@"C:\Schroedinger\async prog lernen.pdf")) {
						await stream.WriteAsync(task.Result, 0, task.Result.Length);
						Console.WriteLine("Save complete");
					}
				}).Wait();
			}

			Task<byte[]>[] tasks = new Task<byte[]>[urls.Length];
			for (int i = 0; i < urls.Length; i++) {
				using (WebClient client = new WebClient()) {
					Console.WriteLine("Downloading... {0}", urls[i]);
					int index = i;
					tasks[i] = client.DownloadDataTaskAsync(urls[i].ToString());
					tasks[i].ContinueWith(async (t) => {	// Gib diesen Task hier, den ContinueWith zurückgibt neu in die Liste rein
						byte[] data = t.Result;
						string filename = urls[index].Segments[urls[index].Segments.Length - 1] + ".pdf";
						Console.WriteLine("Download complete. Saving {0}.", filename);
						using (FileStream stream = File.OpenWrite(@"C:\Schroedinger\" + filename)) {
							await stream.WriteAsync(data, 0, data.Length);
							Console.WriteLine("Save complete");
						}
						
					}, TaskContinuationOptions.ExecuteSynchronously);
				}
			}
			Console.WriteLine("Programm is now waiting...");
			Task.WaitAll(tasks);
			Console.WriteLine("Finished.");
			Console.ReadKey();
		}
	}
}
