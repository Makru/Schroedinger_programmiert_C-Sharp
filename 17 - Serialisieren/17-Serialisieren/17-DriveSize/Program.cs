using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_DriveSize {
	class Program {
		static void Main(string[] args) {
			DriveInfo[] drives = DriveInfo.GetDrives();
			foreach (DriveInfo drive in drives) {
				Console.WriteLine(String.Format("{0}: {1}", drive.Name, GetFormatedSize(drive)));
			}
			Console.Read();
		}

		private static string GetFormatedSize(DriveInfo drive) {
			string[] units = new string[] { "Byte", "KB", "MB", "GB", "TB", "EB" };
			int idx = 0;
			double freeSpace = drive.TotalFreeSpace;
			while (freeSpace > 1024.0 && idx < units.Length) {
				freeSpace /= 1024.0;
				idx++;
			}
			return String.Format("{0}{1}",
				freeSpace.ToString("0.00"),
				units[idx]);
		}
	}
}
