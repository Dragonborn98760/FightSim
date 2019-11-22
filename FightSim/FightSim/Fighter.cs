using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSim
{
    class Fighter
    {
        new int min;

        new int max;


        Random generator = new Random();


        protected int hp = 100;

        protected int damage = 20;

        public string name;

        

        public int Attack(int damage)
        {
            damage = this.damage;

            hp = hp - damage;

            return hp;
        }

        public int Hurt(int amount)
        {
            

            hp = hp - amount;

            return hp;
        }

        public void IsAlive (bool IsAlive)
        {
            if (hp > 0)
            {
                IsAlive = true;
            }
        }

        public void GetHP (int hp)
        {
            hp = this.hp;

            Console.WriteLine(hp);
        }

        public int Defence (int defence)
        {
            damage = damage - defence;

            return damage;
        }

    }
}
