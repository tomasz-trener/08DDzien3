using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10ZadanieBiblioteka
{
    class Wypozyczenie
    {
        public DateTime DataWypozyczenia;
        public DateTime DataPrzwidywanegoZwrotu;
        public DateTime DataRzeczywistegoZwrotu;
        public string Uwagi;
        public Wypozyczenie Przedluzenie;
        public Czytelnik Czytelnik;
    }
}
