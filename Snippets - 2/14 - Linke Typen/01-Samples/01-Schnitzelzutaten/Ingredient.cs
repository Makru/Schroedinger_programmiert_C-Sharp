using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_WoWShop {
    public enum IngredientUnit {
        g,
        dag,
        kg,
        EL,
        TL,
        Stk,
        Etwas
    }

    public class Ingredient {
        public float Amount { get; set; }
        public IngredientUnit Unit { get; set; }
        public string Name { get; set; }

    }
}
