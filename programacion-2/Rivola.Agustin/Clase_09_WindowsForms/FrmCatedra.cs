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
    public partial class FrmCatedra : Form
    {

        Catedra miCatedra=new Catedra();
        List<AlumnoCalificado> listaAlumnosCalificados = new List<AlumnoCalificado>() ;
        
        public FrmCatedra()
        {
            InitializeComponent();

            foreach (ETipoOrdenamiento e in Enum.GetValues(typeof(ETipoOrdenamiento)))
            {
                comboBox_deOrdenamiento.Items.Add(e);
            }
            comboBox_deOrdenamiento.SelectedIndex = 0;
            comboBox_deOrdenamiento.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            FrmAlumno frmAlumno = new FrmAlumno();
            
            frmAlumno.ShowDialog();
            bool a =miCatedra + frmAlumno.Alumno;

            if (frmAlumno.DialogResult == DialogResult.OK)
            {
                this.ActualizarListadoAlumnos();

            }
        }

        private void ComboBox_deOrdenamiento_SelectedIndexChanged(object sender, EventArgs e)
        {

            int orden = this.comboBox_deOrdenamiento.SelectedIndex;

            

            switch(orden)
            {
                case 0:
                    miCatedra.Alumnos.Sort(Alumno.OrdenarPorLegajoAsc);

                    break;
                case 1:
                    miCatedra.Alumnos.Sort(Alumno.OrdenarPorLegajoDesc);
                    break;
                case 2:
                    miCatedra.Alumnos.Sort(Alumno.OrdenarPorApellidoAsc);
                   
                    break;
                case 3:
                    miCatedra.Alumnos.Sort(Alumno.OrdenarPorApellidoDesc);
                    break;

            }

            this.ActualizarListadoAlumnos();

          
        }


       private void ActualizarListadoAlumnos()
       {
            this.listBox_alumnos.Items.Clear();
            for (int i = 0; i < miCatedra.Alumnos.Count; i++)
            {
                this.listBox_alumnos.Items.Add(miCatedra.Alumnos[i].ToString());
            }

            ActualizarListadoAlumnosCalificados();
            
       }

        private void ActualizarListadoAlumnosCalificados()
        {
            this.listBox_alumnosCalificados.Items.Clear();
            for (int i = 0; i < listaAlumnosCalificados.Count; i++)
            {
                this.listBox_alumnosCalificados.Items.Add(listaAlumnosCalificados[i].Mostrar());
            }
        }

        private void btn_calificar_Click(object sender, EventArgs e)
        {
            int index = listBox_alumnos.SelectedIndex;

            if(index>=0)
            {
                FrmAlumnoCalificado frmAlumnoCalificado = new FrmAlumnoCalificado(miCatedra.Alumnos[index]);

                frmAlumnoCalificado.ShowDialog();

                if (frmAlumnoCalificado.DialogResult == DialogResult.OK)
                {
                    miCatedra.Alumnos.RemoveAt(index);
                    listaAlumnosCalificados.Add(frmAlumnoCalificado.AlumnoCalificado);

                    ActualizarListadoAlumnos();
                    

                }
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            int index = listBox_alumnos.SelectedIndex;

            if(index >=0)
            {
                FrmAlumno frmAlumno = new FrmAlumno(miCatedra.Alumnos[index]);

                frmAlumno.ShowDialog();

                if (frmAlumno.DialogResult == DialogResult.OK)
                {
                    miCatedra.Alumnos.RemoveAt(index);
                    miCatedra.Alumnos.Insert(index,frmAlumno.Alumno);

                    ActualizarListadoAlumnos();

                }
            }
        }
    }
}
