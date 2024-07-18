using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Datos
{
    public class DatosPlatoPedido
    {
        Conexion cn = new Conexion();
        SqlCommand cmd = null;
        public string IngresarPlatoPedido(PlatoPedido platoSeleccionado)
        {
            string comando = $"INSERT INTO PlatoPedido(idPlato, idPedido, descripcion, cantidad, precio, total, estado)" +
                $"VALUES({platoSeleccionado.IdPlato}, {platoSeleccionado.IdPedido}, '{platoSeleccionado.Descripcion}'," +
                $"{platoSeleccionado.Cantidad}, {DoubleVSaDB(platoSeleccionado.Precio)}, {DoubleVSaDB(platoSeleccionado.ValorTotal)}, 1)";

            try
            {
                cmd = new SqlCommand(comando);
                cn.Conectar();
                cmd.Connection = cn.Cn;
                cmd.CommandText = comando;
                cmd.ExecuteNonQuery();
                cn.Desconectar();
                return "Plato del Pedido ingresado en la DB de manera exitosa";
            }
            catch (SqlException ex)
            {
                return $"Error en el ingreso a la DB \n{ex}";
            }
        }
        //public List<PlatoPedido> ConsultarPlatoPedidos()
        //{
        //    List<PlatoPedido> listaPlatoPedidoDB = new List<PlatoPedido>();
        //    SqlDataReader dr = null;
        //    PlatoPedido platoPedido = null;

        //    string comando = "SELECT idPlato, idPedido, descripcion, cantidad, precio, total FROM PlatoPedido";

        //    try
        //    {
        //        cmd = new SqlCommand(comando);
        //        cn.Conectar();
        //        cmd.Connection = cn.Cn;
        //        cmd.CommandText = comando;
        //        dr = cmd.ExecuteReader();
        //        while (dr.Read())
        //        {
        //            platoPedido = new PlatoPedido(0, 0, " ", 0, 0, 0, true);
        //            platoPedido.IdPlato = Convert.ToInt32(dr["idPlato"]);
        //            platoPedido.IdPedido = Convert.ToInt32(dr["idPedido"]);
        //            platoPedido.Descripcion = dr["descripcion"].ToString();
        //            platoPedido.Cantidad = Convert.ToInt32(dr["cantidad"]);
        //            platoPedido.Precio = Convert.ToDouble(DoubleDBaVS(Convert.ToDouble(dr["precio"])));
        //            platoPedido.ValorTotal = Convert.ToDouble(DoubleDBaVS(Convert.ToDouble(dr["total"])));

        //            Console.WriteLine(platoPedido.ToString());
        //            listaPlatoPedidoDB.Add(platoPedido);
        //        }
        //    }
        //    catch (SqlException ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //    return listaPlatoPedidoDB;
        //}
        public List<PlatoPedido> ConsultarPlatoPedidosPorId(int idPedidoDB)
        {
            List<PlatoPedido> listaPlatoPedidoDB = new List<PlatoPedido>();
            SqlDataReader dr = null;
            PlatoPedido platoPedido = null;

            string comando = $"SELECT idPlato, idPedido, descripcion, cantidad, precio, total, estado FROM PlatoPedido WHERE idPedido = {idPedidoDB}";

            try
            {
                cmd = new SqlCommand(comando);
                cn.Conectar();
                cmd.Connection = cn.Cn;
                cmd.CommandText = comando;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    platoPedido = new PlatoPedido(0, 0, " ", 0, 0, 0, true);
                    platoPedido.IdPlato = Convert.ToInt32(dr["idPlato"]);
                    platoPedido.IdPedido = Convert.ToInt32(dr["idPedido"]);
                    platoPedido.Descripcion = dr["descripcion"].ToString();
                    platoPedido.Cantidad = Convert.ToInt32(dr["cantidad"]);
                    platoPedido.Precio = Convert.ToDouble(DoubleDBaVS(Convert.ToDouble(dr["precio"])));
                    platoPedido.ValorTotal = Convert.ToDouble(DoubleDBaVS(Convert.ToDouble(dr["total"])));
                    platoPedido.Estado = Convert.ToInt32(dr["estado"]) == 1 ? true : false;

                    listaPlatoPedidoDB.Add(platoPedido);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return listaPlatoPedidoDB;
        }
        public string DoubleDBaVS(double valor)
        {
            string precioS = Convert.ToString(valor);
            return precioS.Replace('.', ',');
        }
        public string DoubleVSaDB(double valor)
        {
            string precioS = Convert.ToString(valor);
            return precioS.Replace(',', '.');
        }

        public string EliminarPlatoPedido(int idEliminar, int idPedido)
        {
            string comando = $"UPDATE PlatoPedido SET estado = 0 WHERE idPedido = {idPedido} AND idPlato = {idEliminar}";

            try
            {
                cmd = new SqlCommand(comando);
                cn.Conectar();
                cmd.Connection = cn.Cn;
                cmd.CommandText = comando;
                cmd.ExecuteNonQuery();
                return $"Pedido Actualizado";
            }
            catch (SqlException ex)
            {
                return $"Error:\n{ex.Message}";
            }
        }
    }
}
