using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_09";
            Console.ForegroundColor = ConsoleColor.Yellow;

            int i;
            int j;
            int tam;
            string piramide="*";

            do
            {
                Console.Write("Ingrese la altura de la piramide : ");

                tam = int.Parse(Console.ReadLine());

               

                if (tam <= 0)
                {
                    Console.WriteLine("Error,ingrese un numero entero positivo");
                }

            } while (tam <= 0);

            Console.WriteLine();

            for (i=1;i<tam;i++)
            {
                piramide += "\n*";
                for (j = 1; j < i + 2 ; j++)
                {
                    piramide += "*";
                }

            }

            Console.Write(piramide);

            Console.Read();
            

        }
    }
}
