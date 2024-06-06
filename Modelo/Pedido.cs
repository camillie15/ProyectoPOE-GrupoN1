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
        List <Plato> menuSeleccionado = null;
        int cantidadProductos = 0;
        double totalPedido = 0;

        public int CodPedido { get => codPedido; set => codPedido = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public List<Plato> MenuSeleccionado1 { get => menuSeleccionado; set => menuSeleccionado = value; }
        public int CantidadProductos { get => cantidadProductos; set => cantidadProductos = value; }
        public double TotalPedido { get => totalPedido; set => totalPedido = value; }

        public Pedido(int codPedido, Cliente cliente, List<Plato> menuSeleccionado1, int cantidadProductos, double totalPedido)
        {
            CodPedido = codPedido;
            Cliente = cliente;
            MenuSeleccionado1 = menuSeleccionado1;
            CantidadProductos = cantidadProductos;
            TotalPedido = totalPedido;
        }
    }
}
