using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class Correo:IMostrar<List<Paquete>>
    {
        private List<Thread> mockPaquetes;
        private List<Paquete> paquetes;
        /// <summary>
        /// get retorna los Paquetes 
        /// set establece valor
        /// </summary>
        public List<Paquete> Paquetes
        {
            get { return this.paquetes ; }
            set {this.paquetes=value; }

        }
        /// <summary>
        /// inicializa los atributos de la clase
        /// </summary>
        public Correo()
        {
            this.mockPaquetes = new List<Thread>();
            this.paquetes = new List<Paquete>();
        }

        /// <summary>
        /// cierra los hilos
        /// </summary>
        public void FinEntregas()
        {
            foreach(Thread t in this.mockPaquetes)
            {
                t.Abort();
            }
        }
        /// <summary>
        /// muestra los datos de los atributos de las clases
        /// </summary>
        /// <param name="elemento">elemento a mostrar</param>
        /// <returns>retorna un string con los datos de la clase</returns>
        public string MostrarDatos(IMostrar<List<Paquete>> elemento)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Paquete p in ((Correo)elemento).Paquetes)
            {
                sb.AppendLine(string.Format("{0} para {1} ({2})", p.TrackingID, p.DireccionEntrega, p.Estado.ToString()));
            }


            return sb.ToString();
        }
        /// <summary>
        /// suma un paquete a la lista de paquetes dentro de correo
        /// </summary>
        /// <param name="c">coreo</param>
        /// <param name="p">paquete</param>
        /// <returns>retorna un correo</returns>
        public static Correo operator +(Correo c,Paquete p)
        {
            foreach(Paquete i in c.Paquetes)
            {
                if(i==p)
                {
                    throw new TrakingIdRepetidoException("El paquete ya se encuentra en la lista.");
                }
               
            }
           
            try
            {
                c.Paquetes.Add(p);
                Thread t = new Thread(p.MockCicloDeVida);
                c.mockPaquetes.Add(t);
                t.Start();
            }
            catch(Exception e)
            {
                throw e;
            }
            
            return c;
        }


            



    }
}
