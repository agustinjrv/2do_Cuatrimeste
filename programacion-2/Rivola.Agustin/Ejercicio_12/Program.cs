using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            bool continuar = false; ;
            char c='a';
                ConsoleKeyInfo a;

            do
            {
                Console.Write("ingrese una letra : ");
                a =Console.ReadKey();
                c =a.KeyChar;

                Console.WriteLine();
                Console.WriteLine("la letra ingresada es {0}", c);
                Console.WriteLine();

                Console.Write("Desea Continuar(s/n)?", c);
                a = Console.ReadKey();
                c = a.KeyChar;
                Console.WriteLine();
                while (c != 's' && c != 'n')
                {
                    
                    Console.WriteLine("error,Desea Continuar(s/n)?", c);
                    a = Console.ReadKey();
                    c = a.KeyChar;
                }

                continuar = ValidaS_N(char.ToLower(c));
            } while (continuar);

        }

        public static bool ValidaS_N(char c)
        {
            bool retorno = false;

            if(c=='s')
            {
                retorno = true;
            }
            return retorno;
        }





    }
}
