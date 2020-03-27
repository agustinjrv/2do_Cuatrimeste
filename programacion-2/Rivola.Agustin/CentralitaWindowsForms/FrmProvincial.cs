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
    public partial class FrmProvincial : FrmLlamada
    {

        Provincial nuevaLlamadaProvincial;

        public FrmProvincial()
        {
            InitializeComponent();

            foreach (Franja f in Enum.GetValues(typeof(Franja)))
            {
                comboBox_franja.Items.Add(f);
            }
            comboBox_franja.SelectedItem = Franja.Franja_1;
            comboBox_franja.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public Provincial Provincial
        {
            get { return this.nuevaLlamadaProvincial; }
        }

        protected override void Btn_aceptar_Click(object sender, EventArgs e)
        {
            string origen = textBox_NumeroOrigen.Text;
            string destino = textBox_numeroDestino.Text;
            float duracion = float.Parse(textBox_Duracion.Text);
            Franja franja = (Franja)comboBox_franja.SelectedItem;

            this.nuevaLlamadaProvincial = new Provincial(origen, franja, duracion, destino);

            base.Btn_aceptar_Click(sender, e);
        }
        
   
    }
}
