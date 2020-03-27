using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona unaPersona = new Persona("Agustin","Rivola",42432112);

            Console.WriteLine(unaPersona.Mostrar());

            Persona otraPersona = new Persona("Pepito", "Gonzales", 55221133);

            Console.WriteLine(otraPersona.Mostrar());

            Console.ReadLine();







        }
    }
}
