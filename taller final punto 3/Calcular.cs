using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace taller_final_punto_3
{
    public class Calcular
    {
        public double numero1;
        public double numero2;

        public void setnumero1(double valor) 
        {
            this.numero1 = valor;
        
        }
        public void setnumero2(double valor)
        {
            this.numero2 = valor;

        }
        public double getnumero1() 
        {
            return this.numero1;
        
        }
        public double getnumero2()
        {
            return this.numero2;

        }
    }
}
