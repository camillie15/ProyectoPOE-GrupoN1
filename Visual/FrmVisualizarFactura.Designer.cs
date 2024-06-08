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
            this.dgvFactura = new System.Windows.Forms.DataGridView();
            this.btBuscarTodos = new System.Windows.Forms.Button();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.ColIdfactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // btBuscar
            // 
            this.btBuscar.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscar.Location = new System.Drawing.Point(194, 198);
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
            this.label1.Location = new System.Drawing.Point(501, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Visualizar Factura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(279, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cedula : ";
            // 
            // dgvFactura
            // 
            this.dgvFactura.AllowUserToDeleteRows = false;
            this.dgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIdfactura,
            this.ColCedula,
            this.ColSubtotal,
            this.ColIva,
            this.ColTotal});
            this.dgvFactura.Location = new System.Drawing.Point(70, 278);
            this.dgvFactura.Name = "dgvFactura";
            this.dgvFactura.ReadOnly = true;
            this.dgvFactura.RowHeadersWidth = 82;
            this.dgvFactura.RowTemplate.Height = 33;
            this.dgvFactura.Size = new System.Drawing.Size(1115, 393);
            this.dgvFactura.TabIndex = 5;
            // 
            // btBuscarTodos
            // 
            this.btBuscarTodos.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscarTodos.Location = new System.Drawing.Point(847, 198);
            this.btBuscarTodos.Name = "btBuscarTodos";
            this.btBuscarTodos.Size = new System.Drawing.Size(160, 58);
            this.btBuscarTodos.TabIndex = 6;
            this.btBuscarTodos.Text = "Todos";
            this.btBuscarTodos.UseVisualStyleBackColor = true;
            this.btBuscarTodos.Click += new System.EventHandler(this.btBuscarTodos_Click);
            // 
            // textBuscar
            // 
            this.textBuscar.Location = new System.Drawing.Point(437, 119);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(556, 31);
            this.textBuscar.TabIndex = 7;
            // 
            // ColIdfactura
            // 
            this.ColIdfactura.HeaderText = "Id Factura";
            this.ColIdfactura.MinimumWidth = 10;
            this.ColIdfactura.Name = "ColIdfactura";
            this.ColIdfactura.ReadOnly = true;
            // 
            // ColCedula
            // 
            this.ColCedula.HeaderText = "Cedula";
            this.ColCedula.MinimumWidth = 10;
            this.ColCedula.Name = "ColCedula";
            this.ColCedula.ReadOnly = true;
            // 
            // ColSubtotal
            // 
            this.ColSubtotal.HeaderText = "Subtotal";
            this.ColSubtotal.MinimumWidth = 10;
            this.ColSubtotal.Name = "ColSubtotal";
            this.ColSubtotal.ReadOnly = true;
            // 
            // ColIva
            // 
            this.ColIva.HeaderText = "Iva";
            this.ColIva.MinimumWidth = 10;
            this.ColIva.Name = "ColIva";
            this.ColIva.ReadOnly = true;
            // 
            // ColTotal
            // 
            this.ColTotal.HeaderText = "Total a pagar";
            this.ColTotal.MinimumWidth = 10;
            this.ColTotal.Name = "ColTotal";
            this.ColTotal.ReadOnly = true;
            // 
            // FrmVisualizarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(1269, 788);
            this.Controls.Add(this.textBuscar);
            this.Controls.Add(this.btBuscarTodos);
            this.Controls.Add(this.dgvFactura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.btBuscar);
            this.Name = "FrmVisualizarFactura";
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
        private System.Windows.Forms.DataGridView dgvFactura;
        private System.Windows.Forms.Button btBuscarTodos;
        private System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdfactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSubtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIva;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTotal;
    }
}