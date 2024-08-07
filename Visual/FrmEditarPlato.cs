﻿using Controlador;
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
    public partial class FrmEditarPlato : Form
    {
        private CtrlPlato ctrlPlato;
        private int idPlato;
        private FrmVisualizarPlato visualizarPlato;
        public FrmEditarPlato(CtrlPlato ctrlPlato, int idPlato, string nombre, string descripcion, double precio, bool estado, int numPlato, FrmVisualizarPlato visualizarPlato)
        {
            InitializeComponent();
            this.ctrlPlato = ctrlPlato;
            this.idPlato = idPlato;
            this.visualizarPlato = visualizarPlato;

            txtEditarIdPlato.Text = numPlato.ToString();
            txtEditarNombrePlato.Text = nombre;
            txtEditarDescripcionPlato.Text = descripcion;
            txtEditarPrecioPlato.Text = precio.ToString();
            cmbEditarEstadoPlato.SelectedItem = estado ? "Disponible" : "Agotado";
        }

        private void btnEditarPlato_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtEditarNombrePlato.Text;
                string descripcion = txtEditarDescripcionPlato.Text;
                double precio = Convert.ToDouble(txtEditarPrecioPlato.Text);
                bool estado = cmbEditarEstadoPlato.SelectedItem.ToString() == "Disponible";

                ctrlPlato.ActualizarPlato(idPlato, nombre, descripcion, precio, estado, true);
                ctrlPlato.EditarPlato(idPlato, nombre, descripcion, precio, estado);

                MessageBox.Show("Plato editado correctamente.");
                visualizarPlato.ActualizarDataGridView();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
