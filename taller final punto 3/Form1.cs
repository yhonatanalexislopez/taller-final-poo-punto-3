using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace taller_final_punto_3
{
    public partial class Form1 : Form
    {
        Suma suma = new Suma();
        Restar restar = new Restar();
        Multiplicar multiplicar = new Multiplicar();
        Divicion divicion = new Divicion();


        public Form1()
        {
            InitializeComponent();
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            suma.setnumero1(double.Parse(txtnumerouno.Text));
            suma.setnumero2(double.Parse(txtnumerodos.Text));

            lblresultado.Text = Convert.ToString(suma.suma());
        }

        private void btnrestar_Click(object sender, EventArgs e)
        {
            restar.setnumero1(double.Parse(txtnumerouno.Text));
            restar.setnumero2(double.Parse(txtnumerodos.Text));

            lblresultado.Text = Convert.ToString(restar.restar());

        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            multiplicar.setnumero1(double.Parse(txtnumerouno.Text));
            multiplicar.setnumero2(double.Parse(txtnumerodos.Text));

            lblresultado.Text = Convert.ToString(multiplicar.multiplicar());
        }

        private void btndividir_Click(object sender, EventArgs e)
        {
            divicion.setnumero1(double.Parse(txtnumerouno.Text));
            divicion.setnumero2(double.Parse(txtnumerodos.Text));

            lblresultado.Text = Convert.ToString(divicion.divicion());
        }

       
    }
}
