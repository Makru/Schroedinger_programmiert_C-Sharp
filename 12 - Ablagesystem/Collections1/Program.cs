using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Collections1 {
	class Program {
		static Stopwatch watch = new Stopwatch();
		static DateTime timer;
		static Random rnd = new Random(DateTime.Now.Millisecond);
		static void Main(string[] args) {
			int amount = 100000;
			int searchAmount = 10000;
			Arrays(amount, searchAmount);
			LinkedList(amount, searchAmount);
			Lists(amount, searchAmount);
			SortedLists(amount, searchAmount);
			SortedDictionaries(amount, searchAmount);
			HashSets(amount, searchAmount);
			Dictionaries(amount, searchAmount);
			Console.WriteLine("Finished");
			Console.ReadKey();
		}

		private static void ListSizeTest() {
			int size = 10000000;
			Stopwatch myWatch = new Stopwatch();
			myWatch.Start();
			List<int> myList = new List<int>();
			for (int i = 0; i < size; i++)
				myList.Add(i);
			myWatch.Stop();
			Console.WriteLine("{0} items: {1}ms", size, myWatch.ElapsedMilliseconds);
			myWatch.Reset();
			myWatch.Start();
			myList = new List<int>(size);
			for (int i = 0; i < size; i++)
				myList.Add(i);
			myWatch.Stop();
			Console.WriteLine("sized: {0} items: {1}ms", size, myWatch.ElapsedMilliseconds);

		}

		private static void Lists(int amount, int searchAmount) {
			StartMeasure("List");
			List<int> list = new List<int>();
			for (int i = 0; i < amount; i++)
				list.Add(rnd.Next(amount));
			EndMeasure("List fill");

			for (int i = 0; i < searchAmount; i++) {
				int search = rnd.Next(amount);
				bool contains = list.Contains(search);
			}
			EndMeasure(String.Format("Searched for {0} times", searchAmount));

			StartMeasure("List mit Größenangabe");
			list = new List<int>(amount);
			for (int i = 0; i < amount; i++)
				list.Add(rnd.Next(amount));
			EndMeasure("List fill");

			for (int i = 0; i < searchAmount; i++) {
				int search = rnd.Next(amount);
				bool contains = list.Contains(search);
			}
			EndMeasure(String.Format("Searched for {0} times", searchAmount));

		}

		private static void LinkedList(int amount, int searchAmount) {
			StartMeasure("Linked List");
			LinkedList<int> list = new LinkedList<int>();
			for (int i = 0; i < amount; i++)
				list.AddLast(rnd.Next(amount));
			EndMeasure("Linked List fill");

			for (int i = 0; i < searchAmount; i++) {
				int search = rnd.Next(amount);
				bool contains = list.Contains(search);
			}
			EndMeasure(String.Format("Searched for {0} times", searchAmount));
		}

		private static void SortedDictionaries(int amount, int searchAmount) {
			StartMeasure("Sorted Dictionary");
			SortedDictionary<int, int> list = new SortedDictionary<int, int>();
			for (int i = 0; i < amount; i++) {
				int val = rnd.Next(amount);
				if (!list.ContainsKey(val))
					list.Add(val, val); ;
			}
			EndMeasure("Sorted Dictionary fill");

			for (int i = 0; i < searchAmount; i++) {
				int search = rnd.Next(amount);
				bool contains = list.ContainsKey(search);
			}
			EndMeasure(String.Format("Searched for {0} times", searchAmount));
		}

		private static void HashSets(int amount, int searchAmount) {
			StartMeasure("HashSet");
			HashSet<int> data = new HashSet<int>();
			for (int i = 0; i < amount; i++)
				data.Add(rnd.Next(amount));
			EndMeasure("HashSet fill");

			for (int i = 0; i < searchAmount; i++) {
				int search = rnd.Next(amount);
				bool contains = data.Contains(search);
			}
			EndMeasure(String.Format("Searched for {0} times", searchAmount));


			StartMeasure("SortedSet");
			SortedSet<int> data1 = new SortedSet<int>();
			for (int i = 0; i < amount; i++)
				data1.Add(rnd.Next(amount));
			EndMeasure("SortedSet fill");

			for (int i = 0; i < searchAmount; i++) {
				int search = rnd.Next(amount);
				bool contains = data1.Contains(search);
			}
			EndMeasure(String.Format("Searched for {0} times", searchAmount));
		}

		private static void Dictionaries(int amount, int searchAmount) {
			StartMeasure("Dictionary");
			Dictionary<int, int> list = new Dictionary<int, int>();
			for (int i = 0; i < amount; i++) {
				int val = rnd.Next(amount);
				if (!list.ContainsKey(val))
					list.Add(val, val); ;
			}
			EndMeasure("Dictionary fill");

			for (int i = 0; i < searchAmount; i++) {
				int search = rnd.Next(amount);
				bool contains = list.ContainsKey(search);
			}
			EndMeasure(String.Format("Searched for {0} times", searchAmount));
		}

		private static void SortedLists(int amount, int searchAmount) {
			StartMeasure("Sorted List");
			SortedList<int, int> list = new SortedList<int, int>();
			for (int i = 0; i < amount; i++) {
				int val = rnd.Next(amount);
				if (!list.ContainsKey(val))
					list.Add(val, val);
			}

			EndMeasure("List fill");

			for (int i = 0; i < searchAmount; i++) {
				int search = rnd.Next(amount);
				bool contains = list.ContainsKey(search);
			}
			EndMeasure(String.Format("Searched for {0} times", searchAmount));
		}


		private static void Arrays(int amount, int searchAmount) {
			StartMeasure("Array");
			int[] data = new int[amount];
			for (int i = 0; i < amount; i++)
				data[i] = rnd.Next(amount);
			EndMeasure("Array fill");

			for (int i = 0; i < searchAmount; i++) {
				int search = rnd.Next(amount);
				for (int j = 0; j < amount; j++)
					if (data[i] == search)
						break;
			}
			EndMeasure(String.Format("Searched for {0} times", searchAmount));
		}
		static void StartMeasure(string text) {
			Console.WriteLine(text);
			timer = DateTime.Now;
			watch.Reset();
			watch.Start();
		}
		static void EndMeasure(string text) {
			watch.Stop();
			double stopsec = watch.ElapsedMilliseconds / 1000.0;
			double seconds = DateTime.Now.Subtract(timer).TotalSeconds;
			Console.WriteLine("{0}: {1}sec ({2}sec)", text, seconds, stopsec);
			timer = DateTime.Now;
			watch.Reset();
			watch.Start();
		}

		static void WorkWithDictionary() {
			Dictionary<int, string> myDict = new Dictionary<int, string>();
			if (!myDict.ContainsKey(4))
				myDict.Add(4, "Schrödinger");
			myDict.Add(1, "Freundin");
			foreach (KeyValuePair<int, string> item in myDict)
				Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
		}

		static void WorkWithSortedDictionary() {
			SortedDictionary<int, string> myDict = new SortedDictionary<int, string>();
			if (!myDict.ContainsKey(4))
				myDict.Add(4, "Schrödinger");
			myDict.Add(1, "Freundin");
			foreach (KeyValuePair<int, string> item in myDict)
				Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
		}

		static void WorkWithSortedLists() {
			SortedList<int, string> myList = new SortedList<int, string>();
			myList.Add(4, "Schrödinger");
			myList.Add(1, "Freundin");
			foreach (KeyValuePair<int, string> item in myList) {
				Console.WriteLine("Key: {0}; Wert: {1}", item.Key, item.Value);
			}
			myList.Add(1, "Schrödinger");
			myList.Add(1, "Freundin");

			if (myList.ContainsKey(1))
				Console.WriteLine("#1 ist da!");
		}

		static void WorkWithSets() {
			HashSet<int> mySet = new HashSet<int>();
			bool wasAdded = mySet.Add(2);
			wasAdded = mySet.Add(2);
			wasAdded = mySet.Add(1);
			wasAdded = mySet.Add(3);
			bool exist = mySet.Contains(1);
			foreach (int item in mySet)
				Console.WriteLine(item);

			SortedSet<int> mySet1 = new SortedSet<int>();
			mySet1.Add(2);
			mySet1.Add(2);
			mySet1.Add(1);
			wasAdded = mySet1.Add(3);
			foreach (int item in mySet1)
				Console.WriteLine(item);

		}
	}
}
