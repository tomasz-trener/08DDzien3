using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05ZadanieZawodnicy
{
    class Zawodnik
    {
        public int Id_zawodnika;
        public int Id_trenera;
        public string Imie;
        public string Nazwisko;
        public string Kraj;
        public DateTime DataUrodzenia; 
        public int Wzrost;
        public int Waga;

        public Zawodnik()
        {

        }

        public Zawodnik(string imie, string nazwisko)
        {
            Imie = imie;
            Nazwisko = nazwisko;
        }

        public string PrzedstawSie()
        {
            return $"Nazywam się {Imie} {Nazwisko} i pochodzę z {Kraj}";
        }
    }
}
