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
        public FrmVisualizarPlato()
        {
            InitializeComponent();
        }

        private void btnAgregarPlato_Click(object sender, EventArgs e)
        {
            FrmIngresarPlato ingresarPlato = new FrmIngresarPlato();
            ingresarPlato.ShowDialog();
        }

        private void btnEditarPlato_Click(object sender, EventArgs e)
        {
            FrmEditarPlato editarPlato = new FrmEditarPlato();
            editarPlato.ShowDialog();
        }

        private void btnVolverPlato_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
