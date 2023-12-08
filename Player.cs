using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuanHernandez_Prog2_Final
{
    public class Player
    {
        // Fields
        string _fname;
        string _lname;
        string _team;
        string _status;

        //constructor
        public Player(string fname, string lname, string team, string status)
        {
            _fname = fname;
            _lname = lname; 
            _team = team;
            _status = status;
        }// Player constructor

        // properties
        public string Fname { get => _fname; set => _fname = value; }
        public string Lname { get => _lname; set => _lname = value; }
        public string Team { get => _team; set => _team = value; }
        public string Status { get => _status; set => _status = value; }

        // Display method
        public string DisplayInformation()
        {
            string fullname = _fname + " " + _lname;

            string fullDisplay = ""; // ""
            fullDisplay += $"Player Name: {fullname }\n";
            fullDisplay += $"Teams: {_team}\n";
            fullDisplay += $"Status: {_status}\n";
            fullDisplay += "-----------------\n";
            return fullDisplay;
        }
    }// Player
}// namespace
