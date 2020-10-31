using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class MadLib
    {
        static void Main()
        {
            Console.WriteLine("*********Mad Lib*********");
            Console.WriteLine("Please enter some information below to do this Mad Lib. Unless otherwise specified, verbs should be in standard present tense (i.e. swim, run). Adverbs are words modifying verbs('soon', 'swiftly'). Adjectives are words that describe nounds (like 'green' or 'descriptive').");

            Console.WriteLine("Noun:");
            string noun = Console.ReadLine();

            Console.WriteLine("Verb:");
            string verb = Console.ReadLine();

            Console.WriteLine("Noun:");
            string nounTwo = Console.ReadLine();

            Console.WriteLine("Adjective:");
            string adjective = Console.ReadLine();

            Console.WriteLine("Noun (animal):");
            string animal = Console.ReadLine();

            Console.WriteLine("Once upon a time there was a {0} who liked to {1}. They lived in the town of {3} {2}. Their best friend was their pet {4}. One day their pets family showed up. Unbeknownst to the {0}, their {4} was taken from their family by poachers. It was very sad for the {0}, because they lost their friend, but were happy that the {4} was able to see their family again.", noun, verb, nounTwo, adjective, animal);
        }
    }
}
