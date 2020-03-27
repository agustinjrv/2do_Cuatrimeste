using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Clase_09.Entidades
{
    public class Alumno
    {
        protected string apellido;
        protected ETipoExamen examen;
        protected int legajo;
        protected string nombre;

        public string Apellido
        {
            get { return this.apellido; }
        }
        public ETipoExamen Examen
        {
            get { return this.examen; }
        }
        public int Legajo
        {
            get { return this.legajo; }
        }
        public string Nombre
        {
            get { return this.nombre; }
        }
        public Alumno(string nombre ,string apellido ,int legajo,ETipoExamen examen)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
            this.examen = examen;
        }

        public static string Mostrar(Alumno a)
        {
            return  a.apellido +" "+ a.nombre + "--- Legajo : " + a.legajo.ToString() +"--- Examen : "+ a.examen.ToString();
        }
        

        public static bool operator ==(Alumno a,Alumno b)
        {
            bool retorno = false;

            if(a.legajo==b.legajo && a.examen==b.examen && string.Equals(a.apellido, b.apellido) && string.Equals(a.nombre, b.nombre))
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Alumno a, Alumno b)
        {
            return !(a == b);
        }

        public static int OrdenarPorApellidoAsc(Alumno a, Alumno b)
        {
            return string.Compare(a.apellido, b.apellido);
        }

        public static int OrdenarPorApellidoDesc(Alumno a,Alumno b)
        {
            return -1 * OrdenarPorApellidoAsc(a, b);


        }

        public static int OrdenarPorLegajoAsc(Alumno a,Alumno b)
        {
            return String.Compare(a.legajo.ToString(), b.legajo.ToString());
        }

        public static int OrdenarPorLegajoDesc(Alumno a,Alumno b)
        {
            return -1 * OrdenarPorLegajoAsc(a, b);
        }

        public override string ToString()
        {
            return Alumno.Mostrar(this);
        }



    }
}
