﻿using Davis.RoleplayingGameInterfaces;
using Davis.RPGTester;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WPFBattle
{
    class DisplayFireAttack : FireAttack
    {
        private CharacterImage image;

        public DisplayFireAttack(CharacterImage image)
        {
            this.image = image;
        }

        public override void Attack(ICharacter attacker, ICharacter defender)
        {
            image.characterState = CharacterImage.CharacterState.Attacking; //Set Character's image to attacking
            Thread.Sleep(300); //pause image
            base.Attack(attacker, defender);
            image.characterState = CharacterImage.CharacterState.Idle; //set back to idle
        }
    }
}