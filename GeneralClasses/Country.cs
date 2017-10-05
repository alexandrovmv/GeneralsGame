using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralClasses
{
    class Country
    {
        string _Name;
        public string Name
        {
            get
            {
                return _Name;
            }
        }
        public int Balance { get; set; }
        public int Soldiers{ get; set; }
        //Крестьяне
        public int Peasants{ get; set; }
        public int Teritory{ get; set; }
        //Плотность или максимальное население
        public int Density{ get; set; }
        //Зерно
        public int Seed{ get; set; }
        public int SeedIncrement{ get; set; }
        public int PeasantIncrement{ get; set; }
        //Расходы
        public int ExpensesOnSience{ get; set; }
        public int ExpensesOnArmy{ get; set; }
        //Генералы
        public List<General> Generals{ get; set; }

        public Country(string Name, int Balance, int Soldiers, int Peasants, int Teritory, int Density, 
                       int Seed, int SeedIncrement, int PeasantIncrement, int ExpensesOnSience,
                       int ExpensesOnArmy, General General)
        {
            _Name = Name;
            this.Balance=Balance;
            this.Soldiers=Soldiers;
            this.Peasants=Peasants;
            this.Teritory=Teritory;
            this.Density=Density;
            this.Seed=Seed;
            this.SeedIncrement=SeedIncrement;
            this.PeasantIncrement=PeasantIncrement;
            this.ExpensesOnSience=ExpensesOnSience;
            this.ExpensesOnArmy=ExpensesOnArmy;
            Generals.Add(General);
        }
    }
}
