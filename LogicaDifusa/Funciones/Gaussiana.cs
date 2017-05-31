using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDifusa.Funciones
{
    class Gaussiana
    {
        
        private int limSuperior { get; set; }
        private double a { get; set; }
        private double b { get; set; }

        public Gaussiana()
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
                form.Grafico.Series[2].Points.AddXY(x, Math.Exp(-0.5*Math.Pow(((x-a)/b),2)));
                form.dataGridView1.Rows.Add(x, Math.Exp(-0.5 * Math.Pow(((x - a) / b), 2)));
            }
            return limSuperior;
        }
    }
}

