﻿using Modelo;
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
        List<Plato> listaPlatos = new List<Plato>();
        static List<Pedido> listaPedidos = new List<Pedido>();
        List<Cliente> listaClientes = CtrlCliente.Clientes;
        static string pedidoR = string.Empty;

        CtrlConversiones ctrlConversiones = new CtrlConversiones();

        public static List<Pedido> ListaPedidos { get => listaPedidos; set => listaPedidos = value; }
        public static string PedidoR { get => pedidoR; set => pedidoR = value; }
        public static int Cantidades { get => cantidades; set => cantidades = value; }
        public static double TotalPed { get => totalPed; set => totalPed = value; }
        public List<Plato> ListaPlatos { get => listaPlatos; set => listaPlatos = value; }

        public void AgregarAlPedido(string pedidoSleccionado, string cantidadItem, DataGridView dgvIngresoPedido, TextBox txtCantPedido, TextBox txtTotPedido)
        {
            int cantItemAgregado = ctrlConversiones.toInt(cantidadItem);

            if(pedidoSleccionado != null && cantItemAgregado > 0)
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
            else
            {
                MessageBox.Show("Error: Datos sin ingresar");
            }
        }

        public void crearPlato()
        {
            for(int i = 0; i < 10; i++)
            {
                ListaPlatos.Add(new Plato(1, "hola", "huiajd", 8, true));
            }
        }


        public void LlenarCmbPedido(ComboBox cmbPedido)
        {
            foreach (var item in ListaPlatos)
            {
                if (item.Estado == true)
                {
                    cmbPedido.Items.Add(item.Descripcion + " - $" + item.Precio);
                }

            }
        }

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
            for (int i = 0; i < listaPedidos.Count; i++)
            {
                dgvPedidos.Rows.Add();
                dgvPedidos.Rows[i].Cells["idPedido"].Value = listaPedidos[i].CodPedido;
                dgvPedidos.Rows[i].Cells["clientePedido"].Value = listaPedidos[i].Cliente;
                dgvPedidos.Rows[i].Cells["menuPedido"].Value = listaPedidos[i].MenuSeleccionado;
                dgvPedidos.Rows[i].Cells["cantPedido"].Value = listaPedidos[i].CantidadProductos;
                dgvPedidos.Rows[i].Cells["valorPedido"].Value = $"$ {listaPedidos[i].TotalPedido}";

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

            if(campo != null && datoBuscar != null)
            {
                if (campo.ToLower().Equals("id"))
                {
                    int idBuscar = ctrlConversiones.toInt(datoBuscar);
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
                }

                if (pedidosBuscar.Count > 0)
                {
                    dgvPedidos.Rows.Clear();
                    for (int i = 0; i < pedidosBuscar.Count; i++)
                    {
                        dgvPedidos.Rows.Add();
                        dgvPedidos.Rows[i].Cells["idPedido"].Value = pedidosBuscar[i].CodPedido;
                        dgvPedidos.Rows[i].Cells["clientePedido"].Value = pedidosBuscar[i].Cliente;
                        dgvPedidos.Rows[i].Cells["menuPedido"].Value = pedidosBuscar[i].MenuSeleccionado;
                        dgvPedidos.Rows[i].Cells["cantPedido"].Value = pedidosBuscar[i].CantidadProductos;
                        dgvPedidos.Rows[i].Cells["valorPedido"].Value = $"$ {pedidosBuscar[i].TotalPedido}";
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron pedidos que coincidan con el dato");
                }
            }
            else
            {
                MessageBox.Show("Datos no validos para realizar la busqueda");            }
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
