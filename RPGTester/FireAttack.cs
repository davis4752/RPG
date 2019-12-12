using Davis.RoleplayingGameInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Davis.RPGTester
{
    public class FireAttack : NormalAttack //Implement NormalAttack
    {
        public override void Attack(ICharacter attacker, ICharacter target)
        {
            //Attack Phrase
            Console.WriteLine(attacker.Name + " throws a fireball at " + target.Name +
            "!");
            base.Attack(attacker, target);
        }
    }
}
