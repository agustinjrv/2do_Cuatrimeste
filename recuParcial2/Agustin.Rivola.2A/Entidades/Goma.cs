using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    
    //Goma-> soloLapiz:bool(publico); PreciosCuidados->true; 
    //Reutilizar UtilesToString en ToString() (mostrar todos los valores).
    //Sacapunta-> deMetal:bool(publico); 
    //Reutilizar UtilesToString en ToString() (mostrar todos los valores).
    public class Goma:Utiles
    {

        public bool soloLapiz;

        public Goma( bool soloLapiz,string marca, double precio) : base(marca, precio)
        {
            this.soloLapiz = soloLapiz;


        }

        public override bool PreciosCuidados
        {
            get { return true; }
        }


        public override string UtilesToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Goma");
            sb.AppendLine("solo Lapiz :" + this.soloLapiz.ToString());


            return  sb.ToString()+ base.UtilesToString();
        }
        public override string ToString()
        {
            return this.UtilesToString();
        }
    }
}
