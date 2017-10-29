using DataBase;
using GeneralClasses;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralsServer
{
    public class Game : IGeneral
    {
       public int GetSeedCount(string PlayerName)
        {
            Player SelectedPlayer = Players.Find(x => x.Name == PlayerName);
            return SelectedPlayer.country.Seed;
        }
        DB database { get; set; }
        static List<Player> _Players { get; set; }
        public List<Player> Players
        {
            get
            {
                return _Players;
            }

            set
            {
                _Players = value;
            }
        }

        public void AddUser(string name)
        {
            Player p = new Player(name);
            Players.Add(p);
        }
        public Game()
        {

            if (Players == null)
            {
                Players = new List<Player>();

            }

        }
        public int GetCount()
        {
            return _Players.Count();
        }
        public bool IsFinish()
        {

            foreach (Player p in _Players)
            {

                if (!p.IsFinished) return false;
            }

            return true;
        }

        public void ReName(string Oldname, string NewName)
        {
            Player q = Players.Find(x => x.Name == Oldname);
            q.Name = NewName;
        }

        public void FinishRound(string name)
        {
            Player SelectedPalyer = Players.Find(x => x.Name == name);
            SelectedPalyer.IsFinished = true;
        }

        public bool Registr(string login, string password)
        {
            database = new DB();
            return database.Add_User(login, password);
        }

        public bool Autorise(string login, string password)
        {
            database = new DB();
            return database.Authorization(login, password);
        }

        public bool isServerFull()
        {
            if (Players.Count < 4) return false;
            return true;
        }

        public void HireScietists(string PlayerName, int Count)
        {
            Player SelectedPlayer = Players.Find(x => x.Name == PlayerName);
            SelectedPlayer.country.Peasants -= Count;
            SelectedPlayer.country.Balance -= Count * StaticConstats.PriceOfScientists;
            SelectedPlayer.country.Scientist += Count;


        }
        public void HireSoldiers(string PlayerName, int Count)
        {
            Player SelectedPlayer = Players.Find(x => x.Name == PlayerName);
            SelectedPlayer.country.Peasants -= Count;
            SelectedPlayer.country.Balance -= Count * StaticConstats.PriceOfSoldiers;
            SelectedPlayer.country.Soldiers += Count;
        }

        public void BuySeeds(string PlayerName, int Count)
        {
            Player SelectedPlayer = Players.Find(x => x.Name == PlayerName);
            SelectedPlayer.country.Seed += Count;
            SelectedPlayer.country.Balance -= Count * StaticConstats.PriceOfSeedsBuy;
        }
        public int GetMaxCountScietists(string PlayerName)
        {
            int MaxCountOfScietists;
            Player SelectedPlayer = Players.Find(x => x.Name == PlayerName);
            MaxCountOfScietists = SelectedPlayer.country.Balance / StaticConstats.PriceOfScientists;
            if (MaxCountOfScietists > SelectedPlayer.country.Peasants)
            {
                MaxCountOfScietists = SelectedPlayer.country.Peasants;
            }

            return MaxCountOfScietists;
        }
        public int GetMaxCountSoldiers(string PlayerName)
        {
            int MaxCountSoldiers;
            Player SelectedPlayer = Players.Find(x => x.Name == PlayerName);
            MaxCountSoldiers = SelectedPlayer.country.Balance / StaticConstats.PriceOfSoldiers;
            if (MaxCountSoldiers > SelectedPlayer.country.Peasants)
            {
                MaxCountSoldiers = SelectedPlayer.country.Peasants;
            }
            return MaxCountSoldiers;
        }

        public int GetMaxCountOfSeeds(string PlayerName)
        {
            int MaxCountSeeds;
            Player SelectedPlayer = Players.Find(x => x.Name == PlayerName);
            MaxCountSeeds = SelectedPlayer.country.Balance / StaticConstats.PriceOfSeedsBuy;

            return MaxCountSeeds;
        }

        public void SellSeeds(string PlayerName, int Count)
        {
            Player SelectedPlayer = Players.Find(x => x.Name == PlayerName);
            SelectedPlayer.country.Seed -= Count;
            SelectedPlayer.country.Balance += Count * StaticConstats.PriceOfSeedsSell;
        }
        /// <summary>
        /// Метод переводит солдат в крестьян
        /// </summary>
        /// <param name="PlayerName"></param>
        /// <param name="Count"></param>
        public void SellSoldiers(string PlayerName, int Count)
        {
            Player SelectedPlayer = Players.Find(x => x.Name == PlayerName);
            SelectedPlayer.country.Soldiers -= Count;
            SelectedPlayer.country.Peasants += Count;
        }
        /// <summary>
        /// Метод переводит ученых в крестьян
        /// </summary>
        /// <param name="PlayerName"></param>
        /// <param name="Count"></param>
        public void SellScietists(string PlayerName, int Count)
        {
            Player SelectedPlayer = Players.Find(x => x.Name == PlayerName);
            SelectedPlayer.country.Scientist -= Count;
            SelectedPlayer.country.Peasants += Count;
        }
        //Просчет количества лет для полного иследования научной галузи
        public int GetYearsForDensityLvl(ScientificLevels a, int count)
        {
            int Years = (100 * a.DensityLevel) / count * (a.ScientificLevel / 10 + 1);
            return Years;
        }
        public int GetYearsForPeasantIncrementLevel(ScientificLevels a, int count)
        {
            int Years = (100 * a.PeasantIncrementLevel) / count * (a.ScientificLevel / 10 + 1);
            return Years;
        }
        public int GetYearsForSeedIcrementLevel(ScientificLevels a, int count)
        {
            int Years = (100 * a.SeedIcrementLevel) / count * (a.ScientificLevel / 10 + 1);
            return Years;
        }
        public int GetYearsForEconomyLevel(ScientificLevels a, int count)
        {
            int Years = (100 * a.EconomyLevel) / count * (a.ScientificLevel / 10 + 1);
            return Years;
        }
        public int GetYearsForWarArtLevel(ScientificLevels a, int count)
        {
            int Years = (100 * a.WarArtLevel) / count * (a.ScientificLevel / 10 + 1);
            return Years;
        }
        public int GetYearsForScientificLevel(ScientificLevels a, int count)
        {
            int Koef = 100 * a.ScientificLevel / count;
            return Koef;
        }
        #region Действия с генералом
        public void HireGeneral(string PlayerName, int Price, string GeneralName, int Age, int Skill, int Speed)
        {
            Player SelectedPlayer = Players.Find(x => x.Name == PlayerName);
            if (SelectedPlayer.country.Generals == null) SelectedPlayer.country.Generals = new List<GeneralClasses.General>();
            SelectedPlayer.country.Generals.Add(new GeneralClasses.General(GeneralName,Age,Skill,Speed));
        }

        public void FireGeneral(string PlayerName, string GeneralName)
        {
            Player SelectedPlayer = Players.Find(x => x.Name == PlayerName);
            SelectedPlayer.country.Generals.Remove(
                SelectedPlayer.country.Generals.Find(x=>{return x.Name == GeneralName; }
                ));
        }

        public int GetCountOfGenerals(string PlayerName)
        {
            return Players.Find(x => x.Name == PlayerName).country.Generals.Count;
        }
        #endregion
        public int GetMoney(string PlayerName)
        {
            Player SelectedPlayer = Players.Find(x => x.Name == PlayerName);
            return SelectedPlayer.country.Balance;
        }
        public int GetScientists(string Playername)
        {
            Player SelectedPlayer = Players.Find(x => x.Name == Playername);
            return SelectedPlayer.country.Scientist;
        }
        public int SpendOnScientists(string Playername)
        {
            Player SelectedPlayer = Players.Find(x => x.Name == Playername);
            return SelectedPlayer.country.Scientist * StaticConstats.SpendOnScientist;
        }

        public void Seeding(string PlayerName, int Count)
        {
            Player SelectedPlayer = Players.Find(x => x.Name == PlayerName);
            SelectedPlayer.country.Seed -= Count;
            SelectedPlayer.country.SeedForSeeding += Count;
        }
       
        public bool IsPlayerAlreasyExist(string PlayerName)
        {
            foreach (Player item in Players)
            {
                if (item.Name == PlayerName)
                    return true;
            }

            return false;
        }
        public int GetCountOfPeasants(string PlayerName)
        {
            Player SelectedPlayer = Players.Find(x => x.Name == PlayerName);
            return SelectedPlayer.country.Peasants;
        }

        public void DeleteSelectedPlayer(string PlayerName)
        {
            Players.Remove(Players.Find(x => x.Name == PlayerName));
        }
       public int GetCountOfSoldiers(string PlayerName)
       {
            Player SelectedPlayer = Players.Find(x => x.Name == PlayerName);
            return SelectedPlayer.country.Soldiers;
       }
       public int GetSpendOnSoldiers(string PlayerName)
       {
            Player SelectedPlayer = Players.Find(x => x.Name == PlayerName);
            return SelectedPlayer.country.Soldiers * StaticConstats.SpendOnSoldier;
        }

        #region Методы для работы с уровнями науки
        public int GetScientificLevel(string PlayerName, ScientificLevelType LevelType)
        {
            int result = 0;
            Player SelectedPlayer = Players.Find(x => x.Name == PlayerName);
            switch (LevelType)
            {
                case ScientificLevelType.Density:
                    result = SelectedPlayer.country.ScienceLevels[(int)ScientificLevelType.Density].Level;
                    break;
                case ScientificLevelType.PeasantIncrement:
                    result = SelectedPlayer.country.ScienceLevels[(int)ScientificLevelType.PeasantIncrement].Level;
                    break;
                case ScientificLevelType.SeedIncrement:
                    result = SelectedPlayer.country.ScienceLevels[(int)ScientificLevelType.SeedIncrement].Level;
                    break;
                case ScientificLevelType.Economy:
                    result = SelectedPlayer.country.ScienceLevels[(int)ScientificLevelType.Economy].Level;
                    break;
                case ScientificLevelType.WarArt:
                    result = SelectedPlayer.country.ScienceLevels[(int)ScientificLevelType.WarArt].Level;
                    break;
                case ScientificLevelType.Scientific:
                    result = SelectedPlayer.country.ScienceLevels[(int)ScientificLevelType.Scientific].Level;
                    break;
            }

            return result;
        }

        public int GetSeedIncrement(string PlayerName)
        {
            Player SelectedPlayer = Players.Find(x => x.Name == PlayerName);
            return (int)(SelectedPlayer.country.SeedForSeeding*StaticConstats.SeedIncrementKoefPerScientLevel*SelectedPlayer.country.ScienceLevels[(int)ScientificLevelType.SeedIncrement].Level);
        }

        public int GetPeopleIncrement(string PlayerName)
        {
            Player SelectedPlayer = Players.Find(x => x.Name == PlayerName);
            int result;
            result = (int)(SelectedPlayer.country.Peasants * StaticConstats.PeopleIncrementKoefPerScientLevel * SelectedPlayer.country.ScienceLevels[(int)ScientificLevelType.PeasantIncrement].Level);
            return result;
        }

        public int GetMaxPeopleCount(string PlayerName)
        {
            Player SelectedPlayer = Players.Find(x => x.Name == PlayerName);
            return SelectedPlayer.country.ScienceLevels[(int)ScientificLevelType.Density].Level * SelectedPlayer.country.Teritory * StaticConstats.PeoplePerSquare;
        }

        public int GetTerritorySize(string PlayerName)
        {
            Player SelectedPlayer = Players.Find(x => x.Name == PlayerName);
            return SelectedPlayer.country.Teritory;
        }

        public ObservableCollection<ScientificLevel> GetScientificLevels(string PlayerName)
        {
            Player SelectedPlayer = Players.Find(x => x.Name == PlayerName);
            return SelectedPlayer.country.ScienceLevels;
        }
        #endregion
    }
}
