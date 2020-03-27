using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Entidades.SP
{

    //Agregar un método de extensión a la clase Cajon que:
    //Reciba como parámetro un entero (será usado como valor del campo ID)
    //Elimine de la base de datos la fruta cuyo ID coincida con el parámetro recibido
    //Retorne un booleano que indique: 
    //TRUE, si se ha eliminado la fruta. 
    //FALSE, si no se elimino.
    //Excepción, si se probocó algún error en la base de datos
    public static class Extencion
    {
        public static bool EliminarFruta(this Cajon<Manzana> cajon, int id)
        {
            bool retorno = false;
            int filas;

            using (SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexion))
            {
                SqlCommand cmd = new SqlCommand();
                conexion.Open();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = string.Format("DELETE FROM frutas where id={0} ", id);
                filas=cmd.ExecuteNonQuery();

                if(filas!=0)
                retorno = true;
            }
                        
            return retorno;

        }



    }
}
