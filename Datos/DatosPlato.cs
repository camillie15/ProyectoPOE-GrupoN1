using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosPlato
    {
        SqlCommand cmd = new SqlCommand();
        public string InsertPlato(Plato plato, SqlConnection conn)
        {
            Console.WriteLine("-----INSERT ACTIVIDAD-----");
            string x = "";
            string comando = "INSERT INTO Plato(nombre, descripcion, precio, estado)\n" +
                             "VALUES ('"+plato.Nombre+ "','"+plato.Descripcion+ "', '"+ Mett(plato.Precio)+ "','"+ plato.Estado+"'); \n";

            //Console.WriteLine(comando);
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = comando;
                cmd.ExecuteNonQuery();
                x = "1";
            }
            catch (SqlException ex)
            {
                x = "0" + ex.Message; Console.WriteLine(x);
            }
            return x;
        }
        public string Mett(double precio)
        {
            string precioStr = Convert.ToString(precio);
            return precioStr.Replace(',', '.');
        }

        public List<Plato> ConsultarPlato(SqlConnection conn)
        {
            List<Plato> lista = new List<Plato>();
            SqlDataReader dr = null;
            Plato plato = null;
            string comando = "SELECT * FROM Plato";
            cmd = new SqlCommand();
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = comando;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    plato = new Plato(0,"","",0,true);
                    plato.IdPlato = Convert.ToInt32(dr["idPlato"]);
                    plato.Nombre = dr["nombre"].ToString();
                    plato.Descripcion = dr["descripcion"].ToString();
                    plato.Precio = Convert.ToDouble(dr["precio"]);
                    plato.Estado = dr.GetBoolean(dr.GetOrdinal("estado"));
                    lista.Add(plato);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return lista;
        }
    }
}
