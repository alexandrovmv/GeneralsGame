using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GeneralsServer
{

    [Serializable]
    class Some
    {
        public string Text { get; set; }
        public DateTime Date { get; set; }
    }
    class Program
    {
        const int port = 20001;
        static void Main(string[] args)
        {
            Console.WriteLine("Это сервер");
            IPAddress address = IPAddress.Parse("127.0.0.1");
            IPEndPoint endpoint = new IPEndPoint(address, 11000);
            TcpListener listener = new TcpListener(endpoint);
            listener.Start();
            Console.WriteLine("Ожидаем подключения...");
            while (true)
            {
                TcpClient Handler = listener.AcceptTcpClient();

                Console.WriteLine("Подключен");
                Thread t = new Thread(Handle);
                t.IsBackground = true;
                t.Start(Handler);
            }

        }
        static void Handle(object parameter)
        {
            TcpClient client = (TcpClient)parameter;
            NetworkStream sr = client.GetStream();
            StreamReader srr = new StreamReader(sr);
            while (true)
            {
                //byte[] bytes = new byte[500];
                //sr.Read(bytes, 0, 500);
                //string s = Encoding.Unicode.GetString(bytes);

                string s = srr.ReadLine();
                Console.WriteLine(s);
                if (s == "exit")
                {

                    sr.Close();
                    client.Close();
                    break;
                }

            }

        }
    }
}
