using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_19.Entidades
{
    public static class Serializador
    {

        public static bool Serializar(IXML ixml)
        {
            return ixml.Guardar(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Persona.xml"); ;
        }

        public static bool Deserializar(IXML ixml, out object obj)
        {
            return ixml.Leer(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Persona.xml", out obj); ;
        }
    }
}
