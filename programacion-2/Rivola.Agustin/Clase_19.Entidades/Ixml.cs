﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_19.Entidades
{
    public interface IXML
    {
        bool Guardar(string str);

        bool Leer(string str, out object obj);

    }
}
