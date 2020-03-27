using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentralitaPolimorfismo;

namespace CentralitaPolimorfismo
{

    
    public class Provincial : Llamada
    {
        protected Franja _franjaHoraria;

        public Provincial(string origen,Franja miFranja,float duracion,string destino):base(origen,destino,duracion)
        {
            this._franjaHoraria = miFranja;
        }

        public Provincial(Franja miFranja,Llamada unaLlamada):this(unaLlamada.NroOrigen,miFranja,unaLlamada.Duracion,unaLlamada.NroDestino)
        {

        }

        private float CalcularCosto()
        {
            float costo=0;
          
            switch (this._franjaHoraria)
            {
                case Franja.Franja_1:

                    costo = 0.99f * base.Duracion;                  
                    break;

                case Franja.Franja_2:

                    costo = 1.25f * base.Duracion;
                    break;

                case Franja.Franja_3:

                    costo = 0.66f * base.Duracion;
                    break;
            }

            return costo;
            
        }

        public override float CostoLlamada
        {
            get { return CalcularCosto(); }
        }

        protected override string Mostrar()
        {
            StringBuilder cadena = new StringBuilder(base.Mostrar() + " Costo de llamada : " + this.CostoLlamada.ToString());

            return cadena.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public override bool Equals(object obj)
        {
            bool retorno=false;

            if(obj is Provincial)
            {
                retorno = true;
            }

            return retorno;
        }

    }

    
}
