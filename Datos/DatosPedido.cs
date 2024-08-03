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
        DatosCliente datosCliente = new DatosCliente();
        Conexion cn = new Conexion();
        SqlCommand cmd = null;

        public string IngresarPedido(Pedido pedidoN)
        {
            string comando = $"INSERT INTO Pedido(idCliente, cantidadPedido, totalPedido, estadoPedido)" +
                $"VALUES({pedidoN.Cliente.IdCliente}, {pedidoN.CantidadProductos}, {DoubleVSaDB(pedidoN.TotalPedido)}, '1')";
            try
            {
                cmd = new SqlCommand(comando);
                cn.Conectar();
                cmd.Connection = cn.Cn;
                cmd.CommandText = comando;
                cmd.ExecuteNonQuery();
                cn.Desconectar();
                return "Pedido ingresado de manera exitosa";
            }
            catch (SqlException ex)
            {
                return $"Error en el ingreso a la DB \n{ex}";
            }
        }

        public List<Pedido> ConsultarPedidos()
        {
            List<Pedido> listaPedidosDB = new List<Pedido>();
            SqlDataReader dr = null;
            Pedido pedido = null;

            string comando = "SELECT idPedido, idCliente, cantidadPedido, totalPedido, estadoPedido FROM Pedido";

            try
            {
                cmd = new SqlCommand(comando);
                cn.Conectar();
                cmd.Connection = cn.Cn;
                cmd.CommandText = comando;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Cliente cliente = null;
                    List<PlatoPedido> platosPedidos = new List<PlatoPedido>();
                    pedido = new Pedido(0, cliente, 0, 0, true);
                    pedido.CodPedido = Convert.ToInt32(dr["idPedido"]);
                    pedido.Cliente = datosCliente.ObtenerClientes().Find(delBuscar => delBuscar.IdCliente == (Convert.ToInt32(dr["idCliente"])));
                    pedido.CantidadProductos = Convert.ToInt32(dr["cantidadPedido"]);
                    pedido.TotalPedido = Convert.ToDouble(DoubleDBaVS(Convert.ToDouble(dr["totalPedido"])));
                    pedido.Estado = Convert.ToInt32(dr["estadoPedido"]) == 1 ? true : false;

                    listaPedidosDB.Add(pedido);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return listaPedidosDB;
        }

        public Pedido ConsultarPedidoPorId(int idPedidoBuscar)
        {
            SqlDataReader dr = null;
            Pedido pedido = null;

            string comando = $"SELECT idPedido, idCliente, cantidadPedido, totalPedido, estadoPedido FROM Pedido WHERE idPedido = {idPedidoBuscar}";

            try
            {
                cmd = new SqlCommand(comando);
                cn.Conectar();
                cmd.Connection = cn.Cn;
                cmd.CommandText = comando;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Cliente cliente = null;
                    pedido = new Pedido(0, cliente, 0, 0, true);
                    pedido.CodPedido = Convert.ToInt32(dr["idPedido"]);
                    pedido.Cliente = datosCliente.ObtenerClientes().Find(delBuscar => delBuscar.IdCliente == (Convert.ToInt32(dr["idCliente"])));
                    pedido.CantidadProductos = Convert.ToInt32(dr["cantidadPedido"]);
                    pedido.TotalPedido = Convert.ToDouble(DoubleDBaVS(Convert.ToDouble(dr["totalPedido"])));
                    pedido.Estado = Convert.ToInt32(dr["estadoPedido"]) == 1 ? true : false;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return pedido;
        }

        public List<Pedido> ConsultarPedidosPorCliente(int idClienteBuscar)
        {
            List<Pedido> listaPedidosDB = new List<Pedido>();
            SqlDataReader dr = null;
            Pedido pedido = null;

            string comando = $"SELECT idPedido, idCliente, cantidadPedido, totalPedido, estadoPedido FROM Pedido WHERE idCliente = {idClienteBuscar}";

            try
            {
                cmd = new SqlCommand(comando);
                cn.Conectar();
                cmd.Connection = cn.Cn;
                cmd.CommandText = comando;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Cliente cliente = null;
                    pedido = new Pedido(0, cliente, 0, 0, true);
                    pedido.CodPedido = Convert.ToInt32(dr["idPedido"]);
                    pedido.Cliente = datosCliente.ObtenerClientes().Find(delBuscar => delBuscar.IdCliente == (Convert.ToInt32(dr["idCliente"])));
                    pedido.CantidadProductos = Convert.ToInt32(dr["cantidadPedido"]);
                    pedido.TotalPedido = Convert.ToDouble(DoubleDBaVS(Convert.ToDouble(dr["totalPedido"])));
                    pedido.Estado = Convert.ToInt32(dr["estadoPedido"]) == 1 ? true : false;

                    Console.WriteLine($"{idClienteBuscar}, {pedido.ToString()}");
                    listaPedidosDB.Add(pedido);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return listaPedidosDB;
        }

        public string ActualizarPedido(Pedido pedido, int id)
        {
            string comando = $"UPDATE Pedido SET idCliente = {pedido.Cliente.IdCliente}, cantidadPedido = {pedido.CantidadProductos}," +
                $"totalPedido = {DoubleVSaDB(pedido.TotalPedido)} WHERE idPedido = {id}";

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

        public void EliminarPedido(int codPedido)
        {
            string comando = $"UPDATE Pedido SET estadoPedido = 0 WHERE idPedido = {codPedido}";

            try
            {
                cmd = new SqlCommand(comando);
                cn.Conectar();
                cmd.Connection = cn.Cn;
                cmd.CommandText = comando;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error:\n{ex.Message}");
            }
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

        public int UltimoIdPedidoDB()
        {
            List<Pedido> listaPDB = ConsultarPedidos();
            int id = 0;
            if (listaPDB.Count > 0)
            {
                id = listaPDB[listaPDB.Count - 1].CodPedido;
            }
            return id;
        }
    }
}
