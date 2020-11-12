using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Kochrezept {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Zutaten vom überbackenen Dinkelpfannkuchen");
            PrintIngredients("Dinkelvollkornmehl", "Milch", "Salz", "Zwiebel", "Lauch", "Weißkraut", "Karotten", "Sellerie", "Butter", "Eigelb", "Sauerrahm", "Sahne", "Emmentaler", "Eier", "Pfeffer", "Curry", "Muskatnuss");

            Console.WriteLine("Zutaten vom Dinkelsalat");
            string[] ingredients = new string[] { "Dinkel", "Tomaten", "Rucola", "Mozzarella", "Thunfisch", "Oliven", "Knoblauch", "Olivenöl", "Salz" };
            PrintIngredients(ingredients);
        }

        static void PrintIngredients(params string[] ingredients) {
            foreach (string ingredient in ingredients)
                Console.WriteLine(ingredient);
        }
    }
}
