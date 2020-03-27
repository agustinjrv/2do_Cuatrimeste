using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    
   
    //Métodos
    //ToString: Mostrará en formato de tipo string: 
    //el tipo de cartuchera, la capacidad, la cantidad actual de elementos, el precio total y el listado completo 
    //de todos los elementos contenidos en la misma. Reutilizar código.
    //Sobrecarga de operador
    //(+) Será el encargado de agregar elementos a la cartuchera siempre y cuando no supere la capacidad máxima de la misma.
    public class Cartuchera<T> where T :Utiles
    {

        public delegate void Precio(Cartuchera<T> c, EventArgs e);
        public event Precio EventoPrecio;


        protected int capacidad;
        protected List<T> elementos;


        public Cartuchera()
        {
            this.elementos = new List<T>();
        }

        public Cartuchera(int capacidad):this()
        {
            this.capacidad = capacidad;
        }

        public List<T> Elementos
        {
            get { return this.elementos; }
        }

        public double PrecioTotal
        {
            get 
            {
                double precioTotal = 0;

                foreach(T elemento in this.Elementos)
                {
                    precioTotal += elemento.precio; 
                }

                return precioTotal; 
            }
        }

        public override string ToString()
        {
           

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Tipo de Cartuchera :" + "yo que se");
            sb.AppendLine("Capacidad :" + this.capacidad.ToString());
            sb.AppendLine("Cantidad de elementos :" + this.Elementos.Count);
            sb.AppendLine("Precio Total :" + this.PrecioTotal);

            foreach(T elemento in this.Elementos)
            {
                sb.AppendLine(elemento.ToString());
            }

            return sb.ToString();
            
        }
        
        //Crear el manejador necesario para que, una vez capturado el evento, se imprima en un archivo de texto: 
        //la fecha (con hora, minutos y segundos) y el total de la cartuchera (en un nuevo renglón). 
        //Se deben acumular los mensajes. El archivo se guardará con el nombre tickets.log en la carpeta 'Mis documentos' del cliente.
        //El manejador de eventos (c_gomas_EventoPrecio) invocará al método (de clase) 
        //ImprimirTicket (se alojará en la clase Ticketeadora), que retorna un booleano indicando si se pudo escribir o no

        public static Cartuchera<T> operator +(Cartuchera<T> cartuchera, T elemento)
        {
            if(!(object.Equals(cartuchera,null)&& object.Equals(elemento,null)))
            {
                if (cartuchera.elementos.Count < cartuchera.capacidad)
                {
                    cartuchera.Elementos.Add(elemento);

                    if(cartuchera.PrecioTotal>85)
                    {
                        
                        cartuchera.EventoPrecio(cartuchera, new EventArgs());
                        
                    }

                }
                else
                {
                    throw new CartucheraLlenaException("Cartuchera llena,no se a podido agregar el elemento");
                }
            }

            return cartuchera;
        }


    }
}
