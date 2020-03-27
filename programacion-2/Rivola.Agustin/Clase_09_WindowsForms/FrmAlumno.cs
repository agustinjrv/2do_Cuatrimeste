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


namespace Clase_09_WindowsForms
{
    public partial class FrmAlumno : Form
    {
        private Alumno a;


        public Alumno Alumno
        {
            get { return this.a; }
        }
       
       


        public FrmAlumno()
        {

            InitializeComponent();
            comboBox_TipoExamen.DropDownStyle = ComboBoxStyle.DropDownList;

            foreach (ETipoExamen e in Enum.GetValues(typeof(ETipoExamen)))
            {
                this.comboBox_TipoExamen.Items.Add(e);
            }
            comboBox_TipoExamen.SelectedIndex = 2;


        }

        public FrmAlumno(Alumno alumno):this()
        {
            this.textBox_apellido.Text = alumno.Apellido;
            this.textBox_nombre.Text = alumno.Nombre;
            this.textBox_legajo.Text = alumno.Legajo.ToString();
            this.textBox_legajo.Enabled=false;
        }

        protected virtual void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            string nombre= textBox_nombre.Text;
            string apellido= textBox_apellido.Text;
            int legajo= int.Parse(textBox_legajo.Text);
            ETipoExamen examen= (ETipoExamen)comboBox_TipoExamen.SelectedIndex;

            a = new Alumno(nombre,apellido,legajo,examen);
            MessageBox.Show(Alumno.Mostrar(a));
            this.DialogResult = DialogResult.OK;



        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
