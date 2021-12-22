using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09ZapisKlamerkowy
{
    class Program
    {
        static void Main(string[] args)
        {
            Firma f = new Firma();
            f.Pracownicy = new Pracownik[3];

            f.Pracownicy[0] = new Pracownik();
            f.Pracownicy[0].Imie = "Jan";
            f.Pracownicy[0].Nazwisko = "Kowalski";
            f.Pracownicy[0].Pensja = 4000;

            Pracownik p = new Pracownik();
            p.Imie = "Adam";
            p.Nazwisko = "Nowak";
            p.Pensja = 5000;

            f.Pracownicy[1] = p;

            Faktura faktura = new Faktura();
            faktura.DataUtworzenia = DateTime.Now;
            faktura.Numer = 555;

            f.Pracownicy[0].Faktury.Add(faktura);

            faktura.Towary = new Towar[2];
            faktura.Towary[0] = new Towar();
            faktura.Towary[0].Kategoria = Kategoria.czarne;
            faktura.Towary[0].Cena = 50;

            Console.WriteLine(f.Pracownicy[0].Faktury[0].Towary[0].Cena);

            Console.ReadKey();


        }
    }
}
