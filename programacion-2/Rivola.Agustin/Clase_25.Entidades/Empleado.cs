using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_25.Entidades;

namespace Clase_25.Entidades
{
    public class Empleado
    {

        private string nombre;
        private string apellido;
        private int legajo;
        private double sueldo;

        public event LimiteSueldoDelegado limiteSueldo;
        public event LimiteSueldoMejorado sueldoMejorado;

        //public void object_empleado(double sueldo, Empleado emp)
        //{

        //}

        public Empleado(string nombre,string apellido,int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }


        public string Nombre
        {
            get {return this.nombre; }
            set { this.nombre = value ; }
        }

        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }
        public int Legajo
        {
            get { return this.legajo; }
            set { this.legajo = value; }
        }
        public double Sueldo
        {
            get { return this.sueldo; }
            set
            {
                if(30000<value)
                {
                    EmpleadoEventArgs e = new EmpleadoEventArgs();
                    e.SueldoAsignar = value;

                    //this.sueldo = value;
                    this.sueldoMejorado(this,e);
                }
                else if(18000<value && 30000>=value)
                {
                    this.limiteSueldo(value,this);
                }
                else
                {
                    this.sueldo = value;
                }


            }
        }

        public override string ToString()
        {
            return " Nombre :" + this.nombre+ " " + this.apellido + " Legajo :" + this.legajo.ToString() + " Sueldo :" + this.sueldo.ToString();
        }


      

    }
}
