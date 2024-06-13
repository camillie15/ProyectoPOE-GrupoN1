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
    public partial class FrmVisualizarFactura : Form
    {
        CtrlFactura ctrlFactura = new CtrlFactura();
        public FrmVisualizarFactura()
        {
            InitializeComponent();
            ctrlFactura.LlenaGrid(dgvFactura);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            string filtro = textBuscar.Text.Trim();
            ctrlFactura.BuscarFactura(dgvFactura, filtro);

        }

        private void btBuscarTodos_Click(object sender, EventArgs e)
        {
            dgvFactura.Rows.Clear();
            ctrlFactura.LlenaGrid(dgvFactura);
        }
    }
}
