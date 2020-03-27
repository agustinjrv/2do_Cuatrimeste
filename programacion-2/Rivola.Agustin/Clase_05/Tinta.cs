using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_05
{
    class Tinta
    {
        private ConsoleColor _color;
        private ETipoTinta _tipo;

        public Tinta()
        {
           this._color= ConsoleColor.Blue;
           this._tipo = ETipoTinta.comun;
        }
        
        private string Mostrar()
        {
            return "color : " + this._color.ToString() + " tipo : " + this._tipo.ToString();
        }

        public static string Mostrar(Tinta tinta)
        {
            return tinta.Mostrar();
        }
        
        public static bool operator == (Tinta uno,Tinta dos)
        {
            bool esIgual=false;
          
            if(uno._color==dos._color && uno._tipo==dos._tipo)
            {
                esIgual = true;
            }

            return esIgual;
        }

        public static bool operator !=(Tinta uno, Tinta dos)
        {
            return !(uno == dos);
        }

        public static bool operator ==(Tinta a, ConsoleColor color)
        {
            bool esIgual = false;

            if (a._color == color)
            {
                esIgual = true;
            }

            return esIgual;
        }

        public static bool operator !=(Tinta a, ConsoleColor color)
        {
            return !(a == color);
        }

        public static explicit operator string(Tinta a)
        { 
        
            return a.Mostrar();
        }






    }
}
