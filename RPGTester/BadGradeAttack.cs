using Davis.RoleplayingGameInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Davis.RPGTester
{
    public class BadGradeAttack : NormalAttack //Implement NormalAttack
    {
        public override void Attack(ICharacter attacker, ICharacter target)
        {
            Console.WriteLine(attacker.Name + " lowers " + target.Name +
            " grade!");
            base.Attack(attacker, target);
        }
    }
}
