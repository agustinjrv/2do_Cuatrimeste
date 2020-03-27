using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Libro
    {
        protected Autor autor;
        protected int cantidadDePaginas;
        protected static Random generadorDePaginas;
        protected float precio;
        protected string titulo;

        public int CantidadDePaginas
        {
            get
            {
                if(this.cantidadDePaginas==0)
                {
                    this.cantidadDePaginas = generadorDePaginas.Next(10,570);
                }

                return this.cantidadDePaginas;
            }
        }

        static Libro()
        {
            generadorDePaginas = new Random();
        }

        public Libro(float precio, string titulo, Autor autor)
        {
            this.precio = precio;
            this.titulo = titulo;
            this.autor = autor;
        }

        public Libro(string titulo, string apellido, string nombre, float precio):this(precio,titulo,new Autor(nombre,apellido))
        {

        }

        public static explicit operator String(Libro l)
        {
            return Mostrar(l);
        }

        

        private static string Mostrar(Libro l)
        {
     
            string cadena = "";
            cadena += l.autor;
            cadena += "\nTITULO : " + l.titulo + "\nCANTIDAD DE PAGINAS : " + l.CantidadDePaginas.ToString()+ "\nPRECIO : " + l.precio.ToString()+ "\n";

            return cadena;
        }

        public static bool operator ==(Libro a,Libro b)
        {
            bool retorno = false;

            if(a.titulo==b.titulo && a.autor==b.autor)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Libro a, Libro b)
        {
            return !(a == b);
        }

















    }
}
