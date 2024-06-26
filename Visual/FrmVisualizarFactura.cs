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
    public partial class FrmVisualizarFactura : Form
    {
        CtrlFactura ctrlFactura = new CtrlFactura();
        public FrmVisualizarFactura()
        {
            InitializeComponent();
            ctrlFactura.LlenaGrid(dgvFactura);
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            string filtro = textBuscar.Text.Trim();
            string criterio = cmbBusqueda.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(criterio))
            {
                MessageBox.Show("Por favor, selecciona un criterio de búsqueda.", "Criterio de Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dgvFactura.Rows.Clear();
            ctrlFactura.BuscarFactura(dgvFactura, filtro, criterio);
            textBuscar.Clear();
        }

        private void btAnular_Click(object sender, EventArgs e)
        {
            if (dgvFactura.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgvFactura.SelectedRows[0];
                int idFactura = Convert.ToInt32(filaSeleccionada.Cells["ColIdFactura"].Value);
                double iva = Convert.ToDouble(filaSeleccionada.Cells["ColIva"].Value);
                double subtotal = Convert.ToDouble(filaSeleccionada.Cells["ColSubtotal"].Value);
                double total = Convert.ToDouble(filaSeleccionada.Cells["ColTotal"].Value);
                string estadoStr = filaSeleccionada.Cells["ColEstado"].Value.ToString();
                bool estado = estadoStr == "Activo";
                DateTime fecha = Convert.ToDateTime(filaSeleccionada.Cells["ColFecha"].Value);
                FrmAnularFactura anularFactura = new FrmAnularFactura(ctrlFactura, idFactura, iva, total, subtotal, estado, fecha, this);
                anularFactura.Show();
            }
            else
            {
                MessageBox.Show(" Seleccione una fila por Anular .");
            }
        }

        public void ActualizarData()
        {
            ctrlFactura.LlenaGrid(dgvFactura);
            dgvFactura.DataSource = null;

        }

        private void btReporteG_Click(object sender, EventArgs e)
        {
            try
            {
                int mesActual = DateTime.Now.Month;
                int añoActual = DateTime.Now.Year;

                DateTime formatFecha = new DateTime(añoActual, mesActual, 1);
                double totalFacturasActivas = 0;
                string reporte = "REPORTE GENERAL \n\n";
                string fechaR = $" Facturas de {formatFecha.ToString("MMMM", new System.Globalization.CultureInfo("es-ES"))}\n\n";

                foreach (DataGridViewRow row in dgvFactura.Rows)
                {
                    string cliente = row.Cells["ColCedula"].Value.ToString();
                    DateTime fechaFactura = Convert.ToDateTime(row.Cells["ColFecha"].Value);
                    string estadoSt = row.Cells["ColEstado"].Value.ToString();
                    bool estadoFactura = estadoSt == "Activo";
                    double totalFactura = Convert.ToDouble(row.Cells["ColTotal"].Value);

                    if (fechaFactura.Month == mesActual && fechaFactura.Year == añoActual && estadoSt != "Anulado")
                    {
                        reporte += $"ID: {row.Cells["ColIdFactura"].Value}, Cliente: {cliente}, Total: {totalFactura}, Estado: {(estadoFactura ? "Activo" : "Anulado")}\n";

                        if (estadoFactura)
                        {
                            totalFacturasActivas += totalFactura;
                        }
                    }
                }
                reporte += $"\n TOTAL FACTURAS EMITIDAS: {totalFacturasActivas}";
                MessageBox.Show(fechaR + reporte, "REPORTE GENERAL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
