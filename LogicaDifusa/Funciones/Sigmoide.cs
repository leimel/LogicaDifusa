using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDifusa.Funciones
{
    class Sigmoide
    {
    
        private int limSuperior { get; set; }
        private double a { get; set; }
        private double b { get; set; }

        public Sigmoide()
        {
           
        }
        public void asignar(int limite, double a, double b)
        {
            this.limSuperior = limite;
            this.a = a;
            this.b = b;
        }

        public int graficar(int limInferior)
        {
            Form1 form = Form1.getInstance();
            for (int x = limInferior; x <= limSuperior; ++x)
            {
                form.Grafico.Series[4].Points.AddXY(x, 1/(1+(Math.Exp(-a*(x-b)))));
                form.dataGridView1.Rows.Add(x, 1 / (1 + (Math.Exp(-a * (x - b)))));
            }
            return limSuperior;
        }
    }
}

