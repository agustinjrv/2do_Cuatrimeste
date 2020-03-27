using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_08.Entidades
{
    public class Capitulo
    {
        private int numero;
        private string titulo;
        private int paginas;
        private static Random generadorDeNumeros;
        private static Random generadorDePaginas;

        public int Numero
        {
            get
            {
                
                return this.numero;
            }
        }

        public string Titulo
        {
            get
            {
                return this.titulo;
            }
        }

        public int Paginas
        {
            get
            {
                return this.paginas;
            }
        }

        static Capitulo()
        {
            Capitulo.generadorDeNumeros = new Random();
            Capitulo.generadorDePaginas = new Random();
        }

        private Capitulo(int numero, string titulo, int paginas)
        {
            this.numero = numero;
            this.titulo = titulo;
            this.paginas = paginas;
        }

        public static implicit operator Capitulo(string str)
        {
            Capitulo a = new Capitulo(Capitulo.generadorDeNumeros.Next(1, 65), str, Capitulo.generadorDePaginas.Next(15, 234));

            return a;
        }
        public static bool operator ==(Capitulo uno, Capitulo dos)
        {
            bool retorno = false;

            if(!object.Equals(uno,null) && !object.Equals(dos,null))
            {
                if (uno.numero == dos.numero && uno.paginas == dos.paginas && uno.titulo == dos.titulo)
                {
                    retorno = true;
                }
            }
         

            return retorno;

        }

        public static bool operator !=(Capitulo uno, Capitulo dos)
        {
            return !(uno == dos);
        }



    }

    



    

}
