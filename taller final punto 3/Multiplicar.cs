using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace taller_final_punto_3
{
    public class Multiplicar:Calcular
    {
        public double multiplicar() 
        {
            return (this.getnumero1() * this.getnumero2());
        }
    }
}
