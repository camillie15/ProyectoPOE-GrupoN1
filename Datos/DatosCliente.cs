using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Datos
{
    public class DatosCliente
    {
        Conexion cn = new Conexion();
        SqlCommand cmd = new SqlCommand();
        public string IngresarCliente(Cliente cliente)
        {
            char estado = ComprobarEstado(cliente.Estado);
            string comando = $"INSERT INTO Cliente (nombre, apellido, cedula, edad, email, estado , direccion) VALUES ('{cliente.Nombre}'," +
                $"'{cliente.apellido}', '{cliente.Cedula}', {cliente.Edad} , '{cliente.Email}', '{estado}' , '{cliente.Direccion}') ";
            try
            {
                cn.Conectar();
                cmd.Connection = cn.Cn;
                cmd.CommandText = comando;
                cmd.ExecuteNonQuery();
                cn.Desconectar();
                return "Se pudo registrar";
            }
            catch (SqlException ex)
            {
                return $"No se pudo registrar {ex}";
            }
        }

        public List<Cliente> ObtenerClientes()
        {
            List<Cliente> lista = new List<Cliente>();
            string comando = "SELECT * FROM Cliente";
            SqlDataReader dr = null;
            Cliente cliente = null;

            try
            {
                cn.Conectar();
                cmd.Connection = cn.Cn;
                cmd.CommandText = comando;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (Convert.ToInt32(dr["estado"]) == 1)
                    {
                        cliente = new Cliente("", "", "", 0, "", true, 0, "");
                        cliente.Nombre = dr["nombre"].ToString();
                        cliente.Apellido = dr["apellido"].ToString();
                        cliente.Cedula = dr["cedula"].ToString();
                        cliente.Edad = Convert.ToInt32(dr["edad"]);
                        cliente.Email = dr["email"].ToString();
                        cliente.Estado = Convert.ToInt32(dr["estado"]) == 1 ? true : false;
                        cliente.IdCliente = Convert.ToInt32(dr["idCliente"]);
                        cliente.Direccion = dr["direccion"].ToString();
                        lista.Add(cliente);
                    }
                }
                cn.Desconectar();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return lista;
        }

        public Cliente BuscarCliente(int id)
        {
            Cliente clienteEncontrado = new Cliente("", "", "", 0, "", true, 0, "");

            return clienteEncontrado;
        }

        private char ComprobarEstado(bool flag)
        {
            char result = ' ';
            if (flag == true)
            {
                result = '1';
            }
            else
            {
                result = '0';
            }
            return result;
        }
    }
}
