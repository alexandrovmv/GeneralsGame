using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralClasses
{
    public class Country
    {
        //Уровни науки
        public ScientificLevels ScienceLevels;     

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
        public int Soldiers{ get; set; }
        public int Scientist { get; set; }
        
        //Крестьяне
        public int Peasants{ get; set; }
        public int maxPeasants { get; set; }
        //Площадь
        public int Teritory{ get; set; }
        //Плотность или максимальное население
        public int Density{ get; set; }
        //Зерно
        public int Seed{ get; set; }
        //Прирост зерна
        public int SeedIncrement{ get; set; }
        //Прирост крестьян
        public int PeasantIncrement{ get; set; }
        //Расходы
        public int ExpensesOnSience{ get; set; }
        public int ExpensesOnArmy{ get; set; }
        //Генералы
        public List<General> Generals{ get; set; }

        public Country(string Name, int Balance, int Peasants, int Teritory, int Seed)
        {
            ScienceLevels = new ScientificLevels();
            _Name = Name;
            //Начальное количество денег
            this.Balance=Balance;
            //Начальная плотность населения 10 человек на единицу площади. В дальнейшем будет увелдичиватся в зависимости от уровня науки в стране
            this.Density = ScienceLevels.DensityLevel*10;
            // начальное колдичество крестьян
            this.Peasants=Peasants;
            this.Teritory=Teritory;
            this.Seed=Seed;
            Generals= new List<General>();
        }
    }

}
