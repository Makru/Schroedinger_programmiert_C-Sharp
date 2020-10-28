using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling {
    class Program {
        static void Main(string[] args) {
            try {
                string text = System.IO.File.ReadAllText("c:\\myFile.txt");
                Console.WriteLine("Der Text in der Datei lautet:");
                Console.WriteLine(text);
            }
            catch (System.IO.FileNotFoundException) {
                Console.WriteLine("Die Datei gibts ja gar nicht!");
            }
            catch (System.IO.DirectoryNotFoundException) {
                Console.WriteLine("Der Ordner zur Datei existiert nicht.");
            }
            catch (UnauthorizedAccessException) {
                Console.WriteLine("Der Zugriff auf die Datei wurde verweigert. Etsch!");
            }
            catch (Exception e) {
                Console.WriteLine("Hoppala. Da hat es etwas ganz komisches:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
