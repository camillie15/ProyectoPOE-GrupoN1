using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Plato
    {
        private int idPlato = 0;
        private string nombre = string.Empty;
        private string descripcion = string.Empty;
        private double precio = 0;
        private bool estado = true;
        private bool estadoLogico;

        public Plato(int idPlato, string nombre, string descripcion, double precio, bool estado, bool estadoLogico)
        {
            this.idPlato = idPlato;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.precio = precio;
            this.estado = estado;
            this.estadoLogico = estadoLogico;
        }
        public int IdPlato { get => idPlato; set => idPlato = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double Precio { get => precio; set => precio = value; }
        public bool Estado { get => estado; set => estado = value; }
        public bool EstadoLogico { get => estadoLogico; set => estadoLogico = value; }

        public override string ToString()
        {
            return "Nombre: " + nombre + "\nDescripción: " + descripcion + "\nPrecio: " + precio + "\nEstado: " + (estado ? "Activo" : "Inactivo");
        }
    }
}
