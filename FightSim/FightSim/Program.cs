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

                    //creates an instance of class
                    Hero_1 Character = new Hero_1();

                    Enemy Enemy = new Enemy();


                    //name your character
                    Character.name = Console.ReadLine();


                    // if character is alive
                    while (Character.hp > 0)
                    {
                        //ask what does player wants to do
                        string actionChoice;

                        int action;

                        Console.WriteLine("Choose your action: (1. Attack, 2.Defence)");
                        actionChoice = Console.ReadLine();

                        while (!int.TryParse(Console.ReadLine(), out action))
                        {
                            //if attack
                            if (action == 1)
                            {
                                //takes the damage from attack method and puts it into an int
                                int damage = Character.Attack(Character.damage);

                                // then changes the enemy damage to after the attack
                                Enemy.hp = Enemy.hp - damage;
                            }
                            // if defence 
                            else if (action == 2)
                            {
                                //create an int with damge and take the hurt method's damage into it
                                int damage = Character.Hurt(Character.damage);
                                //create an int for amount of defence 
                                int defence = Character.Defence(Character.defence);
                                //subtract the damage after the defence difference into player hp
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
