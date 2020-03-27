using System;

namespace clase_02.Entidades
{
    public class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;

        public static void CargarMensaje(string mensaje)
        {
            Sello.mensaje = mensaje;
        }

        public static string ImprimirMensaje()
        {
            Sello.color = ConsoleColor.White;

            return ArmarFormatoMensaje();
        }

        public static void BorrarMensaje()
        {
            Sello.mensaje = null;
        }

        public static string ImprimirEnColor()
        {
            Sello.color = ConsoleColor.Red;

            Console.ForegroundColor = color;

            return ArmarFormatoMensaje();
        }

        private static string ArmarFormatoMensaje()
        {
            if (Sello.mensaje != null)
            {

                int tam = Sello.mensaje.Length;
                int i;
                string techo = "*";

                for (i = 0; i < tam + 1; i++)
                {
                    techo += "*";
                }

                return techo + "\n*" + Sello.mensaje + "*\n" + techo;
            }
            else
            {
                return null;
            }


        }


    }
}
