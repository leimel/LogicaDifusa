using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicaDifusa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void c_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void gaussiana_CheckedChanged(object sender, EventArgs e)
        {
            if (valoresGa.Visible == true) valoresGa.Visible = false;
            else valoresGa.Visible = true;
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void triangular_CheckedChanged(object sender, EventArgs e)
        {
            if (valoresTri.Visible == true) valoresTri.Visible = false;
            else valoresTri.Visible = true;
        }

        private void trapezoidal_CheckedChanged(object sender, EventArgs e)
        {
            if(valoresTra.Visible==true) valoresTra.Visible = false;
            else valoresTra.Visible = true;
            
        }

        private void bell_CheckedChanged(object sender, EventArgs e)
        {
            if (valoresBe.Visible == true) valoresBe.Visible = false;
            else valoresBe.Visible = true;
        }

        private void sigmoide_CheckedChanged(object sender, EventArgs e)
        {
            if (valoresSi.Visible == true) valoresSi.Visible = false;
            else valoresSi.Visible = true;
        }

        private void graficar_Click(object sender, EventArgs e)
        {
            if (valoresTri.Visible == true)
            {
                if()
            }
            if (valoresTra.Visible == true)
            {

            }
            if(valoresGa.Visible == true)
            {

            }
            if (valoresBe.Visible == true)
            {

            }
            if (valoresSi.Visible == true)

        }
    }
}
