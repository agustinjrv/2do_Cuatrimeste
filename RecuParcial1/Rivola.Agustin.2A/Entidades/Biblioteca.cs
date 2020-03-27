using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Biblioteca
    {
        private int capacidad;
        private List<Libro> libros;

        public double PrecioDeManuales
        {
            get { return ObtenerPrecio(ELibro.PrecioDeManuales); }
        }

        public double PrecioDeNovelas
        {
            get { return ObtenerPrecio(ELibro.PrecioDeNovelas); }
        }
        public double PrecioTotal
        {
            get{ return ObtenerPrecio(ELibro.PrecioDeNovelas); }
        }


        private Biblioteca()
        {
            libros = new List<Libro>();
        }

        private Biblioteca(int capacidad):this()
        {
            this.capacidad = capacidad;
        }

        public static implicit operator Biblioteca(int capacidad)
        {
            return new Biblioteca(capacidad);
        }

        public static string Mostrar(Biblioteca b)
        {
            StringBuilder sb = new StringBuilder("");

            sb.AppendLine("Capacidad :"+b.capacidad.ToString());
            sb.AppendLine("Total por manuales :" + b.PrecioDeManuales.ToString());
            sb.AppendLine("Total por novelas :" + b.PrecioDeNovelas.ToString());
            sb.AppendLine("Total :" + b.PrecioTotal);
            sb.AppendLine("*******************************");
            sb.AppendLine("Listado de libros");
            sb.AppendLine("*******************************");


            foreach (Libro l in b.libros)
            {
                if(l is Manual)
                {
                    sb.AppendLine(((Manual)l).ToString());
                }
                else
                {
                    sb.AppendLine(((Novela)l).ToString());
                }

            }

            return sb.ToString();
        }

        private double ObtenerPrecio(ELibro tipoLibro)
        {
            double precio=0;

            switch (tipoLibro)
            {
                case ELibro.PrecioDeManuales:

                    foreach(Libro l in this.libros)
                    {
                        if(l is Manual)
                        {
                            precio+=(Single)(Manual)l;
                        }
                    }

                    break;
                case ELibro.PrecioDeNovelas:

                    foreach(Libro l in this.libros)
                    {
                        if(l is Novela)
                        {
                            precio+=(Novela)l;
                        }
                    }
                    break;
                case ELibro.PrecioTotal:

                    foreach (Libro l in this.libros)
                    {
                        if (l is Manual)
                        {
                            precio += (Single)(Manual)l;
                        }
                    }

                    foreach (Libro l in this.libros)
                    {
                        if (l is Novela)
                        {
                            precio += (Novela)l;
                        }
                    }
                    break;
            }



            return precio;
        }

        public static bool operator ==(Biblioteca b, Libro l)
        {
            bool retorno = false;

            foreach(Libro i in b.libros)
            {
                if(i==l)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        public static bool operator !=(Biblioteca b, Libro l)
        {
            return !(b == l);
        }

        public static Biblioteca operator +(Biblioteca b, Libro l)
        {
            if(!(b == l))
            {
                
                if (b.libros.Count < b.capacidad)
                {
                    b.libros.Add(l);
                }
                else
                {
                    Console.WriteLine("No hay mas lugar en la biblioteca!!!");
                }
            }
            else
            {
                Console.WriteLine("El libro ya esta en la biblioteca!!!");
                
            }

            return b;
        }








    }
}
