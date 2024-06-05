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
        List<Cliente> listc = CtrlCliente.Clientes;
        //List<Pedido> listp = CtrlPedido.ListaPedidos;

        public static List<Factura> Listafact { get => listafact; set => listafact = value; }

    
        public void LlenaGrid(DataGridView dgvFactura)
        {
            int i = 0;
            foreach (Factura f in Listafact)
            {
                i = dgvFactura.Rows.Add();
                dgvFactura.Rows[i].Cells["ColIdFactura"].Value = f.IdFactura;
                dgvFactura.Rows[i].Cells["ColCliente"].Value = f.Cliente;
                //dgvFactura.Rows[i].Cells["ColCedula"].Value = f.cedula;
                dgvFactura.Rows[i].Cells["ColTotal"].Value = f.Total;

            }
        }

        public void llenarPedido (TextBox txtContenido)
        {

        }


        public string CrearId()
        {
            return (listafact.Count + 1).ToString();
        }

        public string obternercliente()
        {
            return listc[listc.Count - 1].nombre + "\n" +
                   listc[listc.Count - 1].apellido;
            
        }

        public void IngresarFactura(string pCliente, string pSubtotal, string pIva, string pTotal, string pIdFactura)
        {
            double subtotal = v.ConvertirDouble(pSubtotal);
            double iva = v.ConvertirDouble(pIva);
            double total = v.ConvertirDouble(pTotal);
            int idFactura = v.toInt(pIdFactura);

            Factura factura = new Factura( pCliente, subtotal, iva, total, idFactura);

            listafact.Add(factura);

        }





    }
}
