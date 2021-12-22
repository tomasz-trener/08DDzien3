using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01ZadanieTemperatury
{
    class Program
    {
        static void Main(string[] args)
        {
            TransformatorJednostek tj = new TransformatorJednostek();

            double temp = 20;

            double wynik= tj.ZamienTemperature(temp,'p','f');


            TransformatorJednostek2 tj2 = new TransformatorJednostek2();
           
            double temp2= tj2.ZamienTemperatureNaInna(20, Jednostka.Celsjusz, Jednostka.Fahrenheit);

            temp2= tj2.ZamienTemperatureNaInna(10, Jednostka.Celsjusz, Jednostka.Fahrenheit);


            TransformatorJednostek3 tj3 = new TransformatorJednostek3();
            tj3.jednWejsciowa = Jednostka.Fahrenheit;
            tj3.jednDocelowa = Jednostka.Kelvin;

            double wynik3= tj3.ZamienTemperatureNaInna(10);

            tj3.jednWejsciowa = Jednostka.Celsjusz;
            tj3.jednDocelowa = Jednostka.Kelvin;

            double wynik4 = tj3.ZamienTemperatureNaInna(20);


            Console.WriteLine(wynik);

            Console.ReadKey();
        }
    }
}
