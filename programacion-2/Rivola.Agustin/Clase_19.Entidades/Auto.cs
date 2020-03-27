using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace Clase_19.Entidades
{
    public class Auto : IXML
    {
        public string marca;
        public double precio;

        public Auto(string marca, double precio) : this()
        {
            this.marca = marca;
            this.precio = precio;
        }

        public Auto()
        {
            this.marca = "";
            this.precio = 0;
        }

        public override string ToString()
        {
            return "marca : " + this.marca + "\n Precio :" + this.precio.ToString();
        }

        public bool Guardar(string str)
        {
            bool retorno = false;

            try
            {
                XmlSerializer a = new XmlSerializer(typeof(Auto));
                TextWriter archivo = new StreamWriter(str);

                a.Serialize(archivo, this);
                retorno = true;
                archivo.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return retorno;
        }

        public bool Leer(string str, out object obj)
        {
            obj = null;
            bool retorno = false;

            try
            {
                XmlSerializer a = new XmlSerializer(typeof(Auto));
                TextReader archivo = new StreamReader(str);

                obj = (Auto)a.Deserialize(archivo);
                retorno = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

            }
            return retorno;
        }
    }
}
