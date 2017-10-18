﻿using GeneralClasses;
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
            void AddUser(string Name);
            [OperationContract]
            void Registr(string Login, string Password);
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

            public void Hierscietisctc(string PlayerName, int Count)
            {
                Player SelectedPlayer = Players.Find(x => x.Name == PlayerName);
                SelectedPlayer.country.Peasants -= Count;
                SelectedPlayer.country.Balance -= Count * StaticConstats.PriceOfScientists;
                SelectedPlayer.country.Scientist += Count;


            }
            public void  HireSoldiers(string PlayerName, int Count)
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
                if(MaxCountOfScietists>SelectedPlayer.country.Peasants)
                {
                    MaxCountOfScietists = SelectedPlayer.country.Peasants;
                }
              
                return MaxCountOfScietists;
            }
           public int  GetMaxCountSoldiers(string PlayerName)
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

            public void SellSoldiers(string PlayerName, int Count)
            {
                Player SelectedPlayer = Players.Find(x => x.Name == PlayerName);
                SelectedPlayer.country.Soldiers -= Count;
            }

            public void SellScietists(string PlayerName, int Count)
            {
                Player SelectedPlayer = Players.Find(x => x.Name == PlayerName);
                SelectedPlayer.country.Scientist -= Count;
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
