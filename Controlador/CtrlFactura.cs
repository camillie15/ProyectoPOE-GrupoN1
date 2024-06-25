using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Windows.Forms;
using System.IO;

namespace Controlador
{
    public class CtrlFactura

    {
        CtrlConversiones v = new CtrlConversiones();
        CtrlPedido p = new CtrlPedido();

        private static List<Factura> listafact = new List<Factura>();
        // lista pedido
        List<Pedido> listp = CtrlPedido.ListaPedidos;


        public static List<Factura> Listafact { get => listafact; set => listafact = value; }

        public void LlenaGrid(DataGridView dgvFactura, bool todos = true, string estadoF = "")
        {

            int i = 0;
            dgvFactura.Rows.Clear();

            IEnumerable<Factura> facturas;
            if (todos)
            {
                facturas = listafact;
            }
            else if (estadoF.Equals("Anualdo", StringComparison.OrdinalIgnoreCase))
            {
                facturas = listafact.Where(p => p.Estado == false);
            }
            else if (estadoF.Equals("Activo", StringComparison.OrdinalIgnoreCase))
            {
                facturas = listafact.Where(p => !p.Estado == true);
            }
            else
            {
                throw new ArgumentException("El estado no es válido. Debe ser 'Anulado', 'Activo'.");
            }

            if (listafact.Count > 0)
            {
                foreach (Factura f in Listafact)
                {
                    i = dgvFactura.Rows.Add();
                    dgvFactura.Rows[i].Cells["ColIdFactura"].Value = f.IdFactura;
                    dgvFactura.Rows[i].Cells["ColCedula"].Value = f.Pedido.Cliente.Cedula;
                    dgvFactura.Rows[i].Cells["ColSubtotal"].Value = f.Subtotal;
                    dgvFactura.Rows[i].Cells["ColIva"].Value = f.Iva;
                    dgvFactura.Rows[i].Cells["ColTotal"].Value = f.Total;
                    dgvFactura.Rows[i].Cells["ColEstado"].Value = f.Estado ? "Activo" : "Anulado";
                    dgvFactura.Rows[i].Cells["ColMotivo"].Value = f.MotivoA;
                    dgvFactura.Rows[i].Cells["ColFecha"].Value = f.Fecha.ToString("d");
                }
            }
            else
            {
                MessageBox.Show("NO EXISTEN FACTURAS REGISTRADAS.");
            }
        }

        public Pedido RetornarPedido()
        {
            Pedido pedido = null;
            if (listp.Count > 0)
            {
                pedido = listp[listp.Count - 1];
            }
            else
            {
                pedido = null;
            }
            return pedido;
        }

        public string CrearId()
        {
            return (listafact.Count + 1).ToString();
        }

        public void IngresarFactura(string pIva, string pTotal, string pIdFactura, string pSubtotal, string pEstado, string pMotivoA, string pFecha)
        {
            double subtotal = v.toDouble(pSubtotal);
            double iva = v.toDouble(pIva);
            double total = v.toDouble(pTotal);
            int idFactura = v.toInt(pIdFactura);
            bool estado = pEstado.Equals("Activo", StringComparison.OrdinalIgnoreCase);
            DateTime fecha = v.ConvertirDateTime(pFecha);

            Pedido pedido = RetornarPedido();

            Factura factura = new Factura(iva, total, pedido, idFactura, subtotal, estado, pMotivoA, fecha);
            listafact.Add(factura);
        }

        public void Calcular(string subtotalText, out string ivaText, out string totalText)
        {
            double subtotal;
            if (!double.TryParse(subtotalText, out subtotal))
            {
                ivaText = "";
                totalText = "";
                MessageBox.Show("Por favor, ingrese un subtotal válido.");
                return;
            }

            const double ValorIva = 0.15;
            double TotalIva = subtotal * ValorIva;
            double totalConIva = subtotal + TotalIva;

            ivaText = TotalIva.ToString("F2");
            totalText = totalConIva.ToString("F2");
        }

        //public void BuscarFactura(DataGridView dgvFactura, string columna)
        //{
        //    dgvFactura.Rows.Clear();
        //    int i = 0;
        //    bool tf = false;

        //    foreach (Factura f in Listafact)
        //    {
        //        if (string.IsNullOrEmpty(columna) || f.Pedido.Cliente.Cedula.Contains(columna))
        //        {
        //            i = dgvFactura.Rows.Add();
        //            dgvFactura.Rows[i].Cells["ColIdFactura"].Value = f.IdFactura;
        //            dgvFactura.Rows[i].Cells["ColCedula"].Value = f.Pedido.Cliente.Cedula;
        //            dgvFactura.Rows[i].Cells["ColSubtotal"].Value = f.Subtotal;
        //            dgvFactura.Rows[i].Cells["ColIva"].Value = f.Iva;
        //            dgvFactura.Rows[i].Cells["ColTotal"].Value = f.Total;
        //            dgvFactura.Rows[i].Cells["ColEstado"].Value = f.Estado ? "Activo" : "Anulado";
        //            dgvFactura.Rows[i].Cells["ColMotivo"].Value = f.MotivoA;
        //            dgvFactura.Rows[i].Cells["ColFecha"].Value = f.Fecha.ToString("d");
        //            tf = true;
        //        }

        //    }
        //    if (!tf)
        //    {
        //        MessageBox.Show("ERROR: NO SE ENCONTRARON RESULTADOS CON LOS FILTROS PROPORCIONADOS.", "SIN RESULTADOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}

        public void BuscarFactura(DataGridView dgvFactura, string filtro, string cmbFiltro)
        {
            dgvFactura.Rows.Clear();
            int i = 0;
            bool tf = false;

            foreach (Factura f in Listafact)
            {
                bool flag = false; // verifica si coincide con el filtro del combobox

                // busqueda por cedula
                if (cmbFiltro == "Cedula" && f.Pedido.Cliente.Cedula.Contains(filtro))
                {
                    flag = true;
                }
                if (flag)
                {
                    int rowIndex = dgvFactura.Rows.Add();
                    dgvFactura.Rows[i].Cells["ColIdFactura"].Value = f.IdFactura;
                    dgvFactura.Rows[i].Cells["ColCedula"].Value = f.Pedido.Cliente.Cedula;
                    dgvFactura.Rows[i].Cells["ColSubtotal"].Value = f.Subtotal;
                    dgvFactura.Rows[i].Cells["ColIva"].Value = f.Iva;
                    dgvFactura.Rows[i].Cells["ColTotal"].Value = f.Total;
                    dgvFactura.Rows[i].Cells["ColEstado"].Value = f.Estado ? "Activo" : "Anulado";
                    dgvFactura.Rows[i].Cells["ColMotivo"].Value = f.MotivoA;
                    dgvFactura.Rows[i].Cells["ColFecha"].Value = f.Fecha.ToString("d");
                    tf = true;
                }
            }
            if (!tf)
            {
                MessageBox.Show("ERROR: NO SE ENCONTRARON RESULTADOS CON LOS FILTROS PROPORCIONADOS.", "SIN RESULTADOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void llenarTxt(TextBox txtContenido, TextBox txtSubtotal, TextBox txtCliente)
        {
            Pedido ped = RetornarPedido();
            string contenido = string.Empty;
            for (int i = 0; i < ped.MenuSeleccionado.Count; i++)
            {
                contenido += ped.MenuSeleccionado[i] + Environment.NewLine + Environment.NewLine;
            }

            txtContenido.Text = contenido;
            txtSubtotal.Text = ped.TotalPedido.ToString();
            txtCliente.Text = ped.Cliente.Cedula;
        }

        public void EditarFactura(int idFactura, bool nuevoEstado, string nuevoMotivo)
        {
            Factura facturaExistente = listafact.FirstOrDefault(f => f.IdFactura == idFactura);

            if (facturaExistente != null)
            {

                facturaExistente.Estado = nuevoEstado;
                facturaExistente.MotivoA = nuevoMotivo;

            }
            else
            {
                throw new Exception($"Factura con ID {idFactura} no encontrada");
            }
        }

    }
}
