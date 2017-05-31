using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDifusa.Funciones
{
    class Bell
    {
        private int limSuperior { get; set; }
        private double a { get; set; }
        private double b { get; set; }
        private double c { get; set; }

        public Bell()
        {
           
        }
        public void asignar(int limite, double a, double b, double c)
        {
            this.limSuperior = limite;
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public int graficar(int limInferior)
        {
            Form1 form = Form1.getInstance();
            for (int x = limInferior; x <= limSuperior; ++x)
            {
                form.Grafico.Series[3].Points.AddXY(x,1/(1+(Math.Abs((x-c)/a)*2*b)));
                form.dataGridView1.Rows.Add(x, 1 / (1 + (Math.Abs((x - c) / a) * 2 * b)));
            }
            return limSuperior;
        }
    }
}
