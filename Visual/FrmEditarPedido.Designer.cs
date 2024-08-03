namespace Visual
{
    partial class FrmEditarPedido
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.dgvIngresoPedido = new System.Windows.Forms.DataGridView();
            this.descripcionPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorUnitarioItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotalPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAggPedido = new System.Windows.Forms.Button();
            this.btnContinuarPedido = new System.Windows.Forms.Button();
            this.txtTotPedido = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCantPedido = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCantItem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPedido = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdPedido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminarMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresoPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCliente
            // 
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(426, 81);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(583, 28);
            this.cmbCliente.TabIndex = 38;
            // 
            // dgvIngresoPedido
            // 
            this.dgvIngresoPedido.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(62)))));
            this.dgvIngresoPedido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIngresoPedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvIngresoPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngresoPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descripcionPedido,
            this.valorUnitarioItem,
            this.cantidadItem,
            this.valorTotalPedido});
            this.dgvIngresoPedido.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvIngresoPedido.Location = new System.Drawing.Point(112, 227);
            this.dgvIngresoPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvIngresoPedido.Name = "dgvIngresoPedido";
            this.dgvIngresoPedido.RowHeadersWidth = 51;
            this.dgvIngresoPedido.RowTemplate.Height = 24;
            this.dgvIngresoPedido.Size = new System.Drawing.Size(885, 185);
            this.dgvIngresoPedido.TabIndex = 37;
            // 
            // descripcionPedido
            // 
            this.descripcionPedido.HeaderText = "Descripcion";
            this.descripcionPedido.MinimumWidth = 6;
            this.descripcionPedido.Name = "descripcionPedido";
            this.descripcionPedido.Width = 245;
            // 
            // valorUnitarioItem
            // 
            this.valorUnitarioItem.HeaderText = "Valor Unitario";
            this.valorUnitarioItem.MinimumWidth = 6;
            this.valorUnitarioItem.Name = "valorUnitarioItem";
            this.valorUnitarioItem.Width = 130;
            // 
            // cantidadItem
            // 
            this.cantidadItem.HeaderText = "Cantidad";
            this.cantidadItem.MinimumWidth = 6;
            this.cantidadItem.Name = "cantidadItem";
            this.cantidadItem.Width = 125;
            // 
            // valorTotalPedido
            // 
            this.valorTotalPedido.HeaderText = "Valor Total";
            this.valorTotalPedido.MinimumWidth = 6;
            this.valorTotalPedido.Name = "valorTotalPedido";
            this.valorTotalPedido.Width = 110;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightSalmon;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(223)))));
            this.btnCancelar.Location = new System.Drawing.Point(548, 478);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(156, 44);
            this.btnCancelar.TabIndex = 36;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(223)))));
            this.label9.Location = new System.Drawing.Point(92, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 20);
            this.label9.TabIndex = 35;
            this.label9.Text = "EDICIÓN PEDIDO";
            // 
            // btnAggPedido
            // 
            this.btnAggPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(209)))), ((int)(((byte)(120)))));
            this.btnAggPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggPedido.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggPedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(223)))));
            this.btnAggPedido.Location = new System.Drawing.Point(757, 163);
            this.btnAggPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAggPedido.Name = "btnAggPedido";
            this.btnAggPedido.Size = new System.Drawing.Size(120, 44);
            this.btnAggPedido.TabIndex = 34;
            this.btnAggPedido.Text = "Agregar";
            this.btnAggPedido.UseVisualStyleBackColor = false;
            this.btnAggPedido.Click += new System.EventHandler(this.btnAggPedido_Click);
            // 
            // btnContinuarPedido
            // 
            this.btnContinuarPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(209)))), ((int)(((byte)(120)))));
            this.btnContinuarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuarPedido.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuarPedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(223)))));
            this.btnContinuarPedido.Location = new System.Drawing.Point(358, 478);
            this.btnContinuarPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnContinuarPedido.Name = "btnContinuarPedido";
            this.btnContinuarPedido.Size = new System.Drawing.Size(156, 44);
            this.btnContinuarPedido.TabIndex = 33;
            this.btnContinuarPedido.Text = "Continuar";
            this.btnContinuarPedido.UseVisualStyleBackColor = false;
            this.btnContinuarPedido.Click += new System.EventHandler(this.btnContinuarPedido_Click);
            // 
            // txtTotPedido
            // 
            this.txtTotPedido.Enabled = false;
            this.txtTotPedido.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotPedido.Location = new System.Drawing.Point(734, 430);
            this.txtTotPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotPedido.Name = "txtTotPedido";
            this.txtTotPedido.Size = new System.Drawing.Size(73, 28);
            this.txtTotPedido.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(223)))));
            this.label8.Location = new System.Drawing.Point(550, 432);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "Valor Total Pedido:";
            // 
            // txtCantPedido
            // 
            this.txtCantPedido.Enabled = false;
            this.txtCantPedido.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantPedido.Location = new System.Drawing.Point(426, 430);
            this.txtCantPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantPedido.Name = "txtCantPedido";
            this.txtCantPedido.Size = new System.Drawing.Size(56, 28);
            this.txtCantPedido.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(223)))));
            this.label7.Location = new System.Drawing.Point(259, 432);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Cantidad Pedido:";
            // 
            // txtCantItem
            // 
            this.txtCantItem.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantItem.Location = new System.Drawing.Point(669, 173);
            this.txtCantItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantItem.MaxLength = 1;
            this.txtCantItem.Name = "txtCantItem";
            this.txtCantItem.Size = new System.Drawing.Size(71, 28);
            this.txtCantItem.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(223)))));
            this.label5.Location = new System.Drawing.Point(569, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(223)))));
            this.label4.Location = new System.Drawing.Point(108, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Items:";
            // 
            // cmbPedido
            // 
            this.cmbPedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPedido.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPedido.FormattingEnabled = true;
            this.cmbPedido.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cmbPedido.Location = new System.Drawing.Point(185, 173);
            this.cmbPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPedido.Name = "cmbPedido";
            this.cmbPedido.Size = new System.Drawing.Size(365, 28);
            this.cmbPedido.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(223)))));
            this.label3.Location = new System.Drawing.Point(108, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Menu";
            // 
            // txtIdPedido
            // 
            this.txtIdPedido.Enabled = false;
            this.txtIdPedido.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPedido.Location = new System.Drawing.Point(258, 82);
            this.txtIdPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdPedido.Name = "txtIdPedido";
            this.txtIdPedido.Size = new System.Drawing.Size(72, 28);
            this.txtIdPedido.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(223)))));
            this.label1.Location = new System.Drawing.Point(342, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(223)))));
            this.label2.Location = new System.Drawing.Point(108, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Codigo Pedido:";
            // 
            // btnEliminarMenu
            // 
            this.btnEliminarMenu.BackColor = System.Drawing.Color.LightSalmon;
            this.btnEliminarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarMenu.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(223)))));
            this.btnEliminarMenu.Location = new System.Drawing.Point(883, 163);
            this.btnEliminarMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarMenu.Name = "btnEliminarMenu";
            this.btnEliminarMenu.Size = new System.Drawing.Size(114, 44);
            this.btnEliminarMenu.TabIndex = 39;
            this.btnEliminarMenu.Text = "Eliminar";
            this.btnEliminarMenu.UseVisualStyleBackColor = false;
            this.btnEliminarMenu.Click += new System.EventHandler(this.btnEliminarMenu_Click);
            // 
            // FrmEditarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(1100, 550);
            this.Controls.Add(this.btnEliminarMenu);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.dgvIngresoPedido);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnAggPedido);
            this.Controls.Add(this.btnContinuarPedido);
            this.Controls.Add(this.txtTotPedido);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCantPedido);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCantItem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbPedido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdPedido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "FrmEditarPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditarPedido";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresoPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.DataGridView dgvIngresoPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorUnitarioItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotalPedido;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAggPedido;
        private System.Windows.Forms.Button btnContinuarPedido;
        private System.Windows.Forms.TextBox txtTotPedido;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCantPedido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCantItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbPedido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminarMenu;
    }
}