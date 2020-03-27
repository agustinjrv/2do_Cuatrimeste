using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_18.Entidades;

namespace Clase_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Carreta unaCarreta =new Carreta(100.50);

            Console.WriteLine("La carreta ");
            unaCarreta.MostrarPrecio();

            

            //Auto 

            Familiar f = new Familiar(15000, "ags 123", 4);
            Deportivo d = new Deportivo(50000, "dps 987", 2);
            Console.WriteLine();

            Console.WriteLine("Auto familiar :");
            f.MostrarPatente();
            f.MostrarPrecio();
            Console.WriteLine();

            Console.WriteLine("Auto Deportivo :");
            d.MostrarPatente();
            d.MostrarPrecio();
            

            //avion

            Privado p = new Privado(20000, 946, 5);
           
            p.MostrarPrecio();
            
            Console.Read();







        }
    }
}
