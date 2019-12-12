using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Davis.RPGTester;

namespace WPFBattle
{



    public class MageView : Mage  //Implement Character base
    {
        private CharacterImage image;

        public MageView(string name, int health, CharacterImage frame)
        {
            this.CharacterClass = "Mage";         //Fighters class
            this.attackBehavior = new DisplaySwordAttack(frame); //class Attack
            this.Name = name;                        //Characters name
            this.Health = health;                    //Characters health
            this.image = frame;                      //character image
            image.characterState = CharacterImage.CharacterState.Idle; //start with state idle
        }

        public override void ReceiveAttack(int damage)
        {
            image.characterState = CharacterImage.CharacterState.TakeDamage; //set image to take damage
            Thread.Sleep(300); //pause image 
            base.ReceiveAttack(damage); //take the damage from attack
            
            if (Health == 0)
                image.characterState = CharacterImage.CharacterState.Dead; //if character has no health then image = dead 
            else
                image.characterState = CharacterImage.CharacterState.Idle; //if character has health then image = idle
        }

    }
}
