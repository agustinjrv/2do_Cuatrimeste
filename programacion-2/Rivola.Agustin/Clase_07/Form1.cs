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
    public partial class Form1 : Form
    {
        Paleta miPaleta;
        

        public Form1()
        {
            InitializeComponent();

            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
            this.CrearPaleta.Visible = true;
        }

        private void administracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.miPaleta = 5;
        }

        private void temperaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTemperas frm = new frmTemperas();


            frm.StartPosition = FormStartPosition.CenterScreen;

            // frm.MdiParent = this;
          
            frm.ShowDialog();
            if(frm.DialogResult == DialogResult.OK)
            {
                this.miPaleta += frm.MiTempera;
                this.listBox1.Items.Add((string)this.miPaleta);
                
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }

        private void CrearPaleta_Click(object sender, EventArgs e)
        {
            this.CrearPaleta.Enabled = true;
            this.CrearPaleta.Visible = true;
        }
    }
}
