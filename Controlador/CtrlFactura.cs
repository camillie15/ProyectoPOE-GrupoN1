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

        public void LlenaGrid(DataGridView dgvFactura)
        {
            int i = 0;

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


        public void IngresarFactura(string pIva, string pTotal, string pIdFactura, string pSubtotal)
        {
            double subtotal = v.toDouble(pSubtotal);
            double iva = v.toDouble(pIva);
            double total = v.toDouble(pTotal);
            int idFactura = v.toInt(pIdFactura);

            Pedido pedido = RetornarPedido();

            Factura factura = new Factura(iva, total, pedido, idFactura, subtotal);
            listafact.Add(factura);
        }

        public void Calcular(string pSubtotal, TextBox txtIva, TextBox txtTotal)
        {
            double subtotal;
            if (!double.TryParse(pSubtotal, out subtotal))
            {
                MessageBox.Show("Por favor, ingrese un subtotal válido.");
                return;
            }

            const double ValorIva = 0.15;
            double TotalIva = subtotal * ValorIva;
            double totalConIva = subtotal + TotalIva;

            txtIva.Text = TotalIva.ToString("");
            txtTotal.Text = totalConIva.ToString("");

        }


        public void BuscarFactura(DataGridView dgvFactura, string columna)
        {
            dgvFactura.Rows.Clear();
            int i = 0;
            bool tf = false;

            foreach (Factura f in Listafact)
            {
                if (string.IsNullOrEmpty(columna) || f.Pedido.Cliente.Cedula.Contains(columna))
                {
                    i = dgvFactura.Rows.Add();
                    dgvFactura.Rows[i].Cells["ColIdFactura"].Value = f.IdFactura;
                    dgvFactura.Rows[i].Cells["ColCedula"].Value = f.Pedido.Cliente.Cedula;
                    dgvFactura.Rows[i].Cells["ColSubtotal"].Value = f.Subtotal;
                    dgvFactura.Rows[i].Cells["ColIva"].Value = f.Iva;
                    dgvFactura.Rows[i].Cells["ColTotal"].Value = f.Total;
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
    }

}