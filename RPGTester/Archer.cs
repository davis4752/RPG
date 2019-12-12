using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Davis.RPGTester
{
    public class Archer : CharacterBase
    {
        public Archer(string name, int health)
        {
            this.CharacterClass = "Archer";         //Fighter's class
            this.attackBehavior = new BowAttack();  //Fighter's Attack
            this.Name = name;                       //Character's name
            this.Health = health;                   //Character's health
        }

        public Archer(string name)
 : this(name, GameConstants.Instance.PlayerHitpoints)
        {
        }
        public Archer()
 : this(CharacterBase.AnonymousName + (++CharacterBase.anonymousCounter).ToString(),
GameConstants.Instance.PlayerHitpoints)
        {
        }
    }
}
