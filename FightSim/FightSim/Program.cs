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

            int heroNumber;
            //fighter choice
            Console.WriteLine("Choose your fighter:(1)");          

            //imput check for valid number
            while (!int.TryParse(Console.ReadLine(), out heroNumber))
            {

                Console.WriteLine("Enter a valid number:");



            }

            //if 1 choose hero 1
            if (heroNumber == 1)
            {

                //creates an instance of class
                Hero_1 Character = new Hero_1();

                Enemy Enemy = new Enemy();


                //name your character
                Character.name = Console.ReadLine();


                // if character is alive
                while (Character.hp > 0 && Enemy.hp > 0)
                {
                    //ask what does player wants to do

                    int action;

                    Console.WriteLine("Choose your action: (1. Attack, 2.Defence)");
                    

                    while (!int.TryParse(Console.ReadLine(), out action))
                    {

                        Console.WriteLine("Please enter a valid number");

                    }
                    //if attack
                    if (action == 1)
                    {
                        //takes the damage from attack method and puts it into an int
                        int damage = Character.Attack(Character.damage);

                        // then changes the enemy damage to after the attack
                        Enemy.hp = Enemy.hp - damage;

                        Console.WriteLine("Enemy HP: " + Enemy.GetHP());
                        Enemy.GetHP();
                       
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

                        //get hp
                        Console.WriteLine("Hero HP: " + Character.GetHP());
                        

                        
                    }
                    else
                    {
                        //create an int with damge and take the hurt method's damage into it
                        int damage = Character.Hurt(Character.damage);
                        //subtract the damage after the defence difference into player hp
                        Character.hp = Character.hp - damage;

                        //get hp
                        Console.WriteLine("Hero HP: " + Character.GetHP());
                        
                    }
                }

                if (Character.hp == 0 || Character.hp < 0)
                {
                    Console.WriteLine("Gēmuōbā");
                }
                else
                {
                    Console.WriteLine("Omedettou! Anata ga katta!");
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







        }

    }
}
