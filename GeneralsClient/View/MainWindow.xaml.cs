using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GeneralsClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Client();
        }
        public void Client()
        {
            IPAddress address = IPAddress.Parse("127.0.0.1");
            IPEndPoint endpoint = new IPEndPoint(address, 11000);
            TcpClient client = new TcpClient();
            client.Connect(endpoint);
            NetworkStream sw = client.GetStream();
            StreamWriter sww = new StreamWriter(sw);
            while (true)
            {
                string p = Console.ReadLine();
                sww.WriteLine(p);
                sww.Flush();
                if (p == "exit")
                {
                    sww.Close();
                    client.Close();
                    break;
                }
            }
        }
    }
}
