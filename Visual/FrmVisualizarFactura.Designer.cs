namespace Visual
{
    partial class FrmVisualizarFactura
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
            this.btBuscar = new System.Windows.Forms.Button();
            this.btVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.dgvFactura = new System.Windows.Forms.DataGridView();
            this.ColIdfactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // btBuscar
            // 
            this.btBuscar.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscar.Location = new System.Drawing.Point(70, 192);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(160, 58);
            this.btBuscar.TabIndex = 0;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // btVolver
            // 
            this.btVolver.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVolver.Location = new System.Drawing.Point(573, 701);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(160, 58);
            this.btVolver.TabIndex = 1;
            this.btVolver.Text = "Volver";
            this.btVolver.UseVisualStyleBackColor = true;
            this.btVolver.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(509, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Visualizar Factura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filtro de Busqueda: ";
            // 
            // cbFiltro
            // 
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Items.AddRange(new object[] {
            "Id de facturas",
            "Cedula"});
            this.cbFiltro.Location = new System.Drawing.Point(345, 131);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(315, 33);
            this.cbFiltro.TabIndex = 4;
            // 
            // dgvFactura
            // 
            this.dgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIdfactura,
            this.ColCliente,
            this.ColCedula,
            this.ColTotal});
            this.dgvFactura.Location = new System.Drawing.Point(70, 278);
            this.dgvFactura.Name = "dgvFactura";
            this.dgvFactura.RowHeadersWidth = 82;
            this.dgvFactura.RowTemplate.Height = 33;
            this.dgvFactura.Size = new System.Drawing.Size(1115, 393);
            this.dgvFactura.TabIndex = 5;
            // 
            // ColIdfactura
            // 
            this.ColIdfactura.HeaderText = "Id Factura";
            this.ColIdfactura.MinimumWidth = 10;
            this.ColIdfactura.Name = "ColIdfactura";
            this.ColIdfactura.Width = 130;
            // 
            // ColCliente
            // 
            this.ColCliente.HeaderText = "Cliente";
            this.ColCliente.MinimumWidth = 10;
            this.ColCliente.Name = "ColCliente";
            this.ColCliente.Width = 130;
            // 
            // ColCedula
            // 
            this.ColCedula.HeaderText = "Cedula";
            this.ColCedula.MinimumWidth = 10;
            this.ColCedula.Name = "ColCedula";
            this.ColCedula.Width = 130;
            // 
            // ColTotal
            // 
            this.ColTotal.HeaderText = "Total a pagar";
            this.ColTotal.MinimumWidth = 10;
            this.ColTotal.Name = "ColTotal";
            this.ColTotal.Width = 200;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(718, 134);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(361, 31);
            this.textBox1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(674, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "->";
            // 
            // VisualizarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 788);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgvFactura);
            this.Controls.Add(this.cbFiltro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.btBuscar);
            this.Name = "VisualizarFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VisualizarFactura";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.DataGridView dgvFactura;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdfactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTotal;
    }
}