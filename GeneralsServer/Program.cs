using GeneralClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using DataBase;
using System.IO;

namespace General
{
    class Program
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
            void AddUser(string name);
            [OperationContract]
            void Registr(string login, string password);
            [OperationContract]
            bool Autorise(string login, string password);

        }
        public class Game : IGeneral
        {
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
                Players.Add(new Player(name));

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
               
            }

            public void Registr(string login, string password)
            {
                database = new DB();
                database.Add_User(login, password);
            }

            public bool Autorise(string login, string password)
            {
                database = new DB();
                return database.Authorization(login, password);
            }
        }
        static void Main(string[] args)
        {
            DataBase.DB db = new DB();
            if (!File.Exists("TestDB.db")) {
                db.Create_DataBase();
            }
            ServiceHost host = new ServiceHost(typeof(Game));
            host.Open();
            Console.WriteLine("Service is on");
            Console.ReadKey();
            host.Close();
            Console.WriteLine("Service is off");
        }
    }
}
