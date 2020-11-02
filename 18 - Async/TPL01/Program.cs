using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPL01 {
	class Program {
		static void Main(string[] args) {
			//TryTask().Wait();

			Task<int[]> t1 = new Task<int[]>(GetPrims, (object)new KeyValuePair<int, int>(1, 20000));
			Task<int[]> t2 = new Task<int[]>(GetPrims, (object)new KeyValuePair<int, int>(20001, 40000));
			Task<int[]> t3 = new Task<int[]>(GetPrims, (object)new KeyValuePair<int, int>(40001, 60000));
			Task<int[]> t4 = new Task<int[]>(GetPrims, (object)new KeyValuePair<int, int>(60001, 80000));
			Task<Task<int[]>> t6 = Task.WhenAny<int[]>(t1, t2, t3, t4);

			Task t5 = Task.Factory.ContinueWhenAll<int[]>(new Task<int[]>[] { t1, t2, t3, t4 }, (tasks) => {
				foreach (Task<int[]> task in tasks) {
					Console.WriteLine("Primzahlen von Task: {0}", task.Id);
					Console.WriteLine(String.Join(", ", task.Result));
				}
			});
			t1.Start();
			t2.Start();
			t3.Start();
			t4.Start();
			t6.Wait();
			Console.WriteLine("The first finished task was: " + t6.Result.Id);
			t5.Wait();


			// Task Cancellation
			CancellationTokenSource src = new CancellationTokenSource();
			CancellationToken ct = src.Token;
			ct.Register(() => Console.WriteLine("Abbruch! Rückzug!"));
			Task t = new Task(() => {
				System.Threading.Thread.Sleep(1000);
				if (ct.IsCancellationRequested)
					ct.ThrowIfCancellationRequested();
				Console.WriteLine("Task Finished");
			}, ct);
			t.Start();
			src.CancelAfter(200);
			try {
				t.Wait();
			}
			catch (AggregateException) {
				// Task was canceled.
				Console.WriteLine("ThrowIfCancellationRequested() liefert eben eine Exception");
			}
			Console.WriteLine("Canceled: {0}. Finished: {1}. Error: {2}", t.IsCanceled, t.IsCompleted, t.IsFaulted);
			Console.WriteLine("Finished");
		}

		static int[] GetPrims(object vals) {
			int from = ((KeyValuePair<int, int>)vals).Key;
			int to = ((KeyValuePair<int, int>)vals).Value;
			List<int> prims = new List<int>();
			for (int i = from; i <= to; i++) {
				bool isPrim = true;
				for (int j = 2; j < i / 2; j++)
					if (i % j == 0) {
						isPrim = false;
						break;
					}
				if (isPrim)
					prims.Add(i);
			}
			return prims.ToArray();
		}

		private static async Task TryTask() {
			CancellationTokenSource source = new CancellationTokenSource();
			source.CancelAfter(TimeSpan.FromSeconds(1));
			Task<int> task = Task.Run(() => SlowFunc(1, 2, source.Token), source.Token);

			// (A canceled task will raise an exception when awaited).
			await task;
		}

		private static int SlowFunc(int a, int b, CancellationToken cancellationToken) {
			string someString = string.Empty;
			for (int i = 0; i < 200000; i++) {
				someString += "a";
				if (i % 1000 == 0)
					cancellationToken.ThrowIfCancellationRequested();
			}

			return a + b;
		}
	}
}
