using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WPFBattle
{
    public class CharacterImage: System.Windows.Controls.Image
    {
        public enum CharacterState //4 different states for characters
        {
            Idle,
            Dead,
            Attacking,
            TakeDamage
        }
        private CharacterState characterstate;

        public CharacterState characterState
        {
            get { return characterstate; }
            set
            {
                characterstate = value;
                this.Dispatcher.Invoke((Action)(() =>
                {
                    UpdateImageSource();
                }));
            }
        }

        //Get images for different states
        public ImageSource IdleImageSource { get; set; }
        public ImageSource AttackingImageSource { get; set; }
        public ImageSource TakeDamageImageSource { get; set; }
        public ImageSource DeadImageSource { get; set; }

        protected void UpdateImageSource() //update based on state
        {
            switch (characterState)
            {
                case CharacterState.Attacking:
                    this.Source = AttackingImageSource;
                    break;
                case CharacterState.TakeDamage:
                    this.Source = TakeDamageImageSource;
                    break;
                case CharacterState.Dead:
                    this.Source = DeadImageSource;
                    break;
                case CharacterState.Idle:
                default:
                    this.Source = IdleImageSource;
                    break;
            }
        }


        protected override void OnRender(DrawingContext dc)
        {
            UpdateImageSource();
            base.OnRender(dc);
        }

    }
}
