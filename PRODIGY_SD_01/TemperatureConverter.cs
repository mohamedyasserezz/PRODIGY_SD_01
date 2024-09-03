using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRODIGY_SD_01
{
    public class TemperatureConverter
    {
        public double Temperature { get; private set; }
        public char Unit { get; private set; }

        public TemperatureConverter(double temperature, char unit)
        {
            Temperature = temperature;
            Unit = char.ToUpper(unit);
        }

        public void ConvertTemperature()
        {
            switch (Unit)
            {
                case 'C':
                    DisplayConversionsFromCelsius();
                    break;
                case 'F':
                    DisplayConversionsFromFahrenheit();
                    break;
                case 'K':
                    DisplayConversionsFromKelvin();
                    break;
                default:
                    Console.WriteLine("Invalid unit. Please enter C for Celsius, F for Fahrenheit, or K for Kelvin.");
                    break;
            }
        }

        private void DisplayConversionsFromCelsius()
        {
            double fahrenheit = CelsiusToFahrenheit(Temperature);
            double kelvin = CelsiusToKelvin(Temperature);

            DisplayResults(Temperature, "Celsius", fahrenheit, "Fahrenheit", kelvin, "Kelvin");
        }

        private void DisplayConversionsFromFahrenheit()
        {
            double celsius = FahrenheitToCelsius(Temperature);
            double kelvin = CelsiusToKelvin(celsius);

            DisplayResults(Temperature, "Fahrenheit", celsius, "Celsius", kelvin, "Kelvin");
        }

        private void DisplayConversionsFromKelvin()
        {
            double celsius = KelvinToCelsius(Temperature);
            double fahrenheit = CelsiusToFahrenheit(celsius);

            DisplayResults(Temperature, "Kelvin", celsius, "Celsius", fahrenheit, "Fahrenheit");
        }

        private double CelsiusToFahrenheit(double celsius) => (celsius * 9 / 5) + 32;

        private double FahrenheitToCelsius(double fahrenheit) => (fahrenheit - 32) * 5 / 9;

        private double CelsiusToKelvin(double celsius) => celsius + 273.15;

        private double KelvinToCelsius(double kelvin) => kelvin - 273.15;

        private void DisplayResults(double originalTemp, string originalUnit, double convertedTemp1, string convertedUnit1, double convertedTemp2, string convertedUnit2)
        {
            Console.WriteLine($"\n{originalTemp} degrees {originalUnit} is equal to:");
            Console.WriteLine($"{convertedTemp1:F2} degrees {convertedUnit1}");
            Console.WriteLine($"{convertedTemp2:F2} degrees {convertedUnit2}");
        }
    }
}
