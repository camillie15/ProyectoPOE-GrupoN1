﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class IngresarPedido : Form
    {
        public IngresarPedido()
        {
            InitializeComponent();
            cmbPedido.Items.Add("");
        }

        private void txtCantItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            char caracter = e.KeyChar;
            if (!char.IsDigit(caracter) && caracter != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }
        }

    }
}