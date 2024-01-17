using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ScuffedScri
{
    [Serializable]
    public class Project
    {
        public string Name { get; set; }
        public string NameSpace { get; set; }
        public string Target { get; set; }

        public string ProgramCs { get; set; }
        public string FormCs { get; set; }

        public Size FormSize { get; set; }

        public List<controlProps> Controls { get; set; }
    }
}
