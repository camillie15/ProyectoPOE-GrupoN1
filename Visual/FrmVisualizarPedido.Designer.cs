﻿namespace Visual
{
    partial class FrmVisualizarPedido
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
            this.label1.Location = new System.Drawing.Point(326, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "VISUALIZAR PEDIDOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(147, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Campo a buscar:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(416, 58);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBusqueda.MaxLength = 10;
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(128, 24);
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
            this.cmbCampoBusqueda.Location = new System.Drawing.Point(275, 58);
            this.cmbCampoBusqueda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCampoBusqueda.Name = "cmbCampoBusqueda";
            this.cmbCampoBusqueda.Size = new System.Drawing.Size(92, 25);
            this.cmbCampoBusqueda.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(380, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "->";
            // 
            // btnVolverPedido
            // 
            this.btnVolverPedido.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverPedido.Image = global::Visual.Properties.Resources.imgVolver;
            this.btnVolverPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolverPedido.Location = new System.Drawing.Point(356, 400);
            this.btnVolverPedido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVolverPedido.Name = "btnVolverPedido";
            this.btnVolverPedido.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnVolverPedido.Size = new System.Drawing.Size(109, 41);
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
            this.btnBuscarPedido.Location = new System.Drawing.Point(562, 48);
            this.btnBuscarPedido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscarPedido.Name = "btnBuscarPedido";
            this.btnBuscarPedido.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnBuscarPedido.Size = new System.Drawing.Size(109, 41);
            this.btnBuscarPedido.TabIndex = 5;
            this.btnBuscarPedido.Text = "Buscar ";
            this.btnBuscarPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarPedido.UseVisualStyleBackColor = false;
            this.btnBuscarPedido.Click += new System.EventHandler(this.btnBuscarPedido_Click);
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvPedidos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(192)))), ((int)(((byte)(179)))));
            this.dgvPedidos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedidos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPedidos.Location = new System.Drawing.Point(46, 104);
            this.dgvPedidos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.RowHeadersWidth = 51;
            this.dgvPedidos.RowTemplate.Height = 24;
            this.dgvPedidos.Size = new System.Drawing.Size(778, 270);
            this.dgvPedidos.TabIndex = 8;
            // 
            // idPedido
            // 
            this.idPedido.HeaderText = "Id Pedido";
            this.idPedido.MinimumWidth = 6;
            this.idPedido.Name = "idPedido";
            this.idPedido.ReadOnly = true;
            this.idPedido.Width = 115;
            // 
            // clientePedido
            // 
            this.clientePedido.HeaderText = "Cliente";
            this.clientePedido.MinimumWidth = 6;
            this.clientePedido.Name = "clientePedido";
            this.clientePedido.ReadOnly = true;
            this.clientePedido.Width = 110;
            // 
            // menuPedido
            // 
            this.menuPedido.HeaderText = "Menu Seleccionado";
            this.menuPedido.MinimumWidth = 6;
            this.menuPedido.Name = "menuPedido";
            this.menuPedido.ReadOnly = true;
            this.menuPedido.Width = 230;
            // 
            // cantPedido
            // 
            this.cantPedido.HeaderText = "Cantidad Total";
            this.cantPedido.MinimumWidth = 6;
            this.cantPedido.Name = "cantPedido";
            this.cantPedido.ReadOnly = true;
            this.cantPedido.Width = 145;
            // 
            // valorPedido
            // 
            this.valorPedido.HeaderText = "Valor Total";
            this.valorPedido.MinimumWidth = 6;
            this.valorPedido.Name = "valorPedido";
            this.valorPedido.ReadOnly = true;
            this.valorPedido.Width = 125;
            // 
            // FrmVisualizarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(884, 466);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.btnVolverPedido);
            this.Controls.Add(this.btnBuscarPedido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbCampoBusqueda);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FrmVisualizarPedido";
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