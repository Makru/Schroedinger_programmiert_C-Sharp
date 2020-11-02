namespace _03_Products {
	using System;
	using System.Linq;

	public static class ExtensionMethods {
		public static int Median(this int[] items) {
			return items.OrderBy(n => n).Skip(items.Count() / 2).Take(1).First();
		}
	}
}
