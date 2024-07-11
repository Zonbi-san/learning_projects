using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bullshit_in_bullshit_out
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sevastolink™ V.2136.1");
            Console.Write("Please enter your username: ");
            String username = Console.ReadLine();
            if (username != "soloman_2101" && username != "misterbigdickcaptain")
            {
                Console.WriteLine("New user detected, please contact a working joe");
                Console.ReadLine();
            }
            else if (username == "soloman_2101")
            {
                Console.Write("Welcome back " + username + ", now please enter your PIN: ");
                string pin = Console.ReadLine();
                if (pin == "311201")
                {
                    Console.WriteLine("Now booting systems");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Wrong PIN, please answer the security questions.");
                    Console.Write("What is the result of 1 + 1 * 2?: ");
                    int n1 = Convert.ToInt32(Console.ReadLine());
                    int result = 1 + 1 * 2;
                    if (n1 == result)
                    {
                        Console.WriteLine("Security question completed, now booting systems");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Unauthorized access detected, please restart the computer");
                        Console.ReadLine();
                    }

                }
            }
            else if (username == "misterbigdickcaptain")
            {
                Console.Write("Welcome back " + username + ", now please enter your PIN: ");
                string pin = Console.ReadLine();
                if (pin == "42069")
                {
                    Console.WriteLine("Now booting systems");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Wrong PIN, please answer the security questions.");
                    Console.Write("What is my favourite porn film: ");
                    string answer = Console.ReadLine();
                    if  (answer == "2 girls 1 cup")
                    {
                        Console.WriteLine("Security question completed, now booting systems");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Unauthorized access detected, please restart the computer");
                        Console.ReadLine();
                    }


                }

            }
        }
    }
}