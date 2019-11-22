using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSim
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string heroChoice;

            int heroNumber;

            Console.WriteLine("Choose your fighter:(1)");

            heroChoice = Console.ReadLine();

            while (!int.TryParse(Console.ReadLine(), out heroNumber))
            {

                if (heroNumber == 1)
                {
                    Fighter hero = new Hero_1();
                }
                /*else if (heroChoice == "2")
                {

                }
                else if (heroChoice == "3")
                {

                }
                else if (heroChoice == "4")
                {

                }*/
                else
                {
                    Console.WriteLine("Enter a valid number:");

                }
            }
        }
    }
}
