﻿using System;
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
    public partial class IngresarCliente : Form
    {
        public IngresarCliente()
        {
            InitializeComponent();
        }

        private void btnContinuarCliente_Click(object sender, EventArgs e)
        {
            IngresarPedido ingresarPedido = new IngresarPedido();
            ingresarPedido.Show();
            this.Close();
        }
    }
}
