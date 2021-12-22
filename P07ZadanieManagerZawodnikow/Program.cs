using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07ZadanieManagerZawodnikow
{
    class Program
    {
        static void Main(string[] args)
        {
            string sciezka = @"C:\dane\zawodnicy.txt";

            ManagerZawodnikow mz = new ManagerZawodnikow(sciezka, RodzajImportu.Lokalne);

            Zawodnik[] zaw = mz.WygenerujZawodnikow();
            foreach (var z in zaw)
                Console.WriteLine(z.PrzedstawSie());

            Console.WriteLine(string.Format("Średni wzrost wynosi: {0:0.00}", mz.PodajSredniWzrostZawodnikow()));
            Console.WriteLine(string.Format("Średni waga wynosi: {0:0.00}", mz.PodajSredniaWageZawodnikow()));

            foreach (var gk in mz.PodajSredniWzrostDlaKazdegoKraju())
                Console.WriteLine(string.Format("kraj: {0} = {1:0.00}", gk.NazwaKraju, gk.SredniWzrost));

            Console.ReadKey();

        }
    }
}
