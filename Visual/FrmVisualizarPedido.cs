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
    public partial class FrmVisualizarPedido : Form
    {
        CtrlPedido ctrlPedido = new CtrlPedido();
        public FrmVisualizarPedido()
        {
            InitializeComponent();
            ctrlPedido.AutocompletarGridPedido(dgvPedidos);
        }

        private void btnVolverPedido_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarPedido_Click(object sender, EventArgs e)
        {
            string campo = (string)cmbCampoBusqueda.SelectedItem;
            string datoBuscar = txtBusqueda.Text;

            dgvPedidos.Rows.Clear();
            ctrlPedido.BuscarPedido(campo, datoBuscar, dgvPedidos);
            txtBusqueda.Clear();
        }
    }
}
