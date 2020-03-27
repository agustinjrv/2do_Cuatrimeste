using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_18.Entidades
{
    public class Comercial:Avion
    {
        protected int _capacidadPasajeros;

        public Comercial(double precio,double velocidad,int pasajeros):base(precio,velocidad)
        {
            this._capacidadPasajeros = pasajeros;
        }


    }
}
