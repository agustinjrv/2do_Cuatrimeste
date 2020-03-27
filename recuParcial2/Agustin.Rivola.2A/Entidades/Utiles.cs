using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //Crear la siguiente jerarquía de clases:
    //Utiles-> marca:string y precio:double (publicos); PreciosCuidados:bool (prop. s/l, abstracta);
    //constructor con 2 parametros y UtilesToString():string (protegido y virtual, retorna los valores del útil)
    //ToString():string (polimorfismo; reutilizar código)
    //Lapiz-> color:ConsoleColor(publico); trazo:ETipoTrazo(enum {Fino, Grueso, Medio}; publico); PreciosCuidados->true; 
    //Reutilizar UtilesToString en ToString() (mostrar todos los valores).
    //Goma-> soloLapiz:bool(publico); PreciosCuidados->true; 
    //Reutilizar UtilesToString en ToString() (mostrar todos los valores).
    //Sacapunta-> deMetal:bool(publico); 
    //Reutilizar UtilesToString en ToString() (mostrar todos los valores).
    public abstract class Utiles
    {
        public string marca;
        public double precio;

        protected Utiles(string marca, double precio)
        {
            this.marca = marca;
            this.precio = precio;
        }
        public Utiles()
        {

        }


        public abstract bool PreciosCuidados { get; }

        public virtual string UtilesToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Marca :"+ this.marca);
            sb.AppendLine("Precio :" + this.precio.ToString());


            return sb.ToString();

        }

        public override string ToString()
        {
            return this.UtilesToString();
        }
    }
}
