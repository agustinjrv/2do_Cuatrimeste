using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_09.Entidades;
using Clase_09;

namespace Clase_09_WindowsForms
{
    public partial class FrmPrincipal : Form
    {
       

        public FrmPrincipal()
        {
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;

            InitializeComponent();
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CatedraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCatedra frmCatedra = new FrmCatedra();
            //frmCatedra.MdiParent = this;
            frmCatedra.Show();
        }
    }
}
