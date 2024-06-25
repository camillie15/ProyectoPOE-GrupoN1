namespace Visual
{
    partial class FrmIngresarFactura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContenido = new System.Windows.Forms.TextBox();
            this.txtEfectivo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnCancelarFactura = new System.Windows.Forms.Button();
            this.btFinalizar = new System.Windows.Forms.Button();
            this.txtCodfactura = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtDevolucion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btEditarPedido = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(366, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "PEDIDO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(131, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Cod Factura:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "FACTURACIÓN";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(36, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "IVA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Subtotal";
            // 
            // txtContenido
            // 
            this.txtContenido.Enabled = false;
            this.txtContenido.Location = new System.Drawing.Point(260, 107);
            this.txtContenido.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtContenido.Multiline = true;
            this.txtContenido.Name = "txtContenido";
            this.txtContenido.Size = new System.Drawing.Size(290, 225);
            this.txtContenido.TabIndex = 26;
            // 
            // txtEfectivo
            // 
            this.txtEfectivo.Location = new System.Drawing.Point(133, 269);
            this.txtEfectivo.Multiline = true;
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.Size = new System.Drawing.Size(99, 18);
            this.txtEfectivo.TabIndex = 30;
            this.txtEfectivo.TextChanged += new System.EventHandler(this.txtEfectivo_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(37, 266);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 17);
            this.label14.TabIndex = 29;
            this.label14.Text = "Efectivo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(36, 312);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 17);
            this.label13.TabIndex = 27;
            this.label13.Text = "Devolución";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(37, 94);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 17);
            this.label15.TabIndex = 31;
            this.label15.Text = "Cliente: ";
            // 
            // btnCancelarFactura
            // 
            this.btnCancelarFactura.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarFactura.Location = new System.Drawing.Point(427, 371);
            this.btnCancelarFactura.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelarFactura.Name = "btnCancelarFactura";
            this.btnCancelarFactura.Size = new System.Drawing.Size(117, 36);
            this.btnCancelarFactura.TabIndex = 34;
            this.btnCancelarFactura.Text = "Cancelar";
            this.btnCancelarFactura.UseVisualStyleBackColor = true;
            this.btnCancelarFactura.Click += new System.EventHandler(this.btnCancelarFactura_Click);
            // 
            // btFinalizar
            // 
            this.btFinalizar.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFinalizar.Location = new System.Drawing.Point(35, 368);
            this.btFinalizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btFinalizar.Name = "btFinalizar";
            this.btFinalizar.Size = new System.Drawing.Size(117, 36);
            this.btFinalizar.TabIndex = 35;
            this.btFinalizar.Text = "Registrar";
            this.btFinalizar.UseVisualStyleBackColor = true;
            this.btFinalizar.Click += new System.EventHandler(this.btFinalizar_Click);
            // 
            // txtCodfactura
            // 
            this.txtCodfactura.Enabled = false;
            this.txtCodfactura.Location = new System.Drawing.Point(134, 58);
            this.txtCodfactura.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCodfactura.Name = "txtCodfactura";
            this.txtCodfactura.Size = new System.Drawing.Size(98, 20);
            this.txtCodfactura.TabIndex = 36;
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(134, 94);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(98, 20);
            this.txtCliente.TabIndex = 37;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(134, 140);
            this.txtSubtotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(98, 20);
            this.txtSubtotal.TabIndex = 38;
            this.txtSubtotal.TextChanged += new System.EventHandler(this.txtSubtotal_TextChanged);
            // 
            // txtIva
            // 
            this.txtIva.Enabled = false;
            this.txtIva.Location = new System.Drawing.Point(134, 183);
            this.txtIva.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(98, 20);
            this.txtIva.TabIndex = 39;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(133, 225);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(99, 20);
            this.txtTotal.TabIndex = 40;
            // 
            // txtDevolucion
            // 
            this.txtDevolucion.Enabled = false;
            this.txtDevolucion.Location = new System.Drawing.Point(133, 312);
            this.txtDevolucion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDevolucion.Name = "txtDevolucion";
            this.txtDevolucion.Size = new System.Drawing.Size(99, 20);
            this.txtDevolucion.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(114, 269);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 17);
            this.label4.TabIndex = 42;
            this.label4.Text = "$";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(116, 310);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 17);
            this.label5.TabIndex = 43;
            this.label5.Text = "$";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(257, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 17);
            this.label8.TabIndex = 44;
            this.label8.Text = "Fecha de Emision";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "dd-MM-yyy";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(392, 55);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(158, 20);
            this.dtpFecha.TabIndex = 45;
            // 
            // btEditarPedido
            // 
            this.btEditarPedido.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditarPedido.Location = new System.Drawing.Point(231, 371);
            this.btEditarPedido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btEditarPedido.Name = "btEditarPedido";
            this.btEditarPedido.Size = new System.Drawing.Size(117, 36);
            this.btEditarPedido.TabIndex = 46;
            this.btEditarPedido.Text = "Editar Pedido";
            this.btEditarPedido.UseVisualStyleBackColor = true;
            this.btEditarPedido.Click += new System.EventHandler(this.btEditarPedido_Click);
            // 
            // FrmIngresarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(583, 434);
            this.Controls.Add(this.btEditarPedido);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDevolucion);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtIva);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtCodfactura);
            this.Controls.Add(this.btFinalizar);
            this.Controls.Add(this.btnCancelarFactura);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtEfectivo);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtContenido);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmIngresarFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IngresarFactura";
            this.Load += new System.EventHandler(this.FrmIngresarFactura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContenido;
        private System.Windows.Forms.TextBox txtEfectivo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnCancelarFactura;
        private System.Windows.Forms.Button btFinalizar;
        private System.Windows.Forms.TextBox txtCodfactura;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtDevolucion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btEditarPedido;
    }
}