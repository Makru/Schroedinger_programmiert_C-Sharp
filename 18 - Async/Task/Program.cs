using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks {
	class Program {
		static void Main(string[] args) {
			Task t = Task.Run(() => {
				Console.WriteLine("Ich melde mich nach 2 sec. wieder zurück.");
				System.Threading.Thread.Sleep(2000);
				Console.WriteLine("Bin wieder da!");
			});
			Task t1 = Task.Run(() => {
				Console.WriteLine("Ich schlafe für 1sec.");
				System.Threading.Thread.Sleep(1000);
				Console.WriteLine("1sec vorbei.");
			});
			Task.WaitAll(t, t1);
			Console.WriteLine("Alle fertig!");

		}

		async bool HiMethod() {
			await Task.Run(() => {
				Console.WriteLine("Ich melde mich nach 2 sec. wieder zurück.");
				System.Threading.Thread.Sleep(2000);
				Console.WriteLine("Bin wieder da!");
			});
			return true;
		}
	}
}
