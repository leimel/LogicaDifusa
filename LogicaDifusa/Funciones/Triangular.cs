using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDifusa.Funciones
{
    class Triangular
    {
        private int limSuperior { get; set; }
        private double a { get; set; }
        private double b { get; set; }
        private double c { get; set; }

        public Triangular()
        {
            
        }

        public void asignar(int limite,double a,double b,double c)
        {
            this.limSuperior = limite;
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public int graficar(int limInferior )
        {
            Form1 form = Form1.getInstance();
            for (int x = limInferior; x <= limSuperior; ++x)
            {
                if (x <= a || x > c)
                {
                    form.Grafico.Series[0].Points.AddXY(x, 0);
                    form.dataGridView1.Rows.Add(x, 0);
                }
                else if (x > a && x <= b)
                {
                    form.Grafico.Series[0].Points.AddXY(x, (x - a) / (b - a));
                    form.dataGridView1.Rows.Add(x, (x - a) / (b - a));
                }
                else if (x > b && x <= c)
                {
                    form.Grafico.Series[0].Points.AddXY(x, (c - x) / (c - b));
                    form.dataGridView1.Rows.Add(x, (c - x) / (c - b));
                }
            }
            return limSuperior;
        }
    }
}