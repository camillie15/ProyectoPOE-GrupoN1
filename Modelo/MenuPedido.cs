using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    //By: Camillie Ayovi Villafuerte
    public class MenuPedido
    {
        int idMenu = 0;
        int idPedido = 0;
        string descripcion = string.Empty;
        int cantidad = 0;
        double precio = 0;
        double valorTotal = 0;

        public int IdMenu { get => idMenu; set => idMenu = value; }
        public int IdPedido { get => idPedido; set => idPedido = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public double Precio { get => precio; set => precio = value; }
        public double ValorTotal { get => valorTotal; set => valorTotal = value; }

        public MenuPedido(int idMenu, int idPedido, string descripcion, int cantidad, double precio, double valorTotal)
        {
            IdMenu = idMenu;
            IdPedido = idPedido;
            Descripcion = descripcion;
            Cantidad = cantidad;
            Precio = precio;
            ValorTotal = valorTotal;
        }

        public override string ToString()
        {
            return $"{IdMenu}, {IdPedido}, {Descripcion}, {Cantidad}, {Precio}, {ValorTotal}";
        }
    }
}
