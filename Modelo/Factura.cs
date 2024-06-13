using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    //By: Juliet Ortuño Sanchez
    public class Factura
    {
        Pedido pedido = null;
        double subtotal = 0;
        double iva = 0;
        double total = 0;
        int idFactura = 0;

        public Factura(double iva, double total, Pedido pedido, int idFactura, double subtotal)
        {
            Iva = iva;
            Total = total;
            Pedido = pedido;
            IdFactura = idFactura;
            Subtotal = subtotal;
        }

        public double Iva { get => iva; set => iva = value; }
        public double Total { get => total; set => total = value; }
        public Pedido Pedido { get => pedido; set => pedido = value; }
        public int IdFactura { get => idFactura; set => idFactura = value; }
        public double Subtotal { get => subtotal; set => subtotal = value; }
    }
}
