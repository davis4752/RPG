using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Davis.RPGTester;

namespace WPFBattle
{

   

    public class WarriorView : Warrior  //Implement Character base
    {
        private CharacterImage image;

        public WarriorView(string name, int health, CharacterImage frame)
        {
            this.CharacterClass = "Warrior";         //Fighters class
            this.attackBehavior = new DisplaySwordAttack(frame) ; //class Attack
            this.Name = name;                        //Characters name
            this.Health = health;                    //Characters health
            this.image = frame;
            image.characterState = CharacterImage.CharacterState.Idle;
        }

        public override void ReceiveAttack(int damage)
        {
            image.characterState = CharacterImage.CharacterState.TakeDamage; //set character's image to take damage
            Thread.Sleep(300); //pause character's image
            base.ReceiveAttack(damage); //take damage from attack

            if (Health == 0)
                image.characterState = CharacterImage.CharacterState.Dead; //if character has no health then image = dead
            else
                image.characterState = CharacterImage.CharacterState.Idle; //if character has health then image = idle
        }

    }
}
