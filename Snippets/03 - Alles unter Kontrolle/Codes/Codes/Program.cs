using System;

namespace Codes {
    class Program {
        static void Main(string[] args) {

            bool freundinDa = true;
            if (freundinDa == true) {
                // Fernsehabend mit Schnulzenfilm
            }
            else {
                // WoW zocken mit Pizza und Chips
            }

            bool hatFreundinHunger = false;
            bool hatKatzeHunger = true;
            if (hatFreundinHunger || hatKatzeHunger) {
                // Fütterungszeit
            }

            int tvKanal;
            int actionFilm = 1;
            int liebesFilm = 2;
            if (freundinDa)
                tvKanal = liebesFilm;
            else
                tvKanal = actionFilm;
            tvKanal = freundinDa ? liebesFilm : actionFilm;


            // Code 1
            int dayOfWeek=0;
            bool isWeekend;
            switch (dayOfWeek) {
                case 0:
                case 6:
                    isWeekend = true;
                    break;
                default:
                    isWeekend = false;
                    break;
            }

            if (dayOfWeek == 3 || dayOfWeek == 6)
                isWeekend = true;
            else
                isWeekend = false;

            isWeekend = dayOfWeek == 3 || dayOfWeek == 6 ? true : false;
        }
    }
}
