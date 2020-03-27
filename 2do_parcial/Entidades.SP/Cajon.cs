using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades.SP
{


    //Crear las interfaces: 
    //ISerializar -> Xml(string):bool
    //IDeserializar -> Xml(string, out Fruta):bool
    //Implementar (implicitamente) ISerializar en Cajon y manzana
    //Implementar (explicitamente) IDeserializar en manzana
    //Los archivos .xml guardarlos en el escritorio del cliente
    public class Cajon<T>:ISerializar
    {
        protected int _capacidad;
        protected List<T> _elementos;
        protected double _precioUnitario;
        public delegate void Precio(Cajon<T> cajon, EventArgs e);
        public event Precio EventoPrecio;

        public Cajon()
        {
            this._elementos = new List<T>();
        }

        public Cajon(int capacidad):this()
        {
            this._capacidad = capacidad;
        }

        public Cajon( double precioUnitario,int capacidad) :this(capacidad)
        {
            this._capacidad = capacidad;
            this._precioUnitario = precioUnitario;
        }

        public List<T> Elementos
        {
            get { return this._elementos; }
        }

        public double PrecioUnitario
        {
            get { return this._precioUnitario; }
            set { this._precioUnitario = value; }
        }
        public int Capacidad
        {
            get { return this._capacidad; }
            set { this._capacidad = value; }
        }


        public double PrecioTotal
        {
            get { return this._precioUnitario*this.Elementos.Count; }
        }

        public override string ToString()
        {
         
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Capacidad :" + this._capacidad);
            sb.AppendLine("Cantidad de elementos :" + this.Elementos.Count);
            sb.AppendLine("Precio Total :" + this.PrecioTotal);

            foreach (T elemento in this.Elementos)
            {
                sb.AppendLine(elemento.ToString());
            }

            return sb.ToString();
        }

        
        public static Cajon<T> operator +(Cajon<T> c, T e)
        {
            
            if(!(object.Equals(c,null)&& object.Equals(e,null)))
            {
                if (c.Elementos.Count < c._capacidad)
                {
                    c.Elementos.Add(e);

                    if (c.PrecioTotal > 55)
                        c.EventoPrecio(c, new EventArgs());
                }
                else
                {
                    throw new CajonLlenoException("cajon lleno ,no se pueden agregar mas elementos");
                }
            }
            
           

            return c;
        }

        public bool Xml(string str)
        {
            bool retorno = false;
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(Cajon<T>));
                TextWriter tx = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +"\\"+ str);
                xml.Serialize(tx, this);
                tx.Close();
                retorno = true;
            }
            catch (Exception)
            {

            }
            return retorno;
        }


    }
}
