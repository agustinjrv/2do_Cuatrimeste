using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    //Sacapunta-> deMetal:bool(publico); 
    //Reutilizar UtilesToString en ToString() (mostrar todos los valores).
    public class Sacapunta:Utiles
    {
        public bool deMetal;

        public Sacapunta( bool deMetal, double precio, string marca) : base(marca, precio)
        {
            this.deMetal = deMetal;
        }

        public override bool PreciosCuidados
        {
            get { return false; }
        }


        public override string UtilesToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Sacapunta:");
            sb.AppendLine("Es de metal :" +this.deMetal.ToString());

            return  sb.ToString()+ base.UtilesToString();
        }
        public override string ToString()
        {
            return this.UtilesToString();
        }
    }
}
