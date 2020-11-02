using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_WoWShop {
    // Definieren eines Shop Eintrags
    public enum Category {
        Handwerkszeug,
        Waffe,
        Kleidung,
        Rüstung,
        Süßigkeit
    }
    class WoWItem {
        public string ID { get; set; }
        public string Desc { get; set; }
        public Category Cat { get; set; }
        public int Price { get; set; }
    }
}
