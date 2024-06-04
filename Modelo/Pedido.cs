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
        string cliente = string.Empty;
        string menuSeleccionado = string.Empty;
        int cantidadProductos = 0;
        double totalPedido = 0;

        public int CodPedido { get => codPedido; set => codPedido = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public string MenuSeleccionado { get => menuSeleccionado; set => menuSeleccionado = value; }
        public int CantidadProductos { get => cantidadProductos; set => cantidadProductos = value; }
        public double TotalPedido { get => totalPedido; set => totalPedido = value; }

        public Pedido(int codPedido, string cliente, string menuSeleccionado, int cantidadProductos, double totalPedido)
        {
            CodPedido = codPedido;
            Cliente = cliente;
            MenuSeleccionado = menuSeleccionado;
            CantidadProductos = cantidadProductos;
            TotalPedido = totalPedido;
        }
    }
}
