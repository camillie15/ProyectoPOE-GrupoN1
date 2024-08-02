using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;

namespace Visual
{
    public partial class FrmFiltroCliente : Form
    {
        CtrlCliente ctrlCliente;
        public FrmFiltroCliente()
        {
            InitializeComponent();
        }

        private void btnBuscarFiltro_Click(object sender, EventArgs e)
        {
            ctrlCliente = new CtrlCliente();
            if (cbConfirmacion.Checked)
            {
                ctrlCliente.BuscarClienteFiltro(dgvCliente, (int)nudEdad.Value, txtGmail.Text);
            }
            else
            {
                ctrlCliente.BuscarClienteFiltro(dgvCliente, 0, txtGmail.Text);
            }

        }
    }
}
