using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_09.Entidades;

namespace Clase_09
{
    public class Catedra
    {
        List<Alumno> alumnos = new List<Alumno>();

        public List<Alumno> Alumnos
        {
            get { return this.alumnos; }
        }


        public Catedra()
        {

        }

        public static bool operator ==(Catedra c, Alumno a)
        {
            bool retorno = false;

            if (!object.Equals(c, null) && !object.Equals(a, null))
            {
                if (c.alumnos.Contains(a))
                {
                    retorno = true;
                }


            }

            return retorno;

        }


        public static bool operator !=(Catedra c, Alumno a)
        {
            return !(c == a);
        }




        public static bool operator +(Catedra c, Alumno a)
        {
            bool retorno = false;

            if (c != a)
            {
                retorno = true;
                c.alumnos.Add(a);
            }

            return retorno;
        }

        public static int operator |(Catedra c, Alumno a)
        {
            int i=-1;

            if(c==a)
            {
                i= c.alumnos.IndexOf(a);
            }

            return i;
        }

        public static bool operator -(Catedra c,Alumno a)
        {
            bool retorno = false;
            int i;

            if(c==a)
            {
                i=c | a;

                c.alumnos.Remove(a);

                retorno = true;
            }

            return retorno;
        }

        public override string ToString()
        {
            string cadena="";

            for(int i=0;i<this.alumnos.Count;i++)
            {
                cadena += this.alumnos[i].ToString() + "\n";
            }


            return cadena;
        }
        
    }
}
