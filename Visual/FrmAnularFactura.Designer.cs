namespace Visual
{
    partial class FrmAnularFactura
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
            this.cmbAnularEstado = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpFechaA = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAnularTotal = new System.Windows.Forms.TextBox();
            this.txtAnularIva = new System.Windows.Forms.TextBox();
            this.txtAnularSubtotal = new System.Windows.Forms.TextBox();
            this.txtAnularCliente = new System.Windows.Forms.TextBox();
            this.txtAnularCodfactura = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtContenido = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMotivoA = new System.Windows.Forms.Label();
            this.txtMotivoA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btRegistroAnulacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbAnularEstado
            // 
            this.cmbAnularEstado.FormattingEnabled = true;
            this.cmbAnularEstado.Items.AddRange(new object[] {
            "ACTIVO",
            "ANULADO"});
            this.cmbAnularEstado.Location = new System.Drawing.Point(265, 520);
            this.cmbAnularEstado.Name = "cmbAnularEstado";
            this.cmbAnularEstado.Size = new System.Drawing.Size(191, 33);
            this.cmbAnularEstado.TabIndex = 71;
            this.cmbAnularEstado.Text = "Activo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(70, 516);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 32);
            this.label11.TabIndex = 70;
            this.label11.Text = "Estado";
            // 
            // dtpFechaA
            // 
            this.dtpFechaA.CustomFormat = "dd-MM-yyy";
            this.dtpFechaA.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaA.Location = new System.Drawing.Point(782, 110);
            this.dtpFechaA.Name = "dtpFechaA";
            this.dtpFechaA.Size = new System.Drawing.Size(313, 31);
            this.dtpFechaA.TabIndex = 69;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(512, 110);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(249, 32);
            this.label8.TabIndex = 68;
            this.label8.Text = "Fecha de Emision";
            // 
            // txtAnularTotal
            // 
            this.txtAnularTotal.Enabled = false;
            this.txtAnularTotal.Location = new System.Drawing.Point(262, 436);
            this.txtAnularTotal.Name = "txtAnularTotal";
            this.txtAnularTotal.Size = new System.Drawing.Size(194, 31);
            this.txtAnularTotal.TabIndex = 64;
            // 
            // txtAnularIva
            // 
            this.txtAnularIva.Enabled = false;
            this.txtAnularIva.Location = new System.Drawing.Point(265, 354);
            this.txtAnularIva.Name = "txtAnularIva";
            this.txtAnularIva.Size = new System.Drawing.Size(191, 31);
            this.txtAnularIva.TabIndex = 63;
            // 
            // txtAnularSubtotal
            // 
            this.txtAnularSubtotal.Enabled = false;
            this.txtAnularSubtotal.Location = new System.Drawing.Point(264, 271);
            this.txtAnularSubtotal.Name = "txtAnularSubtotal";
            this.txtAnularSubtotal.Size = new System.Drawing.Size(192, 31);
            this.txtAnularSubtotal.TabIndex = 62;
            // 
            // txtAnularCliente
            // 
            this.txtAnularCliente.Enabled = false;
            this.txtAnularCliente.Location = new System.Drawing.Point(265, 183);
            this.txtAnularCliente.Name = "txtAnularCliente";
            this.txtAnularCliente.Size = new System.Drawing.Size(191, 31);
            this.txtAnularCliente.TabIndex = 61;
            // 
            // txtAnularCodfactura
            // 
            this.txtAnularCodfactura.Enabled = false;
            this.txtAnularCodfactura.Location = new System.Drawing.Point(264, 114);
            this.txtAnularCodfactura.Name = "txtAnularCodfactura";
            this.txtAnularCodfactura.Size = new System.Drawing.Size(192, 31);
            this.txtAnularCodfactura.TabIndex = 60;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(70, 183);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(129, 32);
            this.label15.TabIndex = 57;
            this.label15.Text = "Cliente: ";
            // 
            // txtContenido
            // 
            this.txtContenido.Enabled = false;
            this.txtContenido.Location = new System.Drawing.Point(518, 210);
            this.txtContenido.Margin = new System.Windows.Forms.Padding(12);
            this.txtContenido.Multiline = true;
            this.txtContenido.Name = "txtContenido";
            this.txtContenido.Size = new System.Drawing.Size(577, 457);
            this.txtContenido.TabIndex = 53;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(69, 436);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 32);
            this.label10.TabIndex = 52;
            this.label10.Text = "Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(69, 354);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 32);
            this.label7.TabIndex = 51;
            this.label7.Text = "IVA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 271);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 32);
            this.label3.TabIndex = 50;
            this.label3.Text = "Subtotal";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(729, 168);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 32);
            this.label9.TabIndex = 49;
            this.label9.Text = "PEDIDO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 32);
            this.label2.TabIndex = 48;
            this.label2.Text = "Cod Factura:";
            // 
            // lblMotivoA
            // 
            this.lblMotivoA.AutoSize = true;
            this.lblMotivoA.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivoA.Location = new System.Drawing.Point(69, 600);
            this.lblMotivoA.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMotivoA.Name = "lblMotivoA";
            this.lblMotivoA.Size = new System.Drawing.Size(285, 32);
            this.lblMotivoA.TabIndex = 72;
            this.lblMotivoA.Text = "Motivo de Anulación";
            // 
            // txtMotivoA
            // 
            this.txtMotivoA.Location = new System.Drawing.Point(75, 671);
            this.txtMotivoA.Multiline = true;
            this.txtMotivoA.Name = "txtMotivoA";
            this.txtMotivoA.Size = new System.Drawing.Size(381, 137);
            this.txtMotivoA.TabIndex = 73;
            this.txtMotivoA.TextChanged += new System.EventHandler(this.txtMotivoA_TextChanged);
            this.txtMotivoA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMotivoA_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(451, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 32);
            this.label1.TabIndex = 74;
            this.label1.Text = "Anular Factura";
            // 
            // btRegistroAnulacion
            // 
            this.btRegistroAnulacion.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegistroAnulacion.Location = new System.Drawing.Point(717, 719);
            this.btRegistroAnulacion.Name = "btRegistroAnulacion";
            this.btRegistroAnulacion.Size = new System.Drawing.Size(184, 60);
            this.btRegistroAnulacion.TabIndex = 75;
            this.btRegistroAnulacion.Text = "Anular";
            this.btRegistroAnulacion.UseVisualStyleBackColor = true;
            this.btRegistroAnulacion.Click += new System.EventHandler(this.btRegistroAnulacion_Click);
            // 
            // FrmAnularFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(1167, 841);
            this.Controls.Add(this.btRegistroAnulacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMotivoA);
            this.Controls.Add(this.lblMotivoA);
            this.Controls.Add(this.cmbAnularEstado);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtpFechaA);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAnularTotal);
            this.Controls.Add(this.txtAnularIva);
            this.Controls.Add(this.txtAnularSubtotal);
            this.Controls.Add(this.txtAnularCliente);
            this.Controls.Add(this.txtAnularCodfactura);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtContenido);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FrmAnularFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAnularFactura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAnularEstado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpFechaA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAnularTotal;
        private System.Windows.Forms.TextBox txtAnularIva;
        private System.Windows.Forms.TextBox txtAnularSubtotal;
        private System.Windows.Forms.TextBox txtAnularCliente;
        private System.Windows.Forms.TextBox txtAnularCodfactura;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtContenido;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMotivoA;
        private System.Windows.Forms.TextBox txtMotivoA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btRegistroAnulacion;
    }
}