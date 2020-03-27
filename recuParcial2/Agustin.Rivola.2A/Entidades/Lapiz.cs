using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;


namespace Entidades
{


    
    public class Lapiz:Utiles,ISerializa,IDeserializa
    {
        public enum ETipoTrazo { Fino,Grueso,Medio}
        

        public ConsoleColor color;
        public ETipoTrazo trazo;

        public override bool PreciosCuidados
        {
            get {return true; }
        }



        public string Path => throw new NotImplementedException();

        public Lapiz(ConsoleColor color, ETipoTrazo trazo,string marca, double precio) : base(marca, precio)
        {
            this.color = color;
            this.trazo = trazo;
        }

        public Lapiz():base()
        {

        }

        public override string UtilesToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Lapiz");
            sb.AppendLine("Color :" +this.color.ToString());
            sb.AppendLine("Trazo : " + this.trazo.ToString());

            return sb.ToString();
        }

        public override string ToString()
        {
            return   this.UtilesToString() + base.UtilesToString();

        }
        //Implementar (implícitamente) ISerializa lápiz
        //Implementar (explícitamente) IDeserializa en lápiz
        //El archivo .xml guardarlo en el escritorio del cliente con el nombre formado con su apellido.nombre.lapiz.xml
        //Ejemplo: Alumno Juan Pérez -> perez.juan.lapiz.xml,
        public bool Xml()
        {
            bool retorno = false;

            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(Lapiz));
                TextWriter tx = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+ "\\Rivola.Agustin.lapiz.xml");
                xml.Serialize(tx,this);
                tx.Close();
                retorno = true;
            }
            catch (Exception)
            {
                
            }

            return retorno;
            
        }

        bool IDeserializa.Xml(out Lapiz unLapiz)
        {
            bool retorno = false;
            unLapiz = null;

            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(Lapiz));
                TextReader tr = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Rivola.Agustin.lapiz.xml");
                unLapiz = (Lapiz)xml.Deserialize(tr);
                tr.Close();
                retorno = true;

            }
            catch (Exception)
            {
                
            }


            return retorno;
        }
    }
}
