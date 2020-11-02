using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelWC {
	class Program {
		static int amountOfToiletts = 4;
		static int amountOfPerson = 200;
		static BlockingCollection<Person> toiletts = new BlockingCollection<Person>(amountOfToiletts);
		static Random rnd = new Random(DateTime.Now.Millisecond);

		static void Main(string[] args) {
			Person[] persons = InitializePersons();

			Task producer = InitializeProducer(persons);
			//Task[] consumer = new Task[amountOfToiletts];
			//for (int i = 0; i < consumer.Length; i++) {
			//	consumer[i] = Task.Run(() => Consume());
			//}

			// Aufgabe und Lösung der aufgabe -> Umschreiben auf ein Parallel.For
			ParallelOptions options = new ParallelOptions();
			options.MaxDegreeOfParallelism = amountOfToiletts;
			Parallel.For(0, amountOfToiletts, options, i => Consume());

			List<Task> allTasks = new List<Task>();
			//allTasks.AddRange(consumer);
			allTasks.Add(producer);
			Task.WaitAll(allTasks.ToArray());
			Console.WriteLine("Alle WCs wieder frei!");
			Console.ReadKey();
		}

		private static Task InitializeProducer(Person[] persons) {
			Task producer = Task.Run(() => {
				DateTime start = DateTime.Now;
				for (int i = 0; i < persons.Length; i++) {
					if (persons[i].WaitUntilToilette < DateTime.Now.Subtract(start).TotalSeconds)
						// Ups too late!
						Console.WriteLine("Das ging in die Hose!");
					else {
						toiletts.Add(persons[i]);
						Console.WriteLine("Person {0} ist für {1}s auf der toilette", persons[i].Number, persons[i].TimeOnToilette);
					}
				}
			});

			return producer;
		}

		private static Person[] InitializePersons() {
			Person[] persons = new Person[amountOfPerson];
			for (int i = 0; i < amountOfPerson; i++) {
				persons[i] = new Person(rnd.Next(2, 30), rnd.Next(80, 250));
				persons[i].Number = i;
			}
			return persons;
		}

		private static void Consume() {
			DateTime start = DateTime.Now;
			Person p = toiletts.Take();
			while (p != null) {
				System.Threading.Thread.Sleep(p.TimeOnToilette * 1000);	// Simuliere
				Console.WriteLine("Person {0} ist fertig. Thread: {1}", p.Number, System.Threading.Thread.CurrentThread.ManagedThreadId);
				p = toiletts.Take();
			}
			Console.WriteLine("Niemand ist in der Toilette!");
		}
	}
}
