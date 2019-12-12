using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Davis.RPGTester
{
    public class Warrior: CharacterBase  //Implement Character base
    {
        public Warrior(string name, int health)
        {
            this.CharacterClass = "Warrior";         //Fighters class
            this.attackBehavior = new SwordAttack(); //class Attack
            this.Name = name;                        //Characters name
            this.Health = health;                    //Characters health
            this.CharacterState = "Idle";            //The current state of the character
        }

        public Warrior(string name)
        : this(name, GameConstants.Instance.PlayerHitpoints)
        {
        }
        public Warrior()
         : this(CharacterBase.AnonymousName + (++CharacterBase.anonymousCounter).ToString(),
        GameConstants.Instance.PlayerHitpoints)
        {
        }
    }

}
