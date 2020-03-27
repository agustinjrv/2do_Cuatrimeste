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

namespace MainCorreo
{
    public partial class FrmPpal : Form
    {
        Correo correo;
        /// <summary>
        /// constructor
        /// </summary>
        public FrmPpal()
        {
            InitializeComponent();
            this.correo = new Correo();
            this.FormClosing += new FormClosingEventHandler(FrmPpal_FormClosing);
        }
        /// <summary>
        /// ingresa paquetes al sistema al cargar los datos 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string trackingID = mtxtTrackingID.Text;
            string direccionEntrega = txtDireccion.Text;

            try
            {
                Paquete p = new Paquete(direccionEntrega, trackingID);
                p.InformarEstado += new Paquete.DelegadoEstado(this.paq_InformaEstado);
                this.correo += p;
                this.ActualizarEstados();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// muestra todos los datos de los pquetes almacenados en correo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostarTodos_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<List<Paquete>>((IMostrar<List<Paquete>>)correo);
        }
        /// <summary>
        /// metodo para el evento paq_InformaEstado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void paq_InformaEstado(object sender, EventArgs e)
        {
            try
            {
                if (this.InvokeRequired)
                {
                    Paquete.DelegadoEstado d = new Paquete.DelegadoEstado(paq_InformaEstado);
                    this.Invoke(d, new object[] { sender, e });
                }
                else
                {
                    this.ActualizarEstados();
                }
                if (sender is Exception)
                {
                    MessageBox.Show(((Exception)sender).Message);
                }
            }
            catch(Exception)
            {

            }
        }
        /// <summary>
        /// actualiza las listas
        /// </summary>
        private void ActualizarEstados()
        {
            lstEstadoEntregado.Items.Clear();
            lstEstadoEnViaje.Items.Clear();
            lstEstadoIngresado.Items.Clear();

            foreach (Paquete p in this.correo.Paquetes)
            {
                switch (p.Estado)
                {
                    case Paquete.EEstado.Ingresado:

                        lstEstadoIngresado.Items.Add(p);

                        break;
                    case Paquete.EEstado.EnViaje:

                        lstEstadoEnViaje.Items.Add(p);
                        break;
                    case Paquete.EEstado.Entregado:

                        lstEstadoEntregado.Items.Add(p);
                        break;
                }
            }

        }
        /// <summary>
        /// cierra los hilos abiertos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.correo.FinEntregas();
        }
        /// <summary>
        /// guarda un archivo de texto en el escritorio con los datos de los paquetes que esttan en correo
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="elemento"></param>
        private void MostrarInformacion<T>(IMostrar<T> elemento)
        {
            if (!object.Equals(elemento, null))
            {
                string str = elemento.MostrarDatos(elemento);
                rtbMostrar.Text = str;
                
                str.Guardar("Salida");
                
                
            }
        }
        /// <summary>
        /// muestra el paquete selecionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<Paquete>((IMostrar<Paquete>)lstEstadoEntregado.SelectedItem);
        }
    }
}
