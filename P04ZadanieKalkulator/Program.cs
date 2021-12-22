using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04ZadanieKalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            KalkulatorUniwersalny km = new KalkulatorUniwersalny(Operacja.Mnozenie);

            int wynik =  km.WykonajOperacje(2, 3);


            KalkulatorUniwersalny ko = new KalkulatorUniwersalny(Operacja.Odejmowanie);
            wynik = ko.WykonajOperacje(2, 3);


        }
    }
}
