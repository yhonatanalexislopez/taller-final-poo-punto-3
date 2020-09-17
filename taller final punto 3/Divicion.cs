using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace taller_final_punto_3
{
    public class Divicion:Calcular
    {
        public double divicion() 
        {
            return (this.getnumero1() / this.getnumero2());
        }
    }
}
