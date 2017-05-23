using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDifusa.Funciones
{
    class Gaussiana
    {

        private int limInferior { get; set; }
        private int limSuperior { get; set; }
        private double a { get; set; }
        private double b { get; set; }


        private Gaussiana(int lin, int lsup, double a, double b)
        {
            this.limInferior = lin;
            this.limSuperior = lsup;
            this.a = a;
            this.b = b;
  
        }
        public static Gaussiana CREATE(int lin, int lsup, double a, double b)
        {
            if (lin >= 0 && lsup <= 100 && lin < lsup && b>0)
            {
                return new Gaussiana(lin, lsup, a, b);
            }
            return null;
        }


        public void graficar()
        {
            Form1 form = Form1.getInstance();
            for (int x = limInferior; x <= limSuperior; ++x)
            {
                form.Grafico.Series[0].Points.AddXY(x, Math.Exp(-0.5*Math.Pow(((x-a)/b),2)));
                form.dataGridView1.Rows.Add(x, Math.Exp(-0.5 * Math.Pow(((x - a) / b), 2)));
            }
        }
    }
}

