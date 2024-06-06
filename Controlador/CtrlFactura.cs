using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Windows.Forms;

namespace Controlador
{
    public class CtrlFactura

    {
        CtrlConversiones v = new CtrlConversiones();
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
                    dgvFactura.Rows[i].Cells["ColCedula"].Value = f.Cliente;
                    dgvFactura.Rows[i].Cells["ColSubtotal"].Value = f.Subtotal;
                    dgvFactura.Rows[i].Cells["ColIva"].Value = f.Iva;
                    dgvFactura.Rows[i].Cells["ColTotal"].Value = f.Total;
                }
            }
            else
            {
                MessageBox.Show("NO EXISTEN PRESIONES REGISTRADAS.");
            }
        }


        public string RetornarClientePedido()
        {
            string cedula = string.Empty;
            if (listp.Count > 0)
            {
                cedula = listp[listp.Count - 1].Cliente;
            }
            else
            {
                cedula = string.Empty;
            }
            return cedula;
        }

        // generar id de factura

        public string CrearId()
        {
            return (listafact.Count + 1).ToString();
        }

        

        public void IngresarFactura(string pCliente, string pSubtotal, string pIva, string pTotal, string pIdFactura, TextBox txtTotal, TextBox txtIva, TextBox txtSubtotal)
        {
                double subtotal = v.ConvertirDouble(pSubtotal);
                double iva = v.ConvertirDouble(pIva);
                double total = v.ConvertirDouble(pTotal);
                int idFactura = v.toInt(pIdFactura);

                // Calculo
                double sub = Convert.ToDouble(txtSubtotal.Text);
                double ValorIva = 0.15;
                double TotalIva = sub * ValorIva;
                double totalConIva = sub + TotalIva;

                // Asigna los valores calculados a los TextBox correspondientes
                txtIva.Text = TotalIva.ToString("");
                txtTotal.Text = totalConIva.ToString("");

                // Crea una instancia de la clase Factura y agrega a la lista
                Factura factura = new Factura(TotalIva, pCliente, totalConIva, idFactura, sub);
                listafact.Add(factura);
            }

        }

 }
