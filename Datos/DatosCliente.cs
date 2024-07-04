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
            string comando = $"INSERT INTO Persona (nombre, apellido, cedula, edad, email, estado) VALUES ('{cliente.Nombre}'," +
                $"'{cliente.apellido}', '{cliente.Cedula}', {cliente.Edad} , '{cliente.Email}', '{estado}') ";
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
