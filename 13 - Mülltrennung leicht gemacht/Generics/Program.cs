using Generics.WoWSample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics {
	class Program {
		static void Main(string[] args) {
			GenericCollections();

			Covariance();

			WoWSampleSimulation();
		}

		private static void WoWSampleSimulation() {
			// Create the big bad boss
			BadBoss badBoy = new BadBoss() { Attack = 40, AttackSpeed = 0.6F, Energy = 250, MaxEnergy = 2500, Name = "Big Boss" };

			// some players....
			IEnumerable<WoWCreature> players = new List<WoWCreature>() {
				new Warrior() { Attack=20, Energy=100, MaxEnergy=100, Name="Player1" },
				new Warrior() { Attack=21, Energy=98, MaxEnergy=100, Name="Player2" },
				new Shaman() { Attack=10, Energy=60, MaxEnergy=80, HealingValue=11, Name="Shaman" }
			};
			int playerCount = 3;

			Random rnd = new Random();

			// do fight.
			int deadPlayers = 0;
			while (deadPlayers < playerCount && badBoy.Energy > 0) {
				foreach (WoWCreature player in players) {
					if (player.Energy <= 0)
						continue;   // Player is dead go next.

					player.DoAttack(badBoy);    // Player attacks

					if (badBoy.Energy <= 0)
						break;                  // Boss is dead.

					if (player is Shaman) {
						// Bad teamplayer -> shaman only heals himself :-\
						((Shaman)player).Heal(player);
					}

					// Let the boss attack the player! Sometimes!
					if (rnd.Next(0, 10) / 10.0F <= badBoy.AttackSpeed)
						badBoy.DoAttack(player);

					if (player.Energy <= 0)
						deadPlayers++;
				}
			}

			if (badBoy.Energy <= 0)
				Console.WriteLine("VICTORY! The boss is dead!");
			else
				Console.WriteLine("YOU LOST!");
		}

		private static void GenericCollections() {
			List<int> myList = new List<int>();
			List<string> secondList = new List<string>();

			TrashContainer<int> iC = new TrashContainer<int>(10);
			TrashContainer<string> sC = new TrashContainer<string>(10);

			iC.Push(1);
			iC.Push(2);
			int lastValue = iC.Pop();

			sC.Push("Papiermüll");
			sC.Push("noch mehr müll");
			string s = sC.Pop();


			WaitingQueue<double> wc = new WaitingQueue<double>(3);
			wc.Push(1);
			wc.Push(2);
			Console.WriteLine(wc.Pop());
			wc.Push(3);
			Console.WriteLine(wc.Pop());
			Console.WriteLine(wc.Pop());


			SortedTrashContainer<int> sortedContainer = new SortedTrashContainer<int>(4);
			sortedContainer.Push(4);
			sortedContainer.Push(2);
			sortedContainer.Push(5);
			Console.WriteLine(sortedContainer.Pop());
			Console.WriteLine(sortedContainer.Pop());
			Console.WriteLine("FOREACH SORTED CONTAINER ITEM");
			foreach (var item in sortedContainer)
				Console.WriteLine(item);
			Console.WriteLine("==END == FOREACH SORTED CONTAINER ITEM");

			List<string> list1 = ObjectCreator<List<string>>.CreateSingleton();
			List<string> list2 = MyCreator.CreateObject<List<string>>();
			var data11 = ObjectCreator<List<string>>.CreateSingleton();
			var data21 = ObjectCreator<Dictionary<string, string>>.CreateSingleton();
			var data22 = ObjectCreator<Dictionary<string, string>>.CreateSingleton();
		}

		private static void Covariance() {
			Action<Base> b = (target) => { Console.WriteLine(target.GetType().Name); };
			Action<Derived> d = b;
			d(new Derived());
			b(new Derived());
			b(new Base());
			//d(new Base());	// <-- doesn't work!
			IComparable<Base> b0 = new Base();
			IComparable<Base> b1 = new Derived();
			IComparable<Derived> b2 = new Derived();
			IComparable<Derived> b3 = new Base();
			b3.CompareTo(new Derived());
			//b3.CompareTo(new Base()); //<-- doesn't work!
		}
	}

	class Base : IComparable<Base> {
		public int Id { get; set; }
		public int CompareTo(Base other) {
			return Id.CompareTo(other.Id);
		}
	}
	class Derived : Base {
	}
}
