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
    public class Alumno : Persona
    {
        public double nota;

        public Alumno(string nombre, string apellido, int edad, double nota) : base(nombre, apellido, edad)
        {
            this.nota = nota;
        }

        public Alumno() : base()
        {
            this.nota = 0;
        }

        public override string ToString()
        {
            return base.ToString() + "\nNota :" + this.nota.ToString();
        }





    }
}
