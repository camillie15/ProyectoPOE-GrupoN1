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
        private Cliente cliente = null;
        List<Plato> menuSeleccionado = null;
        public int cantidadProductos = 0;
        public double totalPedido = 0;

        public int CodPedido { get => codPedido; set => codPedido = value; }

        public int CantidadProductos { get => cantidadProductos; set => cantidadProductos = value; }

        public double TotalPedido { get => totalPedido; set => totalPedido = value; }

        public List<Plato> MenuSeleccionado { get => menuSeleccionado; set => menuSeleccionado = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }

        public Pedido(int codPedido, int cantidadProductos, double totalPedido, List<Plato> menuSeleccionado, Cliente cliente)
        {
            CodPedido = codPedido;
            CantidadProductos = cantidadProductos;
            TotalPedido = totalPedido;
            MenuSeleccionado = menuSeleccionado;
            Cliente = cliente;
        }

        public double calcularPedido(List<Plato> menuSeleccionado)
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
