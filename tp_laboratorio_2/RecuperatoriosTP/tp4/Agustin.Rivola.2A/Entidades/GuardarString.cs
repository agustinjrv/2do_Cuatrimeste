using System;
using System.IO;
namespace Entidades
{
    public static class GuardarString
    {

        /// <summary>
        /// Extension de string para guardar un archivo de texto
        /// </summary>
        /// <param name="texto">texto a guardar</param>
        /// <param name="archivo">nombre del archivo</param>
        /// <returns>retorna true si se pudo guardar</returns>
        public static bool Guardar(this string texto, string archivo)
        {
            bool retorno = false;
            try
            {
                TextWriter sw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + archivo + ".txt", true);
                sw.WriteLine(texto);
                sw.Close();
                retorno = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return retorno;
        }




    }
}
