using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.SP
{



    //Banana-> _paisOrigen:string (protegido); Nombre:string (prop. s/l, retornará 'Banana'); 
    //Reutilizar FrutaToString en ToString() (mostrar todos los valores). TieneCarozo->false
    //Durazno-> _cantPelusa:int (protegido); Nombre:string (prop. s/l, retornará 'Durazno'); 
    //Reutilizar FrutaToString en ToString() (mostrar todos los valores). TieneCarozo->true
    //Crear una instancia de cada clase e inicializar los atributos del form _manzana, _banana y _durazno. 
    public class Banana:Fruta
    {

        protected string _paisOrigen;

        public Banana()
        {
        }

        public Banana(string color, double peso,string paisOrigen) : base(color, peso)
        {
            this._paisOrigen = paisOrigen;

        }

        public string Nombre
        {
            get { return "Banana"; }
        }

        public override bool TieneCarozo
        {
            get { return false; }
        }

        public string PaisOrigen
        {
            get { return this._paisOrigen; }
            set { this._paisOrigen = value; }
        }

        public override string ToString()
        {
            return this.FrutaToString();
        }

        protected override string FrutaToString()
        {
            return this.Nombre + "\n" +base.FrutaToString() + "\nPais de origen :" + this._paisOrigen;
        }


    }
}
