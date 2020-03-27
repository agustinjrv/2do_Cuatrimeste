using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases_4.Entidades;

namespace Clase_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Cosa lala = new Cosa();
            DateTime fecha = new DateTime(2000, 09, 28);

            lala.EstablecerValor(5);

            lala.EstablecerValor("hola mundo");

            lala.EstablecerValor(fecha);

            
    
            Console.WriteLine(lala.Mostrar());


            Cosa lele = new Cosa("lele");

            Console.WriteLine(lele.Mostrar());

            Cosa lili = new Cosa("lili", (DateTime.Parse("01/01/2001")));

            Console.WriteLine(lili.Mostrar());

            Cosa lolo = new Cosa("lolo", (DateTime.Parse("02/02/2002")), 8);

            Console.WriteLine(lolo.Mostrar());





            Console.Read();

        }
    }
}
