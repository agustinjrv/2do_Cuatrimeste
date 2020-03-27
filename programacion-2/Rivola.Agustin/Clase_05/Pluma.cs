using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_05
{
    class Pluma
    {
        private string _marca;
        private Tinta _tinta;
        private int _cantidad;

        public Pluma()
        {
            this._marca = "sin marca";
            this._tinta = null;
            this._cantidad = 0;
        }

        public Pluma(string marca) : this()
        {
            this._marca = marca;
        }

        public Pluma(string marca, Tinta tinta) : this(marca)
        {
            this._tinta = tinta;
        }

        public Pluma(string marca, Tinta tinta, int cantidad) : this(marca, tinta)
        {
            this._cantidad = cantidad;
        }

        private string Mostrar()
        {
            return "marca : " + this._marca.ToString() + " tinta :" + Tinta.Mostrar(this._tinta) + " cantidad :" + this._cantidad.ToString();
        }

        public static string Mostrar(Pluma a)
        {
            return a.Mostrar();
        }

        public static bool operator ==(Pluma a, Tinta b)
        {
            bool sonIguales = false;


            if(a._tinta== b)
            {
                sonIguales = true;
            }

            return sonIguales;
        }

        public static bool operator !=(Pluma a, Tinta b)
        {
            return !(a == b);

        }

        public static Pluma operator +(Pluma a,Tinta b)
        {

            if(!(Console.Equals(a,null)) && !(Console.Equals(b,null)))
            {
                if (a._tinta == b)
                {
                    if (a._cantidad < 100)
                    {
                        a._cantidad++;
                    }
                }
            }
           

            

            return a;
        }



    }
}
