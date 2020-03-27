using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_17.entidades
{
    public class Auto
    {
        private string _color;
        private string _marca;


        public string Color
        {
            get {return this.Color; } 
        }

        public string Marca
        {
            get { return this.Marca ; }
        }

        public Auto(string color,string marca)
        {
            this._color = color;
            this._marca = marca;
        }

        

        public static bool operator ==(Auto a,Auto b)
        {
            bool retorno=false;

            if(a._marca==b._marca && a._color==b._color)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Auto a, Auto b)
        {
            return !(a == b);
        }

        public override string ToString()
        {
            return "Marca : " + this._marca + " color : " + this._color;
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;

            if(obj is Auto)
            {
                if(obj==this)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

    }
}
