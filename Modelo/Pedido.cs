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
        List<MenuPedido> menuSeleccionado = null;
        int cantidadProductos = 0;
        double totalPedido = 0;

        public int CodPedido { get => codPedido; set => codPedido = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public List<MenuPedido> MenuSeleccionado { get => menuSeleccionado; set => menuSeleccionado = value; }
        public int CantidadProductos { get => cantidadProductos; set => cantidadProductos = value; }
        public double TotalPedido { get => totalPedido; set => totalPedido = value; }

        public Pedido(int codPedido, Cliente cliente, List<MenuPedido> menuSeleccionado, int cantidadProductos, double totalPedido)
        {
            CodPedido = codPedido;
            Cliente = cliente;
            MenuSeleccionado = menuSeleccionado;
            CantidadProductos = cantidadProductos;
            TotalPedido = totalPedido;
        }

        public override string ToString()
        {
            var platosString = string.Join(", ", MenuSeleccionado.Select(p => p.ToString()));
            return $"{CodPedido}\n{Cliente}\n{platosString}\n{CantidadProductos}\n{TotalPedido}\n";
        }
    }
}
