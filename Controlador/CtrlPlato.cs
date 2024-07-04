using Datos;
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
        DatosPlato dplato =new DatosPlato();
        Conexion cnBDD = new Conexion();
        static List<Plato> listaPlatos = new List<Plato>();
        CtrlConversiones validacion = new CtrlConversiones();

        public void IngresarPlato(string nombre, string descripcion, string precioStr, string estadoStr)
        {
            if (string.IsNullOrWhiteSpace(nombre) ||
            string.IsNullOrWhiteSpace(descripcion) ||
            string.IsNullOrWhiteSpace(precioStr) ||
            string.IsNullOrWhiteSpace(estadoStr))
            {
                throw new ArgumentException("Error: Ingrese todos los Campos");
            }
            int idPlato = GenerarIdPlato();
            double precio;

            //precioStr = precioStr.Replace(",", ".");
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
            //listaPlatos.Add(nuevoPlato);
            IngresarPlatoBD(nuevoPlato);

        }

        public void IngresarPlatoBD(Plato plato)
        {
            string msj = string.Empty;
            string msjBD = cnBDD.Conectar();

            if (msjBD[0] == '1')
            {
                msj = dplato.InsertPlato(plato, cnBDD.Cn);
                if (msj[0] == '0')
                {
                    MessageBox.Show("ERROR INESPERADO: " + msj);
                }
            }
            else if (msjBD[0] == '0')
            {
                MessageBox.Show("ERROR: " + msjBD);
            }
            cnBDD.Desconectar();
        }

        public void EditarPlato(int idPlato, string nombre, string descripcion, double precio, bool estado)
        {
            Plato plato = listaPlatos.FirstOrDefault(p => p.IdPlato == idPlato);
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
        //public void Llenar(DataGridView dgvVisualizarPlato, bool mostrarTodos = true, string estadoFiltrar = "")
        //{

        //    int i = 0;
        //    dgvVisualizarPlato.Rows.Clear();
        //    List<Plato> listaPlatosSql = SeleccionarPlato();
        //    IEnumerable<Plato> platosFiltrados;
        //    if (mostrarTodos)
        //    {
        //        platosFiltrados = listaPlatosSql;
        //    }
        //    else if (estadoFiltrar.Equals("Disponibles", StringComparison.OrdinalIgnoreCase))
        //    {
        //        platosFiltrados = listaPlatosSql.Where(p => p.Estado);
        //    }
        //    else if (estadoFiltrar.Equals("Agotados", StringComparison.OrdinalIgnoreCase))
        //    {
        //        platosFiltrados = listaPlatosSql.Where(p => !p.Estado);
        //    }
        //    else
        //    {
        //        throw new ArgumentException("El estado no es válido. Debe ser 'Disponibles', 'Agotados' o 'Todos'.");
        //    }

        //    foreach (Plato p in platosFiltrados)
        //    {
        //        i = dgvVisualizarPlato.Rows.Add();
        //        dgvVisualizarPlato.Rows[i].Cells["clmIdPlato"].Value = i + 1;
        //        dgvVisualizarPlato.Rows[i].Cells["clmNombre"].Value = p.Nombre;
        //        dgvVisualizarPlato.Rows[i].Cells["clmDescripcion"].Value = p.Descripcion;
        //        dgvVisualizarPlato.Rows[i].Cells["clmPrecio"].Value = p.Precio;
        //        dgvVisualizarPlato.Rows[i].Cells["clmEstado"].Value = p.Estado ? "Disponibles" : "Agotados";
        //    }
        //}

        public void Llenar(DataGridView dgvVisualizarPlato, bool mostrarTodos = true, string estadoFiltrar = "")
        {
            int i = 0;
            dgvVisualizarPlato.Rows.Clear();
            listaPlatos = SeleccionarPlato();
            IEnumerable<Plato> platosFiltrados;
            if (mostrarTodos)
            {
                platosFiltrados = listaPlatos;
            }
            else if (estadoFiltrar.Equals("Disponibles", StringComparison.OrdinalIgnoreCase))
            {
                platosFiltrados = listaPlatos.Where(p => p.Estado);
            }
            else if (estadoFiltrar.Equals("Agotados", StringComparison.OrdinalIgnoreCase))
            {
                platosFiltrados = listaPlatos.Where(p => !p.Estado);
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
        private List<Plato> SeleccionarPlato()
        {
            List<Plato> lista = new List<Plato>();
            string msj = cnBDD.Conectar();
            if (msj[0] == '1')
            {
                lista = dplato.ConsultarPlato(cnBDD.Cn);
            }
            else if (msj[0] == '0')
            {
                MessageBox.Show("Ocurrio un error: " + msj);
            }
            cnBDD.Desconectar();
            return lista;
        }

        private int GenerarIdPlato()
        {
            if (listaPlatos.Count == 0)
            {
                return 1;
            }
            else
            {
                int ultimoId = listaPlatos.Max(p => p.IdPlato);
                if (ultimoId >= 999)
                {
                    throw new InvalidOperationException("El ID del plato ha alcanzado el límite máximo.");
                }
                return ultimoId + 1;
            }
        }

        public void EliminarPlato(int rowIndex)
        {

            listaPlatos.Remove(listaPlatos[rowIndex]);

        }
        public void ComprobarConexion()
        {
            string msg = string.Empty;
            string flag = cnBDD.Conectar();
            if (flag == "1")
            {
                msg = "Conexion exitosa";
            }
            else
            {
                msg = "No se pudo conectar: " + flag;
            }
            MessageBox.Show(msg);
        }
    }
}