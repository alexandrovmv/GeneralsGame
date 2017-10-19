using GeneralsClient.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralsClient.Model
{
    static class InterClass
    {
        public static GeneralClient gc { get; set; } = new GeneralClient();
        public static string PlayerName { get; set; }
    }
}
