using System;
namespace Codes {
	public static class DateTimeExtensions {
		public static int DaysSinceMillenium(this DateTime val) {
			return val.Subtract(new DateTime(2000, 1, 1)).Days;
		}
	}
}
