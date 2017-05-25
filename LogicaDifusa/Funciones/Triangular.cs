using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDifusa.Funciones
{
    class Triangular
    {
        private int limInferior { get; set; }
        private int limSuperior { get; set; }
        private double a { get; set; }
        private double b { get; set; }
        private double c { get; set; }

        private Triangular(int lin,int lsup,double a,double b,double c)
        {
            this.limInferior = lin;
            this.limSuperior = lsup;
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public static Triangular CREATE(int lin, int lsup, double a, double b, double c)
        {
            if (lin >= 0 && lsup <= 100 && lin < lsup && a<b && b<c)
            {
                return new Triangular(lin, lsup, a, b, c);
            }
            return null;
        }

       
        public void graficar()
        {
            Form1 form = Form1.getInstance();
            form.Grafico.Series[0].Color= System.Drawing.Color.Red ;
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
        }
    }
}