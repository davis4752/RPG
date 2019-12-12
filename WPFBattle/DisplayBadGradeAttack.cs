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
    class DisplayBadGradeAttack : BadGradeAttack
    {
        private CharacterImage image;

        public DisplayBadGradeAttack(CharacterImage image)
        {
            this.image = image;
        }

        public override void Attack(ICharacter attacker, ICharacter defender)
        {
            image.characterState = CharacterImage.CharacterState.Attacking; //Change image to attacking
            Thread.Sleep(300); //pause character image
            base.Attack(attacker, defender);
            image.characterState = CharacterImage.CharacterState.Idle; //Set back to idle
        }
    }
}