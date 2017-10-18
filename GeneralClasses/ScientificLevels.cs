using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralClasses
{
    public class ScientificLevels
    {
        //Наверное нужна переменная с незанятыми учеными 
        public int DensityLevel { get; set; }
        public int PeasantIncrementLevel { get; set; }
        public int SeedIcrementLevel { get; set; }
        public int EconomyLevel { get; set; }
        public int WarArtLevel { get; set; }
        public int ScientificLevel { get; set; }
        public ScientificLevels()
        {
            DensityLevel = PeasantIncrementLevel = SeedIcrementLevel = EconomyLevel = WarArtLevel = ScientificLevel = 1;
        }

    }
}
