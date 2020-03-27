using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_06.Entidades;

namespace Clase_07
{
    public partial class frmTemperas : Form
    {
        private Tempera t;
        public Tempera MiTempera
        {
            get
            {
                return this.t;
            }
           
        }


       

        public frmTemperas()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            foreach (ConsoleColor c in Enum.GetValues(typeof(ConsoleColor)))
            {
                this.comboBox1.Items.Add(c);

            }
            this.comboBox1.SelectedItem = ConsoleColor.Magenta;
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Color_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

           




        }

        private void button1_Click(object sender, EventArgs e)
        {
            string marca = this.textMarca.Text;
            string cantidad = this.textCantidad.Text;
            ConsoleColor color=(ConsoleColor)this.comboBox1.SelectedItem;
            t = new Tempera(color,marca,int.Parse(cantidad));

            MessageBox.Show(t);
            this.DialogResult = DialogResult.OK;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmTemperas_Load(object sender, EventArgs e)
        {

        }
    }
}
