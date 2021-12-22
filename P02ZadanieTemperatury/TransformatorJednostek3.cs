using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02ZadanieTemperatury
{
    enum Jednostka
    {
        Celsjusz,
        Fahrenheit,
        Kelvin
    }
    class TransformatorJednostek3
    {
        private Jednostka jednWejsciowa;
        private Jednostka jednDocelowa;



        public TransformatorJednostek3()
        {
            jednWejsciowa = Jednostka.Celsjusz;
            jednDocelowa = Jednostka.Kelvin;
        }

        public TransformatorJednostek3(Jednostka jednWejsciowa, Jednostka jednDocelowa)
        {
            this.jednWejsciowa = jednWejsciowa;
            this.jednDocelowa = jednDocelowa;
        }

        /// <summary>
        /// To jest metoda, która zamienia temperaturę z jdnej jednostki na drugą
        /// </summary>
        /// <param name="n">Dana wejściowa (temperatura)</param>
        /// <param name="jednWejsciowa">Jednostka wejściowa z zakresu c,f,k</param>
        /// <param name="jednDocelowa">Jednostka docelowa z zakresu c,f,k</param>
        /// <returns>Zwraca przekonwertowaną temperaturę</returns>
        public double ZamienTemperatureNaInna(double n)
        {
            if (jednWejsciowa == Jednostka.Celsjusz && jednDocelowa == Jednostka.Fahrenheit)
                return celcjuszNaFahrenheit(n);

            if (jednWejsciowa == Jednostka.Celsjusz && jednDocelowa == Jednostka.Kelvin)
                return celcjuszNaKelwin(n);

            if (jednWejsciowa == Jednostka.Fahrenheit && jednDocelowa == Jednostka.Kelvin)
                return fahrenheitNaKelwin(n);

            if (jednWejsciowa == Jednostka.Fahrenheit && jednDocelowa == Jednostka.Celsjusz)
                return fahrenheitNaCelcjusz(n);

            if (jednWejsciowa == Jednostka.Kelvin && jednDocelowa == Jednostka.Celsjusz)
                return kelwinNaCelsjusz(n);

            if (jednWejsciowa == Jednostka.Kelvin && jednDocelowa == Jednostka.Fahrenheit)
                return kelvinNaFahrenheit(n);

            throw new Exception("Nieobsługiwana jednostka");
        }

        private double celcjuszNaFahrenheit(double n)
        {
            return n * 1.8 + 32;
        }

        private double celcjuszNaKelwin(double n)
        {
            return n + 273.15;
        }

        private double fahrenheitNaKelwin(double n)
        {
            return (n - 32) / 1.8 + 273.15;
        }

        private double fahrenheitNaCelcjusz(double n)
        {
            return (n - 32) / 1.8;
        }

        private double kelwinNaCelsjusz(double n)
        {
            return n - 273.15;
        }

        private double kelvinNaFahrenheit(double n)
        {
            return (n - 273.15) * 1.8 + 32;
        }

    }
}
