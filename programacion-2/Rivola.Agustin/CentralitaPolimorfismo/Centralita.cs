using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentralitaPolimorfismo;


namespace CentralitaPolimorfismo
{
    public class Centralita
    {
        private List <Llamada> _listaDeLlamadas =new List<Llamada>();
        protected string _razonSocial;

        public List<Llamada> Llamadas
        {
            get {return this._listaDeLlamadas; }
        }


        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            if(!(object.Equals(nuevaLlamada,null)))
            {
                this._listaDeLlamadas.Add(nuevaLlamada);
            }
        }

        public Centralita()
        {
            _razonSocial = "";
        }

        public Centralita(string nombreEmpresa)
        {
            this._razonSocial = nombreEmpresa;
        }
        
        public static bool operator ==(Centralita central,Llamada nuevaLlamada)
        {
            int tam = central._listaDeLlamadas.Count;
            bool retorno=false;

            for(int i=0;i<tam;i++)
            {
                if(central._listaDeLlamadas[i]==nuevaLlamada)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public static bool operator !=(Centralita central, Llamada nuevaLlamada)
        {
            return !(central == nuevaLlamada);
        }

        public static Centralita operator +(Centralita central,Llamada nuevaLlamada)
        {
            if(!(central==nuevaLlamada))
            {
                central.AgregarLlamada(nuevaLlamada);
            }
            else
            {
                Console.WriteLine("Esa llamada ya se encuentra en la central");
            }

            return central;
        }

        public override string ToString()
        {
            int tam = _listaDeLlamadas.Count;
            string cadena="";
            
            for(int i=0;i<tam;i++)
            {
                cadena += _listaDeLlamadas[i].ToString();
            }
            return cadena;
        }




    }
}
