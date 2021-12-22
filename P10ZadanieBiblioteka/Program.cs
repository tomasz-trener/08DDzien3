using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10ZadanieBiblioteka
{
    class Program
    {
        static void Main(string[] args)
        {
            Karta k = new Karta()
            {
                Numer = "1308/00",
                Tytul = "O kurdlach dla opornych",
                Wydanie = 1,
                DataZakupu = new DateTime(2000, 1, 27),
                Autor = new Autor[2]
                {
                    new Autor()
                    {
                        Imie = "L",
                        Nazwisko = "Tarantoga",
                        DrugieImie = "A"
                    },
                    new Autor()
                    {
                        Imie = "I",
                        Nazwisko = "Tichy",
                    }
                },
                Cena = new Cena()
                {
                    CenaJednostkowa = 17.5,
                    Uwagi = "zakup z 18.08 –20,00"
                },
                Sygnatura = new List<Sygnatura>()
                {
                    new Sygnatura()
                    {
                        Numer = 012370,
                        Aktywna = true
                    },
                    new Sygnatura()
                    {
                        Numer = 012371,
                        Aktywna = false,
                        Uwaga= "zgłoszona utrata 01.05.2000",
                        Wypozyczenia = new List<Wypozyczenie>()
                        {
                            new Wypozyczenie()
                            {
                                Czytelnik = new Czytelnik()
                                {
                                    NrKarty="A1427",
                                },
                                DataWypozyczenia = new DateTime(2000,1,31),
                                DataPrzwidywanegoZwrotu = new DateTime(2000,2,15),
                                DataRzeczywistegoZwrotu = new DateTime(2000,2,20),
                                Uwagi = "Pobrano karę 2,00"
                            },
                            new Wypozyczenie()
                            {
                                Czytelnik = new Czytelnik()
                                {
                                    NrKarty="B2354",
                                },
                                DataWypozyczenia = new DateTime(2000,2,22),
                                DataPrzwidywanegoZwrotu = new DateTime(2000,3,7),
                                Uwagi = "06.03.2000 Zgoda na przedłużenie",
                                Przedluzenie = new Wypozyczenie()
                                {
                                    DataPrzwidywanegoZwrotu = new DateTime(2000,3,15),
                                    DataRzeczywistegoZwrotu = new DateTime(2000,3,15)
                                }
                            },
                        }
                    }
                }



            };

            string s = k.Sygnatura[1].Wypozyczenia[1].Uwagi;
            Console.WriteLine(s);

            Console.ReadLine();
        }
    }
}
