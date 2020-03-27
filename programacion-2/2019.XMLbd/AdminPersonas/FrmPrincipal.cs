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
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using System.Data.SqlClient;



namespace AdminPersonas
{
    public partial class FrmPrincipal : Form
    {
        private List<Persona> lista;
        private DataTable tablaPersonas;
        private SqlDataAdapter dataAdapter;
        private SqlConnection sqlConexion;

        public FrmPrincipal()
        {
            InitializeComponent();

            this.sqlConexion = new SqlConnection(Properties.Settings.Default.Conexion);
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
            this.lista = new List<Persona>();
            this.tablaPersonas=new DataTable();
            this.dataAdapter = new SqlDataAdapter("SELECT * FROM Personas", this.sqlConexion);
            this.dataAdapter.Fill(tablaPersonas);
            this.dataAdapter.InsertCommand = new SqlCommand("insert into Persona(nombre,apellido,edad) values (@p1,@p2@p3)",sqlConexion);
            this.dataAdapter.UpdateCommand = new SqlCommand("update Personas set nombre=@p1,apellido=@p2,edad=@p3 where id=@p4", sqlConexion);
            this.dataAdapter.DeleteCommand = new SqlCommand("delete form Personas where id=@p4", sqlConexion);

            dataAdapter.InsertCommand.Parameters.Add("@p1", SqlDbType.VarChar, 50, "nombre");
            dataAdapter.InsertCommand.Parameters.Add("@p2", SqlDbType.VarChar, 50, "apellido");
            dataAdapter.InsertCommand.Parameters.Add("@p3", SqlDbType.Int, 2, "edad");
            //dataAdapter.InsertCommand.Parameters.Add("@p4", SqlDbType.Int,2, "id");

            dataAdapter.UpdateCommand.Parameters.Add("@p1", SqlDbType.VarChar, 50, "nombre");
            dataAdapter.UpdateCommand.Parameters.Add("@p2", SqlDbType.VarChar, 50, "apellido");
            dataAdapter.UpdateCommand.Parameters.Add("@p3", SqlDbType.Int, 2, "edad");
            dataAdapter.UpdateCommand.Parameters.Add("@p4", SqlDbType.Int, 2, "id");

            //dataAdapter.DeleteCommand.Parameters.Add("@p1", SqlDbType.VarChar, 50, "nombre");
            //dataAdapter.DeleteCommand.Parameters.Add("@p2", SqlDbType.VarChar, 50, "apellido");
            //dataAdapter.DeleteCommand.Parameters.Add("@p3", SqlDbType.Int, 2, "edad");
            dataAdapter.DeleteCommand.Parameters.Add("@p4", SqlDbType.Int, 2, "id");





        }

        private void cargarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();

            o.ShowDialog();
            XmlSerializer xmls = new XmlSerializer(typeof(List<Persona>));
            TextReader archivo = new StreamReader(o.FileName);
            this.lista=(List<Persona>)xmls.Deserialize(archivo);

            archivo.Close();
        }

        private void guardarEnArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                SaveFileDialog s = new SaveFileDialog();
                s.FileName = "listaDePersonasWinForm.xml";
                s.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                s.ShowDialog();
                XmlSerializer xmls = new XmlSerializer(typeof(List<Persona>));
                TextWriter archivo = new StreamWriter(s.FileName);
                xmls.Serialize(archivo, lista);
                
                archivo.Close();
            }
            catch (Exception eh)
            {
                MessageBox.Show(eh.Message);
            }
        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisorPersona frm = new frmVisorPersona(lista);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            lista = frm.ListaPersona;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataAdapter.Update(tablaPersonas);
            this.Close();
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConexion = new SqlConnection(Properties.Settings.Default.Conexion);
                sqlConexion.Open();
                MessageBox.Show("Exito");
                sqlConexion.Close();
            }
            catch(Exception eh)
            {
                MessageBox.Show(eh.ToString());
            }
                
               
        }

        private void traerTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sql = new SqlConnection();
                sql.ConnectionString = Properties.Settings.Default.Conexion;
                sql.Open();
                SqlCommand s = new SqlCommand();
                s.Connection = sql;
                s.CommandType = CommandType.Text;
                s.CommandText = "Select * FROM Personas";
                SqlDataReader sqlRead = s.ExecuteReader();


                while (sqlRead.Read() != false)
                {
                    object id = sqlRead[0];
                    object nombre = sqlRead[1];
                    object apellido = sqlRead[2];
                    object edad = sqlRead[3];

                    Persona nuevaPersona = new Persona(nombre.ToString(), apellido.ToString(), int.Parse(edad.ToString()));
                    lista.Add(nuevaPersona);
                }
                sqlRead.Close();
                s.Connection.Close();
                sql.Close();
            }
            catch (Exception eh)
            {
                MessageBox.Show(eh.ToString());
            }
        }

        private void SincronizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataAdapter.Update(tablaPersonas);
        }
    }
}
