using Davis.RoleplayingGameInterfaces;
using OhioState.RoleplayingGameLibrary;
using Davis.RPGTester;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RPGTester
{
    public class Program
    {


        //   private combat combat;
        static void Main(string[] args)
        {
            //  battle = new Combat
            IList<ICharacter> playerParty1 = new List<ICharacter>(); //Create Parties
            IList<ICharacter> playerParty2 = new List<ICharacter>();
            string groupName1 = "Good_Guys"; //Give Parties names
            string groupName2 = "Bad_Guys";
            playerParty1.Add(new Mage("Gandalf")); //Add the good guys
            playerParty1.Add(new Warrior("Boromir"));
            playerParty2.Add(new Archer("Bow guy")); //Add the bad guys
            playerParty2.Add(new ComputerWizard("Machine Language"));

            ICombat battle = new Combat(playerParty1, playerParty2, groupName1, groupName2); //Create Icombat for AutoBattle
            battle.AutoBattle(); //Start Auto Battle

            while(true){
}
        }
    }
}
