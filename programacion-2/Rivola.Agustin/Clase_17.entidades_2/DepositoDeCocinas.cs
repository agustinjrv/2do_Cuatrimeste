using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_17.entidades_2
{
    public class DepositoDeCocinas
    {
        /*

        private int _capacidadMaxima;
        private List<Cocina> _lista;

        public DepositoDeCocinas(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<Cocina>();
        }



        private int GetIndice(Cocina a)
        {
            int index = -1;

            for (int i = 0; i < this._lista.Count; i++)
            {
                if (this._lista[i] == a)
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        public static bool operator -(DepositoDeCocinas d, Cocina a)
        {
            bool retorno = false;
            int i = d.GetIndice(a);

            if (i != -1)
            {
                d._lista.RemoveAt(i);
            }

            return retorno;
        }

        public static bool operator +(DepositoDeCocinas d, Cocina a)
        {
            bool retorno = false;

            if (d._lista.Count < d._capacidadMaxima)
            {
                d._lista.Add(a);
                retorno = true;
            }
            return retorno;
        }

        public bool Agregar(Cocina a)
        {

            return (this + a);
        }

        public bool Remover(Cocina a)
        {
            return (this - a);
        }

        public override string ToString()
        {
            string cadena = "";

            cadena = "capacidad maxima : " + this._capacidadMaxima.ToString();
            foreach (Cocina a in this._lista)
            {
                cadena += "\n" + a.ToString();
            }


            return cadena;
        }


        */

    }
}
