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
        private bool estado = true;
        string motivoA = string.Empty;
        DateTime fecha;

        public Factura(double iva, double total, Pedido pedido, int idFactura, double subtotal, bool estado, string motivoA, DateTime fecha)
        {
            Iva = iva;
            Total = total;
            Pedido = pedido;
            IdFactura = idFactura;
            Subtotal = subtotal;
            this.estado = estado;
            this.Fecha = fecha;
            this.MotivoA = motivoA;
        }

        public double Iva { get => iva; set => iva = value; }
        public double Total { get => total; set => total = value; }
        public Pedido Pedido { get => pedido; set => pedido = value; }
        public int IdFactura { get => idFactura; set => idFactura = value; }
        public double Subtotal { get => subtotal; set => subtotal = value; }
        public bool Estado { get => estado; set => estado = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string MotivoA { get => motivoA; set => motivoA = value; }

        public override string ToString()
        {
            return "Iva " + iva + "\n Subtotal" + subtotal + "\n Total " + total + "\nEstado: " + (estado ? " Activo" : "Anulado");
        }
    }
}
