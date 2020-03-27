using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto :Vehiculo
    {
        public ECilindrada cilindrada;


        public Moto(string marca,EPais pais,string modelo,float precio,ECilindrada cilindrada) : base(marca,pais,modelo,precio)
        {
            this.cilindrada = cilindrada;
        }

        public static bool operator ==(Moto a, Moto b)
        {
            bool retorno = false;

            if (a.cilindrada==b.cilindrada && a==b)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Moto a, Moto b)
        {
            return !(a == b);
        }

        public static implicit operator Single(Moto m)
        {
            return m.precio;
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;

            if (obj is Moto)
            {
                if (obj == this)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        public override string ToString()
        {
            return base.ToString() + "\nTipo :" + this.cilindrada.ToString();
        }




    }
}
