using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace MiCalculadora
{
    
    public partial class LaCalculadora : Form
    {
        
        public LaCalculadora()
        {
            InitializeComponent();
        }
#region metodos "nativos"
        private void Form1_Load(object sender, EventArgs e)
        {
               
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
#endregion


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Numero numero1 = new Numero();
            this.lblResultado.Text=numero1.DecimalBinario(txtNumero1.Text);
            this.lblResultado.Show();
        }
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Numero numero1 = new Numero();
            this.lblResultado.Text = numero1.BinarioDecimal(txtNumero1.Text);
            this.lblResultado.Show();

        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }
        private void btnOperar_Click(object sender, EventArgs e)
        {
            double retValue= LaCalculadora.Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text);
            this.lblResultado.Text=""+retValue;
            this.lblResultado.Show();
        }
        private void Limpiar()
        {
            this.txtNumero1.ResetText();
            this.txtNumero2.ResetText();
            this.cmbOperador.ResetText();
            this.lblResultado.ResetText();
        }
        private static double Operar(string numero1, string numero2, string operador)
        {
            Calculadora c1 = new Calculadora();
            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);
           return c1.Operar(num1, num2, operador);

           
        }

        private void cmbOperador_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
