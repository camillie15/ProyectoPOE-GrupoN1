using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class MenuItem
    {
        private int idMenu;
        private string nombre;
        private string descripcion;
        private double precio;
        private bool estado;

        public MenuItem(int idMenu, string nombre, string descripcion, double precio, bool estado)
        {
            this.idMenu = idMenu;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.precio = precio;
            this.estado = estado;
        }
        public int IdMenu { get => idMenu; set => idMenu = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double Precio { get => precio; set => precio = value; }
        public bool Estado { get => estado; set => estado = value; }

        public override string ToString()
        {
            return "Nombre: " + nombre + "\nDescripción: " + descripcion + "\nPrecio: " + precio + "\nEstado: " + (estado ? "Activo" : "Inactivo");
        }
    }
}
