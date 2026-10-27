using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryAbrhamRepaso
{
    public partial class Calculo : Form
    {
        public Calculo()
        {
            InitializeComponent();
        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string monto;
            monto = txtMonto.Text;

            string interes;
            interes = cmbIVA.Text;

            decimal Monto = Convert.ToDecimal(txtMonto.Text);
            decimal Interes = Convert.ToDecimal(cmbIVA.Text);
            decimal total = Monto * Interes;

            float resultado;
            resultado = (float)(Monto * Interes) / 100;
            lblResultado.Text = "Resultado: " + resultado.ToString();
        }
    }
}
