using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using Entidades;
using System.Data.SqlClient;


namespace AdminPersonas
{
    public partial class frmVisorPersona : Form
    {
        SqlConnection sql;
        private List<Persona> listaPersonas;

        public frmVisorPersona()
        {
            InitializeComponent();
            this.sql  = new SqlConnection(Properties.Settings.Default.Conexion);
            this.listaPersonas = new List<Persona>();
        }

        public frmVisorPersona(List<Persona>listaPersonas):this()
        {
           
            this.listaPersonas = listaPersonas;
            this.ActualizarLista();
        }

        public List<Persona> ListaPersona
        {
            get {return this.listaPersonas; }
        }

        protected virtual void btnAgregar_Click(object sender, EventArgs e)
        {
            frmPersona frm = new frmPersona();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            if(frm.DialogResult==DialogResult.OK)
            {
                listaPersonas.Add(frm.Persona);
               // lstVisor.Items.Add(frm.Persona);
                SqlConnection sql = new SqlConnection(Properties.Settings.Default.Conexion);
                sql.Open();

                SqlCommand com = new SqlCommand();
                com.Connection = sql;
                com.CommandType = CommandType.Text;
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("Insert into Personas(nombre,apellido,edad) values('{0}','{1}','{2}')", frm.Persona.nombre, frm.Persona.apellido, frm.Persona.edad);
                com.CommandText = sb.ToString();
                com.ExecuteNonQuery();

                sql.Close();
            }
                this.ActualizarLista();
        }

        protected virtual void btnModificar_Click(object sender, EventArgs e)
        { 
            
            frmPersona frm = new frmPersona((Persona)lstVisor.SelectedItem);
            frm.StartPosition = FormStartPosition.CenterScreen;
            this.sql.Open();
            frm.ShowDialog();
            
            if(frm.DialogResult==DialogResult.OK)
            {
                this.lstVisor.SelectedItem = frm.Persona;

                try
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendFormat("update Personas set nombre='{0}',apellido='{1}',edad={2} where id={3}", frm.Persona.nombre, frm.Persona.apellido, frm.Persona.edad, this.lstVisor.SelectedIndex + 1);
                    SqlCommand com = new SqlCommand();
                    com.Connection = this.sql;
                    com.CommandType = CommandType.Text;
                    com.CommandText = sb.ToString();
                    com.ExecuteNonQuery();
                }
                catch(Exception x)
                {
                    MessageBox.Show(x.ToString());
                }


            }

                this.sql.Close();
                this.ActualizarLista();
        }

        protected virtual void btnEliminar_Click(object sender, EventArgs e)
        {
            this.listaPersonas.Remove((Persona)lstVisor.SelectedItem);
            this.sql.Open();
            
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("delete from Personas where id={0}", this.lstVisor.SelectedIndex + 1);
                SqlCommand com = new SqlCommand();
                com.Connection = this.sql;
                com.CommandType = CommandType.Text;
                com.CommandText = sb.ToString();
                com.ExecuteNonQuery();

           
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            this.ActualizarLista();
            this.sql.Close();


            //implementar
        }


        protected virtual void ActualizarLista()
        {
            this.lstVisor.Items.Clear();

            foreach (Persona p in this.listaPersonas)
            {
                this.lstVisor.Items.Add(p);
            }
        }

        protected virtual void LstVisor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Quita el modificador si existe
            this.btnModificar.Click -= new EventHandler(btnModificar_Click);
            this.btnEliminar.Click -= new EventHandler(btnEliminar_Click);

            //los agrega
            this.btnModificar.Click += new EventHandler(btnModificar_Click);
            this.btnEliminar.Click += new EventHandler(btnEliminar_Click);
        }

        private void FrmVisorPersona_Load(object sender, EventArgs e)
        {
            this.btnAgregar.Click += new EventHandler(btnAgregar_Click);
        }
    }
}
