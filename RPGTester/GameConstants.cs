using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Davis.RoleplayingGameInterfaces;

namespace Davis.RPGTester
{
    class GameConstants
    {
        public static GameConstants Instance
        {
            get { return instance; }
        }

        private static GameConstants instance = new GameConstants();

        private GameConstants()
        {
        }
        private const int dodgeDifficulty = 5; // Chance is 1/DodgeDifficulty, so increasing numbers are more difficult.
        private const int damageBonus = 5;     
        private const int damageRange = 10;
        private const int playerHitpoints = 30; //Players health

        //Give value to the character's classes
        public int DodgeDifficulty
        {
            get { return dodgeDifficulty; }
        }
        public int DamageBonus
        {
            get { return damageBonus; }
        }
        public int DamageRange
        {
            get { return damageRange; }
        }
        public int PlayerHitpoints
        {
            get { return playerHitpoints; }
        }

    }

}
