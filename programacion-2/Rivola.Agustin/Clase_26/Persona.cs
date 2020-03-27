using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_26
{
    public class Persona
    {
        protected string nombre;
        protected string apellido;
        protected int dni;

        public Persona(string nombre,string apellido,int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        public string Nombre
        {
            get {return this.nombre; }
        }

        public string Apellido
        {
            get {return this.apellido; }
        }
        public int DNI
        {
            get { return this.dni; } 
        }



        //geters
        public string GetNombre()
        {
            return this.nombre;
        }

        public string GetApellido()
        {
            return this.apellido;
        }

        public int GetDNI()
        {
            return this.dni;
        }

        public string ObtenerInfo()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.nombre);
            sb.AppendLine(this.apellido);
            sb.AppendLine(this.dni.ToString());

            return sb.ToString();
        }







    }
}
