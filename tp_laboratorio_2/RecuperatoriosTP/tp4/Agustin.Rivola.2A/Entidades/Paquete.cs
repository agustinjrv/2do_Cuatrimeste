using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class Paquete : IMostrar<Paquete>
    {
        public enum EEstado { Ingresado, EnViaje, Entregado }
        public delegate void DelegadoEstado(object o, EventArgs e);

        private string direccionEntrega;
        private EEstado estado;
        private string trackingID;

        public event DelegadoEstado InformarEstado;
        
        /// <summary>
        /// retorna el atributo direccionEntrega 
        /// </summary>
        public string DireccionEntrega
        {
            get { return this.direccionEntrega; }
            set { this.direccionEntrega = value; }

        }
        /// <summary>
        /// retorna el atributo estado
        /// </summary>
        public EEstado Estado
        {
            get { return this.estado; }
            set { this.estado = value; }

        }

        /// <summary>
        /// retorna el atributo TrackingID
        /// </summary>
        public string TrackingID
        {
            get { return this.trackingID; }
            set { this.trackingID = value; }

        }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="direccionEntrega">string</param>
        /// <param name="trackingID">string</param>
        public Paquete(string direccionEntrega,string trackingID)
        {
            this.DireccionEntrega = direccionEntrega;
            this.TrackingID = trackingID;
        }


        /// <summary>
        /// maneja el ciclo de vida de el paquete
        /// </summary>
        public void MockCicloDeVida()
        {
            bool flag = true;
            while(flag)
            {
                try
                {
                    this.InformarEstado(this, new EventArgs());

                   
                    Thread.Sleep(4000);

                    switch (this.Estado)
                    {
                        case EEstado.Ingresado:
 
                             this.Estado = EEstado.EnViaje;
                            break;

                        case EEstado.EnViaje:

                            this.Estado = EEstado.Entregado;
                            PaqueteDAO.Insertar(this);
                            break;
                        case EEstado.Entregado:
                            flag = false;
                            break;

                           
                    }

                }
                catch (Exception e)
                {
                     InformarEstado(e,new EventArgs());
                }


            }

        }

      /// <summary>
      /// muestra los datos de el paquete
      /// </summary>
      /// <param name="elemento"></param>
      /// <returns></returns>
        public string MostrarDatos(IMostrar<Paquete> elemento)
        {
            Paquete p = (Paquete)elemento;


            return string.Format("{0} para {1}", p.trackingID, p.direccionEntrega);
        }
        /// <summary>
        /// Dos paquetes serán iguales siempre y cuando su Tracking ID sea el mismo.
        /// </summary>
        /// <param name="p1">paquete 1</param>
        /// <param name="p2">paquete 2</param>
        /// <returns>retorna true si son iguales</returns>
        public static bool operator ==(Paquete p1,Paquete p2)
        {
            bool retorno=false;

            if(p1.TrackingID==p2.TrackingID)
            {
                retorno = true;
            }

            return retorno;
        }

        /// Dos paquetes serán distintos si el Tracking ID es distinto
        /// </summary>
        /// <param name="p1">paquete 1</param>
        /// <param name="p2">paquete 2</param>
        /// <returns>retorna true si son ditintos</returns>
        public static bool operator !=(Paquete p1, Paquete p2)
        {
            return !(p1 == p2);
        }
        /// <summary>
        /// retorna los datos del elemento en string
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return this.MostrarDatos(this) +" "+this.Estado.ToString();
        }

        
    }
}
