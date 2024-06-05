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
        List<Cliente> listaClientes = CtrlCliente.Clientes;
        static string pedidoR = string.Empty;

        CtrlConversiones ctrlConversiones = new CtrlConversiones();

        public static List<Pedido> ListaPedidos { get => listaPedidos; set => listaPedidos = value; }
        public static string PedidoR { get => pedidoR; set => pedidoR = value; }
        public static int Cantidades { get => cantidades; set => cantidades = value; }
        public static double TotalPed { get => totalPed; set => totalPed = value; }

        public void AgregarAlPedido(string pedidoSleccionado, string cantidadItem, DataGridView dgvIngresoPedido, TextBox txtCantPedido, TextBox txtTotPedido)
        {

            string[] pedidoAgg = pedidoSleccionado.Split('-');

            string descripcionPed = pedidoAgg[0];
            string precio = pedidoAgg[1].Substring(2);
            double precioItem = ctrlConversiones.toDouble(precio);
            int cantidadItemPed = ctrlConversiones.toInt(cantidadItem);

            double totalPedidoItem = precioItem * cantidadItemPed;

            int i = dgvIngresoPedido.Rows.Add();

            dgvIngresoPedido.Rows[i].Cells["descripcionPedido"].Value = descripcionPed;
            dgvIngresoPedido.Rows[i].Cells["valorUnitarioItem"].Value = $"$ {precioItem}";
            dgvIngresoPedido.Rows[i].Cells["cantidadItem"].Value = cantidadItemPed;
            dgvIngresoPedido.Rows[i].Cells["valorTotalPedido"].Value = $"$ {totalPedidoItem}";

            Cantidades += cantidadItemPed;
            TotalPed += (precioItem * cantidadItemPed);
            txtCantPedido.Text = Cantidades.ToString();
            txtTotPedido.Text = $"$ {TotalPed.ToString()}";

            PedidoR += pedidoSleccionado + "\n";

        }

        /*public void LlenarCmbPedido(ComboBox cmbPedido)
        {
            foreach (var item in listaPlatos)
            {
                if (item.Estado == true)
                {
                    cmbPedido.Items.Add(item.Descripcion + " - $" + item.Precio);
                }

            }
        }*/

        public bool IngresarPedido(string sId, string cliente, string menu, string sCantItems, string sTotalPed)
        {
            bool flag = false;

            int id = ctrlConversiones.toInt(sId);
            int cantItem = ctrlConversiones.toInt(sCantItems);
            string totP = ctrlConversiones.stringWithoutDolar(sTotalPed);
            double totalPed = ctrlConversiones.toDouble(totP);

            Pedido pedidoN = null;

            if (menu != null && totalPed > 0 && cantItem > 0)
            {
                pedidoN = new Pedido(id, cliente, menu, cantItem, totalPed);
                ListaPedidos.Add(pedidoN);
                flag = true;
            }
            else
            {
                MessageBox.Show("Error: Datos sin ingresar");
                flag = false;
            }
            return flag;

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
                dgvPedidos.Rows[i].Cells["valorPedido"].Value = $"$ {pedido.TotalPedido}";

            }
        }

        public string RetornarCICliente()
        {
            string cedula = string.Empty;
            if(listaClientes.Count > 0)
            {
                cedula = listaClientes[listaClientes.Count - 1].Cedula;
            }
            else
            {
                cedula = string.Empty;
            }
            return cedula;
        }

        public void BuscarPedido(string campo, string datoBuscar, DataGridView dgvPedidos)
        {
            List<Pedido> pedidosBuscar = new List<Pedido>();

            if (campo.ToLower().Equals("id"))
            {
                int idBuscar = Convert.ToInt32(datoBuscar);
                Pedido pedidoBuscar = ListaPedidos.Find(delBuscar => delBuscar.CodPedido == idBuscar);
                if (pedidoBuscar != null)
                {
                    pedidosBuscar.Add(pedidoBuscar);
                }
            }
            else if (campo.ToLower().Equals("cliente"))
            {
                pedidosBuscar = ListaPedidos.FindAll(delBuscar => delBuscar.Cliente.Contains(datoBuscar));
            }
            else if (campo.ToLower().Equals("todos"))
            {
                pedidosBuscar = ListaPedidos;
                ;
            }

            if (pedidosBuscar.Count > 0)
            {
                dgvPedidos.Rows.Clear();
                foreach (Pedido pedidoB in pedidosBuscar)
                {
                    int i = dgvPedidos.Rows.Add();
                    dgvPedidos.Rows[i].Cells["idPedido"].Value = pedidoB.CodPedido;
                    dgvPedidos.Rows[i].Cells["clientePedido"].Value = pedidoB.Cliente;
                    dgvPedidos.Rows[i].Cells["menuPedido"].Value = pedidoB.MenuSeleccionado;
                    dgvPedidos.Rows[i].Cells["cantPedido"].Value = pedidoB.CantidadProductos;
                    dgvPedidos.Rows[i].Cells["valorPedido"].Value = $"$ {pedidoB.TotalPedido}";
                }
            }
            else
            {
                MessageBox.Show("No se encontraron pedidos que coincidan con los criterios de búsqueda.");
            }
        }

        public void RestartPedido()
        {
            Cantidades = 0;
            TotalPed = 0;
            pedidoR = string.Empty;
        }

        public void EliminarRegistroCliente(string cedula)
        {
            Cliente clienteEliminar = listaClientes.Find(cliente => cliente.Cedula.Equals(cedula));
            if(clienteEliminar != null )
            {
                listaClientes.Remove(clienteEliminar);
                CtrlCliente.Clientes = listaClientes;
            }
        }
    }
}
