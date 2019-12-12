using Davis.RoleplayingGameInterfaces;
using OhioState.RoleplayingGameLibrary;
using Davis.RPGTester;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;




namespace WPFBattle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
            TextWriter writer = new TextBoxStreamWriter(textbox);
            Console.SetOut(writer);

            IList<ICharacter> playerParty1 = new List<ICharacter>(); //Create Parties
            IList<ICharacter> playerParty2 = new List<ICharacter>();
            string groupName1 = "Good_Guys"; //Give Parties names
            string groupName2 = "Bad_Guys";
            playerParty1.Add(new MageView("Gandalf", 50, Player1Image )); //Add the good guys
            playerParty1.Add(new WarriorView("Boromir", 50, Player2Image));
            playerParty2.Add(new ArcherView("Bow guy", 50, Player3Image)); //Add the bad guys
            playerParty2.Add(new ComputerWizardView("Machine Language", 50, Player4Image));

            ICombat battle = new Combat(playerParty1, playerParty2, groupName1, groupName2); //Create Icombat for AutoBattle
            CombatThread fight = new CombatThread(battle);
            fight.Start();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Redirect console

        }
    }
}
