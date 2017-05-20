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
        private int a { get; set; }
        private int b { get; set; }
        private int c { get; set; }
        private KeyValuePair<int, int> xy;

        public Triangular() { }
       
        public bool validar()
        {
            if (limInferior < 0 || limSuperior > 100 || limSuperior <= limInferior) return false;
            return true;
        }
        public void graficar (int a, int b, int c)
        {
            for(int i=limInferior; i<limSuperior; ++i)
            {

            }
        }

    }
}
