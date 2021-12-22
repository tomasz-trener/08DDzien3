using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02ZadanieTemperatury
{
    class Program
    {
        static void Main(string[] args)
        {
            TransformatorJednostek3 tj3 = new TransformatorJednostek3(Jednostka.Kelvin,Jednostka.Celsjusz);

          //  tj3.JednWejsciowa = Jednostka.Celsjusz;
          //  tj3.JednWejsciowa = Jednostka.Fahrenheit;

            //TransformatorJednostek3 tj4 = new TransformatorJednostek3()

            double wynik=  tj3.ZamienTemperatureNaInna(20);


        }
    }
}
