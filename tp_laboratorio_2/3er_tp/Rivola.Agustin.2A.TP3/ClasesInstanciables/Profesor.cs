using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace ClasesInstanciables
{
    public sealed class Profesor:Universitario
    {
        private Queue<Universidad.EClases> clasesDelDia;
        private static Random random;


        static Profesor()
        {
            random = new Random();
        }

        public Profesor(int id,string nombre,string apellido ,string dni,ENacionalidad nacionalidad):base(id,nombre,apellido,dni,nacionalidad)
        {
            this.clasesDelDia = new Queue<Universidad.EClases>();
            _randomClases();
            _randomClases();

        }
        
        public Profesor():base()
        {

        }



        private void _randomClases()
        {
            this.clasesDelDia.Enqueue((Universidad.EClases)Profesor.random.Next(0, 3));
        }

        protected override string MostrarDatos()
        {
            return base.MostrarDatos() + this.ParticiparEnClase() ;
        }

        public static bool operator ==(Profesor i,Universidad.EClases clase)
        {
            bool retorno = false;

            foreach(Universidad.EClases e in i.clasesDelDia)
            {
                if(e==clase)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public static bool operator !=(Profesor i, Universidad.EClases clase)
        {
            return !(i == clase);
        }

        protected override string ParticiparEnClase()
        {
            string cadena="";
            int tam= this.clasesDelDia.Count;
            
            foreach(Universidad.EClases unaClase in this.clasesDelDia)
            {
                cadena+="\n"+Enum.GetName(typeof(Universidad.EClases),unaClase);
            }

            return "\nClases del dia " + cadena;
        }
        

        public override string ToString()
        {
            return MostrarDatos();
        }







    }
}
