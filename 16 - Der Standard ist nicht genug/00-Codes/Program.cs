using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codes {
	class Program {
		static void Main(string[] args) {
			DateTime now = DateTime.Now;
			int days = now.DaysSinceMillenium();
			Console.WriteLine("Days since millenium " + days);


			string text = "hallo schrödinger";
			string upperText = text.UpperCaseLetters(5);
			string upperText2 = StringExtensions.UpperCaseLetters(text, 5);
			Console.WriteLine(upperText);
			Console.WriteLine(upperText2);

			string result = ((string)null).UpperCaseLetters();
			//string result = StringExtensions.UpperCaseLetters(null);

			LambdaSamples();
		}

		static void LambdaSamples() {
			Func<int, int, int> myAddFunc = (a, b) => a + b;
			Console.WriteLine(myAddFunc(2, 3));
			string[] myCollection = new string[] { "Wow" };

			var result = myCollection
				.Where(myItem => myItem.StartsWith("WoW"))
				.OrderBy(myItem => myItem);
		}
	}
}
