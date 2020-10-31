using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class TempConverter
    {
        static void Main()
        {
            Console.WriteLine("*********Temperature Converter********");

            Console.WriteLine("Please choose a temperature type:\nc) Celsius\nf)Fahrenheit");
            string selection = Console.ReadLine().ToUpper();

            switch (selection)
            {
                case "C":
                    Console.WriteLine("Please enter the temperature in Celsius:");
                    decimal cTemp = Convert.ToDecimal(Console.ReadLine());
                    decimal fTempSolution = cTemp * (9.0m / 5.0m) + 32;
                    Console.WriteLine("The temperature in Fahrenheit is {0}.", fTempSolution);
                    break;
                case "F":
                    Console.WriteLine("Please enter the temperature in Fahrenheit:");
                    decimal fTemp = Convert.ToDecimal(Console.ReadLine());
                    decimal cTempSolution = (fTemp - 32) / (9 / 5);
                    Console.WriteLine("The temperature in Celsius is {0}.", cTempSolution);
                    break;
                default:
                    Console.WriteLine("That wasn't an option. Please restart.");
                    break;
            }
        }
    }
}
