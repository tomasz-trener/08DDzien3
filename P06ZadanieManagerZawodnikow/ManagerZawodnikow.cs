using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P07ZadanieManagerZawodnikow
{
    class ManagerZawodnikow
    {
        string sciezka = "http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt";

        public ManagerZawodnikow()
        {

        }

        public ManagerZawodnikow(string sciezka)
        {
            this.sciezka = sciezka;
        }

        public Zawodnik[] WygenerujZawodnikow()
        {
            WebClient wc = new WebClient();
            string dane = wc.DownloadString(sciezka);

            string[] wiersze =
                dane.Split(new string[1] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            int liczbaWierszy = wiersze.Length;

            Zawodnik[] tab = new Zawodnik[liczbaWierszy - 1];

            for (int i = 1; i < liczbaWierszy; i++)
            {
                string[] komorki = wiersze[i].Split(';');

                Zawodnik z = new Zawodnik();
                z.Id_zawodnika = Convert.ToInt32(komorki[0]);

                if (!string.IsNullOrWhiteSpace(komorki[1]))
                    z.Id_trenera = Convert.ToInt32(komorki[1]);

                z.Imie = komorki[2];
                z.Nazwisko = komorki[3];
                z.Kraj = komorki[4];
                z.DataUrodzenia = Convert.ToDateTime(komorki[5]);
                z.Wzrost = Convert.ToInt32(komorki[6]);
                z.Waga = Convert.ToInt32(komorki[7]);

                tab[i - 1] = z;
            }

            return tab;
        }

    }
}
