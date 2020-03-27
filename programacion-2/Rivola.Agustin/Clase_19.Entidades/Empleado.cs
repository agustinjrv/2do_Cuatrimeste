using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_19.Entidades
{
    public class Empleado : Persona
    {
        public int legajo;
        public double sueldo;


        public Empleado():base()
        {
            this.legajo = 0;
            this.sueldo = 0;
        }

        public Empleado(string nombre, string apellido, int edad, int legajo, double sueldo) : base(nombre, apellido, edad)
        {
            this.legajo = legajo;
            this.sueldo = sueldo;
        }

        public override string ToString()
        {
            return base.ToString() + "\nLegajo :" + this.legajo.ToString() + "\nsueldo : " + this.sueldo.ToString();
        }




    }
}
