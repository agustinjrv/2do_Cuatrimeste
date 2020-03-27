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


        public string Apellido
        {
            get {return this.apellido; }
            set
            {
                this.apellido = ValidarNombreApellido(value);
            }
        }
        public int DNI
        {
            get { return this.dni; }
            set { this.dni = ValidarDni(this.nacionalidad, value); }
        }
        public ENacionalidad Nacionalidad
        {
            get { return this.nacionalidad; }
            set { this.nacionalidad = value; }
        }
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = ValidarNombreApellido(value); }
        }
        public string StringToDNI
        {
            set { this.dni =ValidarDni(this.nacionalidad,value); }
        }

        public Persona()
        {
        }
        public Persona(string nombre,string apellido,ENacionalidad nacionalidad):this()
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;
        }

        public Persona(string nombre, string apellido,int dni, ENacionalidad nacionalidad):this(nombre,apellido,nacionalidad)
        {
            this.DNI = dni;
        }

        public Persona(string nombre, string apellido,string dni ,ENacionalidad nacionalidad):this(nombre,apellido,nacionalidad)
        {
            this.StringToDNI = dni;
        }

        private static int ValidarDni(ENacionalidad nacionalidad,int dato)
        {
            int retorno=-1;

            try
            {
                if (nacionalidad == ENacionalidad.Argentino)
                {
                    if (dato > 0 && dato < 90000000)
                    {
                        retorno = dato;
                    }
                    else
                    {
                        throw new NacionalidadInvalidaException("La nacionalidad Argentina solo puede tener un numero de DNi entre 1 y 89999999");
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
                        throw new NacionalidadInvalidaException("La nacionalidad extranjera solo puede tener un numero de DNi entre 90000000 y 99999999"); 
                    }
                }
                
            }
            catch(NacionalidadInvalidaException n)
            {
                Console.WriteLine(n);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }

            return retorno;
        }

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

        public override string ToString()
        {
            return "POR NOMBRE COMPLETO :" + this.apellido+" , " + this.nombre + "\nNacionalidad : "+this.nacionalidad.ToString();
        }

    }
}
