using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04ZadanieKalkulator
{
    enum Operacja
    {
        Dodawanie,
        Odejmowanie,
        Mnozenie,
        Dzielenie
    }
    class KalkulatorUniwersalny
    {

        private Operacja operacja;

        public KalkulatorUniwersalny(Operacja operacja)
        {
            this.operacja = operacja;
        }


        public int WykonajOperacje(int a, int b)
        {
            if (operacja == Operacja.Dodawanie)
            {
                KalkulatorDodajacy kd = new KalkulatorDodajacy();
                return kd.Dodaj(a, b);
            }
            if (operacja == Operacja.Odejmowanie)
            {
                KalkulatorOdejmujacy kd = new KalkulatorOdejmujacy();
                return kd.Odejmij(a, b);
            }
            if (operacja == Operacja.Mnozenie)
            {
                KalkulatorMnozacy kd = new KalkulatorMnozacy();
                return kd.Przemnoz(a, b);
            }
            if (operacja == Operacja.Dzielenie)
            {
                KalkulatorDzielacy kd = new KalkulatorDzielacy();
                return kd.Podziel(a, b);
            }

            throw new Exception("nieobsługiwana operacja");
        }
    }
}
