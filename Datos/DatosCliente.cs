using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
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

        public void EditarCliente(Cliente cliente)
        {
            string comando = $"UPDATE Cliente " +
                $"SET nombre = '{cliente.Nombre}' , apellido = '{cliente.Apellido}', cedula = '{cliente.Cedula}', edad = {cliente.Edad} , email = '{cliente.Email}', direccion = '{cliente.Direccion}'" +
                $"WHERE idCliente = {cliente.IdCliente}";
            try
            {
                cn.Conectar();
                cmd.Connection = cn.Cn;
                cmd.CommandText = comando;
                cmd.ExecuteNonQuery();
                cn.Desconectar();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void EliminarCliente(int id)
        {
            string comando = $"UPDATE Cliente " +
                $"SET estado = '0'" +
                $"WHERE idCliente = {id}";
            try
            {
                cn.Conectar();
                cmd.Connection = cn.Cn;
                cmd.CommandText = comando;
                cmd.ExecuteNonQuery();
                cn.Desconectar();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public List<Cliente> BuscarCliente(string nombre, string apellido)
        {
            List<Cliente> clientesEncontrados = new List<Cliente>();
            string comando = string.Empty;
            SqlDataReader dr = null;
            Cliente cliente = null;

            if (nombre.Trim().Length > 0 && apellido.Trim().Length == 0)
            {
                comando = $"SELECT * FROM Cliente WHERE nombre LIKE '%{nombre}%'";
            }
            else if (nombre.Trim().Length == 0 && apellido.Trim().Length > 0)
            {
                comando = $"SELECT * FROM Cliente WHERE apellido LIKE '%{apellido}%'";
            }
            else
            {
                comando = $"SELECT * FROM Cliente WHERE nombre LIKE '%{nombre}%' AND apellido LIKE '%{apellido}%'";
            }

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
                        clientesEncontrados.Add(cliente);
                    }
                }
                cn.Desconectar();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return clientesEncontrados;
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

        public int UltimoId()
        {
            List<Cliente> lista = ObtenerClientes();
            if (lista.Count != 0)
            {
                return lista[lista.Count - 1].IdCliente;
            }
            return 1;
        }

        public List<string> ObtenerCedulas()
        {
            List<string> cedulas = new List<string>();
            SqlDataReader dr = null;
            string comando = "SELECT cedula FROM Cliente WHERE estado = '1'";
            try
            {
                cn.Conectar();
                cmd.Connection = cn.Cn;
                cmd.CommandText = comando;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cedulas.Add(dr["cedula"].ToString());
                }
                cn.Desconectar();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return cedulas;
        }

        public List<Cliente> BuscarClienteFiltro(int edad, string dominio)
        {
            List<Cliente> filtroCliente = new List<Cliente>();
            string comando = string.Empty;
            Cliente cliente = null;
            SqlDataReader dr = null;
            string sEdad = edad.ToString(); ;

            if (edad == 0)
            {
                sEdad = string.Empty;
            }

            if (sEdad.Trim().Length > 0 && dominio.Trim().Length == 0)
            {
                comando = $"SELECT * FROM Cliente WHERE edad = {sEdad}";
            }
            else if (sEdad.Trim().Length == 0 && dominio.Trim().Length > 0)
            {
                comando = $"SELECT * FROM Cliente WHERE email LIKE '%{dominio}%'";
            }
            else if (sEdad.Trim().Length > 0 && dominio.Trim().Length > 0)
            {
                comando = $"SELECT * FROM Cliente WHERE edad = {sEdad} AND email LIKE '%{dominio}%'";
            }

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
                        filtroCliente.Add(cliente);
                    }
                }
                cn.Desconectar();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return filtroCliente;
        }
    }
}
