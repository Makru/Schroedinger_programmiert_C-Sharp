using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces {
    class Program {
        static void Main(string[] args) {
            IHasCaffeine[] caffeineDrinks = new IHasCaffeine[] {
                new Coffee() { Caffeine = 100, Degree=90 },
                new Coke() { Caffeine = 25 }
            };

            foreach (IHasCaffeine drink in caffeineDrinks) {
                Console.WriteLine("Koffeingehalt von {0}: {1}",
                    drink.GetType().Name,
                    drink.Caffeine);
            }


            IHotDrink[] hotDrinks = new IHotDrink[] {
                new Coffee() { Caffeine = 100, Degree=90 },
                new Tea() { Degree = 95}
            };
            foreach (IHotDrink drink in hotDrinks) {
                Console.WriteLine("Temperature von {0}: {1}",
                    drink.GetType().Name,
                    drink.Degree);
            }
        }
    }
}
