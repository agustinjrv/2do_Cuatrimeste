using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Externa.Sellada;
using System.IO;
using System.Data.SqlClient;
using System.Data;


namespace Clase_26
{
   public static class Extensora
   {
        public static string ObtenerInfo(this PersonaExternaSellada p)
        {
            return p.Nombre + "\n"+p.Apellido + "\n" + p.Edad.ToString() + "\n" + p.Sexo;
        }

        public static bool EsNulo(this object p)
        {
            return false;
        }

        public static List<Persona> ObtenerListadoBD(this object p)
        {

                List<Persona> lista = new List<Persona>();
            try
            {
                SqlConnection sql = new SqlConnection();
                sql.ConnectionString = Properties.Settings.Default.Conexion;
                sql.Open();
                SqlCommand s = new SqlCommand();
                s.Connection = sql;
                s.CommandType = CommandType.Text;
                s.CommandText = "Select * FROM Personas";
                SqlDataReader sqlRead = s.ExecuteReader();

                while (sqlRead.Read() != false)
                {
                    object id = sqlRead[0];
                    object nombre = sqlRead[1];
                    object apellido = sqlRead[2];
                    object edad = sqlRead[3];

                    Persona nuevaPersona = new Persona(nombre.ToString(), apellido.ToString(), int.Parse(edad.ToString()));
                    lista.Add(nuevaPersona);
                }
                sqlRead.Close();
                s.Connection.Close();
                sql.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                
            }
            


            return lista;
        }


   }
}
