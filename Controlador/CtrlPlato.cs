using Datos;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controlador
{
    public class CtrlPlato
    {
        DatosPlato dplato = new DatosPlato();
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
            Plato nuevoPlato = new Plato(idPlato, nombre, descripcion, precio, estado, true);
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

        public void ActualizarPlato(int idPlato, string nombre, string descripcion, double precio, bool estado, bool estadoLogico)
        {
            string msj = string.Empty;
            string msjBD = cnBDD.Conectar();
            Plato pl = new Plato(idPlato, nombre, descripcion, precio, estado, estadoLogico);
            if (msjBD[0] == '1')
            {
                msj = dplato.ActualizarPlato(pl, cnBDD.Cn);
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


        public void ActualizarEstadoLogicoPlato(int idPlato, bool estadoLogico)
        {
            string msj = string.Empty;
            string msjBD = cnBDD.Conectar();
            if (msjBD[0] == '1')
            {
                msj = dplato.ActualizarEstadoLogicoPlato(idPlato, estadoLogico, cnBDD.Cn);
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
                throw new ArgumentException("Plato no encontrado 1.");
            }
        }

        public void LlenarPorNombre(DataGridView dgvVisualizarPlato, string nombreFiltro)
        {
            int i = 0;
            dgvVisualizarPlato.Rows.Clear();
            listaPlatos = SeleccionarPlato();
            IEnumerable<Plato> platosFiltrados = listaPlatos
                .Where(p => p.Nombre.IndexOf(nombreFiltro, StringComparison.OrdinalIgnoreCase) >= 0 && p.EstadoLogico);

            if (!platosFiltrados.Any())
            {
                MessageBox.Show("Plato no encontrado.");
            }
            else
            {
                foreach (Plato p in platosFiltrados)
                {
                    i = dgvVisualizarPlato.Rows.Add();
                    dgvVisualizarPlato.Rows[i].Cells["clmNum"].Value = i + 1;
                    dgvVisualizarPlato.Rows[i].Cells["clmIdPlato"].Value = p.IdPlato;
                    dgvVisualizarPlato.Rows[i].Cells["clmNombre"].Value = p.Nombre;
                    dgvVisualizarPlato.Rows[i].Cells["clmDescripcion"].Value = p.Descripcion;
                    dgvVisualizarPlato.Rows[i].Cells["clmPrecio"].Value = p.Precio;
                    dgvVisualizarPlato.Rows[i].Cells["clmEstado"].Value = p.Estado ? "Disponibles" : "Agotados";
                }
            }
        }

        public void Llenar(DataGridView dgvVisualizarPlato, bool mostrarTodos = true, string estadoFiltrar = "")
        {
            int i = 0;
            dgvVisualizarPlato.Rows.Clear();
            listaPlatos = SeleccionarPlato();
            IEnumerable<Plato> platosFiltrados;

            if (mostrarTodos)
            {
                platosFiltrados = listaPlatos.Where(p => p.EstadoLogico);
            }
            else if (estadoFiltrar.Equals("Disponibles", StringComparison.OrdinalIgnoreCase))
            {
                platosFiltrados = listaPlatos.Where(p => p.Estado && p.EstadoLogico);
            }
            else if (estadoFiltrar.Equals("Agotados", StringComparison.OrdinalIgnoreCase))
            {
                platosFiltrados = listaPlatos.Where(p => !p.Estado && p.EstadoLogico);
            }
            else
            {
                throw new ArgumentException("El estado no es válido. Debe ser 'Disponibles', 'Agotados' o 'Todos'.");
            }

            foreach (Plato p in platosFiltrados)
            {
                i = dgvVisualizarPlato.Rows.Add();
                dgvVisualizarPlato.Rows[i].Cells["clmNum"].Value = i + 1;
                dgvVisualizarPlato.Rows[i].Cells["clmIdPlato"].Value = p.IdPlato;
                dgvVisualizarPlato.Rows[i].Cells["clmNombre"].Value = p.Nombre;
                dgvVisualizarPlato.Rows[i].Cells["clmDescripcion"].Value = p.Descripcion;
                dgvVisualizarPlato.Rows[i].Cells["clmPrecio"].Value = p.Precio;
                dgvVisualizarPlato.Rows[i].Cells["clmEstado"].Value = p.Estado ? "Disponibles" : "Agotados";
            }
        }

        public List<Plato> SeleccionarPlato()
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

        public void LlenarPlatosEliminados(DataGridView dgvEliminarPlato)
        {
            string msj = cnBDD.Conectar();
            int i = 0;
            dgvEliminarPlato.Rows.Clear();
            List<Plato> platosEliminados = dplato.ConsultarPlatosEliminados(cnBDD.Cn);
            cnBDD.Desconectar();
            if (platosEliminados.Count == 0)
            {
                MessageBox.Show("No se encontraron platos eliminados.");
                return;
            }

            foreach (Plato p in platosEliminados)
            {
                i = dgvEliminarPlato.Rows.Add();
                dgvEliminarPlato.Rows[i].Cells[0].Value = i + 1;
                dgvEliminarPlato.Rows[i].Cells[1].Value = p.IdPlato;
                dgvEliminarPlato.Rows[i].Cells[2].Value = p.Nombre;
                dgvEliminarPlato.Rows[i].Cells[3].Value = p.Descripcion;
                dgvEliminarPlato.Rows[i].Cells[4].Value = p.Precio;
                dgvEliminarPlato.Rows[i].Cells[5].Value = p.Estado ? "Disponibles" : "Agotados";
                dgvEliminarPlato.Rows[i].Cells[6].Value = p.EstadoLogico ? "Activo" : "Inactivo";
            }
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