using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Werkstatt_Arrays {
	class Program {
		static void Main(string[] args) {
			int[] zahlen = new int[] { 1, 1, 2, 3, 5 };
			int[] mehrZahlen = new int[2];
			mehrZahlen[0] = 1;
			mehrZahlen[1] = 1;
			//mehrZahlen[2] = 2;

			int[][] multiArray = new int[3][];
			multiArray[0] = new int[4];
			multiArray[1] = new int[2];
			multiArray[2] = new int[] { 1, 1, 2, 3 };
			int wert = multiArray[0][2];

			int[,] chess = new int[8, 8];
			chess[0, 0] = 2;
			chess[1, 0] = 3;


			int[] z = new int[] { 1, 1, 2, 3, 5 };
			for (int i = 0; i < z.Length; i += 2)
				Console.WriteLine(z[i]);
                Console.ReadKey();
        }
	}
}