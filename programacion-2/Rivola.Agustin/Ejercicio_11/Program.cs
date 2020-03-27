using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_11;

namespace Ejercicio_11
{
    public class Program
    {
        static void Main()
        {
            Console.Title = "Ejercicio_11";

            int min=105;
            int max=-1;
            double acumulador=0;
            double promedio;
            int numero;

            int i;
            for(i=0;i<5;i++)
            {
                Console.WriteLine("Ingrese un numero : ");
                numero = int.Parse(Console.ReadLine());

                if(Validacion.Validar(numero,0,100))
                {
                    if(numero<min)
                    {
                        min = numero;
                    }
                    if(numero>max)
                    {
                        max = numero;
                    }
                    acumulador += numero;
                }
            }

            promedio =acumulador / i;

            Console.WriteLine("Datos ingresados : ");
            Console.WriteLine("Max : {0}\nMin: {1}\nPromedio : {2}",max,min,promedio);

            Console.Read();
        }
    }
}
