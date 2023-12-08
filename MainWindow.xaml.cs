using System;
using System.Collections.Generic;
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

namespace JuanHernandez_Prog2_Final
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 


    // Juan Hernandez
    // DUE 12.07.2023
    // Programming 2 Final
    public partial class MainWindow : Window
    {
        // initializing 
        List<Teams> _teams = new List<Teams>();
        Player selectedPlayer;
        Teams selectedTeam;
        string status;
        string teams;
        bool oteam = false;
        bool dteam = false;
        bool steam = false; 


        public MainWindow()
        {
            InitializeComponent();
            Preload(); // calling preload
        }// mainwindow
        public void Preload()
        {
            // preloading coonferences here, as it is only 2.
            lbConferences.Items.Add("NFC");
            lbConferences.Items.Add("AFC");

            status += "Status: "; // status label
            //teams += "Teams: "; // teams label

        }// preload

        private void btnAddTeam_Click(object sender, RoutedEventArgs e)
        {
            // try parsing in if statement to make sure fields are filled
            if (string.IsNullOrEmpty(tbTeamName.Text) || string.IsNullOrEmpty(tbCity.Text) || string.IsNullOrEmpty(tbStadium.Text) || string.IsNullOrEmpty(tbCoach.Text))
            { Warning(); }
            else
            {
                // adding items to item list and displaying on list view
                Teams item = new Teams(lbConferences.Text, tbTeamName.Text, tbCity.Text, tbStadium.Text, tbCoach.Text);
                ListView_Teams.Items.Add(item);
                //_teams = new List<Teams>();
                _teams.Add(item); //adding to teams list
            }
        }// btn addTeam click
        public void Warning()
        {
            //displays message if any required field is missing
            string title = "WARNING";
            string message = "Missing Field(S)";
            MessageBox.Show(message, title);
        }// warning class 

        private void ListView_Teams_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            /***
             * OK Couldnt figure out how to display player roster when index selected, it kept breaking
             * 
            int selectedIndex = ListView_Teams.SelectedIndex;
            selectedPlayer = selectedTeam.Players[selectedIndex];
            rtbRoster.AppendText(selectedPlayer.DisplayInformation());

            if (selectedPlayer != null)
            {
                

            }***/
        }

        private void btnAddPlayer_Click(object sender, RoutedEventArgs e)
        {
            //teamsin(); // teamsin method which adds the teams player is withing the team, such as offence, defence or special teams
            teams = " ";
            if (oteam)
            {
                teams += "Offence, ";
            }
            if (dteam)
            {
                teams += "Defence, ";
            }
            if (steam)
            {
                teams += "Special Teams, ";
            }
            // unable to remove team once checked checkbox, its being stored somewhere.

            // making sure no missing fields
            if (string.IsNullOrEmpty(tbFName.Text) || string.IsNullOrEmpty(tbLName.Text))
            { Warning(); }
            else // adding new player to list
            {
                Player playerinfo = new Player(tbFName.Text, tbLName.Text, teams, status);
                rtbRoster.AppendText(playerinfo.DisplayInformation()); //displaying player in rich text box, from method in class
                
            }
           
        }

        private void rbActive_Checked(object sender, RoutedEventArgs e)
        {
            status = "Active"; // radio button, status will either be active or inactive on the team
        }

        private void rbInactive_Checked(object sender, RoutedEventArgs e)
        {
            status = "Inactive"; // radio button, status will either be active or inactive on the team
        }

        private void cbOffence_Checked(object sender, RoutedEventArgs e)
        {
            oteam = true; // boolean, will add team to string if true in teamsin method, eitherwise will keep adding if uncheck and recheck
        }

        private void cbDeffence_Checked(object sender, RoutedEventArgs e)
        {
            dteam = true; // boolean, will add team to string if true in teamsin method, eitherwise will keep adding if uncheck and recheck
        }

        private void cbSpecialTeam_Checked(object sender, RoutedEventArgs e)
        {
            steam = true; // boolean, will add team to string if true in teamsin method, eitherwise will keep adding if uncheck and recheck
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            tbCity.Clear();
            tbCoach.Clear();    
            tbFName.Clear();
            tbLName.Clear();    
            tbStadium.Clear();
            tbTeamName.Clear();
            lbConferences.SelectedIndex = -1;
            cbDeffence.IsChecked = false;   
            cbSpecialTeam.IsChecked = false;
            cbOffence.IsChecked = false;    
        }
    }// MainWindow : Window
}// namespace
//Finished