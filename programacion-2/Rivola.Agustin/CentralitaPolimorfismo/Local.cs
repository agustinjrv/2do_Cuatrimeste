using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaPolimorfismo
{
    public class Local :Llamada
    {
        protected float _costo;

        public Local(string origen, float duracion, string destino, float costo):base(origen,destino,duracion)
        {
            this._costo = costo;
        }

        public Local(Llamada unaLlamada,float costo):this(unaLlamada.NroOrigen,unaLlamada.Duracion,unaLlamada.NroDestino,costo)
        {

        }


        public override float CostoLlamada
        {
            get { return this.CalcularCosto(); }            
        }

        protected override string Mostrar()
        {
            StringBuilder cadena = new StringBuilder(base.Mostrar() + "Costo llamada" + this.CostoLlamada.ToString());
            return cadena.ToString();
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;

            if(obj is Local)
            {
                retorno = true;
            }
            return retorno;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        private float CalcularCosto()
        {
            float precio=this._costo * base.Duracion;

            return precio;

        }
 

    }
}
