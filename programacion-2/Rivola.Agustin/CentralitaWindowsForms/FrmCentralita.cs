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
    public partial class FrmCentralita : Form
    {
        Centralita telefonica = new Centralita("Telefonica");
        public enum TipoOrdenamiento {DuracionAsendente,DuracionDesendente,TipoLlamadaAsendente,TipoLlamadaDesendente};
        
        public FrmCentralita()
        {
            InitializeComponent();

            foreach(TipoOrdenamiento t in Enum.GetValues(typeof(TipoOrdenamiento)))
            {
                comboBox_ordenamiento.Items.Add(t);
            }

            comboBox_ordenamiento.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Btn_llamadaLocal_Click(object sender, EventArgs e)
        {
            FrmLocal frmLocal = new FrmLocal();

            frmLocal.ShowDialog();

            if(frmLocal.DialogResult==DialogResult.OK)
            {
                this.telefonica += frmLocal.Local;
                int tam=this.telefonica.Llamadas.Count;
                lst_llamada.Items.Clear();

                for (int i=0;i<tam;i++)
                {
                    lst_llamada.Items.Add(this.telefonica.Llamadas[i].ToString());
                }
            }
        }

        private void Btn_llamadaProvincial_Click(object sender, EventArgs e)
        {
            FrmProvincial frmProvincial = new FrmProvincial();

            frmProvincial.ShowDialog();

            if (frmProvincial.DialogResult == DialogResult.OK)
            {
                this.telefonica += frmProvincial.Provincial;
                int tam = this.telefonica.Llamadas.Count;
                lst_llamada.Items.Clear();

                for (int i = 0; i < tam; i++)
                {
                    lst_llamada.Items.Add(this.telefonica.Llamadas[i].ToString());
                }
            }
        }

        private void comboBox_ordenamiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tipo = comboBox_ordenamiento.SelectedIndex;
            /*
            switch (tipo)
            {
                case 1:
                    this.telefonica.Llamadas.Sort(Llamada.OrdenarPorDuracion);
                    break;
                case 2:
                    this.telefonica.Llamadas.Sort(Llamada.OrdenarPorDuracion);
                    break;
            }
            */


        }
    }
}
