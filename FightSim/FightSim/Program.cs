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
            //variables
            string heroChoice;

            int heroNumber;
            //fighter choice
            Console.WriteLine("Choose your fighter:(1)");

            heroChoice = Console.ReadLine();
            //imput check for valid number
            while (!int.TryParse(Console.ReadLine(), out heroNumber))
            {
                //if 1 choose hero 1
                if (heroNumber == 1)
                {

                    Fighter Character = new Hero_1();

                    Enemy Enemy = new Enemy();


                    //name your character
                    Character.name = Console.ReadLine();

                   

                    while (heroNumber == 1)
                    {
                        string actionChoice;

                        int action;

                        Console.WriteLine("Choose your action: (1. Attack, 2.Defence)");
                        actionChoice = Console.ReadLine();

                        while (!int.TryParse(Console.ReadLine(), out action))
                        {
                               Enemy.hp = Enemy.hp - Character.Attack;




                        }
                    }


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
