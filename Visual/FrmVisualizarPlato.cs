using Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual
{
    public partial class FrmVisualizarPlato : Form

    {
        private CtrlPlato ctrlPlato;
        public FrmVisualizarPlato()
        {
            InitializeComponent();
            ctrlPlato = new CtrlPlato();
            ctrlPlato.Llenar(dgvVisualizarPlato);
        }

        private void btnAgregarPlato_Click(object sender, EventArgs e)
        {
            FrmIngresarPlato formIngresarPlato = new FrmIngresarPlato(ctrlPlato, this);
            formIngresarPlato.Show();
        }

        private void btnVolverPlato_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnEliminarPlato_Click(object sender, EventArgs e)
        {
            if (dgvVisualizarPlato.SelectedRows.Count > 0)
            {
                int rowIndex = dgvVisualizarPlato.SelectedRows[0].Index;
                DialogResult dialogResult = MessageBox.Show("¿Desea eliminar este Plato?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ctrlPlato.EliminarPlato(rowIndex);
                    dgvVisualizarPlato.Rows.RemoveAt(rowIndex);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar.");
            }

        }

        private void btnEditarPlato_Click(object sender, EventArgs e)
        {
            if (dgvVisualizarPlato.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgvVisualizarPlato.SelectedRows[0];
                int idPlato = Convert.ToInt32(filaSeleccionada.Cells["clmIdPlato"].Value);
                string nombre = filaSeleccionada.Cells["clmNombre"].Value.ToString();
                string descripcion = filaSeleccionada.Cells["clmDescripcion"].Value.ToString();
                double precio = Convert.ToDouble(filaSeleccionada.Cells["clmPrecio"].Value);
                bool estado = filaSeleccionada.Cells["clmEstado"].Value.ToString() == "Disponible";

                FrmEditarPlato formEditarPlato = new FrmEditarPlato(ctrlPlato, idPlato, nombre, descripcion, precio, estado, this);
                formEditarPlato.Show();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para editar.");
            }

        }

        private void btnBuscarCampo_Click(object sender, EventArgs e)
        {
            string opcionSeleccionada = cmbCampoBuscar.SelectedItem.ToString();
            bool mostrarTodos = opcionSeleccionada.Equals("Todos", StringComparison.OrdinalIgnoreCase);
            string estadoFiltrar = mostrarTodos ? "" : opcionSeleccionada;

            ctrlPlato.Llenar(dgvVisualizarPlato, mostrarTodos, estadoFiltrar);
        }

        public void ActualizarDataGridView()
        {
            ctrlPlato.Llenar(dgvVisualizarPlato);
        }
    }
}
