using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralsServer
{
    public class Player
    {
        public string Name { get; set; }
        public bool IsFinished { get; set; }

        public Player(string name)
        {
            this.Name = name;
        }
    }
}
