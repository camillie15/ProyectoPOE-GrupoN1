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
    public partial class FrmIngresarPlato : Form
    {
        private CtrlPlato ctrlPlato;
        private FrmVisualizarPlato visualizarPlato;

        public FrmIngresarPlato(CtrlPlato ctrlPlato, FrmVisualizarPlato visualizarPlato)
        {
            InitializeComponent();
            this.ctrlPlato = ctrlPlato;
            this.visualizarPlato = visualizarPlato;
        }

        private void btnRegistrarPlato_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombrePlato.Text;
                string descripcion = txtDescripcionPlato.Text;
                string precioStr = txtPrecioPlato.Text;
                string estadoStr = cmbEstadoPlato.SelectedItem.ToString();
                if (ctrlPlato != null)
                {
                    ctrlPlato.IngresarPlato(nombre, descripcion, precioStr, estadoStr);
                    MessageBox.Show("Plato ingresado correctamente.");
                    visualizarPlato.ActualizarDataGridView();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error: ctrlPlato no está inicializado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtNombrePlato_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letra = e.KeyChar;
            if (!char.IsLetterOrDigit(letra) && letra != ' ' && letra != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }
        }

        private void txtDescripcionPlato_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letra = e.KeyChar;
            if (!char.IsLetterOrDigit(letra) && letra != ',' && letra != ' ' && letra != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }
            if (txtDescripcionPlato.Text.Length >= 30 && letra != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }
        }

        private void txtPrecioPlato_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letra = e.KeyChar;
            if (!char.IsDigit(letra) && letra != (char)Keys.Back && letra != ',')
            {
                e.Handled = true;
                return;
            }
            if (letra == ',' && txtPrecioPlato.Text.Contains(","))
            {
                e.Handled = true;
                return;
            }
            if (letra == ',' && txtPrecioPlato.Text.Length == 0)
            {
                e.Handled = true;
                return;
            }
        }
    }
}
