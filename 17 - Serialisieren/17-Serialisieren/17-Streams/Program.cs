using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Streams {
	class Program {
		static void Main(string[] args) {
			string directory = @"C:\Schroedinger";
			string filename = directory + "\\Schroedinger.txt";
			Console.WriteLine("Bitte Text eingeben:");
			string text = Console.ReadLine();

			// Datei zum schreiben öffnen
			using (FileStream fs = File.OpenWrite(filename)) {
				byte[] info = new UTF8Encoding(true).GetBytes(text);
				fs.Seek(0, SeekOrigin.End);
				// In die Datei schreiben
				fs.Write(info, 0, info.Length);
			}

			Console.WriteLine("Datei geschrieben. Jetzt wieder lesen:");
			// Datei zum Lesen öffnen
			using (FileStream fs = File.OpenRead(filename)) {
				byte[] b = new byte[5];
				UTF8Encoding temp = new UTF8Encoding(true);
				fs.Seek(10, SeekOrigin.Begin);
				while (fs.Read(b, 0, b.Length) > 0) {
					Console.Write(temp.GetString(b));
				}
			}

			Console.WriteLine("Stream Eigenschaften:");
			using (FileStream fs = File.OpenWrite(filename)) {
				GetStreamProperties(fs);
			}
			using (FileStream fs = File.OpenRead(filename)) {
				GetStreamProperties(fs);
			}

			//File.Delete(filename);
			using (FileStream fs = File.Open(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite)) {
				GetStreamProperties(fs);
				byte[] info = new UTF8Encoding(true).GetBytes(text);
				// Text schreiben
				fs.Write(info, 0, info.Length);

				// und auch gleich wieder lesen - zeichenweise ;-)
				fs.Seek(0, SeekOrigin.Begin);
				byte[] bytes = new byte[1];
				UTF8Encoding theText = new UTF8Encoding(true);
				while (fs.Read(bytes, 0, bytes.Length) > 0)
					Console.Write(theText.GetString(bytes));
			}
			Console.WriteLine();
		}

		static void GetStreamProperties(Stream stream) {
			Console.WriteLine("Lesen erlaubt: {0}", stream.CanRead);
			Console.WriteLine("Schreiben erlaubt: {0}", stream.CanWrite);
			Console.WriteLine("Überspringen erlaubt: {0}", stream.CanSeek);
		}
	}
}
