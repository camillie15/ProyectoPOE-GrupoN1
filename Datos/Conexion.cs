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

        private SqlConnection cn;

        public SqlConnection Cn { get => cn; set => cn = value; }

        public string Conectar()
        {
            try
            {
                cn = new SqlConnection();
                cn.ConnectionString = cadena;
                cn.Open();
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
                cn.Close();
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
