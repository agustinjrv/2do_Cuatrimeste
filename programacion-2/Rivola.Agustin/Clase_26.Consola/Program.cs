using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_26;
using Entidades.Externa;
using Entidades.Externa.Sellada;

namespace Clase_26.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona unaPersona = new Persona("carlos", "gonzales", 33);

            Console.WriteLine("con propiedades");
            Console.WriteLine(unaPersona.Nombre);
            Console.WriteLine(unaPersona.Apellido);
            Console.WriteLine(unaPersona.DNI);

            Console.WriteLine("------------------------------");

            Console.WriteLine("con metodos");
            Console.WriteLine(unaPersona.GetNombre());
            Console.WriteLine(unaPersona.GetApellido());
            Console.WriteLine(unaPersona.GetDNI());

            Console.WriteLine("------------------------------");
            Console.WriteLine("Con un solo metodo");
            Console.WriteLine(unaPersona.ObtenerInfo());

            Console.WriteLine("------------------------------");

            Console.WriteLine("Persona externa");
            PersonaExt unaPersonaExt = new PersonaExt("agustin","Rivola",20,Entidades.Externa.ESexo.Masculino);



            Console.WriteLine(unaPersonaExt.Nombre);
            Console.WriteLine(unaPersonaExt.Apellido);
            Console.WriteLine(unaPersonaExt.Edad);

            Console.WriteLine("------------------------------");

            PersonaExternaSellada pExternaSellada = new PersonaExternaSellada("juan","perez",50,Entidades.Externa.Sellada.ESexo.Masculino);
            Console.WriteLine(pExternaSellada.ObtenerInfo());
            pExternaSellada.EsNulo();

            List<Persona>listaPersonas=unaPersona.ObtenerListadoBD();

            Console.WriteLine("------------------------------");
            foreach (Persona p in listaPersonas)
            {

                Console.WriteLine(p.ObtenerInfo());
                Console.WriteLine("------------------------------");
            }



            Console.Read();


        }
    }
}
