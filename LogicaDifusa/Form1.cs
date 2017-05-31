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
        private Triangular Ftriangular = new Triangular();
        private Trapezoidal Ftrapezoidal =new Trapezoidal();
        private Gaussiana Fgaussiana =new Gaussiana();
        private Bell Fbell =new Bell();
        private Sigmoide Fsigmoide =new Sigmoide();
        private int Graficas = 0; 

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

        private void gaussiana_CheckedChanged(object sender, EventArgs e)
        {
            if (valoresGa.Visible == true)
            {
                valoresGa.Visible = false;
                Graficas -= 1;
            }
            else
            {
                valoresGa.Visible = true;
                Graficas += 1;
            }
        }

        private void triangular_CheckedChanged(object sender, EventArgs e)
        {
            if (valoresTri.Visible == true)
            {
                valoresTri.Visible = false;
                Graficas -= 1;    
            }
            else
            {
                valoresTri.Visible = true;
                Graficas += 1;
            }
        }

        private void trapezoidal_CheckedChanged(object sender, EventArgs e)
        {
            if (valoresTra.Visible == true)
            {
                valoresTra.Visible = false;
                Graficas -= 1;
            }
            else
            {
                valoresTra.Visible = true;
                Graficas += 1;
            }

        }

        private void bell_CheckedChanged(object sender, EventArgs e)
        {
            if (valoresBe.Visible == true)
            {
                valoresBe.Visible = false;
                Graficas -= 1;
            }
            else
            {
                valoresBe.Visible = true;
                Graficas += 1;
            }
        }

        private void sigmoide_CheckedChanged(object sender, EventArgs e)
        {
            if (valoresSi.Visible == true)
            {
                valoresSi.Visible = false;
                Graficas -= 1;
            }
            else
            {
                valoresSi.Visible = true;
                Graficas += 1;
            }
        }

        private void graficar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                Grafico.Series[i].Points.Clear();
                Grafico.Series[i].IsVisibleInLegend = false;
            }

            dataGridView1.Rows.Clear();
            int Graficados = 0;
            for(int x = 0; x <= 100 || Graficas > Graficados ; x++)
            {
                if (triangular.Checked && Convert.ToInt32(TriInf.Value) <= x && Convert.ToInt32(TriSup.Value)>=x)
                {
                    Ftriangular.asignar(Convert.ToInt32(TriSup.Value), Convert.ToDouble(TriA.Text), Convert.ToDouble(TriB.Text), Convert.ToDouble(TriC.Text));
                    x = Ftriangular.graficar(x);
                    Grafico.Series[0].IsVisibleInLegend = true;
                    Graficados += 1;
                    continue;
                }
                if (trapezoidal.Checked && Convert.ToInt32(TraInferior.Value) <= x && Convert.ToInt32(TraSuperior.Value) >= x)
                {
                    Ftrapezoidal.asignar(Convert.ToInt32(TraSuperior.Value), Convert.ToDouble(TraA.Text), Convert.ToDouble(TraB.Text), Convert.ToDouble(TraC.Text), Convert.ToDouble(TraD.Text));
                    x = Ftrapezoidal.graficar(x);
                    Grafico.Series[1].IsVisibleInLegend = true;
                    Graficados += 1;
                    continue;
                }
                if (gaussiana.Checked && Convert.ToInt32(GaInferior.Value) <= x && Convert.ToInt32(GaSuperior.Value) >= x)
                {
                    Fgaussiana.asignar(Convert.ToInt32(GaSuperior.Value), Convert.ToDouble(GaA.Text), Convert.ToDouble(GaB.Text));
                    x = Fgaussiana.graficar(x);
                    Grafico.Series[2].IsVisibleInLegend = true;
                    Graficados += 1;
                    continue;
                }
                if (bell.Checked && Convert.ToInt32(BeInferior.Value) <= x && Convert.ToInt32(BeSuperior.Value) >= x)
                {

                    Fbell.asignar(Convert.ToInt32(BeSuperior.Value), Convert.ToDouble(BeA.Text), Convert.ToDouble(BeB.Text), Convert.ToDouble(BeC.Text));
                    x = Fbell.graficar(x);
                    Grafico.Series[3].IsVisibleInLegend = true;
                    Graficados += 1;
                    continue;
                }
                if (sigmoide.Checked && Convert.ToInt32(SigInferior.Value) <= x && Convert.ToInt32(SigSuperior.Value) >= x)
                {
                    Fsigmoide.asignar(Convert.ToInt32(SigSuperior.Value), Convert.ToDouble(SigA.Text), Convert.ToDouble(SigB.Text));
                    x = Fsigmoide.graficar(x);
                    Grafico.Series[4].IsVisibleInLegend = true;
                    Graficados += 1;
                    continue;
                }
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
            if (String.IsNullOrWhiteSpace(GaB.Text))
            {
                GaB.Text = "1";
            }
        }

        private void BeA_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(BeA.Text))
            {
                BeA.Text = "1";
            }
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
            if (Convert.ToDouble(TriA.Text) >= Convert.ToDouble(TriB.Text) || Convert.ToDouble(TriA.Text)<0)
            {
                TriA.Text = "0";
            }
        }

        private void TriB_Leave(object sender, EventArgs e)
        {
            if (Convert.ToDouble(TriB.Text) <= Convert.ToDouble(TriA.Text) || Convert.ToDouble(TriB.Text)>= Convert.ToDouble(TriC.Text))
            {
                TriB.Text = (Convert.ToDouble(TriA.Text)+1).ToString();
            }
        }

        private void TriC_Leave(object sender, EventArgs e)
        {
            if (Convert.ToDouble(TriC.Text) <= Convert.ToDouble(TriB.Text) || Convert.ToDouble(TriC.Text) > 100)
            {
                TriC.Text = "100";
            }
        }

        private void TraA_Leave(object sender, EventArgs e)
        {
            if (Convert.ToDouble(TraA.Text) >= Convert.ToDouble(TraB.Text) || Convert.ToDouble(TraA.Text) < 0)
            {
                TraA.Text = "0";
            }
        }

        private void TraB_Leave(object sender, EventArgs e)
        {
            if (Convert.ToDouble(TraB.Text) <= Convert.ToDouble(TraA.Text) || Convert.ToDouble(TraB.Text) >= Convert.ToDouble(TraC.Text))
            {
                TraB.Text = (Convert.ToDouble(TraA.Text)+1).ToString();
            }
        }

        private void TraC_Leave(object sender, EventArgs e)
        {
            if (Convert.ToDouble(TraC.Text) <= int.Parse(TraB.Text) || int.Parse(TraC.Text) >= int.Parse(TraD.Text))
            {
                TraC.Text = (Convert.ToDouble(TraB.Text) + 1).ToString();
            }
        }

        private void TraD_Leave(object sender, EventArgs e)
        {
            if (Convert.ToDouble(TraD.Text) <= Convert.ToDouble(TraC.Text) || Convert.ToDouble(TraD.Text) > 100)
            {
                TraD.Text = "100";
            }
        }

        private void GaB_Leave(object sender, EventArgs e)
        {
            if (Convert.ToDouble(GaB.Text) <= 0)
            {
                GaB.Text = "1";
            }
        }

        private void BeA_Leave(object sender, EventArgs e)
        {
            if (Convert.ToDouble(BeA.Text) <= 0 )
            {
                BeA.Text = "1";
            }
        }

        private void TriInf_Leave(object sender, EventArgs e)
        {
            TriSup.Minimum = TriInf.Value+1;
        }

        private void TriSup_Leave(object sender, EventArgs e)
        {
            TriInf.Maximum = TriSup.Value - 1;
        }

        private void TraInferior_Leave(object sender, EventArgs e)
        {
            TraSuperior.Minimum = TraInferior.Value + 1;
        }

        private void TraSuperior_Leave(object sender, EventArgs e)
        {
            TraInferior.Maximum = TraSuperior.Value - 1;
        }

        private void GaInferior_Leave(object sender, EventArgs e)
        {
            GaSuperior.Minimum = GaInferior.Value + 1;
        }

        private void GaSuperior_Leave(object sender, EventArgs e)
        {
            GaInferior.Maximum = GaSuperior.Value - 1;
        }

        private void BeInferior_Leave(object sender, EventArgs e)
        {
            BeSuperior.Minimum = BeInferior.Value + 1;
        }

        private void BeSuperior_Leave(object sender, EventArgs e)
        {
            BeInferior.Maximum = BeSuperior.Value - 1;
        }

        private void SigInferior_Leave(object sender, EventArgs e)
        {
            SigSuperior.Minimum = SigInferior.Value + 1;
        }

        private void SigSuperior_Leave(object sender, EventArgs e)
        {
            SigInferior.Maximum = SigSuperior.Value - 1;
        }

        private void Grafico_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.X <= 70 || e.X >= 610 || e.Y <= 25 || e.Y >= 425)
            {
                Lblxy.Visible = false;
            }
            else
            {
                Lblxy.Visible = true;
            }
            try
            {
                Lblxy.Location = new Point(e.X, e.Y);
                double valorx = Grafico.ChartAreas[0].AxisX2.PixelPositionToValue(e.X);
                double valory = Grafico.ChartAreas[0].AxisY2.PixelPositionToValue(e.Y);
                Lblxy.Text = String.Concat(String.Concat(Math.Round(valorx, 0).ToString(), " ; "), (Math.Round(valory, 2)-0.21).ToString());
            }
            catch
            {

            }
        }
    }
}