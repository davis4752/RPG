using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Davis.RPGTester
{
    public class ComputerWizard : CharacterBase
    {
        public ComputerWizard(string name, int health)
        {
            this.CharacterClass = "ComputerWizard";      //Fighters Class
            this.attackBehavior = new BadGradeAttack(); //Fighters Attack 
            this.Name = name;                           //Characters name
            this.Health = health;                       //Characters health
        }

        public ComputerWizard(string name)
 : this(name, GameConstants.Instance.PlayerHitpoints)
        {
        }
        public ComputerWizard()
 : this(CharacterBase.AnonymousName + (++CharacterBase.anonymousCounter).ToString(),
GameConstants.Instance.PlayerHitpoints)
        {
        }
    }
}
