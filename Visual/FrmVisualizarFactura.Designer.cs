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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvFactura = new System.Windows.Forms.DataGridView();
            this.ColIdfactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMotivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btBuscarTodos = new System.Windows.Forms.Button();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.cmbBusqueda = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btAnular = new System.Windows.Forms.Button();
            this.btReporteG = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(209)))));
            this.btBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btBuscar.FlatAppearance.BorderSize = 0;
            this.btBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btBuscar.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.btBuscar.Location = new System.Drawing.Point(81, 132);
            this.btBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(156, 44);
            this.btBuscar.TabIndex = 0;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // btVolver
            // 
            this.btVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(209)))));
            this.btVolver.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.btVolver.Location = new System.Drawing.Point(423, 575);
            this.btVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(156, 44);
            this.btVolver.TabIndex = 1;
            this.btVolver.Text = "Volver";
            this.btVolver.UseVisualStyleBackColor = false;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(538, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Visualizar Factura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.label2.Location = new System.Drawing.Point(77, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filtro de Busqueda";
            // 
            // dgvFactura
            // 
            this.dgvFactura.AllowUserToAddRows = false;
            this.dgvFactura.AllowUserToDeleteRows = false;
            this.dgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIdfactura,
            this.ColCedula,
            this.ColSubtotal,
            this.ColIva,
            this.ColTotal,
            this.ColEstado,
            this.ColMotivo,
            this.ColFecha});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 10.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFactura.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFactura.Location = new System.Drawing.Point(106, 208);
            this.dgvFactura.Margin = new System.Windows.Forms.Padding(4);
            this.dgvFactura.Name = "dgvFactura";
            this.dgvFactura.RowHeadersWidth = 82;
            this.dgvFactura.RowTemplate.Height = 33;
            this.dgvFactura.Size = new System.Drawing.Size(1022, 331);
            this.dgvFactura.TabIndex = 5;
            this.dgvFactura.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFactura_CellContentClick);
            // 
            // ColIdfactura
            // 
            this.ColIdfactura.HeaderText = "Id Factura";
            this.ColIdfactura.MinimumWidth = 6;
            this.ColIdfactura.Name = "ColIdfactura";
            this.ColIdfactura.Width = 70;
            // 
            // ColCedula
            // 
            this.ColCedula.HeaderText = "Cedula";
            this.ColCedula.MinimumWidth = 6;
            this.ColCedula.Name = "ColCedula";
            this.ColCedula.Width = 70;
            // 
            // ColSubtotal
            // 
            this.ColSubtotal.HeaderText = "Subtotal";
            this.ColSubtotal.MinimumWidth = 6;
            this.ColSubtotal.Name = "ColSubtotal";
            this.ColSubtotal.Width = 50;
            // 
            // ColIva
            // 
            this.ColIva.HeaderText = "Iva";
            this.ColIva.MinimumWidth = 6;
            this.ColIva.Name = "ColIva";
            this.ColIva.Width = 50;
            // 
            // ColTotal
            // 
            this.ColTotal.HeaderText = "Total a pagar";
            this.ColTotal.MinimumWidth = 6;
            this.ColTotal.Name = "ColTotal";
            this.ColTotal.Width = 200;
            // 
            // ColEstado
            // 
            this.ColEstado.HeaderText = "Estado";
            this.ColEstado.MinimumWidth = 6;
            this.ColEstado.Name = "ColEstado";
            this.ColEstado.Width = 50;
            // 
            // ColMotivo
            // 
            this.ColMotivo.HeaderText = "Motivo de Anulación";
            this.ColMotivo.MinimumWidth = 6;
            this.ColMotivo.Name = "ColMotivo";
            this.ColMotivo.Width = 200;
            // 
            // ColFecha
            // 
            this.ColFecha.HeaderText = "Fecha De Emision";
            this.ColFecha.MinimumWidth = 6;
            this.ColFecha.Name = "ColFecha";
            this.ColFecha.Width = 200;
            // 
            // btBuscarTodos
            // 
            this.btBuscarTodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(209)))));
            this.btBuscarTodos.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.btBuscarTodos.Location = new System.Drawing.Point(276, 131);
            this.btBuscarTodos.Margin = new System.Windows.Forms.Padding(4);
            this.btBuscarTodos.Name = "btBuscarTodos";
            this.btBuscarTodos.Size = new System.Drawing.Size(156, 44);
            this.btBuscarTodos.TabIndex = 6;
            this.btBuscarTodos.Text = "Todos";
            this.btBuscarTodos.UseVisualStyleBackColor = false;
            this.btBuscarTodos.Click += new System.EventHandler(this.btBuscarTodos_Click);
            // 
            // textBuscar
            // 
            this.textBuscar.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.textBuscar.Location = new System.Drawing.Point(746, 71);
            this.textBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.textBuscar.Multiline = true;
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(269, 24);
            this.textBuscar.TabIndex = 7;
            // 
            // cmbBusqueda
            // 
            this.cmbBusqueda.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.cmbBusqueda.FormattingEnabled = true;
            this.cmbBusqueda.Items.AddRange(new object[] {
            "Cedula",
            "Fecha de Emision",
            "Monto"});
            this.cmbBusqueda.Location = new System.Drawing.Point(256, 71);
            this.cmbBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBusqueda.Name = "cmbBusqueda";
            this.cmbBusqueda.Size = new System.Drawing.Size(391, 28);
            this.cmbBusqueda.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.label3.Location = new System.Drawing.Point(677, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "->";
            // 
            // btAnular
            // 
            this.btAnular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(209)))));
            this.btAnular.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btAnular.FlatAppearance.BorderSize = 2;
            this.btAnular.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.btAnular.Location = new System.Drawing.Point(915, 132);
            this.btAnular.Margin = new System.Windows.Forms.Padding(4);
            this.btAnular.Name = "btAnular";
            this.btAnular.Size = new System.Drawing.Size(156, 44);
            this.btAnular.TabIndex = 10;
            this.btAnular.Text = "Anular";
            this.btAnular.UseVisualStyleBackColor = false;
            this.btAnular.Click += new System.EventHandler(this.btAnular_Click);
            // 
            // btReporteG
            // 
            this.btReporteG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(209)))));
            this.btReporteG.FlatAppearance.BorderSize = 0;
            this.btReporteG.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.btReporteG.Location = new System.Drawing.Point(600, 575);
            this.btReporteG.Margin = new System.Windows.Forms.Padding(4);
            this.btReporteG.Name = "btReporteG";
            this.btReporteG.Size = new System.Drawing.Size(230, 44);
            this.btReporteG.TabIndex = 11;
            this.btReporteG.Text = "Reporte General";
            this.btReporteG.UseVisualStyleBackColor = false;
            this.btReporteG.Click += new System.EventHandler(this.btReporteG_Click);
            // 
            // FrmVisualizarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(1232, 661);
            this.Controls.Add(this.btReporteG);
            this.Controls.Add(this.btAnular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbBusqueda);
            this.Controls.Add(this.textBuscar);
            this.Controls.Add(this.btBuscarTodos);
            this.Controls.Add(this.dgvFactura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.btBuscar);
            this.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.ComboBox cmbBusqueda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btAnular;
        private System.Windows.Forms.Button btReporteG;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdfactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSubtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIva;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMotivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFecha;
    }
}