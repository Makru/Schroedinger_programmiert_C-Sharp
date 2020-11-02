using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Events {
	public enum DrinkType {
		Alcoholic,
		NonAlcoholic
	}
	public class DrinkEventArgs : EventArgs {
		public DrinkEventArgs(DrinkType type) {
			this.Drink = type;
		}
		public DrinkType Drink { get; set; }
	}
}
