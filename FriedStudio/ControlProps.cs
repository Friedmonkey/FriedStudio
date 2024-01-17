using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using Size = System.Windows.Size;

namespace ScuffedScri
{
    [Serializable]
    public class controlProps
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public bool Enabled { get; set; }
        public Color BackColor { get; set; }
        public Color ForeColor { get; set; }
        public Size Size { get; set; }
        public Point Location { get; set; }

        //Textbox
        public bool Multiline { get; set; }

        //CheckBox
        public bool Checked { get; set; }

        public fakeControlType ControlType { get; set; }
    }
}
