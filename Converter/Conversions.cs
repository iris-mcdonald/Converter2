using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    public class Conversions
    {
        public double getGallonsFromLiters(double Liters)
        {
            double Gallons = Liters * .264172;
            return Gallons;
        }

        public double getLitersFromGallons(double Gallons)
        {
            double Liters = Gallons * 3.78541;
            return Liters;
        }

        public double getPoundsFromKilograms(double Kilograms)
        {
            double Pounds = Kilograms * .453592;
            return Pounds;
        }

        public double getKilogramsFromPounds(double Pounds)
        {
            double Kilograms = Pounds * 2.20462;
            return Kilograms;
        }

        public double getFahrenheitFromCelcius(double Celcius)
        {
            double Fahrenheit = Celcius * 9 / 5 + 32;
            return Fahrenheit;
         }

        public double getCelciusFromFahrenheit(double Fahrenheit)
        {
            double Celcius = (Fahrenheit - 32) * 5 / 9;
            return Celcius;
        }
    }
}
