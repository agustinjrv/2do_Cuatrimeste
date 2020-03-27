using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloPrimerParcial
{
    public class Alumno
    {
        private string _apellido;
        private int _legajo;
        private string _nombre;
        private float _nota;

        public string Apellido
        {
            get {return this._apellido; }

            set { this._apellido = value; }
        }

        public int Legajo
        {
            get { return this._legajo; }

            set { this._legajo = value; }
        }

        public string Nombre
        {
            get { return this._nombre; }

            set { this._nombre = value; }
        }

        public float Nota
        {
            get { return this._nota; }

            set { this._nota = value; }
        }

        public Alumno(int legajo, string nombre, string apellido)
        {
            this._legajo = legajo;
            this._nombre = nombre;
            this._apellido = apellido;
        }

        private string Mostrar()
        {
            return this._apellido + ", " + this._nombre +" - Legajo : " + this._legajo.ToString() + " - Nota : " + this._nota.ToString();
        }
       
        public static string Mostrar(Alumno alumno)
        {
            return alumno.Mostrar();
        }

        public static bool operator ==(Alumno a1,Alumno a2)
        {
            bool retorno=false;

            if(a1._legajo==a2._legajo)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Alumno a1, Alumno a2)
        {
            return !(a1 == a2);
        }


    }
}
