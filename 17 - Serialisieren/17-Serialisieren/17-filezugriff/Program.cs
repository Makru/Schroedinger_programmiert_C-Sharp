using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _17_filezugriff {
	class Program {
		static void Main(string[] args) {
			string directory = @"C:\Schroedinger";
			string filename = directory + "\\Schroedinger.txt";
			Console.WriteLine("Letzte Änderung: {0}", File.GetLastWriteTime(filename));
			Console.WriteLine("Bitte Text eingeben:");
			string newText = Console.ReadLine();

			if (File.Exists(filename)) {
				Console.WriteLine("Bisher enthaltener Text:");
				string[] existingText;
				try {
					existingText = File.ReadAllLines(filename);
				}
				catch (System.Security.SecurityException) {
					Console.WriteLine("Leider hast du keinen Zugriff auf die Datei. Sicherheitsgründe...");
					return;
				}
				catch (PathTooLongException) {
					Console.WriteLine("Wow der Pfad muss ja wirklich lang sein!");
					return;
				}
				catch (IOException) {
					Console.WriteLine("Uiuiui ein allgemeiner Lesefehler.");
					return;
				}
				for (int i = 0; i < existingText.Length; i++)
					Console.WriteLine(existingText[i]);
			}

			Console.WriteLine("===========================");
			Console.WriteLine("Neu hinzugefügter Text:");
			if (!Directory.Exists(directory))
				Directory.CreateDirectory(directory);
			File.AppendAllText(filename, Environment.NewLine + newText);
			Console.WriteLine(newText);
			Console.WriteLine("===========================");
			Console.ReadKey();
		}

		//static void Main(string[] args) {
		//	string directory = @"C:\Schroedinger";
		//	string filename = directory + "\\Schroedinger.txt";
		//	FileInfo file = new FileInfo(filename);
		//	Console.WriteLine("Letzte Änderung: {0}", file.LastWriteTime);
		//	Console.WriteLine("Bitte Text eingeben:");
		//	string newText = Console.ReadLine();

		//	if (file.Exists) {
		//		Console.WriteLine("Bisher enthaltener Text:");
		//		using (StreamReader reader = file.OpenText()) {
		//			string existingText = reader.ReadToEnd();
		//			Console.WriteLine(existingText);
		//		}
		//	}

		//	Console.WriteLine("===========================");
		//	Console.WriteLine("Neu hinzugefügter Text:");
		//	DirectoryInfo dir = new DirectoryInfo(directory);
		//	if (!dir.Exists)
		//		dir.Create();

		//	using (StreamWriter writer = file.AppendText()) {
		//		writer.WriteLine(newText);
		//	}
		//	Console.WriteLine(newText);
		//	Console.WriteLine("===========================");
		//	Console.ReadKey();

		//}
	}
}
