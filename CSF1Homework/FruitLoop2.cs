using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class FruitLoop2
    {
        static void Main()
        {
            Console.WriteLine("*********Fruit Loop 2**********");

            string[] fruitNames = { "lemon", "pear", "lime", "banana", "orange", "watermelon" };
            string periodString = "";
            for (int i = 0; i < fruitNames.Length; i++)
            {
                periodString = periodString + ".";
                Console.WriteLine(fruitNames[i]);
                Console.WriteLine(periodString);
            }
        }
    }
}
