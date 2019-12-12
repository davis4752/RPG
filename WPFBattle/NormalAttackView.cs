using Davis.RoleplayingGameInterfaces;
using Davis.RPGTester;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WPFBattle 
{
    class NormalAttackView: NormalAttack
    {

        public void Attack(ICharacter attacker, ICharacter defender, CharacterImage image)
       {
        
            image.characterState = CharacterImage.CharacterState.Attacking; //Set character image to attacking
            Thread.Sleep(300);   //pause characters state
            base.Attack(attacker, defender);
            image.characterState = CharacterImage.CharacterState.Idle;
        }

    }
}