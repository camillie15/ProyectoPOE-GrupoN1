using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosMenuPedido
    {
        Conexion cn = new Conexion();
        SqlCommand cmd = null;
        public string IngresarMenuPedido(MenuPedido menuSeleccionado)
        {
            string comando = $"INSERT INTO MenuPedido(idMenu, idPedido, descripcion, cantidad, precio, total)" +
                $"VALUES({menuSeleccionado.IdMenu}, {menuSeleccionado.IdPedido},'{menuSeleccionado.Descripcion}'," +
                $"{menuSeleccionado.Cantidad}, {Mett(menuSeleccionado.Precio)}, {Mett(menuSeleccionado.ValorTotal)})";
            try
            {
                cmd = new SqlCommand(comando);
                cn.Conectar();
                cmd.Connection = cn.Cn;
                cmd.CommandText = comando;
                cmd.ExecuteNonQuery();
                cn.Desconectar();
                return "Feli";
            }
            catch (SqlException ex)
            {
                return $"Nu feli \n{ex}";
            }
        }

        public string Mett(double valor)
        {
            string precioS = Convert.ToString(valor);
            return precioS.Replace(',', '.');
        }
    }
}
