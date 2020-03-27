using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Centralita Telefonica = new Centralita();

            Local llamada_1 = new Local("burzaco",0.30f,"avellaneda",2.65f);
            Provincial llamada_2 = new Provincial("burzaco",Franja.Franja_1,0.21f,"cordoba");
            Local llamada_3 = new Local("longchamps", 0.45f,"temperley", 1.99f);
            Provincial llamada_4 = new Provincial(Franja.Franja_3,llamada_2);

            Console.WriteLine(Telefonica.ToString());

            Console.Read();

        }
    }
}
