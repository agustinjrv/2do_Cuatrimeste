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

        public static bool Guardar(Jornada jornada)
        {
            Texto txt = new Texto();

            return txt.Guardar(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+@"/Archivo.txt", jornada.ToString());
          
        }

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


        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }

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

        public override string ToString()
        {
            string cadena="CLASE DE : "+ this.clase.ToString()+ " " + this.instructor.ToString();

            cadena += "\n\nAlumnos :";

            foreach(Alumno a in this.alumnos)
            {
                cadena +="\n" + a.ToString()+"\n";
            }
            cadena += "-----------------------------------------\n";

            return cadena;
        }










    }
}
