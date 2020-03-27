using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_06.Entidades
{



    public class Tempera
    {
        private ConsoleColor color;
        private string marca;
        private int cantidad;

        public Tempera(ConsoleColor unColor,string str,int numero )
        {
            this.color = unColor;
            this.marca = str;
            this.cantidad = numero;
        }

        private string Mostrar()
        {
            return " \n\ncolor : " + this.color.ToString() + "\n marca :" + this.marca + "\n cantidad : " + this.cantidad.ToString();
        }

        public static implicit operator string(Tempera t)
        {
            if (!Object.Equals(t, null))
                return t.Mostrar();
            return "\nnull";
        }

        public static bool operator ==(Tempera x, Tempera y)
        {
            if ((!Object.Equals(x, null)) && !Object.Equals(y, null))
            {
                if (x.marca == y.marca && x.color == y.color)
                {
                    return true;
                }
                return false;
            }
            else
            {
                return (Object.Equals(x, y));
            }
        }

        public static bool operator !=(Tempera uno, Tempera dos)
        {
            return !(uno == dos);
        }

        public static Tempera operator +(Tempera uno, int numero)
        {
            uno.cantidad += numero;

            return uno;
        }

        public static Tempera operator +(Tempera uno, Tempera dos)
        {
            if(uno==dos)
            {
                uno += dos.cantidad;
            }

            return uno;
        }






    }
}
