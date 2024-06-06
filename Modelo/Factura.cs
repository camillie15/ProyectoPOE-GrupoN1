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
       // private Pedido pedido = null;
        string cliente = string.Empty;
        double subtotal = 0;
        double iva = 0;
        double total = 0;
        int idFactura = 0;

        public Factura(double iva, string cliente, double total, int idFactura, double subtotal)
        {
            Iva = iva;
            Cliente = cliente;
            Total = total;
            IdFactura = idFactura;
            Subtotal = subtotal;
        }

        public double Iva { get => iva; set => iva = value; }
        public string Cliente { get => cliente; set => cliente= value; }
        public double Total { get => total; set => total = value; }
        //public Pedido Pedido { get => pedido; set => pedido = value; }
        public int IdFactura { get => idFactura; set => idFactura = value; }

        public double Subtotal { get => subtotal; set => subtotal = value; }

        

    }
}
