using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_25.Entidades;

namespace Clase_25.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Empleado unEmpleado = new Empleado("juan","perez",123);
            // unEmpleado.limiteSueldo += Empleado_LimiteSueldo;
            //unEmpleado.limiteSueldo += new LimiteSueldoDelegado(Empleado_LimiteSueldo);
            unEmpleado.limiteSueldo += new LimiteSueldoDelegado(p.ManejadorLimiteSueldo);
            unEmpleado.sueldoMejorado += new LimiteSueldoMejorado(Empleado_SueldoMejorado);
            unEmpleado.sueldoMejorado += new LimiteSueldoMejorado(ManejadorLimiteSueldoMejorado);
            unEmpleado.sueldoMejorado += new LimiteSueldoMejorado(p.ManejadorLimiteSueldoMejorado2);

            unEmpleado.Sueldo = 33000;
            
          //  Console.WriteLine(unEmpleado.ToString());

            Console.Read();


        }

        public static void Empleado_LimiteSueldo(double sueldo, Empleado emp)
        {
            Console.WriteLine("sueldo pedido :{0}" , sueldo);
            Console.WriteLine(emp.ToString());

        }

        public static void Empleado_SueldoMejorado(Empleado emp, EmpleadoEventArgs e)
        {
            Console.WriteLine(emp.ToString());
        }

        public void ManejadorLimiteSueldo(double e ,Empleado emp)
        {
            Console.WriteLine(emp.ToString() + " Limite sueldo :" +e.ToString());
        }
        public static void ManejadorLimiteSueldoMejorado(Empleado emp, EmpleadoEventArgs e)
        {
            Console.WriteLine(emp.ToString() + " Limite sueldo mejorado: " + e.SueldoAsignar);
        }
        public void ManejadorLimiteSueldoMejorado2(Empleado emp, EmpleadoEventArgs e)
        {
            Console.WriteLine(emp.ToString() + " Limite sueldo mejorado2 :" + e.SueldoAsignar);
        }

    }
}
