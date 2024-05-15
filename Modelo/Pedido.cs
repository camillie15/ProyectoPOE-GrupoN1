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
        public int codPedido = 0;
        List<MenuItem> menuSeleccionado = null;
        public int cantidadProductos = 0;
        public double totalPedido = 0;

        public int CodPedido { get => codPedido; set => codPedido = value; }

        public int CantidadProductos { get => cantidadProductos; set => cantidadProductos = value; }

        public double TotalPedido { get => totalPedido; set => totalPedido = value; }

        public List<MenuItem> MenuSeleccionado { get => menuSeleccionado; set => menuSeleccionado = value; }

        public Pedido(int codPedido, int cantididadProductos, double totalPedido, List<MenuItem> menuSeleccionado)
        {
            CodPedido = codPedido;
            CantidadProductos = cantididadProductos;
            TotalPedido = totalPedido;
            MenuSeleccionado = menuSeleccionado;
        }

        public double calcularPedido(List<MenuItem> menuSeleccionado)
        {
            double totalP = 0;
            foreach (var combo in menuSeleccionado)
            {
                totalP += combo.Precio;
            }
            return totalP;
        }
    }
}
