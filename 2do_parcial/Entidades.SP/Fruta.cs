using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.SP
{
    public abstract class Fruta
    {
        //Crear la siguiente jerarquía de clases:
        //Fruta-> _color:string y _peso:double (protegidos); TieneCarozo:bool (prop. s/l, abstracta);
        //constructor con 2 parametros y FrutaToString():string (protegido y virtual, retorna los valores de la fruta)
        //Manzana-> _provinciaOrigen:string (protegido); Nombre:string (prop. s/l, retornará 'Manzana'); 
        //Reutilizar FrutaToString en ToString() (mostrar todos los valores). TieneCarozo->true
        //Banana-> _paisOrigen:string (protegido); Nombre:string (prop. s/l, retornará 'Banana'); 
        //Reutilizar FrutaToString en ToString() (mostrar todos los valores). TieneCarozo->false
        //Durazno-> _cantPelusa:int (protegido); Nombre:string (prop. s/l, retornará 'Durazno'); 
        //Reutilizar FrutaToString en ToString() (mostrar todos los valores). TieneCarozo->true
        //Crear una instancia de cada clase e inicializar los atributos del form _manzana, _banana y _durazno. 

        protected string _color;
        protected double _peso;


        public abstract bool TieneCarozo { get; }

        public string Color
        {
            get { return this._color; }
            set { this._color = value; }

        }
        public double Peso
        {
            get { return this._peso; }
            set { this._peso = value; }
        }
        public Fruta()
        {

        }
        public Fruta(string color,double peso)
        {
            this._color = color;
            this._peso = peso;
        }

      

        protected virtual string FrutaToString()
        {
            return String.Format("Color : {0}\nPeso:{1}", this._color, this._peso);
        }







    }
}
