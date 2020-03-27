using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace Clase_19.Entidades
{
    [XmlInclude(typeof(Alumno))]
    [XmlInclude(typeof(Empleado))]

    public class Persona
    {
        public string nombre;
        public string apellido;
        private int edad;
        private List<string> apodos;

        public Persona(string nombre, string apellido, int edad) : this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }

        public Persona()
        {
            this.nombre = "";
            this.apellido = "";
            this.edad = 0;
            this.apodos = new List<string>();
        }


        public int Edad
        {
            get { return this.edad; }
            set { this.edad = value; }
        }

        public List<string> Apodos
        {
            get { return this.apodos; }

        }

        public override string ToString()
        {
            string cadena = "";
            foreach (string s in this.apodos)
            {
                cadena += " " + s;
            }

            return "Nombre : " + this.nombre + "\nApellido : " + this.apellido + "\nEdad : " + this.edad.ToString() + "\n" + "\nApodos :" + cadena;
        }


    }
}
