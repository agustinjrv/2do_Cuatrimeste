using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Clase_16
{
    class Program
    {
        static void Main(string[] args)
        {



            try
            {
                Metodo1();
            }
            catch(Exception e)
            {
                using (StreamWriter s = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory+"incidencias.log"))
                {
                    Console.WriteLine(e.StackTrace);
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.InnerException.Message);
                }
            }

            Console.Read();


            try
            {
                using (StreamWriter a = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+@"\incidencias.log"))
                {
                    a.WriteLine("hola mundo");
                    a.WriteLine(DateTime.Now);

                }
                //StreamWriter a = new StreamWriter(@"c:\miCarpeta\miArchivo.txt", true);


                //a.Close();
            }
            catch (DirectoryNotFoundException d)
            {
                Console.WriteLine(d.ToString());
            }
            catch (ArgumentException a)
            {
                Console.WriteLine(a.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.Read();
            }
            finally
            {
                Console.WriteLine("presione una tecla para salir");
                Console.ReadKey();
            }


            /*
                        try
                        {
                            using (StreamWriter a = new StreamWriter(@"p:\miCarpeta\miArchivo.txt"))
                            {
                                a.WriteLine("hola mundo");
                                a.WriteLine(DateTime.Now);

                            }
                            //StreamWriter a = new StreamWriter(@"c:\miCarpeta\miArchivo.txt", true);


                            //a.Close();
                        }
                        catch (DirectoryNotFoundException d)
                        {
                            Console.WriteLine(d.ToString());
                        }
                        catch (ArgumentException a)
                        {
                            Console.WriteLine(a.ToString());
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.ToString());
                            Console.Read();
                        }
                        finally
                        {
                            Console.WriteLine("presione una tecla para salir");                
                            Console.ReadKey();                
                        }

                        Metodo1();


                        */

            /*

             using (StreamReader b = new StreamReader(@"c:\miCarpeta\miArchivo.txt"))
             {
                 string linea;

                 while ((linea = b.ReadLine()) != null)
                 {
                     Console.WriteLine(linea);
                 }

                 Console.Read();
             }
             /*
                 string cadena = b.ReadToEnd();

                 Console.WriteLine(cadena);
                 Console.Read();
             */
        }


        public static void Metodo1()
        {
            try
            {
                Metodo2();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
            }
        }

        public static void Metodo2()
        {
            try
            {
                Metodo3();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.InnerException.Message);
                throw new Exception("error en metodo 2",e);
                
                //Console.WriteLine("estoy en metodo 2");
            }
        }
        public static void Metodo3()
        {
            try
            {
                Metodo4();
            }
            catch (DirectoryNotFoundException e)
            {

                Console.WriteLine(e.Message);
                Console.WriteLine(e.InnerException.Message);
                throw new Exception("error en metodo 3", e);

            }
        }
        public static void Metodo4()
        {
           
            Console.WriteLine("estoy en el metodo 4");
            throw new Metodo4Exception("todo mal");
            
        }


        
    }
}
