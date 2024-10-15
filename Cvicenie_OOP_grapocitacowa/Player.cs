using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie_OOP_grapocitacowa
{
    public class Player
    {
        public string ClassType { get; set; }
        public int Power { get; set; }
        public int HP { get; set; }
        public int Mana { get; set; }

        public Player()
        {

        }

        public Player(string classType, int power, int hP, int mana)
        {
            ClassType = classType;
            Power = power;
            HP = hP;
            Mana = mana;
        }
        
        public void DamagePlayer(Player player)
        {
            int HPofEnemy = player.HP;
            int AttackofCurrentPlayer = this.Power;
            int HPofEnemyAfterFight = HPofEnemy - AttackofCurrentPlayer;
            player.HP = HPofEnemyAfterFight;
        }

        public void HealPlayer()
        {
            int ManaOfPlayer = this.Mana;
            int HPofPlayerAfterHeal = this.HP + ManaOfPlayer;
            this.HP = HPofPlayerAfterHeal;
        }
    }
}
