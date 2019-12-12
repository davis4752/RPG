using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Davis.RPGTester;

namespace WPFBattle
{



    public class ComputerWizardView : ComputerWizard  //Implement Character base
    {
        private CharacterImage image;

        public ComputerWizardView(string name, int health, CharacterImage frame)
        {
            this.CharacterClass = "ComputerWizard";         //Fighters class
            this.attackBehavior = new DisplaySwordAttack(frame); //class Attack
            this.Name = name;                        //Characters name
            this.Health = health;                    //Characters health
            this.image = frame;                      //Character image frame
            image.characterState = CharacterImage.CharacterState.Idle; //Start with charater in image idle
        }

        public override void ReceiveAttack(int damage)
        {
            image.characterState = CharacterImage.CharacterState.TakeDamage;  //If character receives an attack set image to "take damage"
            Thread.Sleep(300); //Pause characters image
            base.ReceiveAttack(damage);

            if (Health == 0)
                image.characterState = CharacterImage.CharacterState.Dead; //if health = 0 then image = dead
            else
                image.characterState = CharacterImage.CharacterState.Idle; //if health != 0 then image = idle
        }

    }
}
