using Davis.RoleplayingGameInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Davis.RPGTester
{
    public class BowAttack : NormalAttack //Implement NormalAttack
    {
        public override void Attack(ICharacter attacker, ICharacter target)
        {
            Console.WriteLine(attacker.Name + " shoots arrow at " + target.Name +
            "!");
            base.Attack(attacker, target);
        }
    }
}
