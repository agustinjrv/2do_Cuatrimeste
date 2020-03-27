using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_19.Entidades;
using System.Xml.Serialization;
using System.Xml;
using System.IO;


namespace Clase_19.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona("juan", "perez",25);
            List<Persona> listaPersonas = new List<Persona>();
        //    p.Apodos.Add("lololo");
        //    p.Apodos.Add("lululu");
        //    p.Apodos.Add("dadada");

            Persona p2 = new Persona("marcos", "gonzales",30);
         //   p2.Apodos.Add("lalla");

 
            Empleado e = new Empleado("jazmin", "siles", 50, 333, 10000.50);
         //   e.Apodos.Add("oloa");
            Empleado e2 = new Empleado("florencia", "araya", 50, 333, 10000.50);
          //  e2.Apodos.Add("lili");

            Alumno a = new Alumno("esteban", "yanten", 19, 8);
           // a.Apodos.Add("rata3");
            Alumno a2 = new Alumno("paula", "sosa", 19, 6);
           // a.Apodos.Add("rata4");

            listaPersonas.Add(p);
            listaPersonas.Add(p2);
            listaPersonas.Add(e);
            listaPersonas.Add(e2);
            listaPersonas.Add(a);
            listaPersonas.Add(a2);

            try
            {
                XmlSerializer xmls = new XmlSerializer(typeof(List<Persona>));
                TextWriter archivo = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\listaPersonas.xml");

                xmls.Serialize(archivo, listaPersonas);

                archivo.Close();
            }
            catch (Exception exepcion)
            {
                Console.WriteLine(exepcion);
            }


            
            try
            {
                XmlSerializer xmls = new XmlSerializer(typeof(List<Persona>));
                TextReader archivo = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\listaPersonas.xml");

                List<Persona> listaPersonas2 = (List<Persona>)xmls.Deserialize(archivo);

                foreach (Persona t in listaPersonas2)
                {
                    Console.WriteLine(t.ToString());
                }

            }
            catch (Exception exepcion)
            {
                Console.WriteLine(exepcion);
            }

            
            Console.Read();
            /*


            Console.WriteLine(p.ToString());

            try
            {
                XmlSerializer a = new XmlSerializer(typeof(Persona));
                //XmlTextWriter b = new XmlTextWriter();

                TextWriter archivo = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Persona.xml");
                // StreamWriter archivo=new StreamWriter(Environment.SpecialFolder.Desktop+ @"\Persona.xml");
                a.Serialize(archivo, p);
                archivo.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }

            Console.Read();

            try
            {
                XmlSerializer a = new XmlSerializer(typeof(Persona));
                TextReader archivo = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Persona.xml");

                Persona obj= (Persona)a.Deserialize(archivo);

                Console.WriteLine(obj.ToString());

            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }

            Console.Read();

            try
            {
                XmlSerializer a = new XmlSerializer(typeof (List<Persona>));
                //XmlTextWriter b = new XmlTextWriter();

                TextWriter archivo = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\listaPersonas.xml");
                // StreamWriter archivo=new StreamWriter(Environment.SpecialFolder.Desktop+ @"\Persona.xml");

                a.Serialize(archivo, listaPersonas);

                archivo.Close();
            }
            catch(Exception e)
            {

            }

            try
            {
                XmlSerializer a = new XmlSerializer(typeof(List<Persona>));
                TextReader archivo = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\listaPersonas.xml");

                List<Persona> listaPersonas2 = (List<Persona>)a.Deserialize(archivo);

                foreach(Persona t in listaPersonas2)
                {
                    Console.WriteLine(t.ToString());
                }





            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.Read();


            try
            {
                Auto a = new Auto("fgh 123",100000);

                Serializador.Serializar(a);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

            }

            try
            {
                Auto b = new Auto();
                object o;

                Serializador.Deserializar(b, out o);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

            }
            Console.Read();

            */






        }
    }
}
