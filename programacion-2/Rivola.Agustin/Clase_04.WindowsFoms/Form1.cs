using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases_4.Entidades;

namespace Clase_04.WindowsFoms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = this.textString.Text;

            int number =  int.Parse(this.textEntero.Text);

            DateTime Fecha = Convert.ToDateTime(this.textFecha.Text);

            Cosa a = new Cosa(texto,Fecha,number);

            MessageBox.Show(a.Mostrar());

            listBox1.Items.Add(a.Mostrar());





        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            this.BackColor = System.Drawing.Color.Red;


        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Black;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Blue;
        }
    }
}
