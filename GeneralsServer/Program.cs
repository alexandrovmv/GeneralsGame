using GeneralClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using DataBase;
using System.IO;
using GeneralsServer;

namespace General
{
    class Program
    {
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
