using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloPrimerParcial
{
    public class Materia
    {
        private List<Alumno> _alumnos;
        private EMateria _nombre;
        private Random _notaParaUnAlumno;

        public List<Alumno> Alumnos
        {
            get { return this._alumnos; }
            set { this._alumnos = value; }
        }


        public EMateria Nombre
        {
            get {return _nombre; }
            set {this._nombre =value; }
        }

        static Materia()
        {

        }


        private Materia()
        {
            this._alumnos = new List<Alumno>();
            this._nombre = EMateria.Laboratorio_I;
            this._notaParaUnAlumno = new Random();
        }

        private Materia(EMateria nombre):this()
        {
            this._nombre = nombre;
        }

        private string Mostrar()
        {
            string cadena = this._nombre.ToString();

            cadena += "\n******************************************";
            cadena += "\n******************ALUMNOS*****************";


            foreach (Alumno a in this._alumnos)
            {
                cadena += "\n" + Alumno.Mostrar(a);
            }
       
            return cadena;
        }

        public void CalificarAlumno()
        {
            int tam = this._alumnos.Count;

            for(int i=0;i<tam;i++)
            {
                this._alumnos[i].Nota= this._notaParaUnAlumno.Next(1, 10);
            }
        }

        public static implicit operator Materia(EMateria nombre)
        {
            Materia unaMateria= new Materia(nombre);

            return unaMateria;
        }

        public static implicit operator float(Materia m)
        {
            float promedio=0;
            int tam =m.Alumnos.Count;

            for(int i=0;i<tam;i++)
            {
                promedio+=m.Alumnos[i].Nota;
            }

            return promedio /= tam;
        }

        public static explicit operator string(Materia materia)
        {
            return "";
        }

        public static bool operator ==(Materia m,Alumno a)
        {
            bool retorno = false;

            foreach(Alumno i in m.Alumnos)
            {
                if(i.Legajo==a.Legajo)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Materia m, Alumno a)
        {
            return !(m == a);
        }

        public static Materia operator +(Materia m, Alumno a)
        {
            if(m!=a)
            {
                m.Alumnos.Add(a);
            }

            return m;
        }

        public static Materia operator -(Materia m, Alumno a)
        {
            if(m==a)
            {
                m.Alumnos.Remove(a);
            }

            return m;
        }






    }
}
