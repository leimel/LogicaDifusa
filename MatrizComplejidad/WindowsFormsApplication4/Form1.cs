using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public TextBox[] textos = new TextBox[841];
        public Label[] labels = new Label[59];
        public int nodos = 0;
        public Form1()
        {
            InitializeComponent();

            int y = 0;
            for (int i = 0; i < 29; i++)
            {
                for (int j = 0; j < 29; j++)
                {
                    TextBoxA textBox = new TextBoxA();
                    if (i == 0)
                    {
                        Label label = new System.Windows.Forms.Label();
                        label.Location = new System.Drawing.Point(120 + (j * 42), 40 + (i * 22));
                        label.Size = new System.Drawing.Size(40, 13);
                        label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
                        label.Text = "N" + j.ToString();
                        label.Visible = false;
                        labels[y++] = label;
                        Controls.Add(label);
                    }
                    if (j == 0)
                    {
                        Label label = new System.Windows.Forms.Label();
                        label.Location = new System.Drawing.Point(80 + (j * 42), 62 + (i * 22));
                        label.Size = new System.Drawing.Size(40, 13);
                        label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
                        label.Text = "N" + i.ToString();
                        label.Visible = false;
                        labels[y++] = label;
                        Controls.Add(label);

                    }
                    if (i == j)
                    {
                        textBox.Text = "0";
                        textBox.Enabled = false;
                    }

                    textBox.Location = new System.Drawing.Point(120 + (i * 42), 58 + (j * 22));
                    textBox.Size = new System.Drawing.Size(40, 20);
                    textBox.Leave += new EventHandler(textbox_leave);
                    textBox.KeyPress += new KeyPressEventHandler(nodo_KeyPress);
                    textBox.Visible = false;
                    textBox.posicion = (i * 29) + j;
                    textBox.col = j;
                    textBox.fila = i;
                    textos[(i * 29) + j] = textBox;
                    Controls.Add(textBox);

                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nodos = Convert.ToInt32(Nnodos.Text);
            int y = 29;
            labels[0].Visible = true;
            for (int i = 0; i < 29; i++)
            {
                if (i < Convert.ToInt32(Nnodos.Text))
                {
                    labels[y++].Visible = true;
                }
                else
                {
                    labels[y++].Visible = false;
                }

                for (int j = 0; j < 29; j++)
                {
                    if (j < Convert.ToInt32(Nnodos.Text))
                    {
                        labels[j + 1].Visible = true;
                    }
                    else
                    {
                        labels[j + 1].Visible = false;
                    }
                    if (i < Convert.ToInt32(Nnodos.Text) && j < Convert.ToInt32(Nnodos.Text))
                    {
                        textos[(i * 29) + j].Visible = true;
                    }
                    else
                    {
                        textos[(i * 29) + j].Visible = false;
                    }
                }
            }
        }

        private void textbox_leave(object sender, System.EventArgs e)
        {
            TextBoxA text = sender as TextBoxA;
            if (String.IsNullOrWhiteSpace(text.Text))
            {

            }
            else if ((Convert.ToInt32(text.Text) <= -2) || text.Text.Equals("0"))
            {
                MessageBox.Show("No se permiten distancias nulas o negativas");
                text.Text = "1";
            }
            foreach (TextBoxA reflejo in textos)
            {
                if (reflejo.fila == text.col && reflejo.col == text.fila)
                {
                    reflejo.Text = text.Text;
                }
            }
        }

        private void nodo_KeyPress(object sender, KeyPressEventArgs e)
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


        private void Nnodos_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Nnodos.Text) > 28 || Convert.ToInt32(Nnodos.Text) < 1)
            {
                MessageBox.Show("El número debe estar entre 1 - 28");
                Nnodos.Text = "";
            }

        }
        private void Nnodos_KeyPress(object sender, KeyPressEventArgs e)
        {
            descartarletra(e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[,] matriz = new int[nodos, nodos];
            foreach (TextBoxA ady in textos)
            {
                if (ady.col < nodos && ady.fila < nodos)
                {
                    if (String.IsNullOrWhiteSpace(ady.Text))
                    {
                        ady.Text = "-1";
                    }
                    matriz[ady.col, ady.fila] = Convert.ToInt32(ady.Text);
                }
            }
            Algoritmo_Busqueda prueba = new Algoritmo_Busqueda(3, matriz);
            prueba.CorrerDijkstra();
            Console.WriteLine("La solucion de la ruta mas corta tomando como nodo inicial el NODO 1 es: ");
            int nodo = 1;
            foreach (int i in prueba.D)
            {
                Console.Write("Distancia minima a nodo " + nodo + " es "); Console.WriteLine(i);
                nodo++;
            }
            Console.WriteLine();
            Console.WriteLine("Presione la tecla Enter para salir."); Console.Read();

        }
    }
}

