using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Modelo;

namespace Datos
{
    public class DatosFactura
    {
        Conexion cn = new Conexion();
        SqlCommand cmd = new SqlCommand();
        DatosPedido datosPedido = new DatosPedido();

        public string IngresoFactura(Factura factura)
        {
            char estado = ComprobarEstado(factura.Estado);
            string comando = "INSERT INTO Factura (iva, subtotal, total, idPedido, estado, motivoA, fecha) VALUES (@iva, @subtotal, @total, @idPedido, @estado, @motivoA, @fecha)";

            try
            {
                cn.Conectar();
                SqlCommand cmd = new SqlCommand(comando, cn.Cn);

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@iva", factura.Iva);
                cmd.Parameters.AddWithValue("@subtotal", factura.Subtotal);
                cmd.Parameters.AddWithValue("@total", factura.Total);
                cmd.Parameters.AddWithValue("@idPedido", factura.Pedido.CodPedido);
                cmd.Parameters.AddWithValue("@estado", ComprobarEstado(factura.Estado));
                cmd.Parameters.AddWithValue("@motivoA", factura.MotivoA);
                cmd.Parameters.AddWithValue("@fecha", factura.Fecha);

                cmd.ExecuteNonQuery();
                cn.Desconectar();
                return "Se pudo registrar";
            }
            catch (SqlException ex)
            {
                return $"No se pudo registrar: {ex.Message}";
            }
        }

        public List<Factura> ConsultarFactura()
        {
            List<Factura> lista = new List<Factura>();
            SqlDataReader dr = null;
            Factura fact = null;
            string comando = "SELECT * FROM Factura";

            try
            {
                cn.Conectar();
                cmd.Connection = cn.Cn;
                cmd.CommandText = comando;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    fact = new Factura(0, 0, null, 0, 0, true, string.Empty, DateTime.Now);
                    fact.Iva = Convert.ToDouble(dr["iva"]);
                    fact.Total = Convert.ToDouble(dr["total"]);
                    fact.IdFactura = Convert.ToInt32(dr["idFactura"]);
                    fact.Pedido = datosPedido.ConsultarPedidoPorId(Convert.ToInt32(dr["idPedido"]));
                    fact.Subtotal = Convert.ToDouble(dr["subtotal"]);
                    fact.Estado = Convert.ToInt32(dr["estado"]) == 1 ? true : false;
                    fact.MotivoA = dr["motivoA"].ToString();
                    fact.Fecha = DateTime.Parse(dr["fecha"].ToString());
                    lista.Add(fact);

                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return lista;
        }

        public string AnularFactura(Factura factura)
        {
            string comando = "UPDATE Factura SET Estado = @estado, motivoA = @motivoA WHERE idFactura = @idFactura";

            try
            {
                cn.Conectar();
                cmd.Connection = cn.Cn;
                cmd.CommandText = comando;
                cmd.Parameters.AddWithValue("@estado", ComprobarEstado(factura.Estado));
                cmd.Parameters.AddWithValue("@motivoA", factura.MotivoA);
                cmd.Parameters.AddWithValue("@idFactura", factura.IdFactura);

                cmd.ExecuteNonQuery();
                cn.Desconectar();
                return "Se pudo registrar";
            }
            catch (SqlException ex)
            {
                return $"No se pudo registrar: {ex.Message}";
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

        public int UltimoIdFactura()
        {
            List<Factura> lista = ConsultarFactura();
            if (lista.Count != 0)
            {
                return lista[lista.Count - 1].IdFactura;
            }
            return 1;
        }

    }
}
