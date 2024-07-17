using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    //By: Camillie Ayovi Villafuerte
    public class Pedido
    {
        int codPedido = 0;
        Cliente cliente = null;
        int cantidadProductos = 0;
        double totalPedido = 0;
        bool estado = true;

        public int CodPedido { get => codPedido; set => codPedido = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public int CantidadProductos { get => cantidadProductos; set => cantidadProductos = value; }
        public double TotalPedido { get => totalPedido; set => totalPedido = value; }
        public bool Estado { get => estado; set => estado = value; }

        public Pedido(int codPedido, Cliente cliente, int cantidadProductos, double totalPedido, bool estado)
        {
            CodPedido = codPedido;
            Cliente = cliente;
            CantidadProductos = cantidadProductos;
            TotalPedido = totalPedido;
            Estado = estado;
        }

        public override string ToString()
        {
            return $"{CodPedido}\n{Cliente}\n{CantidadProductos}\n{TotalPedido}\n";
        }
    }
}
