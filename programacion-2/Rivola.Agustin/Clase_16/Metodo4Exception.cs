using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_16
{
    class Metodo4Exception:Exception
    {
        public Metodo4Exception(string mensaje):base(mensaje)
        {

        }

        public Metodo4Exception(string mensaje,Exception e) : base(mensaje,e)
        {

        }

    }
}
