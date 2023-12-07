using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuanHernandez_Prog2_Final
{
    public class Teams
    {
        // Fields
        string _conference;
        string _name;
        string _city;
        string _stadium;
        string _coach;

        // constructor
        public Teams(string conference, string name, string city, string stadium, string coach)
        {
            _conference = conference;
            _name = name;   
            _city = city;   
            _stadium = stadium;
            _coach = coach;
        }// Teams constructor

        // properties
        public string Conference { get => _conference; set => _conference = value; }
        public string Name { get => _name; set => _name = value; }
        public string City { get => _city; set => _city = value; }
        public string Stadium { get => _stadium; set => _stadium = value; }
        public string Coach { get => _coach; set => _coach = value; }
    }// Teams
}// namespace
