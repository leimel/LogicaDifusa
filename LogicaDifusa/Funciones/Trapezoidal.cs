using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDifusa.Funciones
{
    class Trapezoidal
    {
        private int limSuperior { get; set; }
        private double a { get; set; }
        private double b { get; set; }
        private double d { get; set; }
        private double c { get; set; }

        public Trapezoidal()
        {
            
        }

        public void asignar(int limite, double a, double b, double c,double d)
        {
            this.limSuperior = limite;
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public int graficar(int limInferior)
        {
            Form1 form = Form1.getInstance();
            for (int x = limInferior; x <= limSuperior; ++x)
            {
                if (x <= a || x > d)
                {
                    form.Grafico.Series[1].Points.AddXY(x, 0);
                    form.dataGridView1.Rows.Add(x, 0);
                }
                else if (x > b && x <= c)
                {
                    form.Grafico.Series[1].Points.AddXY(x, 1);
                    form.dataGridView1.Rows.Add(x, 1);
                }
                else if (x > a && x <= b)
                {
                    form.Grafico.Series[1].Points.AddXY(x, (x - a) / (b - a));
                    form.dataGridView1.Rows.Add(x, (x - a) / (b - a));
                }
                else if (x > c && x <= d)
                {
                    form.Grafico.Series[1].Points.AddXY(x, (d - x) / (d - c));
                    form.dataGridView1.Rows.Add(x, (d - x) / (d - c));
                }
                
            }
            return limSuperior;
        }
    }
}

