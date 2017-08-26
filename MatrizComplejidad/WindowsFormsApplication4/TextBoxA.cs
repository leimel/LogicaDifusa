using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    class TextBoxA: System.Windows.Forms.TextBox
    {
        public int posicion { get; set; }
        public int fila { get; set; }
        public int col { get; set; }

        public TextBoxA():base()
        {
        }
    }
}
