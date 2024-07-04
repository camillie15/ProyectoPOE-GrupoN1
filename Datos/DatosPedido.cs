using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosPedido
    {
        Conexion cn = new Conexion();
        SqlCommand cmd = null;
        public string IngresarPedido(Pedido pedidoN)
        {
            string comando = $"INSERT INTO Pedido(idCliente, idPlato, cantidadPedido, totalPedido, estadoPedido)" +
                $"VALUES({pedidoN.Cliente.IdCliente}, {pedidoN.MenuSeleccionado[1].IdMenu}, {pedidoN.CantidadProductos}," +
                $"{Mett(pedidoN.TotalPedido)}, '1')";
            try
            {
                cmd = new SqlCommand(comando);
                cn.Conectar();
                cmd.Connection = cn.Cn;
                cmd.CommandText = comando;
                cmd.ExecuteNonQuery();
                cn.Desconectar();
                return "DobleFeli";
            }
            catch (SqlException ex)
            {
                return $"Triple Nu feli \n{ex}";
            }
        }

        public string Mett(double valor)
        {
            string precioS = Convert.ToString(valor);
            return precioS.Replace(',', '.');
        }
    }
}
