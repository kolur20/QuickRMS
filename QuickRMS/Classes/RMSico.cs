using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickRMS.Classes
{
    class RMSico
    {
        public string File { get; set; }
        public bool IsChain { get; set; }
        public string Version { get; set; }

        public RMSico(string path, string version)
        {
            File = path;
            IsChain = File.Contains("Chain") || File.Contains("chain") ? true : false;
            Version = version;
        }
        
        public override string ToString()
        {
            var name =  IsChain? "ChainOffice" : "BackOffice";
            return string.Concat(name, " ", Version, ".lnk");
        }
    }
}
