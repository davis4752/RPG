using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Davis.RPGTester;

namespace WPFBattle
{



    public class ArcherView : Archer  //Implement Character base
    {
        private CharacterImage image;

        public ArcherView(string name, int health, CharacterImage frame) //Create based on name, health, and image frame
        {
            this.CharacterClass = "Archer";         //Fighters class
            this.attackBehavior = new DisplaySwordAttack(frame); //class Attack
            this.Name = name;                        //Characters name
            this.Health = health;                    //Characters health
            this.image = frame;                      //Character Image frame
            image.characterState = CharacterImage.CharacterState.Idle; //Set image to idle
        }

        public override void ReceiveAttack(int damage)
        {
            image.characterState = CharacterImage.CharacterState.TakeDamage; //If character receives damage then display "TakeDamage"
            Thread.Sleep(300); //Pause characters movements
            base.ReceiveAttack(damage); //Subtract damage

            if (Health == 0)
                image.characterState = CharacterImage.CharacterState.Dead; //If health is 0 go to dead image
            else
                image.characterState = CharacterImage.CharacterState.Idle; //If health is not 0 go to idle
        }

    }
}
