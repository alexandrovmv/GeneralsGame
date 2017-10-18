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
        void ReName(string Oldname, string NewName);
        [OperationContract]
        void FinishRound(string name);
        //  List<Player> Players { get; set; }
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
    }
}
