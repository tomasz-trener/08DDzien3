using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01ZadanieTemperatury
{


    class TransformatorJednostek
    {
        /// <summary>
        /// To jest metoda, która zamienia temperaturę z jdnej jednostki na drugą
        /// </summary>
        /// <param name="n">Dana wejściowa (temperatura)</param>
        /// <param name="jednWejsciowa">Jednostka wejściowa z zakresu c,f,k</param>
        /// <param name="jednDocelowa">Jednostka docelowa z zakresu c,f,k</param>
        /// <returns>Zwraca przekonwertowaną temperaturę</returns>
        public double ZamienTemperature(double n, char jednWejsciowa, char jednDocelowa)
        {
            if (jednWejsciowa == 'c' && jednDocelowa == 'f')
                return celcjuszNaFahrenheit(n);

            if (jednWejsciowa == 'c' && jednDocelowa == 'k')
                return celcjuszNaKelwin(n);

            if (jednWejsciowa == 'f' && jednDocelowa == 'k')
                return fahrenheitNaKelwin(n);

            if (jednWejsciowa == 'f' && jednDocelowa == 'c')
                return fahrenheitNaCelcjusz(n);

            if (jednWejsciowa == 'k' && jednDocelowa == 'c')
                return kelwinNaCelsjusz(n);

            if (jednWejsciowa == 'k' && jednDocelowa == 'f')
                return kelwienNaFahrenheit(n);

            throw new Exception("Nieobsługiwana jednostka");
        }

        private double celcjuszNaFahrenheit(double n)
        {
            return n * 1.8 + 32;
        }

        private double celcjuszNaKelwin(double n)
        {
            return n +273.15;
        }

        private double fahrenheitNaKelwin(double n)
        {
            return (n - 32) / 1.8 + 273.15;
        }

        private double fahrenheitNaCelcjusz(double n)
        {
            return (n - 32)/1.8;
        }

        private double kelwinNaCelsjusz(double n)
        {
            return n-273.15;
        }

        private double kelwienNaFahrenheit(double n)
        {
            return (n-273.15)*1.8 + 32;
        }

    }
}
