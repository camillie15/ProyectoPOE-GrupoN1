using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controlador
{
    public class CtrlPedido
    {
        static int cantidades = 0;
        static double totalPed = 0;
        //List<Plato> listaPlatos = CtrlPlato.Platos;
        static List<Pedido> listaPedidos = new List<Pedido>();
        static string pedidoR = string.Empty;

        public List<Pedido> ListaPedidos { get => listaPedidos; set => listaPedidos = value; }
        public static string PedidoR { get => pedidoR; set => pedidoR = value; }

        public void AgregarAlPedido(string pedidoSleccionado, string cantidadItem, DataGridView dgvIngresoPedido, TextBox txtCantPedido, TextBox txtTotPedido)
        {

            string[] pedidoAgg = pedidoSleccionado.Split('-');

            string descripcionPed = pedidoAgg[0];
            string precio = pedidoAgg[1].Substring(2);
            double precioItem = Convert.ToDouble(precio);
            int cantidadItemPed = Convert.ToInt32(cantidadItem);

            double totalPedidoItem = precioItem * cantidadItemPed;

            int i = dgvIngresoPedido.Rows.Add();

            dgvIngresoPedido.Rows[i].Cells["descripcionPedido"].Value = descripcionPed;
            dgvIngresoPedido.Rows[i].Cells["valorUnitarioItem"].Value = precioItem;
            dgvIngresoPedido.Rows[i].Cells["cantidadItem"].Value = cantidadItemPed;
            dgvIngresoPedido.Rows[i].Cells["valorTotalPedido"].Value = totalPedidoItem;

            cantidades += cantidadItemPed;
            totalPed += (precioItem * cantidadItemPed);
            txtCantPedido.Text = cantidades.ToString();
            txtTotPedido.Text = totalPed.ToString();

            PedidoR += pedidoSleccionado + "\n";

        }

        /*public void LlenarCmbPedido(ComboBox cmbPedido)
        {
            foreach (var item in listaPlatos)
            {

                cmbPedido.Items.Add(item.Descripcion + " - $" + item.Precio);
            }
        }*/

        public void IngresarPedido(string sId, string cliente, string menu, string sCantItems, string sTotalPed)
        {
            int id = Convert.ToInt32(sId);
            int cantItem = Convert.ToInt32(sCantItems);
            double totalPed = Convert.ToDouble(sTotalPed);

            Pedido pedidoN = null;

            if (menu != null && totalPed > 0)
            {
                pedidoN = new Pedido(id, cliente, menu, cantItem, totalPed);
                ListaPedidos.Add(pedidoN);
            }

            MessageBox.Show($"{id} \n{cliente} \n{menu} \n{cantItem} \n{totalPed}");

        }

        public void AutocompletarGrid(DataGridView dgvPedidos)
        {
            int i = 0;
            foreach (Pedido pedido in ListaPedidos)
            {
                i = dgvPedidos.Rows.Add();
                dgvPedidos.Rows[i].Cells["idPedido"].Value = pedido.CodPedido;
                dgvPedidos.Rows[i].Cells["clientePedido"].Value = pedido.Cliente;
                dgvPedidos.Rows[i].Cells["menuPedido"].Value = pedido.MenuSeleccionado;
                dgvPedidos.Rows[i].Cells["cantPedido"].Value = pedido.CantidadProductos;
                dgvPedidos.Rows[i].Cells["valorPedido"].Value = pedido.TotalPedido;

            }
        }

    }
}
