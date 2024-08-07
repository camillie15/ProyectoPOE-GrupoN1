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
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
            this.Activated += new EventHandler(this.FrmMenuPrincipal_Activated);

        }
        private void FrmMenuPrincipal_Activated(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }
        private void btnMenuPedido_Click(object sender, EventArgs e)
        {
            FrmIngresarPedido ingresarPedido = new FrmIngresarPedido();
            ingresarPedido.Show();
        }

        private void btnOpcionesUsuario_Click(object sender, EventArgs e)
        {
            FrmOpcionesAdministracion opcionesAdministraciones = new FrmOpcionesAdministracion();
            opcionesAdministraciones.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmIngresarCliente ingresarCliente = new FrmIngresarCliente();
            ingresarCliente.ShowDialog();
        }

        private void btnAutores_Click(object sender, EventArgs e)
        {
            FrmAutores frmAutores = new FrmAutores();
            frmAutores.ShowDialog();
        }

    }
}
