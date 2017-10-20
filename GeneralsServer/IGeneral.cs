using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace GeneralsServer
{
    [ServiceContract]
    public interface IGeneral
    {
        [OperationContract]
        int GetSeedCount(string PlayerName);
        [OperationContract]
        int GetScientists(string Playername);
        [OperationContract]
        int SpendOnScientists(string Playername);

        [OperationContract]
        int GetMoney(string PlayerName);
        [OperationContract]
        bool isServerFull();
        [OperationContract]
        void ReName(string Oldname, string NewName);
        [OperationContract]
        void FinishRound(string name);
        [OperationContract]
        bool IsFinish();
        [OperationContract]
        int GetCount();
        [OperationContract]
        void AddUser(string Name);
        [OperationContract]
        bool Registr(string login, string password);
        [OperationContract]
        bool Autorise(string Login, string Password);
        [OperationContract]
        void Hierscietisctc(string PlayerName, int Count);
        [OperationContract]
        void HireSoldiers(string PlayerName, int Count);
        [OperationContract]
        int GetMaxCountScietists(string PlayerName);
        [OperationContract]
        int GetMaxCountSoldiers(string PlayerName);
        [OperationContract]
        int GetMaxCountOfSeeds(string PlayerName);
        [OperationContract]
        void BuySeeds(string PlayerName, int Count);
        [OperationContract]
        void SellSeeds(string PlayerName, int Count);
        [OperationContract]
        void SellSoldiers(string PlayerName, int Count);
        [OperationContract]
        void SellScietists(string PlayerName, int Count);
        [OperationContract]
        void Seeding(string PlayerName, int Count);

        [OperationContract]
         int GetYearsForScientificLevel(GeneralClasses.ScientificLevels a, int count);
        [OperationContract]
        int GetYearsForDensityLvl(GeneralClasses.ScientificLevels a, int count);
        [OperationContract]
        int GetYearsForSeedIcrementLevel(GeneralClasses.ScientificLevels a, int count);
        [OperationContract]
        int GetYearsForEconomyLevel(GeneralClasses.ScientificLevels a, int count);
        [OperationContract]
        int GetYearsForWarArtLevel(GeneralClasses.ScientificLevels a, int count);
        [OperationContract]
        int GetYearsForPeasantIncrementLevel(GeneralClasses.ScientificLevels a, int count);
        #region Действия с генералом
        [OperationContract]
        void HireGeneral(string PlayerName,int Price, string Name,int Age,int Skill,int Speed);
        [OperationContract]
        void FireGeneral(string PlayerName, string Name);
        [OperationContract]
        int GetCountOfGenerals(string PlayerName);
        #endregion
        [OperationContract]
        bool IsPlayerAlreasyExist(string PlayerName);
        [OperationContract]
        void DeleteSelectedPlayer(string PlayerName);

    }
}
