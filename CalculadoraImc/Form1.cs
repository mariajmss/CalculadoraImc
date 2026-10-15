using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraImc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntCalcula_Click(object sender, EventArgs e)
        {
            //Criando as variaveis
            decimal Peso = Convert.ToDecimal(nudPeso.Text);
            decimal Altura = Convert.ToDecimal(nudAltura.Text);
            decimal imc;
            imc = Peso / (Altura * Altura);
            txtIMC.Text = imc.ToString("0.00");

        }
    }
}
