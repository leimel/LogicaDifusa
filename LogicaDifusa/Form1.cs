using LogicaDifusa.Funciones;
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
        private static Form1 Form;

        public static Form1 getInstance()
        {
            if (Form == null || Form.IsDisposed)
            {
                Form = new Form1();
            }
            return Form;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void c_TextChanged(object sender, EventArgs e)
        {
            validarvacio(TraC);
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
            if (valoresTra.Visible == true) valoresTra.Visible = false;
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
            Grafico.Series[0].Points.Clear();
            dataGridView1.Rows.Clear();
            if (triangular.Checked == true)
            {
                Triangular funtri = Triangular.CREATE(Convert.ToInt32(TriInf.Value), Convert.ToInt32(TriSup.Value), Convert.ToDouble(TriA.Text), Convert.ToDouble(TriB.Text), Convert.ToDouble(TriC.Text));
                funtri.graficar();
            }
            if (trapezoidal.Checked == true)
            {
                Trapezoidal funtra = Trapezoidal.CREATE(Convert.ToInt32(TraInferior.Value), Convert.ToInt32(TraSuperior.Value), Convert.ToDouble(TraA.Text), Convert.ToDouble(TraB.Text), Convert.ToDouble(TraC.Text), Convert.ToDouble(TraD.Text));
                funtra.graficar();
            }
            if (gaussiana.Checked == true)
            {
                Gaussiana funga = Gaussiana.CREATE(Convert.ToInt32(GaInferior.Value), Convert.ToInt32(GaSuperior.Value), Convert.ToDouble(GaA.Text), Convert.ToDouble(GaB.Text));
                funga.graficar();
            }
            if (bell.Checked == true)
            {
                Bell funbe = Bell.CREATE(Convert.ToInt32(BeInferior.Value), Convert.ToInt32(BeSuperior.Value), Convert.ToDouble(BeA.Text), Convert.ToDouble(BeB.Text), Convert.ToDouble(BeC.Text));
                funbe.graficar();
            }
            if (sigmoide.Checked == true)
            {
                Sigmoide funsig = Sigmoide.CREATE(Convert.ToInt32(SigInferior.Value), Convert.ToInt32(SigSuperior.Value), Convert.ToDouble(SigA.Text), Convert.ToDouble(SigB.Text));
                funsig.graficar();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TriA_TextChanged(object sender, EventArgs e)
        {
            validarvacio(TriA);
            
        }

        private void validarvacio(TextBox cuadro)
        {
            if (String.IsNullOrWhiteSpace(cuadro.Text))
            {
                cuadro.Text = "0";
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void TriA_KeyPress(object sender, KeyPressEventArgs e)
        {
            descartarletra(e);
        }

        private void TriB_KeyPress(object sender, KeyPressEventArgs e)
        {
            descartarletra(e);
        }
        private void descartarletra(KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar) || Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TriC_TextChanged(object sender, EventArgs e)
        {
            validarvacio(TriC);
        }

        private void TriC_KeyPress(object sender, KeyPressEventArgs e)
        {
            descartarletra(e);
        }

        private void TraA_KeyPress(object sender, KeyPressEventArgs e)
        {
            descartarletra(e);
        }

        private void TraB_KeyPress(object sender, KeyPressEventArgs e)
        {
            descartarletra(e);
        }

        private void TraC_KeyPress(object sender, KeyPressEventArgs e)
        {
            descartarletra(e);
        }

        private void TraD_KeyPress(object sender, KeyPressEventArgs e)
        {
            descartarletra(e);
        }

        private void GaA_KeyPress(object sender, KeyPressEventArgs e)
        {
            descartarletra(e);
        }

        private void GaB_KeyPress(object sender, KeyPressEventArgs e)
        {
            descartarletra(e);
        }

        private void BeA_KeyPress(object sender, KeyPressEventArgs e)
        {
            descartarletra(e);
        }

        private void BeB_KeyPress(object sender, KeyPressEventArgs e)
        {
            descartarletra(e);
        }

        private void BeC_KeyPress(object sender, KeyPressEventArgs e)
        {
            descartarletra(e);
        }

        private void SigA_KeyPress(object sender, KeyPressEventArgs e)
        {
            descartarletra(e);
        }

        private void SigB_KeyPress(object sender, KeyPressEventArgs e)
        {
            descartarletra(e);
        }

        private void TriB_TextChanged(object sender, EventArgs e)
        {
            validarvacio(TriB);
        }

        private void TraA_TextChanged(object sender, EventArgs e)
        {
            validarvacio(TraA);
        }

        private void TraB_TextChanged(object sender, EventArgs e)
        {
            validarvacio(TraB);
        }

        private void TraD_TextChanged(object sender, EventArgs e)
        {
            validarvacio(TraD);
        }

        private void GaA_TextChanged(object sender, EventArgs e)
        {
            validarvacio(GaA);
        }

        private void GaB_TextChanged(object sender, EventArgs e)
        {
            validarvacio(GaB);
        }

        private void BeA_TextChanged(object sender, EventArgs e)
        {
            validarvacio(BeA);
        }

        private void BeB_TextChanged(object sender, EventArgs e)
        {
            validarvacio(BeB);
        }

        private void BeC_TextChanged(object sender, EventArgs e)
        {
            validarvacio(BeC);
        }

        private void SigA_TextChanged(object sender, EventArgs e)
        {
            validarvacio(SigA);
        }

        private void SigB_TextChanged(object sender, EventArgs e)
        {
            validarvacio(SigB);
        }

        private void TriA_Leave(object sender, EventArgs e)
        {
            if (int.Parse(TriA.Text) > int.Parse(TriB.Text))
            {
                TriA.Text = "0";
            }
        }
    }
}