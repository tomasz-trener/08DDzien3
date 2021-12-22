using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P07ZadanieManagerZawodnikow
{

    enum RodzajImportu
    {
        Zdalne,
        Lokalne
    }

    class ManagerZawodnikow
    {
        string sciezka = "http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt";
        RodzajImportu rodzajImportu;
        Zawodnik[] zawodnicy;

        public ManagerZawodnikow()
        {

        }

        public ManagerZawodnikow(string sciezka, RodzajImportu rodzajImportu)
        {
            this.rodzajImportu = rodzajImportu;
            this.sciezka = sciezka;
        }

        public Zawodnik[] WygenerujZawodnikow()
        {
            string dane;
            if (rodzajImportu == RodzajImportu.Lokalne)
                dane = PodajZawartoscPlikuLokalnego(sciezka);
            else if (rodzajImportu == RodzajImportu.Zdalne)
                dane = PodajZawartoscPlikuZdalnego(sciezka);
            else
                throw new Exception("nieznany rodzaj importu");

            dane = dane.Replace("\r", "");

            string[] wiersze =
                dane.Split(new string[1] { "\n" }, StringSplitOptions.RemoveEmptyEntries);

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

            zawodnicy = tab;
            return tab;
        }


        private string PodajZawartoscPlikuLokalnego(string sciezka)
        {
            return File.ReadAllText(sciezka);
        }

        public string PodajZawartoscPlikuZdalnego(string sciezka)
        {
            WebClient wc = new WebClient();
            return wc.DownloadString(sciezka);
        }

        public double PodajSredniWzrostZawodnikow()
        {
           //Zawodnik[] zawodnicy = WygenerujZawodnikow();

            int[] wartosci = new int[zawodnicy.Length];
            for (int i = 0; i < zawodnicy.Length; i++)
                wartosci[i] = zawodnicy[i].Wzrost;

            return PoliczSrednia(wartosci);

        }
        public double PodajSredniaWageZawodnikow()
        {
           // Zawodnik[] zawodnicy = WygenerujZawodnikow();

            int[] wartosci = new int[zawodnicy.Length];
            for (int i = 0; i < zawodnicy.Length; i++)
                wartosci[i] = zawodnicy[i].Waga;

            return PoliczSrednia(wartosci);
        }

        public GrupaKraj[] PodajSredniWzrostDlaKazdegoKraju()
        {
            string[] kraje = PodajKraje();

            List<GrupaKraj> gk = new List<GrupaKraj>();

            foreach (var k in kraje)
            {
                int[] w = PodajWzrosty(k);
                double sredniWzrost = PoliczSrednia(w);

                GrupaKraj g = new GrupaKraj();
                g.NazwaKraju = k;
                g.SredniWzrost = sredniWzrost;
                gk.Add(g);
            }

            return gk.ToArray();
        }

        private int[] PodajWzrosty(string kraj)
        {
           // Zawodnik[] zawodnicy = WygenerujZawodnikow();

            List<int> wzrosty = new List<int>();

            foreach (var z in zawodnicy)
                if (z.Kraj == kraj)
                    wzrosty.Add(z.Wzrost);

            return wzrosty.ToArray();
        }


        private string[] PodajKraje()
        {
          //  Zawodnik[] zawodnicy = WygenerujZawodnikow();

            List<string> kraje = new List<string>();

            foreach (var z in  zawodnicy)
                if (!kraje.Contains(z.Kraj))
                    kraje.Add(z.Kraj);
            
            return kraje.ToArray();

        }


        private double PoliczSrednia(int[] wartosci)
        {
            double s = 0;
            foreach (var e in wartosci)
                s += e;

            return s / wartosci.Length;
        }

    }
}
