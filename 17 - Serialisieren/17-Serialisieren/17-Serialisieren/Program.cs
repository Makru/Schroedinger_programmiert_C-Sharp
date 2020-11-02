using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Json;

namespace _17_Serialisieren {
	class Program {
		static void Main(string[] args) {
			Person schroedinger = new Person() {
				Name = "Schrödinger",
				Email = "schroedinger@galileo-computing.de",
				Weight = 78
			};

			IFormatter f = new BinaryFormatter();
			string filename = @"C:\Schroedinger\schroedinger_binary.txt";
			using (Stream s = File.OpenWrite(filename)) {
				f.Serialize(s, schroedinger);
			}
			using (Stream s = File.OpenRead(filename)) {
				Person p = (Person)f.Deserialize(s);
			}

			XmlSerializer ser = new System.Xml.Serialization.XmlSerializer(typeof(Person));
			filename = @"C:\Schroedinger\schroedinger.xml";
			using (Stream s = File.OpenWrite(filename)) {
				ser.Serialize(s, schroedinger);
			}
			using (Stream s = File.OpenRead(filename)) {
				Person p = (Person)ser.Deserialize(s);
			}

			filename = @"C:\Schroedinger\schroedinger_json.txt";
			DataContractJsonSerializer jsonSer = new System.Runtime.Serialization.Json.DataContractJsonSerializer(typeof(Person));
			using (Stream s = File.OpenWrite(filename)) {
				jsonSer.WriteObject(s, schroedinger);
			}
			using (Stream s = File.OpenRead(filename)) {
				Person p = (Person)jsonSer.ReadObject(s);
			}


		}
	}
}
