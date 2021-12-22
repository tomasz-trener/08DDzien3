using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03ZadaniePogoda
{
    class Program
    {
        static void Main(string[] args)
        {
            ManagerPogody mp = new ManagerPogody(Jednostka.Celsjusz);

            double wynik=  mp.PodajTemperature("warszawa");
            Console.WriteLine(wynik);

            Console.ReadKey();
        }
    }
}
