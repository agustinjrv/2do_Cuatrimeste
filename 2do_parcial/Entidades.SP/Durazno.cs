using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.SP
{

   
    //Durazno-> _cantPelusa:int (protegido); Nombre:string (prop. s/l, retornará 'Durazno'); 
    //Reutilizar FrutaToString en ToString() (mostrar todos los valores). TieneCarozo->true
    //Crear una instancia de cada clase e inicializar los atributos del form _manzana, _banana y _durazno. 
    public class Durazno:Fruta
    {
        protected int _cantPelusa;

        public Durazno()
        {
        }

        public Durazno(string color, double peso,int cantPelusa) : base(color, peso)
        {
            this._cantPelusa = cantPelusa;
        }

        public string Nombre
        {
            get { return "Durazno"; }
        }

        public override bool TieneCarozo
        {
            get { return true; }

        }

        public int CantPelusa
        {
            get { return this._cantPelusa; }
            set { this._cantPelusa = value; }
        }

        public override string ToString()
        {
            return this.FrutaToString();
        }

        protected override string FrutaToString()
        {
            return this.Nombre + "\n" + base.FrutaToString() + "\ncantidad de pelusa :" + this._cantPelusa.ToString();
        }




    }
}
