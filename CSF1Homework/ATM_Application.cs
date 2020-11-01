using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class ATM_Application
    {
        static void Main()
        {
            Console.WriteLine("********ATM Application***********");

            //Variables
            int accountNumber = 1234;
            int pin = 999;
            Boolean repeat = true;
            string switchCheck = "enterAccountNumber";



            do
            {
                switch (switchCheck)
                {
                    case "enterAccountNumber":
                        Console.WriteLine("Please enter your account number:");
                        int userEnteredNumber = Convert.ToInt32(Console.ReadLine());
                        if (userEnteredNumber == accountNumber)
                        {
                            switchCheck = "enterPIN";
                        }
                        Console.WriteLine("This worked");
                        break;
                    case "enterPIN":
                        Console.WriteLine("Please enter your PIN:");
                        int userEnteredPin = Convert.ToInt32(Console.ReadLine());
                        if (userEnteredPin == pin)
                        {
                            switchCheck = "menu";
                        }
                        break;
                    case "menu":
                        Console.WriteLine("Please enter an option:\n" +
                            "A) Make a deposit\n" +
                            "B) Make a withdrawal\n" +
                            "C) Exit the application");
                        string userEnteredMenu = Console.ReadLine().ToUpper();
                        if(userEnteredMenu == "A")
                        {
                            Console.WriteLine("How much would you like to deposit?");
                            string depositAmountString = Console.ReadLine();
                            Console.WriteLine("{0:c} has been deposited into {1}.", depositAmountString, accountNumber);
                            switchCheck = "menu2";
                        } else if (userEnteredMenu == "B")
                        {
                            Console.WriteLine("How much would you like to withdraw?");
                            string withdrawAmountString = Console.ReadLine();
                            Console.WriteLine("{0:c} has been withdrawen from {1}.", withdrawAmountString, accountNumber);
                            switchCheck = "menu2";
                        } else if (userEnteredMenu == "C")
                        {
                            Console.WriteLine("Thank you for your business.");
                            repeat = false;
                        } else
                        {
                            Console.WriteLine("That wasn't an option. terminating Application.");
                            repeat = false;
                        }
                        break;
                    case "menu2":
                        Console.WriteLine("Would you like to do another withdrawel/deposit?\n" +
                            "A) Yes\n" +
                            "B) No, I would like to exit.");
                        string menu2String = Console.ReadLine().ToUpper();
                        if (menu2String == "A")
                        {
                            switchCheck = "menu";
                        } else if (menu2String == "B")
                        {
                            Console.WriteLine("Thank you for your business.");
                            repeat = false;
                        } else
                        {
                            Console.WriteLine("That wasn't an option. terminating Application.");
                            repeat = false;
                        }
                        break;
                    default:
                        Console.WriteLine("This is the defalut cw.");
                        repeat = false;
                        break;
                }

            } while (repeat);
        }
    }
}
