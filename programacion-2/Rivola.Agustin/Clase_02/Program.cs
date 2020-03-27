using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clase_02.Entidades;

namespace Clase_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "clase_02(prueba)";

            string mensaje;

            Sello.CargarMensaje("hola mundo");

            mensaje = Sello.ImprimirMensaje();

            Console.WriteLine(mensaje);

            Sello.BorrarMensaje();

            mensaje = Sello.ImprimirMensaje();

            Sello.CargarMensaje("hola");

            mensaje = Sello.ImprimirEnColor();

            Console.WriteLine(mensaje);

            Console.Read();





            /*

            string nombre;
       
            

            MiClase.edad = 33;
            MiClase.nombre = "agustin";
            
            MiClase.MostrarEdad();

            nombre= MiClase.retornarNombre();

            Console.Write("el nombre es : {0}\n", MiClase.nombre);


            MiLibreria.MiClase.nombre = "roberto";
            nombre = MiLibreria.MiClase.RetornarNombre();

            Console.Write("el nombre es : {0}\n", MiLibreria.MiClase.nombre);*/





        }
    }
}
