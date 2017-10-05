﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralClasses
{
    [Serializable]
    public class General
    {
        string _Name;
        public string Name
        {   get
            {
                return _Name;
            }
        }
        public int Age { get; set; }
        public int Skill { get; set; }
        public int State { get; set; }
        public int Inspiration { get; set; }
        //public General()
        //{

        //}
        public General(string Name, int Age, int Skill)
        {
            _Name = Name;
            this.Age = Age;
            this.Skill = Skill;
            Inspiration = 100;
        }


    }

}