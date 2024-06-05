namespace Visual
{
    partial class VisualizarPedido
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.cmbCampoBusqueda = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVolverPedido = new System.Windows.Forms.Button();
            this.btnBuscarPedido = new System.Windows.Forms.Button();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.idPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientePedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(434, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "VISUALIZAR PEDIDOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Campo a buscar:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(555, 71);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(170, 28);
            this.txtBusqueda.TabIndex = 2;
            // 
            // cmbCampoBusqueda
            // 
            this.cmbCampoBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCampoBusqueda.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCampoBusqueda.FormattingEnabled = true;
            this.cmbCampoBusqueda.Items.AddRange(new object[] {
            "ID",
            "CLIENTE",
            "TODOS"});
            this.cmbCampoBusqueda.Location = new System.Drawing.Point(367, 71);
            this.cmbCampoBusqueda.Name = "cmbCampoBusqueda";
            this.cmbCampoBusqueda.Size = new System.Drawing.Size(121, 28);
            this.cmbCampoBusqueda.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(506, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "->";
            // 
            // btnVolverPedido
            // 
            this.btnVolverPedido.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverPedido.Image = global::Visual.Properties.Resources.imgVolver;
            this.btnVolverPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolverPedido.Location = new System.Drawing.Point(475, 492);
            this.btnVolverPedido.Name = "btnVolverPedido";
            this.btnVolverPedido.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnVolverPedido.Size = new System.Drawing.Size(145, 50);
            this.btnVolverPedido.TabIndex = 7;
            this.btnVolverPedido.Text = "Volver";
            this.btnVolverPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVolverPedido.UseVisualStyleBackColor = true;
            this.btnVolverPedido.Click += new System.EventHandler(this.btnVolverPedido_Click);
            // 
            // btnBuscarPedido
            // 
            this.btnBuscarPedido.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarPedido.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPedido.Image = global::Visual.Properties.Resources.imgBuscar;
            this.btnBuscarPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarPedido.Location = new System.Drawing.Point(749, 59);
            this.btnBuscarPedido.Name = "btnBuscarPedido";
            this.btnBuscarPedido.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnBuscarPedido.Size = new System.Drawing.Size(145, 50);
            this.btnBuscarPedido.TabIndex = 5;
            this.btnBuscarPedido.Text = "Buscar ";
            this.btnBuscarPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarPedido.UseVisualStyleBackColor = false;
            this.btnBuscarPedido.Click += new System.EventHandler(this.btnBuscarPedido_Click);
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(192)))), ((int)(((byte)(179)))));
            this.dgvPedidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPedido,
            this.clientePedido,
            this.menuPedido,
            this.cantPedido,
            this.valorPedido});
            this.dgvPedidos.Enabled = false;
            this.dgvPedidos.Location = new System.Drawing.Point(88, 128);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.RowHeadersWidth = 51;
            this.dgvPedidos.RowTemplate.Height = 24;
            this.dgvPedidos.Size = new System.Drawing.Size(997, 332);
            this.dgvPedidos.TabIndex = 8;
            // 
            // idPedido
            // 
            this.idPedido.HeaderText = "Id Pedido";
            this.idPedido.MinimumWidth = 6;
            this.idPedido.Name = "idPedido";
            this.idPedido.Width = 110;
            // 
            // clientePedido
            // 
            this.clientePedido.HeaderText = "Cliente";
            this.clientePedido.MinimumWidth = 6;
            this.clientePedido.Name = "clientePedido";
            this.clientePedido.Width = 125;
            // 
            // menuPedido
            // 
            this.menuPedido.HeaderText = "Menu Seleccionado";
            this.menuPedido.MinimumWidth = 6;
            this.menuPedido.Name = "menuPedido";
            this.menuPedido.Width = 180;
            // 
            // cantPedido
            // 
            this.cantPedido.HeaderText = "Cantidad Total";
            this.cantPedido.MinimumWidth = 6;
            this.cantPedido.Name = "cantPedido";
            this.cantPedido.Width = 155;
            // 
            // valorPedido
            // 
            this.valorPedido.HeaderText = "Valor Total";
            this.valorPedido.MinimumWidth = 6;
            this.valorPedido.Name = "valorPedido";
            this.valorPedido.Width = 125;
            // 
            // VisualizarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(1178, 574);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.btnVolverPedido);
            this.Controls.Add(this.btnBuscarPedido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbCampoBusqueda);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "VisualizarPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar Pedido";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.ComboBox cmbCampoBusqueda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarPedido;
        private System.Windows.Forms.Button btnVolverPedido;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientePedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorPedido;
    }
}