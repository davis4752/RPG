using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Davis.RoleplayingGameInterfaces;

namespace Davis.RPGTester
{
    public class NormalAttack : IAttack //Implement IAttack
    {
        protected Random randomNumbers = new Random(); // Simple random number generator
                                                       // for attacks.
        public virtual void Attack(ICharacter attacker, ICharacter target)
        {
            //Attack damage
            int damage = GameConstants.Instance.DamageBonus +
            randomNumbers.Next(GameConstants.Instance.DamageRange);
            target.ReceiveAttack(damage);
        }
    }
}
