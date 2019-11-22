using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSim
{
    class Fighter
    {
        

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

        public static bool IsAlive (bool IsAlive)
        {
            

            return IsAlive;
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
