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
        private Usuario usuario = null;
        private Pedido pedido = null;
        private double iva = 0;
        private string nombre = string.Empty;
        private double total = 0;

        public Factura(Usuario usuario, Pedido pedido, double iva, string nombre, double total)
        {
            this.usuario = usuario;
            this.pedido = pedido;
            this.iva = iva;
            this.nombre = nombre;
            this.total = total;
        }

        public double Iva { get => iva; set => iva = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Total { get => total; set => total = value; }
        internal Usuario Usuario { get => usuario; set => usuario = value; }
        internal Pedido Pedido { get => pedido; set => pedido = value; }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
