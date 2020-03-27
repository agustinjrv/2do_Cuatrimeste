﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Externa;

namespace Clase_26
{
    public class PersonaExt : PersonaExterna
    {
        public PersonaExt(string nombre, string apellido, int edad, ESexo sexo) : base(nombre, apellido, edad, sexo)
        {


        }

        public string Nombre
        {
            get { return base._nombre; }
            set { base._nombre=value; }
        }

        public string Apellido
        {
            get { return base._apellido; }
            set { base._apellido = value; }
        }
        public int Edad
        {
            get { return base._edad; }
            set { base._edad = value; }
        }
        public ESexo Sexo
        {
            get { return base._sexo; }
            set { base._sexo = value; }
        }

    }
}
