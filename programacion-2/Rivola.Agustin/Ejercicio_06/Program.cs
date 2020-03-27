using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_06";
            Console.ForegroundColor = ConsoleColor.Green;

            int i;
            int numero;
            Console.WriteLine("Ingrese año de inicio :");
            i=int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese año de conclucion :");
            numero = int.Parse(Console.ReadLine());

            for(i=i; i<=numero;i++)
            {
                if (i % 4 == 0 && (i%100!=0 || i%400==0))
                {
                    Console.WriteLine("El año {0} es bisiesto", i);
                }
            }

            Console.Read();


        }
    }
}
