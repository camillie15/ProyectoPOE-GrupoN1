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
    public partial class VisualizarCliente : Form
    {
        CtrlCliente ctrCliente = new CtrlCliente();
        ControlEntradaTxt ctrllEntradaTxt = new ControlEntradaTxt();

        public VisualizarCliente()
        {
            InitializeComponent();
            ctrCliente.PresentarClientes(dgvCliente);
        }

        private void txtBuscarCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            ctrllEntradaTxt.ingresoSoloNumeros(sender, e);
        }

        private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            ctrllEntradaTxt.maximoDigitosNumericos(sender, e,10,txtBuscarCliente);
        }

        private void txtVolverCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
