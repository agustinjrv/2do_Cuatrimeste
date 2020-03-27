using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_25.Entidades;
namespace FrmEmpleado
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

            foreach(TipoManejador t in Enum.GetValues(typeof(TipoManejador)))
            {
                comboBox_manejador.Items.Add(t);

            }
            comboBox_manejador.SelectedIndex = 0;
            comboBox_manejador.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = textBox_nombre.Text;
                string apellido = textBox_Apellido.Text;
                int legajo = int.Parse(textBox_Legajo.Text);
                double sueldo = double.Parse(textBox_Sueldo.Text);
                TipoManejador tipo = (TipoManejador)comboBox_manejador.SelectedItem;

                Empleado unEmpleado = new Empleado(nombre, apellido, legajo);

                switch (tipo)
                {
                    case TipoManejador.LimiteSuedo:
                        unEmpleado.limiteSueldo -= new LimiteSueldoDelegado(ManejadorLimiteSueldo);
                        unEmpleado.limiteSueldo += new LimiteSueldoDelegado(ManejadorLimiteSueldo);

                        break;
                    case TipoManejador.LimiteSueldoMejorado:

                        unEmpleado.sueldoMejorado -= new LimiteSueldoMejorado(ManejadorLimiteSueldoMejorado);
                        unEmpleado.sueldoMejorado += new LimiteSueldoMejorado(ManejadorLimiteSueldoMejorado);

                        break;
                    case TipoManejador.Todos:

                        unEmpleado.limiteSueldo -= new LimiteSueldoDelegado(ManejadorLimiteSueldo);
                        unEmpleado.sueldoMejorado -= new LimiteSueldoMejorado(ManejadorLimiteSueldoMejorado);
                        unEmpleado.sueldoMejorado += new LimiteSueldoMejorado(ManejadorLimiteSueldoMejorado2);
                        unEmpleado.limiteSueldo += new LimiteSueldoDelegado(ManejadorLimiteSueldo);

                        break;
                        
                }
                unEmpleado.Sueldo = sueldo;

               // MessageBox.Show(unEmpleado.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString()); 
            }

            
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult=DialogResult.Cancel;
        }

        public void ManejadorLimiteSueldo(double e, Empleado emp)
        {
            MessageBox.Show(emp.ToString() + " Limite sueldo :" + e.ToString());
        }
        public static void ManejadorLimiteSueldoMejorado(Empleado emp, EmpleadoEventArgs e)
        {
            MessageBox.Show(emp.ToString() + " Limite sueldo mejorado: " + e.SueldoAsignar);
        }
        public void ManejadorLimiteSueldoMejorado2(Empleado emp, EmpleadoEventArgs e)
        {
            MessageBox.Show(emp.ToString() + " Limite sueldo mejorado2 :" + e.SueldoAsignar);
        }


    }
}
