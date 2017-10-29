using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralClasses
{
    public class Country
    {
        //Уровни науки
        public ObservableCollection<ScientificLevel> ScienceLevels { get; set; }  

        string _Name;
        public string Name
        {
            get
            {
                return _Name;
            }
        }
        // Общий
        public int Balance { get; set; }
        public int Scientist { get; set; }
        public int Soldiers { get; set; }
        //Крестьяне
        public int Peasants{ get; set; }
        //возможно удаление свойства public int maxPeasants { get; set; }
        //Площадь
        public int Teritory{ get; set; }
        //Плотность или максимальное население
        public int Density{ get; set; }
        //Зерно
        public int Seed{ get; set; }
        public int SeedForSeeding { get; set; }
        ////Прирост зерна
        //public int SeedIncrement{ get; set; }
        ////Прирост крестьян
        //public int PeasantIncrement{ get; set; }
        //Расходы
        public int ExpensesOnSience{ get; set; }
        public int ExpensesOnArmy{ get; set; }
        //Генералы
        public List<General> Generals{ get; set; }

        void InitScientificLevels()
        {
            ScienceLevels = new ObservableCollection<ScientificLevel>();
            for(int i=0;i < Enum.GetNames(typeof(ScientificLevelType)).Length; i++)
            {
                ScienceLevels.Add(new ScientificLevel { Level = i+1, ScienceType = (ScientificLevelType)i,CurrentProgress=(i+1)*10 });
            }
        }
        public Country(string Name, int Balance, int Peasants, int Teritory, int Seed)
        {
            InitScientificLevels();
            _Name = Name;
            //Начальное количество денег
            this.Balance=Balance;
            //Начальная плотность населения 10 человек на единицу площади. В дальнейшем будет увеличиватся в зависимости от уровня науки в стране
            this.Density = ScienceLevels[(int)ScientificLevelType.Density].Level*10;
            // начальное колдичество крестьян
            this.Peasants=Peasants;
            this.Teritory=Teritory;
            this.Seed=Seed;
            Generals= new List<General>();
        }
        public Country() {
            InitScientificLevels();
            Generals = new List<General>();
            Teritory = StaticConstats.Teritory/StaticConstats.CountOfPlayers;
            Seed = StaticConstats.StartCountOfSeed;
            Balance = StaticConstats.StartBalance;
            Peasants = StaticConstats.StartPeasants;
            //Начальная плотность населения 10 человек на единицу площади. В дальнейшем будет увеличиватся в зависимости от уровня науки в стране
            this.Density = ScienceLevels[(int)ScientificLevelType.Density].Level * StaticConstats.SpecificDensity;
        }
    }

}
