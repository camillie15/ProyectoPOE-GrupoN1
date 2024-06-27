using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Conexion
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;

        private SqlConnection connection;

        public SqlConnection Connection { get => connection; set => connection = value; }

        public string Conectar()
        {
            try
            {
                connection = new SqlConnection();
                connection.ConnectionString = cadena;
                connection.Open();
                return "1";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "0" + ex.Message;
            }
        }

        public string Desconectar()
        {
            try
            {
                connection.Close();
                return "1";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "0" + ex.Message;
            }
        }
    }
}
