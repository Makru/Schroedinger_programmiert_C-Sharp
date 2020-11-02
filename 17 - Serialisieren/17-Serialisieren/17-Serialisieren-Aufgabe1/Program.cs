using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Xml.Serialization;

namespace _17_Serialisieren_Aufgabe1 {
	class Program {
		static void Main(string[] args) {
			Person[] personen = new Person[] {
				new Person() { Name = "Schrödinger",
					LieblingsSpeisen = new Speise[] { 
						new Speise() { Name = "Pommes", Art = SpeiseArt.Warm },
						new Speise() {Name = "Schnitzel", Art = SpeiseArt.Warm }
					}
				},
				new Person() { Name = "Schrödingers Freundin",
					LieblingsSpeisen = new Speise[] {
						new Speise() { Name = "Dinkelsalat", Art = SpeiseArt.Kalt }
					}
				}
			};

			string file = @"C:\Schroedinger\Essen_bin.txt";
			BinaryFormatter binary = new BinaryFormatter();
			using (Stream s = File.OpenWrite(file))
				binary.Serialize(s, personen);


			file = @"C:\Schroedinger\Essen_xml.txt";
			XmlSerializer xml = new XmlSerializer(typeof(Person[]));
			using (Stream s = File.OpenWrite(file))
				xml.Serialize(s, personen);

			using (Stream s = File.OpenRead(file)) {
				Person[] persons = (Person[])xml.Deserialize(s);
			}

			file = @"C:\Schroedinger\Essen_jsons.txt";
			DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(Person[]));
			using (Stream s = File.OpenWrite(file))
				json.WriteObject(s, personen);
			using (Stream s = File.OpenRead(file)) {
				Person[] persons = (Person[])json.ReadObject(s);
			}
		}
	}
}
