using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Windows.Forms;
using System.IO;
using Datos;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Controlador
{
    public class CtrlFactura

    {
        CtrlConversiones v = new CtrlConversiones();
        CtrlPedido p = new CtrlPedido();
        DatosFactura dFactura = new DatosFactura();
        DatosPlatoPedido datosPlatoPedido = new DatosPlatoPedido();
        static List<Factura> listafact = new List<Factura>();
        static List<PlatoPedido> plat = new List<PlatoPedido>();
        // lista pedido
        DatosPedido dPedido = new DatosPedido();

        List<Pedido> listp = CtrlPedido.ListaPedidosDB;
        //static List<Pedido> listp = null;

        Conexion cbdd = new Conexion();


        public static List<Factura> Listafact { get => listafact; set => listafact = value; }

        public void LlenaGrid(DataGridView dgvFactura, bool todos = true, string estadoF = "")
        {
            listp = dPedido.ConsultarPedidos();
            IEnumerable<Factura> facturas;
            if (todos)
            {
                facturas = listafact;
            }
            else if (estadoF.Equals("Activo", StringComparison.OrdinalIgnoreCase))
            {
                facturas = listafact.Where(p => p.Estado == true);
            }
            else if (estadoF.Equals("Anulado", StringComparison.OrdinalIgnoreCase))
            {
                facturas = listafact.Where(p => !p.Estado == false);
            }
            else
            {
                throw new ArgumentException("El estado no es válido. Debe ser 'ACTIVO', 'ANULADO'.");
            }

            listafact = dFactura.ConsultarFactura();
            for (int i = 0; i < listafact.Count; i++)
            {
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
                        dgvFactura.Rows[i].Cells["ColEstado"].Value = f.Estado ? "ACTIVO" : "ANULADO";
                        dgvFactura.Rows[i].Cells["ColMotivo"].Value = f.MotivoA;
                        dgvFactura.Rows[i].Cells["ColFecha"].Value = f.Fecha.ToString("d");
                    }
                }
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
            return Convert.ToString(dFactura.UltimoIdFactura() + 1);
        }

        public void IngresarFactura(string pIva, string pTotal, string pIdFactura, string pSubtotal, string pEstado, string pMotivoA, string pFecha)
        {
            double subtotal = v.toDouble(pSubtotal);
            double iva = v.toDouble(pIva);
            double total = v.toDouble(pTotal);
            int idFactura = v.toInt(pIdFactura);
            bool estado = true;
            DateTime fecha = v.ConvertirDateTime(pFecha);
            Pedido pedido = RetornarPedido();

            Factura factura = new Factura(iva, total, pedido, idFactura, subtotal, estado, pMotivoA, fecha);
            //listafact.Add(factura);
            IngresoFacturaBD(factura);
        }
        private void IngresoFacturaBD(Factura factura)
        {
            string msj = cbdd.Conectar();
            string msjBDD = "";
            if (msj[0] == '1')
            {
                msjBDD = dFactura.IngresoFactura(factura);
                MessageBox.Show(msjBDD);
                if (msjBDD[0] == '0')
                {
                    MessageBox.Show("Error en el registro" + msjBDD);
                }
            }
            else if (msj[0] == '0')
            {
                MessageBox.Show("Error" + msj);
            }
            cbdd.Desconectar();
        }

        //public void IngresarFactura(string pIva, string pTotal, string pIdFactura, string pSubtotal, string pEstado, string pMotivoA, string pFecha)
        //{
        //    double subtotal = v.toDouble(pSubtotal);
        //    double iva = v.toDouble(pIva);
        //    double total = v.toDouble(pTotal);
        //    int idFactura = v.toInt(pIdFactura);
        //    bool estado = pEstado.Equals("Activo", StringComparison.OrdinalIgnoreCase);
        //    DateTime fecha = v.ConvertirDateTime(pFecha);

        //    Pedido pedido = RetornarPedido();

        //    Factura factura = new Factura(iva, total, pedido, idFactura, subtotal, estado, pMotivoA, fecha);
        //    listafact.Add(factura);
        //}

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

            ivaText = TotalIva.ToString("");
            totalText = totalConIva.ToString("");
        }

        public void BuscarFactura(DataGridView dgvFactura, string filtro, string cmbFiltro)
        {
            List<Factura> facturasBuscar = new List<Factura>();

            if (!string.IsNullOrEmpty(filtro) || cmbFiltro.ToLower().Equals("todos"))
            {
                foreach (Factura f in Listafact)
                {
                    bool flag = false;

                    // Busqueda por cedula
                    if (cmbFiltro.ToLower().Equals("cedula") && f.Pedido.Cliente.Cedula.Contains(filtro))
                    {
                        flag = true;
                    }
                    // Busqueda por total de factura
                    else if (cmbFiltro.ToLower().Equals("monto"))
                    {
                        string montoBuscar = filtro;
                        if (f.Total.ToString("").Equals(montoBuscar))
                        {
                            flag = true;
                        }
                    }
                    // Buscar todos
                    else if (cmbFiltro.ToLower().Equals("todos"))
                    {
                        flag = true;
                    }

                    if (flag)
                    {
                        facturasBuscar.Add(f);
                    }
                }

                if (facturasBuscar.Count > 0)
                {
                    for (int i = 0; i < facturasBuscar.Count; i++)
                    {
                        int rowIndex = dgvFactura.Rows.Add();
                        dgvFactura.Rows[rowIndex].Cells["ColIdFactura"].Value = facturasBuscar[i].IdFactura;
                        dgvFactura.Rows[rowIndex].Cells["ColCedula"].Value = facturasBuscar[i].Pedido.Cliente.Cedula;
                        dgvFactura.Rows[rowIndex].Cells["ColSubtotal"].Value = facturasBuscar[i].Subtotal;
                        dgvFactura.Rows[rowIndex].Cells["ColIva"].Value = facturasBuscar[i].Iva;
                        dgvFactura.Rows[rowIndex].Cells["ColTotal"].Value = facturasBuscar[i].Total;
                        dgvFactura.Rows[rowIndex].Cells["ColEstado"].Value = facturasBuscar[i].Estado ? "ACTIVO" : "ANULADO";
                        dgvFactura.Rows[rowIndex].Cells["ColMotivo"].Value = facturasBuscar[i].MotivoA;
                        dgvFactura.Rows[rowIndex].Cells["ColFecha"].Value = facturasBuscar[i].Fecha.ToString("d");
                    }
                }
                else
                {
                    MessageBox.Show("ERROR: NO SE ENCONTRARON RESULTADOS CON LOS FILTROS PROPORCIONADOS.", "SIN RESULTADOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Datos no válidos para realizar la búsqueda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void llenarTxt(TextBox txtContenido, TextBox txtSubtotal, TextBox txtCliente)
        {
            Pedido ped = RetornarPedido();

            List<PlatoPedido> listaPlatoPedidoByIdDB = datosPlatoPedido.ConsultarPlatoPedidosPorId(ped.CodPedido);
            string contenido = string.Empty;

            foreach (PlatoPedido platoPedido in listaPlatoPedidoByIdDB)
            {
                if (platoPedido.Estado == true)
                {
                    contenido += $"cantidad : {platoPedido.Cantidad}\n" + Environment.NewLine + $"plato: {platoPedido.Descripcion}\n ";

                }
            }


            txtContenido.Text = contenido;
            txtSubtotal.Text = ped.TotalPedido.ToString();
            txtCliente.Text = ped.Cliente.Cedula;
        }


        public void EditarFactura(int idFactura, bool estado, string motivoA)
        {
            Factura factura = new Factura (idFactura, estado, motivoA);
            dFactura.AnularFactura(factura);
            int posicion = listafact.FindIndex(f => f.IdFactura == idFactura);
            if (posicion >= 0)
            {
                listafact[posicion].Estado = estado;
                listafact[posicion].MotivoA = motivoA;
            }
        }


        public void ConectarBD()
        {
            string msj = cbdd.Conectar();
            if (msj[0] == '1')
            {
                MessageBox.Show("Conexion Exitosa!");
            }
            else if (msj[0] == '0')
            {
                MessageBox.Show("Ocurrio un error: " + msj);
            }
            cbdd.Desconectar();
        }


    }
}

