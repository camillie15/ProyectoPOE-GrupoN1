using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controlador
{
    public class CtrlPlato
    {
        static List<Plato> listaPlatos = new List<Plato>();
        CtrlConversiones validacion = new CtrlConversiones();

        public static List<Plato> ListaPlatos { get => listaPlatos; set => listaPlatos = value; }

        public void IngresarPlato(string nombre, string descripcion, string precioStr, string estadoStr)
        {
            int idPlato = GenerarIdPlato();
            double precio;

            precio = validacion.toDouble(precioStr);

            bool estado;

            if (estadoStr.ToLower().Equals("disponible"))
            {
                estado = true;
            }
            else
            {
                estado = false;
            }
            Plato nuevoPlato = new Plato(idPlato, nombre, descripcion, precio, estado);
            ListaPlatos.Add(nuevoPlato);
        }

        public void EditarPlato(int idPlato, string nombre, string descripcion, double precio, bool estado)
        {
            Plato plato = ListaPlatos.FirstOrDefault(p => p.IdPlato == idPlato);
            if (plato != null)
            {
                plato.Nombre = nombre;
                plato.Descripcion = descripcion;
                plato.Precio = precio;
                plato.Estado = estado;
            }
            else
            {
                throw new ArgumentException("Plato no encontrado.");
            }
        }

        public void Llenar(DataGridView dgvVisualizarPlato, bool mostrarTodos = true, string estadoFiltrar = "")
        {
            int i = 0;
            dgvVisualizarPlato.Rows.Clear();

            IEnumerable<Plato> platosFiltrados;
            if (mostrarTodos)
            {
                platosFiltrados = ListaPlatos;
            }
            else if (estadoFiltrar.Equals("Disponibles", StringComparison.OrdinalIgnoreCase))
            {
                platosFiltrados = ListaPlatos.Where(p => p.Estado);
            }
            else if (estadoFiltrar.Equals("Agotados", StringComparison.OrdinalIgnoreCase))
            {
                platosFiltrados = ListaPlatos.Where(p => !p.Estado);
            }
            else
            {
                throw new ArgumentException("El estado no es válido. Debe ser 'Disponibles', 'Agotados' o 'Todos'.");
            }

            foreach (Plato p in platosFiltrados)
            {
                i = dgvVisualizarPlato.Rows.Add();
                dgvVisualizarPlato.Rows[i].Cells["clmIdPlato"].Value = i + 1;
                dgvVisualizarPlato.Rows[i].Cells["clmNombre"].Value = p.Nombre;
                dgvVisualizarPlato.Rows[i].Cells["clmDescripcion"].Value = p.Descripcion;
                dgvVisualizarPlato.Rows[i].Cells["clmPrecio"].Value = p.Precio;
                dgvVisualizarPlato.Rows[i].Cells["clmEstado"].Value = p.Estado ? "Disponibles" : "Agotados";
            }
        }

        private int GenerarIdPlato()
        {
            if (ListaPlatos.Count == 0)
            {
                return 1;
            }
            else
            {
                int ultimoId = ListaPlatos.Max(p => p.IdPlato);
                if (ultimoId >= 999)
                {
                    throw new InvalidOperationException("El ID del plato ha alcanzado el límite máximo.");
                }
                return ultimoId + 1;
            }
        }

        public void EliminarPlato(int rowIndex)
        {

            ListaPlatos.Remove(ListaPlatos[rowIndex]);

        }
    }
}
