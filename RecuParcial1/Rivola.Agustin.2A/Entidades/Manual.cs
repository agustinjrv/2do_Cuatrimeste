using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Manual:Libro
    {
        public ETipo tipo;

        public Manual(string titulo,string apellido,string nombre,float precio,ETipo tipo):base(titulo,apellido,nombre,precio)
        {
            this.tipo = tipo;
        }

        public static explicit operator Single(Manual m)
        {
            return m.precio;
        }

        public static bool operator ==(Manual a, Manual b)
        {
            bool retorno = false;
            
            if((Libro)a==(Libro)b && a.tipo==b.tipo)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Manual a, Manual b)
        {
            return !(a == b);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append((String)this + "TIPO: " + this.tipo.ToString() +"\n");
            
            return sb.ToString();
        }
        public override bool Equals(object obj)
        {
            bool retorno = false;
            
            if(obj is Manual)
            {
                if((Manual)obj == this)
                {
                    retorno = true;
                }
            }

            return retorno;
        }







    }
}
