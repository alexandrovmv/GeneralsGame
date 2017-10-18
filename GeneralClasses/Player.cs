using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralClasses
{
    public class Player
    {
        string _Name;
        public bool IsFinished;

        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                Name = value;
            }
        }
     public    Country country { get; set; }
        public Player(string Name)
        {
            _Name = Name;
        }

        public bool IsFinish()
        {
            throw new NotImplementedException();
        }
    }
}
