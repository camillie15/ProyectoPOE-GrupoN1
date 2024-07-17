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
            string comando = $"INSERT INTO PlatoPedido(idPlato, idPedido, descripcion, cantidad, precio, total)" +
                $"VALUES({platoSeleccionado.IdPlato}, {platoSeleccionado.IdPedido}, '{platoSeleccionado.Descripcion}'," +
                $"{platoSeleccionado.Cantidad}, {Mett(platoSeleccionado.Precio)}, {Mett(platoSeleccionado.ValorTotal)})";

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

        public string Mett(double valor)
        {
            string precioS = Convert.ToString(valor);
            return precioS.Replace(',', '.');
        }

        public List<PlatoPedido> ConsultarPlatoPedidos()
        {
            List<PlatoPedido> listaPlatoPedidoDB = new List<PlatoPedido>();
            SqlDataReader dr = null;
            PlatoPedido platoPedido = null;

            string comando = "SELECT idPlato, idPedido, descripcion, cantidad, precio, total FROM PlatoPedido";

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
                    platoPedido.Precio = Convert.ToDouble(Mett2(Convert.ToDouble(dr["precio"])));
                    platoPedido.ValorTotal = Convert.ToDouble(Mett2(Convert.ToDouble(dr["total"])));

                    Console.WriteLine(platoPedido.ToString());
                    listaPlatoPedidoDB.Add(platoPedido);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return listaPlatoPedidoDB;
        }

        public List<PlatoPedido> ConsultarPlatoPedidosPorId(int idPedidoDB)
        {
            List<PlatoPedido> listaPlatoPedidoDB = new List<PlatoPedido>();
            SqlDataReader dr = null;
            PlatoPedido platoPedido = null;

            string comando = $"SELECT idPlato, idPedido, descripcion, cantidad, precio, total FROM PlatoPedido WHERE idPedido = {idPedidoDB}";

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
                    platoPedido.Precio = Convert.ToDouble(Mett2(Convert.ToDouble(dr["precio"])));
                    platoPedido.ValorTotal = Convert.ToDouble(Mett2(Convert.ToDouble(dr["total"])));

                    Console.WriteLine($"{idPedidoDB}, {platoPedido.ToString()}");
                    listaPlatoPedidoDB.Add(platoPedido);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return listaPlatoPedidoDB;
        }
        public string Mett2(double valor)
        {
            string precioS = Convert.ToString(valor);
            return precioS.Replace('.', ',');
        }
    }
}
