using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace A2
{
    /// <summary>
    /// Temperature Converter CLI
    /// </summary>
    public class TemperatureConverter
    {

        private enum Choices
        {
            Exit,
            CeltoFar,
            FartoCel
        }

        /// <summary>
        /// The CelsiusToFarenheit method will take a parameter representing   
        /// Celsius and returning the value in Farenheits. 
        /// </summary>
        /// <param name="celsius">Input value in Celsius </param>
        /// <returns> Fahreneit conversion of the input Celsius value. </returns>
        private double CelsiusToFarenheit(double celsius) => (9 / 5.0 * celsius) + 32;

        /// <summary>
        /// The CelsiusToFarenheit method will take a parameter representing   
        /// Celsius and returning the value in Farenheits. 
        /// </summary>
        /// <param name="farenheit">Input value in Celsius </param>
        /// <returns> Fahreneit conversion of the input Celsius value. </returns>
        private double FarenheitToCelcius(double farenheit) => 5 / 9.0 * (farenheit - 32);

        /// <summary>
        /// Display the series of options the user
        /// can take and execute the program further.
        /// </summary>
        /// <returns>void</returns>
        private void ShowMenu()
        {

            Console.WriteLine("-----------------------------------------\n");
            Console.WriteLine("           TEMPERATURE CONVERTER         \n");
            Console.WriteLine("-----------------------------------------\n");

            Console.WriteLine("        Celsius to Fahrenheit        : 1");
            Console.WriteLine("        Fahrenheit to Celsius        : 2");
            Console.WriteLine("        Exit                         : 0");

            Console.WriteLine("-----------------------------------------\n");
            Console.Write("Your choice: ");
        }

        /// <summary>
        /// Display Celcsius to Fahrenheit table.
        /// Range: 0 - 100 C
        /// </summary>
        /// <returns>void</returns>
        private void ShowTableCelsiusToFahrenheit()
        {
            const short max = 100;

            for(int i = 0; i <= max; i+=4)
            {
                Console.WriteLine($"{i,7:0.00} C = \t{CelsiusToFarenheit(i), 7:0.00} F");
            }

        }

        /// <summary>
        /// Display Fahrenheit to Celsius table.
        /// Range: 0 - 212 F
        /// </summary>
        /// <returns>void</returns>
        private void ShowTableFahrenheitToCelsius()
        {
            const short max = 212;

            for (int i = 0; i <= max; i += 10)
            {
                Console.WriteLine($"{i,7:0.00} F = \t{FarenheitToCelcius(i),7:0.00} C");
            }

        }

        /// <summary>
        /// Start method will call all the applied methods in the class
        /// to start the Temperature Converter CLI.
        /// </summary>
        /// <returns>void</returns>
        public void Start()
        {
            bool done = false;
            
            do
            {
                ShowMenu();
                Enum.TryParse<Choices>(Console.ReadLine(), ignoreCase: true, out var choice);
                Console.WriteLine();

                switch (choice)
                {
                    case Choices.CeltoFar:
                        ShowTableCelsiusToFahrenheit();
                        break;
                    case Choices.FartoCel:
                        ShowTableFahrenheitToCelsius();
                        break;
                    case Choices.Exit:
                        done = true;
                        break;
                }

            }while (!done);
        }

    }
}
