using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralClasses
{
    class Player
    {
        string _Name;
        public string Name
        {
            get
            {
                return _Name;
            }
        }
        Country country { get; set; }
        public Player(string Name)
        {
            _Name = Name;
        }
    }
}
