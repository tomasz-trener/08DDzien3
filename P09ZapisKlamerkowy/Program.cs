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
            Firma f = new Firma()
            {
                Pracownicy = new Pracownik[3]
                {
                    new Pracownik()
                    {
                        Imie = "Jan",
                        Nazwisko = "Kowalski",
                        Pensja = 4000,
                        Faktury = new List<Faktura>()
                        {
                            new Faktura()
                            {
                                Numer = 12312,
                                DataUtworzenia = DateTime.Now,
                                Towary = new Towar[2]
                                {
                                    new Towar()
                                    {
                                        Cena =40,
                                        Kategoria = Kategoria.czerwone
                                    },
                                    new Towar()
                                }
                            }
                        }
                    },
                    new Pracownik(),
                    new Pracownik()
                }
            };

            Console.WriteLine(f.Pracownicy[0].Faktury[0].Towary[0].Cena);
            Console.ReadKey();
        }
    }
}
