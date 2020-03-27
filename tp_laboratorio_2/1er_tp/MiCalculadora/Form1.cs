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
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();


            this.cmbOperador.SelectedItem = "+";
            this.cmbOperador.DropDownStyle = ComboBoxStyle.DropDownList;

            
            
        }

      


        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            cmbOperador.Text = "+";
            lblResultado.Text = "";
        }

        private void BtnConvertirADecimal_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Numero.BinarioDecimal(lblResultado.Text);
        }

        private void BtnOperar_Click(object sender, EventArgs e)
        {
            Numero num1 = new Numero(this.txtNumero1.Text);
            Numero num2 = new Numero(this.txtNumero2.Text);

            double resultado= Calculadora.Operar(num1, num2, this.cmbOperador.SelectedItem.ToString());

            lblResultado.Text = resultado.ToString();


        }

        private void BtnConvertirABinario_Click(object sender, EventArgs e)
        {
            

            lblResultado.Text = Numero.DecimalBinario(lblResultado.Text); ;



        }
    }
}
