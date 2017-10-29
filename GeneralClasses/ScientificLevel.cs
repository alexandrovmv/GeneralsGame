using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralClasses
{
    public class ScientificLevel
    {
        public ScientificLevelType ScienceType { get; set; }
        public int Level { get; set; }
        public int CurrentProgress { get; set; }
        public int ScientistOnWork { get; set; }
        public int ScientistOnLevel { get { return Level * StaticConstats.ScientistPerLevel; } }
    }
    public enum ScientificLevelType { Density, PeasantIncrement, SeedIncrement, Economy, WarArt, Scientific }
}
