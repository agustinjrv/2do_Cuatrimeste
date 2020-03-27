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
        /// <summary>
        /// serializará los datos del Universidad en un XML, incluyendo todos los datos de sus Profesores, Alumnos y Jornadas.
        /// </summary>
        /// <param name="uni"></param>
        /// <returns></returns>
        public static bool Guardar(Universidad uni)
        {
            bool retorno = false;
            Xml<Universidad> xml = new Xml<Universidad>();
            xml.Guardar(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+@"/archivoXML.xml", uni);

            return retorno;
        }
        /// <summary>
        /// retornará un Universidad con todos los datos previamente serializados
        /// </summary>
        /// <returns></returns>
        public Universidad Leer()
        {   
            Xml<Universidad> xml = new Xml<Universidad>();
            xml.Leer(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"/archivoXML.xml", out Universidad uni);
                   
            return uni;
        }


        /// <summary>
        /// Un Universidad será igual a un Alumno si el mismo está inscripto en él
        /// </summary>
        /// <param name="g"></param>
        /// <param name="a"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Un Universidad será disinta a un Alumno si el mismo no está inscripto en él
        /// </summary>
        /// <param name="g"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g == a);
        }
        /// <summary>
        /// Un Universidad será igual a un Profesor si el mismo está dando clases en él.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="i"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Un Universidad será distinto a un Profesor si el mismo no está dando clases en él.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public static bool operator !=(Universidad g, Profesor i)
        {
            return !(g == i);
        }
        /// <summary>
        /// retornará el primer Profesor capaz de dar esa clase. Sino, lanzará la Excepción SinProfesorException.
        /// </summary>
        /// <param name="u"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
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
        /// <summary>
        ///  retornará el primer Profesor que no pueda dar la clase
        /// </summary>
        /// <param name="u"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
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
        /// <summary>
        /// agrega un Eclases a universidad generandose una nueva jornada  y asignando un profesor que pueda dar esa  clase y agregara a todos los alumnos que puedan tomarla
        /// </summary>
        /// <param name="g"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Se agregarán Alumnos validando que no estén previamente cargados.
        /// </summary>
        /// <param name="u"></param>
        /// <param name="a"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Se agregarán  Profesores validando que no estén previamente cargados.
        /// </summary>
        /// <param name="u"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public static Universidad operator +(Universidad u,Profesor i)
        {
            if (u != i)
            {
                u.profesores.Add(i);
            }
            return u;
        }
        /// <summary>
        /// muestra los datos de la clase Universidad
        /// </summary>
        /// <param name="uni"></param>
        /// <returns></returns>
        private static string MostrarDatos(Universidad uni)
        {
            string cadena;

            cadena = "\nJORNADA :";
            foreach (Jornada j in uni.jornada)
            {
                cadena += "\n" + j.ToString();
                cadena += "<---------------------------------------------->";
            }

            return cadena;
        }
        /// <summary>
        /// Los datos del Universidad se harán públicos mediante ToString.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return MostrarDatos(this);
        }



    }
}
