using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @lock {
	class Program {
		const int RND_NUM = 100000;
		static Random randomizer = new Random();
		static IDictionary<int, int> numbers = new Dictionary<int, int>();

		static void Main(string[] args) {
			Console.WriteLine("Start Task 1");
			Task t1 = Task.Run(() => AddRandomNumbers());
			Console.WriteLine("Start Task 2");
			Task t2 = Task.Run(() => AddRandomNumbers());
			Console.WriteLine("Wait for finishing");
			Task.WaitAll(t1, t2);
		}

		private static void AddRandomNumbers() {
			for (int i = 0; i < RND_NUM; i++) {
				int val = randomizer.Next(0, RND_NUM);
				lock (numbers) {
					if (!numbers.ContainsKey(val))
						numbers.Add(val, val);
				}
			}
		}
	}
}
