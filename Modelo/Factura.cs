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
        private string cliente = string.Empty;
        private double subtotal = 0;
        private double iva = 0;
        private double total = 0;
        private int idFactura = 0;

        public Factura(string cliente, double subtotal, double iva, double total, int idFactura)
        {
            //this.pedido = pedido;
            this.cliente = cliente;
            this.subtotal = subtotal;
            this.iva = iva;
            this.total = total;
            this.idFactura = idFactura;
        }


        public double Iva { get => iva; set => iva = value; }
        public string Cliente { get => cliente; set => cliente= value; }
        public double Total { get => total; set => total = value; }
        //public Pedido Pedido { get => pedido; set => pedido = value; }
        public int IdFactura { get => idFactura; set => idFactura = value; }

        public double Subtotal { get => subtotal; set => subtotal = value; }

        

    }
}
