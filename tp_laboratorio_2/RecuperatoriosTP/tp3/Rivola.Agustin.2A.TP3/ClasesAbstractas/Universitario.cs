using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    public abstract class Universitario : Persona
    {
        private int legajo;
        /// <summary>
        /// constructor
        /// </summary>
        public Universitario():base()
        {

        }
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="legajo"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base(nombre, apellido, dni, nacionalidad)
        {
            this.legajo = legajo;
        }
        /// <summary>
        /// Muestra los datos de la clase Universitario
        /// </summary>
        /// <returns></returns>
        protected virtual string MostrarDatos()
        {
            return  base.ToString()+ "\n\nLEGAJO NUMERO:" + this.legajo.ToString() ;
        }
        /// <summary>
        /// Dos Universitario serán iguales si son del mismo Tipo y su Legajo o DNI son iguales.
        /// </summary>
        /// <param name="pg1"></param>
        /// <param name="pg2"></param>
        /// <returns></returns>
        public static bool operator ==(Universitario pg1,Universitario pg2)
        {
            bool retorno = false;

            if(pg1.GetType()== pg2.GetType() && (pg1.legajo==pg2.legajo || pg1.DNI==pg2.DNI ))
            {
                retorno = true;
            }
            

            return retorno;
        }
        /// <summary>
        /// Dos Universitario serán distintos si son de distinto Tipo o su Legajo o DNI son distintos
        /// </summary>
        /// <param name="pg1"></param>
        /// <param name="pg2"></param>
        /// <returns></returns>
        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }

        protected abstract string ParticiparEnClase();
        
        /// <summary>
        /// si obj es de la clase Universitario y si this es igual a obj retornara true
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            bool retorno=false;

            if(obj is Universitario)
            {
                if(this==(Universitario)obj)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        
    }
}