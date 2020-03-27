using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaPolimorfismo
{
    public abstract class Llamada
    {
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;
        
        public abstract float CostoLlamada { get; }

        public float Duracion
        {
            get { return this._duracion; }
        }

        public string NroDestino
        {
            get { return this._nroDestino; }
        }

        public string NroOrigen
        {
            get { return this._nroOrigen; }
        }

        public Llamada(string origen,string destino,float duracion)
        {
            this._nroOrigen = origen;
            this._nroDestino = destino;
            this._duracion = duracion;
        }

        protected virtual string Mostrar()
        {
            StringBuilder cadena = new StringBuilder("Numero Origen : " + this._nroOrigen + " numero de destino : " + this._nroDestino + " Duracion : " + this._duracion.ToString());
            return cadena.ToString();
        }

        public static bool operator ==(Llamada uno,Llamada dos)
        {
            bool retorno = false;

            if(object.Equals(uno,dos))
            {
                if((string.Equals(uno._nroOrigen,dos._nroOrigen) && string.Equals(uno._nroDestino,dos._nroDestino)))
                {
                    retorno = true;
                }  
            }
            return retorno;
        }

        public static bool operator !=(Llamada uno, Llamada dos)
        {
            return !(uno == dos);
        }

        public static int OrdenarPorDuracion(Llamada uno,Llamada dos)
        {
            return String.Compare(uno.ToString(), dos.ToString());
        }




    }
}
