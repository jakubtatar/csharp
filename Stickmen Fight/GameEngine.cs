using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stickmen_Fight
{
    public class GameEngine
    {
        public Fighter FirstFighter {  get; set; }
        public Fighter SecondFighter { get; set; }

        public GameEngine()
        {
            FirstFighter = new Fighter(name: "Pikachu");
            SecondFighter = new Fighter(name: "Charizard");
        
        }
    }
}
