using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PandocGUI
{
    class CommandModel
    {
        public string inputfile { get; set; }

        public string defaultCommand { get; set; }
        public string outputfile { get; set; }

        public string outputformat { get; set; }

        public string outputStyle { get; set; }
 
    }
}
