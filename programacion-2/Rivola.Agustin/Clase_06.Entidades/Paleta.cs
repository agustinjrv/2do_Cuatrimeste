using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_06.Entidades
{
    public class Paleta
    {
        private Tempera[] colores;
        private int cantidadMaximaDeColores;

        private Paleta():this(5)
        {

        }

        private Paleta(int cantidadElementos)
        {
            this.colores = new Tempera[cantidadElementos];
            this.cantidadMaximaDeColores = cantidadElementos;
        }

        public static implicit operator Paleta(int numero)
        {
            Paleta a=new Paleta();
            return a;
        }

       private string Mostrar()
        {
            string mensaje = "\nCantidad Maxima de colores: "+ this.cantidadMaximaDeColores.ToString() + " ";

            for (int i = 0; i < this.cantidadMaximaDeColores; i++)
            {
                mensaje += (string)this.colores[i];
            }
            return mensaje;
        }
        public static explicit operator string(Paleta p)
        {
            return p.Mostrar();
        }


        public static bool operator ==(Paleta p,Tempera t)
        {
            bool esta = false;

            for (int i=0;i<p.colores.Length;i++)
            {
                

                if (p.colores[i] == t) 
                {
                    esta = true;
                }
            }

            return esta;
        }

        public static bool operator !=(Paleta p, Tempera t)
        {
            return !(p == t);
        }

        public static Paleta operator +(Paleta p, Tempera t)
        {

            if (p == t)
            {
                if ((p | t) != -1)
                    p.colores[p | t] += t;
            }
            else
            {
                if (p.ObtenerLugarLibre() != -1)
                    p.colores[p.ObtenerLugarLibre()] = t;
            }
            return p;
        }


   

        private int ObtenerLugarLibre()
        {

            int i=-1;

            for ( i= 0; i < this.cantidadMaximaDeColores; i++)
            {
                if (this.colores[i] == null)
                {
                    break;
                }

            }

            return i;

        }

        public static int operator |(Paleta p,Tempera t)
        {
            int i = -1;

            for ( i = 0; i < p.cantidadMaximaDeColores; i++)
            {
                if (p.colores[i] == t)
                {
                    break;
                }
            }



            return i;
        }
        ///agregar sobrecarga de operador "-"
        ///-(paleta,Tempera):Paleta
        ///para quitar cantidad.si la cantidad de la tempera queda en 0 o menor que 0 queda null
    }
}
