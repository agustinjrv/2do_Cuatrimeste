using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Entidades
{
    public static class PaqueteDAO
    {
        private static SqlCommand comando;
        private static SqlConnection conexion;
        


        /// <summary>
        /// inicializa los atributos
        /// </summary>
        static PaqueteDAO()
        {
            comando = new SqlCommand();
            conexion = new SqlConnection(Properties.Settings.Default.Conexion);
        }
        /// <summary>
        /// Inserta en la base de datos un paquete
        /// </summary>
        /// <param name="p">Paquete a insertar en la base de datos</param>
        /// <returns>retorna true si se pudo guardar</returns>
        public static bool Insertar(Paquete p)
        {
            bool retorno = false;
            StringBuilder sb = new StringBuilder();
            try
            {
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                sb.AppendFormat("INSERT INTO Paquetes(direccionEntrega,trackingID,alumno) values('{0}','{1}','{2}')", p.DireccionEntrega, p.TrackingID, "Agustin.Rivola.2A");
                comando.CommandText = sb.ToString();

                comando.ExecuteNonQuery();
                retorno = true;
                
            }
            catch(Exception e)
            {
                 throw e;
            }
            finally
            {
                conexion.Close();
            }

            return retorno; 
        }




    }
}
