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
                Console.WriteLine(heroNumber);
                Console.ReadLine();
                //if 1 choose hero 1
                if (heroNumber == 1)
                {

                    Console.WriteLine("uwu");
                    Console.ReadLine();
                    Hero_1 Character = new Hero_1();

                    Enemy Enemy = new Enemy();


                    //name your character
                    Character.name = Console.ReadLine();



                    while (Character.hp > 0)
                    {
                        string actionChoice;

                        int action;

                        Console.WriteLine("Choose your action: (1. Attack, 2.Defence)");
                        actionChoice = Console.ReadLine();

                        while (!int.TryParse(Console.ReadLine(), out action))
                        {

                            if (action == 1)
                            {
                                int damage = Character.Attack(Character.damage);


                                Enemy.hp = Enemy.hp - damage;
                            }
                            else if (action == 2)
                            {
                                int damage = Character.Hurt(Character.damage);

                                int defence = Character.Defence(Character.defence);

                                Character.hp = Character.hp - (damage - defence);
                            }
                            else
                            {
                                Console.WriteLine("Please enter a valid number");
                                Console.ReadLine();
                            }




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
