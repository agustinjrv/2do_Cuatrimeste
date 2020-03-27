using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace EntidadesAbstractas
{
    public abstract class Persona
    {
        public enum ENacionalidad { Argentino,Extranjero}

        private string apellido;
        private int dni;
        private ENacionalidad nacionalidad;
        private string nombre;

        /// <summary>
        /// get :retorna el apellido .
        /// set establece apellido verificando que sea una letra
        /// </summary>
        public string Apellido
        {
            get {return this.apellido; }
            set
            {
                this.apellido = ValidarNombreApellido(value);
            }
        }
        /// <summary>
        /// get :retorna el dni
        /// set :establece dni verificando que sea un dni valido 
        /// </summary>
        public int DNI
        {
            get { return this.dni; }
            set { this.dni = ValidarDni(this.nacionalidad, value); }
        }
        /// <summary>
        /// get:retorna nacionalidad
        /// set:establece nacionalidad
        /// </summary>
        public ENacionalidad Nacionalidad
        {
            get { return this.nacionalidad; }
            set { this.nacionalidad = value; }
        }

        /// <summary>
        /// get :retorna el nombre .
        /// set establece nombre verificando que sea una letra
        /// </summary>
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = ValidarNombreApellido(value); }
        }

        /// <summary>
        /// get :retorna el dni
        /// set :establece dni verificando que sea un dni valido 
        /// </summary>
        public string StringToDNI
        {
            set { this.dni =ValidarDni(this.nacionalidad,value); }
        }
        /// <summary>
        /// constructor 
        /// </summary>
        public Persona()
        {

        }
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre,string apellido,ENacionalidad nacionalidad):this()
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;
        }
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido,int dni, ENacionalidad nacionalidad):this(nombre,apellido,nacionalidad)
        {
            this.DNI = dni;
        }
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido,string dni ,ENacionalidad nacionalidad):this(nombre,apellido,nacionalidad)
        {
            this.StringToDNI = dni;
        }
        /// <summary>
        /// /// Valida que el dni sea valido,el dni Argentino debe estar entre 1 y 89999999 y el extrangero entre 90000000 y 99999999.
        /// Caso contrario, se lanzará la excepción NacionalidadInvalidaException.
        /// </summary>
        /// <param name="nacionalidad">Enacionalidad</param>
        /// <param name="dato">int</param>
        /// <returns> un entero siendo el dni </returns>
        private static int ValidarDni(ENacionalidad nacionalidad,int dato)
        {
            int retorno=-1;

            if (nacionalidad == ENacionalidad.Argentino)
            {
                if (dato > 0 && dato < 90000000)
                {
                    retorno = dato;
                }
                else
                {
                    throw new NacionalidadInvalidaException();
                }
            }
            else if (nacionalidad == ENacionalidad.Extranjero)
            {
                if (dato >= 90000000 && dato <= 99999999)
                {
                    retorno = dato;
                }
                else
                {
                    throw new NacionalidadInvalidaException(); 
                }
            }
               
            return retorno;
        }
        /// <summary>
        /// validara que el dni ingresado como string sea valido llamando a su sobrecarga validardni
        /// </summary>
        /// <param name="nacionalidad">string</param>
        /// <param name="dato"></param>
        /// <returns>un entero con el dni</returns>
        private static int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int retorno=-1;

            if(int.TryParse(dato,out int numero))
            {
                retorno = ValidarDni(nacionalidad, numero);
            }
            else
            {
              throw new DniInvalidoException("Se a ingresado algo que no es un numero");
            }

            return retorno;
        }

        /// <summary>
        /// Validara que dato sea una letra 
        /// </summary>
        /// <param name="dato"></param>
        /// <returns></returns>
        private static string ValidarNombreApellido(string dato)
        {
            bool esLetra;

            foreach(char c in dato)
            {
                esLetra=char.IsLetter(c);
                if(!esLetra)
                {
                    dato = "";
                    break;
                }
            }
            
            return dato;
        }
        /// <summary>
        /// retorna la info de la clase Persona
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return  this.apellido+" , " + this.nombre + "\nNacionalidad : "+this.nacionalidad.ToString();
        }

    }
}
