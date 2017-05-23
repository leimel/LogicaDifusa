using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDifusa.Funciones
{
    class Bell
    {

        private int limInferior { get; set; }
        private int limSuperior { get; set; }
        private double a { get; set; }
        private double b { get; set; }
        private double c { get; set; }

        private Bell(int lin, int lsup, double a, double b, double c)
        {
            this.limInferior = lin;
            this.limSuperior = lsup;
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public static Bell CREATE(int lin, int lsup, double a, double b, double c)
        {
            if (lin >= 0 && lsup <= 100 && lin < lsup && a < 0)
            {
                return new Bell(lin, lsup, a, b, c);
            }
            return null;
        }


        public void graficar()
        {
            Form1 form = Form1.getInstance();
            for (int x = limInferior; x <= limSuperior; ++x)
            {
                form.Grafico.Series[0].Points.AddXY(x,1/(1+(Math.Abs((x-c)/a)*2*b)));
                form.dataGridView1.Rows.Add(x, 1 / (1 + (Math.Abs((x - c) / a) * 2 * b)));
            }
        }
    }
}
