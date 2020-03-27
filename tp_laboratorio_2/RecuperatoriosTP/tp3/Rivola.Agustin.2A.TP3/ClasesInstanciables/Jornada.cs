using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Archivos;
using Excepciones;



namespace ClasesInstanciables
{
    public class Jornada
    {
        private List<Alumno> alumnos;
        private Universidad.EClases clase;
        private Profesor instructor;


        public List<Alumno> Alumnos
        {
            get { return this.alumnos; }
            set { this.alumnos = value; }
        }

        public Universidad.EClases Clase
        {
            get { return this.clase; }
            set { this.clase = value; }
        }

        public Profesor Instructor
        {
            get { return this.instructor; }
            set { this.instructor = value; }
        }

       

        private Jornada()
        {
            this.alumnos = new List<Alumno>();
        }

        public Jornada(Universidad.EClases clase,Profesor instructor):this()
        {
            this.clase = clase;
            this.instructor = instructor;
            
        }
        /// <summary>
        /// guardará los datos de la Jornada en un archivo de texto
        /// </summary>
        /// <param name="jornada"></param>
        /// <returns></returns>
        public static bool Guardar(Jornada jornada)
        {
            Texto txt = new Texto();

            return txt.Guardar(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+@"/Archivo.txt", jornada.ToString());
          
        }
        /// <summary>
        /// retornará los datos de la Jornada como texto.
        /// </summary>
        /// <returns></returns>
        public static string Leer()
        {
            string linea = "";
            try
            {
              Texto txt = new Texto();
              txt.Leer(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"/Archivo.txt", out linea);
              
            }
            catch(ArchivosException a)
            {
              Console.WriteLine(a);
            }


            return linea;            
        }
        /// <summary>
        /// Una Jornada será igual a un Alumno si el mismo participa de la clase.
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator ==(Jornada j ,Alumno a)
        {
            bool retorno = false;

            foreach(Alumno i in j.alumnos)
            {
                if (i == a)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        /// <summary>
        /// Una Jornada será distinta a un Alumno si el mismo no participa de la clase.
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }
        /// <summary>
        /// Agrega al alumno a la lista de alumnos de la jornada si este no esta ya ingresado
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Jornada operator +(Jornada j, Alumno a)
        {
            if(!(j==a))
            {
                j.alumnos.Add(a);
            }
            else
            {
                throw new AlumnoRepetidoException();
            }

            return j;
        }
        /// <summary>
        /// mostrará todos los datos de la Jornada
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("CLASE DE : " + this.clase.ToString() + " POR NOMBRE COMPLETO :" + this.instructor.ToString());

            sb.AppendLine("\nALUMNOS :");

            foreach(Alumno a in this.alumnos)
            {
                sb.AppendLine("NOMBRE COMPLETO :" + a.ToString());
            }

            return sb.ToString(); ;
        }










    }
}
