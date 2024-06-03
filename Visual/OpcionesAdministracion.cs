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
    public partial class OpcionesAdministracion : Form
    {
        public OpcionesAdministracion()
        {
            InitializeComponent();
        }

        private void btnVisualizarPedido_Click(object sender, EventArgs e)
        {
            VisualizarPedido visualizarPedido = new VisualizarPedido(); 
            visualizarPedido.ShowDialog();
        }

        private void btnVolverOA_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVisualizarCliente_Click(object sender, EventArgs e)
        {
            VisualizarCliente visualizarCliente = new VisualizarCliente();
            visualizarCliente.ShowDialog();
        }

        private void btnVisualizarFactura_Click(object sender, EventArgs e)
        {
            VisualizarFactura visualizarFactura = new VisualizarFactura();
            visualizarFactura.ShowDialog();
        }

        private void btnPlatoOA_Click(object sender, EventArgs e)
        {
            VisualizarPlato visualizarPlato = new VisualizarPlato();
            visualizarPlato.ShowDialog();
        }
    }
}
