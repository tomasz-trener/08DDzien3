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
            ManagerZawodnikow mz = new ManagerZawodnikow();

            foreach (var z in mz.WygenerujZawodnikow())
                Console.WriteLine(z.PrzedstawSie());

            Console.ReadKey();
            
           
        } 
    } 
}
