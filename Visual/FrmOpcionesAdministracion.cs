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
    public partial class FrmOpcionesAdministracion : Form
    {
        public FrmOpcionesAdministracion()
        {
            InitializeComponent();
        }

        private void btnVisualizarPedido_Click(object sender, EventArgs e)
        {
            FrmVisualizarPedido visualizarPedido = new FrmVisualizarPedido();
            visualizarPedido.ShowDialog();
        }

        private void btnVolverOA_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVisualizarCliente_Click(object sender, EventArgs e)
        {
            FrmVisualizarCliente visualizarCliente = new FrmVisualizarCliente();
            visualizarCliente.ShowDialog();
        }

        private void btnVisualizarFactura_Click(object sender, EventArgs e)
        {
            FrmVisualizarFactura visualizarFactura = new FrmVisualizarFactura();
            visualizarFactura.ShowDialog();
        }

        private void btnPlatoOA_Click(object sender, EventArgs e)
        {
            FrmVisualizarPlato visualizarPlato = new FrmVisualizarPlato();
            visualizarPlato.ShowDialog();
        }
    }
}
