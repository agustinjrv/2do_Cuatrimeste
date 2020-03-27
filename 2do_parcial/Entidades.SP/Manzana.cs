using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Entidades.SP
{


    //Crear las interfaces: 
    //ISerializar -> Xml(string):bool
    //IDeserializar -> Xml(string, out Fruta):bool
    //Implementar (implicitamente) ISerializar en Cajon y manzana
    //Implementar (explicitamente) IDeserializar en manzana
    //Los archivos .xml guardarlos en el escritorio del cliente
    public class Manzana : Fruta,ISerializar,IDeserializar
    {
        protected string _provinciaOrigen;

        public Manzana(string color, double peso,string provinciaOrigen) : base(color, peso)
        {
            this._provinciaOrigen = provinciaOrigen;
        }

        public Manzana()
        { 
        }

        public string Nombre
        {
            get { return "Manzana"; }
        }

        public string ProvinciaOrigen
        {
            get {return this._provinciaOrigen; }
            set { this._provinciaOrigen = value; }
        }

        public override bool TieneCarozo
        {
            get { return true; }
        }

        protected override string FrutaToString()
        {
            return this.Nombre+"\n"+base.FrutaToString()+"\nProvincia de origen :" + this._provinciaOrigen ;
        }
        public override string ToString()
        {
            return this.FrutaToString();
        }

        public bool Xml(string str)
        {
            bool retorno = false;

            try
            {

                XmlSerializer xml = new XmlSerializer(typeof(Manzana));
                TextWriter tw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\"+str);
                xml.Serialize(tw, this);
                retorno = true;
                tw.Close();
            }
            catch (Exception e)
            {

               
            }
            
            return retorno;
        }

        bool IDeserializar.Xml(string str, out Fruta unaFruta)
        {
            bool retorno = false;
            unaFruta = null;
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(Manzana));
                TextReader tr = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +"\\"+ str);
               
                unaFruta = (Manzana)xml.Deserialize(tr);
                tr.Close();
                retorno = true;
            }
            catch (Exception e)
            {

            }

            return retorno;
        }
    }
}
