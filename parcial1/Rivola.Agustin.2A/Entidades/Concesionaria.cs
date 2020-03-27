using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Concesionaria
    {
        private int capacidad;
        private List<Vehiculo> vehiculos;

        public double PrecioDeAutos
        {
            get {
                    return ObtenerPrecio(EVehiculo.PrecioDeAutos);
                }

        }
        public double PrecioMotos
        {
            get { return ObtenerPrecio(EVehiculo.PrecioDeMotos); }

        }
        public double PrecioTotal
        {
            get { return ObtenerPrecio(EVehiculo.PrecioTotal); }
        }


        private Concesionaria()
        {
            this.vehiculos = new List<Vehiculo>();
            this.capacidad = 0;
        }
        private Concesionaria(int capacidad):base()
        {
            this.vehiculos = new List<Vehiculo>(capacidad);
            this.capacidad = capacidad;
            
        }

        public static string Mostrar(Concesionaria c)
        {
            string cadena="Capacidad :"+ c.capacidad.ToString() + "\nPrecio de autos : "+c.PrecioDeAutos.ToString()+"\nPrecio de motos : " +c.PrecioMotos.ToString() +"\nPrecio Total :"+ c.PrecioTotal.ToString()+"\n";

            foreach(Vehiculo v in c.vehiculos)
            {
                cadena+=v.ToString()+"\n";
            }

            return cadena;
        }

        public static implicit operator Concesionaria(int capacidad)
        {
            return new Concesionaria(capacidad);
        }

        public static bool operator ==(Concesionaria c, Vehiculo v)
        {
            bool retorno = false;

            foreach(Vehiculo a in c.vehiculos)
            {
                if(a.Equals(v))
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        public static bool operator !=(Concesionaria c, Vehiculo v)
        {
            return !(c == v);
        }

        public static Concesionaria operator +(Concesionaria c, Vehiculo v)
        {

            if(c.vehiculos.Count<c.capacidad)
            {
                if(c!=v)
                {
                    c.vehiculos.Add(v);
                }
                else
                {
                    Console.WriteLine("ese vehiculo ya esta en la conceiconaria");

                }
            }
            else
            {
                Console.WriteLine("No hay espacio en la concecionaria");
            }

            return c;
        }

        public double ObtenerPrecio(EVehiculo tipovehiculo)
        {
            double precio=0;

            switch(tipovehiculo)
            {
                case EVehiculo.PrecioDeAutos:
                    
                    foreach(Vehiculo a in this.vehiculos)
                    {
                        if(a is Auto)
                        {
                            precio += (Single)(Auto)a;
                        }
                    }
                    break;
                case EVehiculo.PrecioDeMotos:
                    foreach (Vehiculo m in this.vehiculos)
                    {
                        if(m is Moto)
                        {
                            precio += (Moto)m;
                        }
                    }

                    break;
                case EVehiculo.PrecioTotal:
                    foreach (Vehiculo a in this.vehiculos)
                    {
                        if (a is Auto)
                        {
                            precio += (Single)(Auto)a;
                        }
                    }
                    foreach (Vehiculo m in this.vehiculos)
                    {
                        if (m is Moto)
                        {
                            precio += (Moto)m;
                        }
                    }

                    break;

            }
            return precio;
        }











    }
}
