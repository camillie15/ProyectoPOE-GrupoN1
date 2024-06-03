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
    public partial class VisualizarPlato : Form
    {
        public VisualizarPlato()
        {
            InitializeComponent();
        }

        private void btnAgregarPlato_Click(object sender, EventArgs e)
        {
            IngresarPlato ingresarPlato = new IngresarPlato();
            ingresarPlato.ShowDialog();
        }

        private void btnEditarPlato_Click(object sender, EventArgs e)
        {
            EditarPlato editarPlato = new EditarPlato();
            editarPlato.ShowDialog();
        }
    }
}
