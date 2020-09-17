using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace taller_final_punto_3
{
    public class Restar:Calcular
    {
        public double restar() 
        {
            return (this.getnumero1() - this.getnumero2());
        
        }
    }
}
