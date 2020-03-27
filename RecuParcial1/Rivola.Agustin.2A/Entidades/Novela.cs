using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Novela:Libro
    {
        public EGenero genero;

        public Novela(string titulo,float precio,Autor autor,EGenero genero):base(precio,titulo,autor)
        {
            this.genero = genero;
        }


        public static implicit operator Single(Novela n)
        {
            return n.precio;
        }

        public static bool operator ==(Novela a, Novela b)
        {
            bool retorno = false;

            if ((Libro)a == (Libro)b && a.genero == b.genero)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Novela a, Novela b)
        {
            return !(a == b);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append((String)this + "GENERO :" + this.genero.ToString()+"\n");

            return sb.ToString();

        }
        public override bool Equals(object obj)
        {
            bool retorno = false;

            if (obj is Novela)
            {
                if ((Novela)obj == this)
                {
                    retorno = true;
                }
            }

            return retorno;
        }



    }
}
