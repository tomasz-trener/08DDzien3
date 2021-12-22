using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10ZadanieBiblioteka
{
    class Karta
    {
        public string Numer;
        public DateTime DataZakupu;
        public int Wydanie;
        public List<Sygnatura> Sygnatura;
        public Cena Cena;
        public Autor[] Autor;
        public string Tytul;
        public Karta Nastepna;
        public Karta Poprzednia;
    }
}
