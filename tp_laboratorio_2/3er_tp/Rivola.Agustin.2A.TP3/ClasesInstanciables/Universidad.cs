using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Archivos;
using Excepciones;


namespace ClasesInstanciables
{
    public class Universidad
    {
        public enum EClases { Programacion,Laboratorio,Legislacion,SPD}

        private List<Alumno> alumnos;
        private List<Jornada> jornada;
        private List<Profesor> profesores;

        public List<Alumno> Alumnos
        {
            get { return this.alumnos; }
            set { this.alumnos = value; }
        }
        public List<Profesor> Instructor
        {
            get { return this.profesores; }
            set { this.profesores = value; }
        }
        public List<Jornada> Jornadas
        {
            get { return this.jornada; }
            set { this.jornada = value; }
        }
        public Jornada this[int i]
        {
            get
            {
                return this.jornada[i];
            }

            set
            {
                this.jornada[i]=value;
            }
        }

        public Universidad()
        {
            this.alumnos = new List<Alumno>();
            this.profesores = new List<Profesor>();
            this.jornada = new List<Jornada>();
        }

        public static bool Guardar(Universidad uni)
        {
            bool retorno = false;
            Xml<Universidad> xml = new Xml<Universidad>();
            xml.Guardar(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+@"/archivoXML.xml", uni);

            return retorno;
        }

        public Universidad Leer()
        {   
            Xml<Universidad> xml = new Xml<Universidad>();
            xml.Leer(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"/archivoXML.xml", out Universidad uni);
                   
            return uni;
        }

        

        public static bool operator ==(Universidad g,Alumno a)
        {
            bool retorno = false;

            foreach(Alumno i in g.alumnos)
            {
                if(i==a)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno ;
        }

        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g == a);
        }

        public static bool operator ==(Universidad g,Profesor i)
        {
            bool retorno = false;

            foreach (Profesor p in g.profesores)
            {
                if (i == p)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public static bool operator !=(Universidad g, Profesor i)
        {
            return !(g == i);
        }

        public static Profesor operator ==(Universidad u,EClases clase)
        {
            Profesor retorno=null;
            bool flag = false;


            foreach (Profesor p in u.profesores)
            {
                if (p == clase)
                {
                    retorno = p;
                    flag = true;
                    break;
                }
            }

            if(!flag)
            {
                throw new SinProfesorException();
            }
            

            return retorno;
        }

        public static Profesor operator !=(Universidad u, EClases clase)
        {
            Profesor retorno = null;


            foreach (Profesor p in u.profesores)
            {
                if (p != clase)
                {
                    retorno = p;
                    break;
                }
            }

            return retorno;
        }

        public static Universidad operator +(Universidad g,EClases clase)
        {
            int i;
            Profesor p = g == clase;
            g.jornada.Add(new Jornada(clase, p));
            i = g.jornada.Count-1;
           
            foreach (Alumno a in g.alumnos)
            {
                if (a == clase)
                {
                    g.jornada[i] += a;
                }
            }



            return g;
        }

        public static Universidad operator +(Universidad u,Alumno a)
        {
            if(u!=a)
            {
                u.alumnos.Add(a);
            }
            else
            {
                throw new AlumnoRepetidoException();
            }
            return u;
        }
        public static Universidad operator +(Universidad u,Profesor i)
        {
            if (u != i)
            {
                u.profesores.Add(i);
            }
            return u;
        }

        private static string MostrarDatos(Universidad uni)
        {
            string cadena;

            cadena = "\nJORNADA :";
            foreach (Jornada j in uni.jornada)
            {
                cadena += "\n" + j.ToString();
            }
/*
            cadena += "Profesores";
            foreach (Profesor p in uni.profesores)
            {
                cadena += "\n" +p.ToString();
            }

            cadena += "\nAlumnos: ";

            foreach (Alumno a in uni.alumnos)
            {
                cadena += "\n" + a.ToString();
            }

            
    */

            return cadena;
        }

        public override string ToString()
        {
            return MostrarDatos(this);
        }



    }
}
