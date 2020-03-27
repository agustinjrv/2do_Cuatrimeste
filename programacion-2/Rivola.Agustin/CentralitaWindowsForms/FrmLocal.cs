using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaPolimorfismo;

namespace CentralitaWindowsForms
{
    public partial class FrmLocal : FrmLlamada
    {

        private Local nuevaLlamadaLocal;

        public FrmLocal()
        {
            InitializeComponent();
        }

        public Local Local
        {
            get { return this.nuevaLlamadaLocal; }
        }

        protected override void Btn_aceptar_Click(object sender, EventArgs e)
        {
            string origen = textBox_NumeroOrigen.Text;
            string destino = textBox_numeroDestino.Text;
            float duracion = float.Parse(textBox_Duracion.Text);

            float costo = float.Parse(textBox_Costo.Text);
            this.nuevaLlamadaLocal = new Local(origen, duracion, destino, costo);

            base.Btn_aceptar_Click(sender, e);
        }

        
    }
}
