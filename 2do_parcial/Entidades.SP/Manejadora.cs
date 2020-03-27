using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades.SP
{//Si el precio total del cajon supera los 55 pesos, se disparará el evento EventoPrecio. 
 //Diseñarlo (de acuerdo a las convenciones vistas) en la clase cajon. 
 //Crear el manejador necesario para que se imprima en un archivo de texto: 
 //la fecha (con hora, minutos y segundos) y el total del precio del cajón en un nuevo renglón.
    public class Manejadora<T> where T: Fruta
    {
        public static void EventoPrecio(object o ,EventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\archivo.txt",true);
                sw.WriteLine(DateTime.Now);
                sw.WriteLine("Precio Total :$"+((Cajon<T>)o).PrecioTotal.ToString());
                sw.Close();
            }
            catch (Exception)
            {
            }
            
        }
    }
}
