using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class Login
    {
        static void Main()
        {
            Console.WriteLine("*********Login**********");
            //Variables
            string userName = "jswift";
            int wrongUserNameCounter = 0;
            Boolean repeat = true;

            /////

            do
            {
                Console.WriteLine("Please enter your username: ");
                string userInput = Console.ReadLine().ToLower();
                if (userInput == userName || userInput == "admin")
                {
                    Console.WriteLine("Access Granted");
                    repeat = false;
                }
                else
                {
                    //Console.WriteLine("Access Denied");
                    wrongUserNameCounter++;
                    if (wrongUserNameCounter < 3)
                    {
                        Console.WriteLine("Access Denied");
                    } else if (wrongUserNameCounter >= 3)
                    {
                        Console.WriteLine("Access Denied. User locked out.");
                        repeat = false;
                    }

                }



            } while (repeat);






            
            
            
            
        }
    }
}
