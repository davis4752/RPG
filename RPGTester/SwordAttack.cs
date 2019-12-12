using Davis.RoleplayingGameInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Davis.RPGTester
{
    public class SwordAttack : NormalAttack  //Implement Normal Attack
    {
        public override void Attack(ICharacter attacker, ICharacter target)
        {
            //Attack Phrase
            Console.WriteLine(attacker.Name + " swings a sword at " + target.Name +
            "!");
            base.Attack(attacker, target);
        }
    }
}
