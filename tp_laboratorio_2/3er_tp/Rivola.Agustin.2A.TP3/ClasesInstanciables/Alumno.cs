using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;




namespace ClasesInstanciables
{
    public sealed class Alumno:Universitario
    {
        public enum EEstadoCuenta { AlDia, Deudor, Becado }

        private Universidad.EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;

        public Alumno()
        {
            this.claseQueToma = Universidad.EClases.Laboratorio;
            this.estadoCuenta = EEstadoCuenta.AlDia;
        }
        public Alumno(int id,string nombre,string apellido,string dni,ENacionalidad nacionalidad,Universidad.EClases claseQueToma):base(id,nombre,apellido,dni,nacionalidad)
        {
            this.claseQueToma = claseQueToma;
        }
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma,EEstadoCuenta estadoCuenta):this(id,nombre,apellido,dni,nacionalidad,claseQueToma)
        {
            this.estadoCuenta=estadoCuenta;
        }

        protected override string ParticiparEnClase()
        {
            return "\nTOMA CLASE DE " + this.claseQueToma.ToString();
        }

        protected override string MostrarDatos()
        {
            return base.MostrarDatos()+ "\nESTADO DE CUENTA :" + estadoCuenta.ToString() + this.ParticiparEnClase() ;
        }

        public static bool operator ==(Alumno a,Universidad.EClases clase)
        {
            bool retorno = false;

            if(a.claseQueToma==clase && a.estadoCuenta!=EEstadoCuenta.Deudor)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Alumno a, Universidad.EClases clase)
        {
            return !(a == clase);
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }




    }
}
