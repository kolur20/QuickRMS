using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickRMS.Classes
{
    class Server
    {
        [Name("NAME")]
        public string Name { get; set; }

        [Name("CONNECTION")]
        public string Connection { get; set; }

        [Name("VERSION")]
        public string Version { get; set; }

        [Name("CHAIN")]
        public bool isChain { get; set; }

        [Name("CO_CONNECTION")]
        public string coConnection { get; set; }

        
    }
}
