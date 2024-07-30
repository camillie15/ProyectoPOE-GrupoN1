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
            string comando = "INSERT INTO Plato(nombre, descripcion, precio, estado, estadoLogico)\n" +
                             "VALUES ('" + plato.Nombre + "','" + plato.Descripcion + "', '" + Mett(plato.Precio) + "','" + plato.Estado + "','" + plato.EstadoLogico + "' ); \n";

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
                    plato = new Plato(
                        Convert.ToInt32(dr["idPlato"]),
                        dr["nombre"].ToString().TrimEnd(),
                        dr["descripcion"].ToString().TrimEnd(),
                        Convert.ToDouble(dr["precio"]),
                        Convert.ToInt32(dr["estado"]) == 1 ? true : false,
                        Convert.ToInt32(dr["estadoLogico"]) == 1 ? true : false
                    );
                    lista.Add(plato);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return lista;
        }

        public List<Plato> ConsultarPlatosEliminados(SqlConnection conn)
        {
            List<Plato> lista = new List<Plato>();
            SqlDataReader dr = null;
            string comando = "SELECT * FROM Plato WHERE estadoLogico = 0";

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = comando;
               
                dr = cmd.ExecuteReader();              
                while (dr.Read())
                {
                        Plato plato = new Plato(
                        Convert.ToInt32(dr["idPlato"]),
                        dr["nombre"].ToString().TrimEnd(),
                        dr["descripcion"].ToString().TrimEnd(),
                        Convert.ToDouble(dr["precio"]),
                        Convert.ToInt32(dr["estado"]) == 1,
                        Convert.ToInt32(dr["estadoLogico"]) == 1
                    );
                    lista.Add(plato);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error en ConsultarPlatosEliminados: " + ex.Message);
            }
            finally
            {
                dr?.Close();
            }

            return lista;
        }




        public string ActualizarPlato(Plato plato, SqlConnection conn)
        {
            string x = "";
            string comando = "UPDATE Plato SET nombre = @nombre, descripcion = @descripcion, precio = @precio, estado = @estado, estadoLogico = @estadoLogico WHERE idPlato = @idPlato";
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = comando;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", plato.Nombre);
                cmd.Parameters.AddWithValue("@descripcion", plato.Descripcion);
                cmd.Parameters.AddWithValue("@precio", plato.Precio);
                cmd.Parameters.AddWithValue("@estado", plato.Estado ? 1 : 0);
                cmd.Parameters.AddWithValue("@estadoLogico", plato.EstadoLogico ? 1 : 0);
                cmd.Parameters.AddWithValue("@idPlato", plato.IdPlato);
                cmd.ExecuteNonQuery();
                x = "1";
            }
            catch (SqlException e)
            {
                x = "0" + e.Message;
            }
            return x;
        }

        public string ActualizarEstadoLogicoPlato(int idPlato, bool estadoLogico, SqlConnection conn)
        {
            string x = "";
            string comando = "UPDATE Plato SET estadoLogico = @estadoLogico WHERE idPlato = @idPlato";
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = comando;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@estadoLogico", estadoLogico ? 1 : 0);
                cmd.Parameters.AddWithValue("@idPlato", idPlato);
                cmd.ExecuteNonQuery();
                x = "1";
            }
            catch (SqlException e)
            {
                x = "0" + e.Message;
            }
            return x;
        }
    }
}
