﻿namespace Visual
{
    partial class FrmIngresarPedido
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdPedido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPedido = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCantItem = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCantPedido = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotPedido = new System.Windows.Forms.TextBox();
            this.btnContinuarPedido = new System.Windows.Forms.Button();
            this.btnAggPedido = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvIngresoPedido = new System.Windows.Forms.DataGridView();
            this.descripcionPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorUnitarioItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotalPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresoPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(223)))));
            this.label2.Location = new System.Drawing.Point(93, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo Pedido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(223)))));
            this.label1.Location = new System.Drawing.Point(327, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente:";
            // 
            // txtIdPedido
            // 
            this.txtIdPedido.Enabled = false;
            this.txtIdPedido.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPedido.Location = new System.Drawing.Point(243, 82);
            this.txtIdPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdPedido.Name = "txtIdPedido";
            this.txtIdPedido.Size = new System.Drawing.Size(72, 28);
            this.txtIdPedido.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(223)))));
            this.label3.Location = new System.Drawing.Point(93, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Menu";
            // 
            // cmbPedido
            // 
            this.cmbPedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPedido.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPedido.FormattingEnabled = true;
            this.cmbPedido.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cmbPedido.Location = new System.Drawing.Point(170, 173);
            this.cmbPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPedido.Name = "cmbPedido";
            this.cmbPedido.Size = new System.Drawing.Size(481, 28);
            this.cmbPedido.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(223)))));
            this.label4.Location = new System.Drawing.Point(93, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Items:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(223)))));
            this.label5.Location = new System.Drawing.Point(674, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cantidad:";
            // 
            // txtCantItem
            // 
            this.txtCantItem.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantItem.Location = new System.Drawing.Point(777, 174);
            this.txtCantItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantItem.MaxLength = 1;
            this.txtCantItem.Name = "txtCantItem";
            this.txtCantItem.Size = new System.Drawing.Size(71, 28);
            this.txtCantItem.TabIndex = 8;
            this.txtCantItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantItem_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(223)))));
            this.label7.Location = new System.Drawing.Point(244, 432);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Cantidad Pedido:";
            // 
            // txtCantPedido
            // 
            this.txtCantPedido.Enabled = false;
            this.txtCantPedido.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantPedido.Location = new System.Drawing.Point(411, 430);
            this.txtCantPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantPedido.Name = "txtCantPedido";
            this.txtCantPedido.Size = new System.Drawing.Size(56, 28);
            this.txtCantPedido.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(223)))));
            this.label8.Location = new System.Drawing.Point(535, 432);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Valor Total Pedido:";
            // 
            // txtTotPedido
            // 
            this.txtTotPedido.Enabled = false;
            this.txtTotPedido.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotPedido.Location = new System.Drawing.Point(719, 430);
            this.txtTotPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotPedido.Name = "txtTotPedido";
            this.txtTotPedido.Size = new System.Drawing.Size(73, 28);
            this.txtTotPedido.TabIndex = 14;
            // 
            // btnContinuarPedido
            // 
            this.btnContinuarPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(209)))), ((int)(((byte)(120)))));
            this.btnContinuarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuarPedido.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuarPedido.ForeColor = System.Drawing.Color.White;
            this.btnContinuarPedido.Location = new System.Drawing.Point(343, 478);
            this.btnContinuarPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnContinuarPedido.Name = "btnContinuarPedido";
            this.btnContinuarPedido.Size = new System.Drawing.Size(156, 44);
            this.btnContinuarPedido.TabIndex = 15;
            this.btnContinuarPedido.Text = "Continuar";
            this.btnContinuarPedido.UseVisualStyleBackColor = false;
            this.btnContinuarPedido.Click += new System.EventHandler(this.btnContinuarPedido_Click);
            // 
            // btnAggPedido
            // 
            this.btnAggPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(209)))), ((int)(((byte)(120)))));
            this.btnAggPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggPedido.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggPedido.ForeColor = System.Drawing.Color.White;
            this.btnAggPedido.Location = new System.Drawing.Point(861, 164);
            this.btnAggPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAggPedido.Name = "btnAggPedido";
            this.btnAggPedido.Size = new System.Drawing.Size(121, 44);
            this.btnAggPedido.TabIndex = 16;
            this.btnAggPedido.Text = "Agregar";
            this.btnAggPedido.UseVisualStyleBackColor = false;
            this.btnAggPedido.Click += new System.EventHandler(this.btnAggPedido_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(223)))));
            this.label9.Location = new System.Drawing.Point(77, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(189, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "REGISTRO PEDIDO";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightSalmon;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(533, 478);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(156, 44);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvIngresoPedido
            // 
            this.dgvIngresoPedido.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(62)))));
            this.dgvIngresoPedido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIngresoPedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvIngresoPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngresoPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descripcionPedido,
            this.valorUnitarioItem,
            this.cantidadItem,
            this.valorTotalPedido});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIngresoPedido.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvIngresoPedido.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvIngresoPedido.Location = new System.Drawing.Point(97, 227);
            this.dgvIngresoPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvIngresoPedido.Name = "dgvIngresoPedido";
            this.dgvIngresoPedido.RowHeadersWidth = 51;
            this.dgvIngresoPedido.RowTemplate.Height = 24;
            this.dgvIngresoPedido.Size = new System.Drawing.Size(885, 185);
            this.dgvIngresoPedido.TabIndex = 19;
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
            // cmbCliente
            // 
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(411, 81);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(583, 28);
            this.cmbCliente.TabIndex = 20;
            // 
            // FrmIngresarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(1100, 550);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FrmIngresarPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresar Pedido";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresoPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdPedido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPedido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCantItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCantPedido;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotPedido;
        private System.Windows.Forms.Button btnContinuarPedido;
        private System.Windows.Forms.Button btnAggPedido;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvIngresoPedido;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorUnitarioItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotalPedido;
    }
}