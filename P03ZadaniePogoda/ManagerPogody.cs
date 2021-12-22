using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P03ZadaniePogoda
{
    class ManagerPogody
    {
        // 1)pola -> cecha obiektu -> cechą naszego manager pogody jest to w jakich jednostkach pracuje 
        // 2)konstruktory -> określa sposób tworzenia obiektu -> wymuszamy na programiście podanie jednostki oraz opcjonalnie adresu url 
        // 3)metody -> co nasa klasa potrafi  robić -> potrafi pobierać temperaturę z danego miasta 


        private string adresUrl = "https://www.google.com/search?q=pogoda+";
        private const char znak = '°';
        private const string znakKoncowy = ">";

        private Jednostka jednostka;

        public ManagerPogody(Jednostka jednostka)
        {
            this.jednostka = jednostka;
        }

        public ManagerPogody(Jednostka jednostka, string adresUrl) : this(jednostka)
        {
          //  this.jednostka = jednostka;
            this.adresUrl = adresUrl;
        }

        public double PodajTemperature(string miasto)
        {
            WebClient wc = new WebClient();
            string dane = wc.DownloadString(adresUrl + miasto);
            // File.WriteAllText(@"c:\dane\pogoda.html", dane);

            int indx = dane.IndexOf(znak);
            int aktualnaPoz = indx - 1;

            while (dane.Substring(aktualnaPoz, 1) != znakKoncowy)
                aktualnaPoz--;
            //while (dane[aktualnaPoz] != znakKoncowy)
            //    aktualnaPoz--;

            string wynik = dane.Substring(aktualnaPoz + 1, indx - aktualnaPoz + 1);

            double wynikDouble = Convert.ToDouble(wynik.Substring(0, wynik.Length - 2));

            TransformatorJednostek3 tj3 = new TransformatorJednostek3(Jednostka.Celsjusz, jednostka);

            if (jednostka != Jednostka.Celsjusz)
                wynikDouble = tj3.ZamienTemperatureNaInna(wynikDouble);

            return wynikDouble;

        }
    }
}
