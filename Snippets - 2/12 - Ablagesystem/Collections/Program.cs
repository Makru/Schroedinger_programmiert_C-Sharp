using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections {
    class Program {
        static void Main(string[] args) {
            System.Collections.ArrayList list = new ArrayList();
            list.Add(42);
            list.Add(new object());
            int theAnswerToAllQuestions = (int)list[0];
            //int theSecondOne = (int)list[1];    // Autsch. Das funktioniert so nicht!

            System.Collections.Hashtable ht = new Hashtable();
            Queue warteschlange = new Queue();
            Stack papierkorb = new Stack();
            SortedList sortierteListe = new SortedList();
            sortierteListe.Add(1, new object());
            sortierteListe.Add(1, new object());


        }
    }
}
