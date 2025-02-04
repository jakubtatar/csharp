using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stickmen_Fight
{
    public class Fighter
    {
        public string name { get; set; }
        public int health { get; set; } = 100;

        public Fighter(string name)
        {
            this.name = name;
        }

        public int Attack1()
        {
            Random random = new Random();
            return random.Next(10, 91);
        }

        public int Attack2() 
        {
            Random random = new Random();
            return random.Next(10, 71);
        }

        public int Attack3() 
        {
            Random random = new Random();
            return random.Next(40, 61);
        }

        public int Heal()
        {
            Random random = new Random();
            int healValue = random.Next(20, 71);
            if (health <= 100 )
            {
                if(health + healValue > 100)
                {
                    health = 100;
                }
                else
                {
                    health += healValue;
                }
            }
            return healValue;
        }
    }
}