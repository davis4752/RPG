using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Davis.RPGTester
{
     public class Mage : CharacterBase
    {
        public Mage(string name, int health)
        {
            this.CharacterClass = "Mage";           //Fighters Class
            this.attackBehavior = new FireAttack(); //Fightrs attack
            this.Name = name;                       //Characters name
            this.Health = health;                   //Characters health
        }

        public Mage(string name)
 : this(name, GameConstants.Instance.PlayerHitpoints)
 {
        }
        public Mage()
 : this(CharacterBase.AnonymousName + (++CharacterBase.anonymousCounter).ToString(),
GameConstants.Instance.PlayerHitpoints)
 {
        }
    }
}
