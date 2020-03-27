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
    public partial class FrmAlumnoCalificado : FrmAlumno
    {
        private AlumnoCalificado a;


        public AlumnoCalificado AlumnoCalificado
        {
            get { return this.a; }
        }





        public FrmAlumnoCalificado()
        {
            InitializeComponent();
        }

        public FrmAlumnoCalificado(Alumno a):this()
        {
            this.textBox_apellido.Enabled = false;
            this.textBox_legajo.Enabled = false;
            this.textBox_nombre.Enabled = false;
            this.comboBox_TipoExamen.Enabled = false;

            this.textBox_nombre.Text = a.Nombre;
            this.textBox_apellido.Text = a.Apellido;
            this.textBox_legajo.Text = a.Legajo.ToString();

        }

        protected override void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            string nombre = textBox_nombre.Text;
            string apellido = textBox_apellido.Text;
            int legajo = int.Parse(textBox_legajo.Text);
            ETipoExamen examen = (ETipoExamen)comboBox_TipoExamen.SelectedIndex;
            double nota =double.Parse(textBox_Nota.Text);

            a = new AlumnoCalificado(nombre, apellido, legajo, examen,nota);
            MessageBox.Show(Alumno.Mostrar(a));
            this.DialogResult = DialogResult.OK;



        }

        private void Btn_Aceptar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
