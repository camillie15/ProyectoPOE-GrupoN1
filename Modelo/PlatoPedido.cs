using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    //By: Camillie Ayovi Villafuerte
    public class PlatoPedido
    {
        int idPlato = 0;
        int idPedido = 0;
        string descripcion = string.Empty;
        int cantidad = 0;
        double precio = 0;
        double valorTotal = 0;
        bool estado = true;

        public int IdPlato { get => idPlato; set => idPlato = value; }
        public int IdPedido { get => idPedido; set => idPedido = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public double Precio { get => precio; set => precio = value; }
        public double ValorTotal { get => valorTotal; set => valorTotal = value; }
        public bool Estado { get => estado; set => estado = value; }

        public PlatoPedido(int idPlato, int idPedido, string descripcion, int cantidad, double precio, double valorTotal, bool estado)
        {
            IdPlato = idPlato;
            IdPedido = idPedido;
            Descripcion = descripcion;
            Cantidad = cantidad;
            Precio = precio;
            ValorTotal = valorTotal;
            Estado = estado;
        }

        public override string ToString()
        {
            return $"{IdPlato}, {IdPedido}, {Descripcion}, {Cantidad}, {Precio}, {ValorTotal}";
        }
    }
}
