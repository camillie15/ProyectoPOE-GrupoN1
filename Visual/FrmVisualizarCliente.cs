using Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual
{
    public partial class FrmVisualizarCliente : Form
    {
        CtrlCliente ctrCliente = new CtrlCliente();
        ControlEntradaTxt ctrllEntradaTxt = new ControlEntradaTxt();

        public FrmVisualizarCliente()
        {
            InitializeComponent();
            ctrCliente.PresentarClientes(dgvCliente);
        }

        private void txtBuscarCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            ctrllEntradaTxt.ingresoSoloLetras(sender, e);
        }

        private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVolverCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvCliente.Rows.Clear();
            ctrCliente.buscarCliente(dgvCliente, txtBuscarNombre.Text, txtBuscarApellido.Text, btnMostrarTodosClientes);
        }

        private void btnMostrarTodosClientes_Click(object sender, EventArgs e)
        {
            dgvCliente.Rows.Clear();
            ctrCliente.PresentarClientes(dgvCliente);
            btnMostrarTodosClientes.Enabled = false;
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            if (dgvCliente.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgvCliente.SelectedRows[0];
                int idCliente = Convert.ToInt32(filaSeleccionada.Cells[0].Value);
                string nombre = filaSeleccionada.Cells[1].Value.ToString();
                string apellido = filaSeleccionada.Cells[2].Value.ToString();
                string cedula = filaSeleccionada.Cells[3].Value.ToString();
                int edad = Convert.ToInt32(filaSeleccionada.Cells[4].Value);
                string email = filaSeleccionada.Cells[5].Value.ToString();
                string direccion = filaSeleccionada.Cells[6].Value.ToString();

                FrmEditarCliente frmEditarCliente = new FrmEditarCliente(ctrCliente, idCliente, nombre, apellido, cedula, edad, email, direccion, this);
                frmEditarCliente.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para editar.");
            }
        }

        public void ActualizarDataGridView()
        {
            dgvCliente.Rows.Clear();
            ctrCliente.PresentarClientes(dgvCliente);
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (dgvCliente.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgvCliente.SelectedRows[0];
                int id = Convert.ToInt32(filaSeleccionada.Cells[0].Value);
                ctrCliente.eliminarCliente(id);
                ActualizarDataGridView();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para editar.");
            }
        }

        private void btnPdfCliente_Click(object sender, EventArgs e)
        {
            CtrlPdfCliente pdf = new CtrlPdfCliente();
            pdf.GenerarPdf(dgvCliente);
            pdf.AbrirPdf();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmFiltroCliente frmFiltroCliente = new FrmFiltroCliente();
            frmFiltroCliente.ShowDialog();
        }
    }
}
