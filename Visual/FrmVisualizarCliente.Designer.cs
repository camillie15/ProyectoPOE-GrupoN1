namespace Visual
{
    partial class FrmVisualizarCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMostrarTodosClientes = new System.Windows.Forms.Button();
            this.txtVolverCliente = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEditarCliente = new System.Windows.Forms.Button();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.btnPdfCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CI Cliente:";
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.BackColor = System.Drawing.Color.White;
            this.txtBuscarCliente.Location = new System.Drawing.Point(266, 70);
            this.txtBuscarCliente.MaxLength = 10;
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(276, 28);
            this.txtBuscarCliente.TabIndex = 1;
            this.txtBuscarCliente.TextChanged += new System.EventHandler(this.txtBuscarCliente_TextChanged);
            this.txtBuscarCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarCliente_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(352, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "VISUALIZAR CLIENTES";
            // 
            // dgvCliente
            // 
            this.dgvCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(192)))), ((int)(((byte)(179)))));
            this.dgvCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 10.2F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.nombreColumn,
            this.apellidoColumn,
            this.cedulaColumn,
            this.edadColumn,
            this.emailColumn,
            this.direccionColumn});
            this.dgvCliente.Location = new System.Drawing.Point(36, 127);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.RowHeadersWidth = 51;
            this.dgvCliente.RowTemplate.Height = 24;
            this.dgvCliente.Size = new System.Drawing.Size(838, 291);
            this.dgvCliente.TabIndex = 4;
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "ID";
            this.idColumn.MinimumWidth = 6;
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Width = 50;
            // 
            // nombreColumn
            // 
            this.nombreColumn.HeaderText = "Nombre";
            this.nombreColumn.MinimumWidth = 6;
            this.nombreColumn.Name = "nombreColumn";
            this.nombreColumn.ReadOnly = true;
            this.nombreColumn.Width = 130;
            // 
            // apellidoColumn
            // 
            this.apellidoColumn.HeaderText = "Apellido";
            this.apellidoColumn.MinimumWidth = 6;
            this.apellidoColumn.Name = "apellidoColumn";
            this.apellidoColumn.ReadOnly = true;
            this.apellidoColumn.Width = 130;
            // 
            // cedulaColumn
            // 
            this.cedulaColumn.HeaderText = "Cedula";
            this.cedulaColumn.MinimumWidth = 6;
            this.cedulaColumn.Name = "cedulaColumn";
            this.cedulaColumn.ReadOnly = true;
            this.cedulaColumn.Width = 125;
            // 
            // edadColumn
            // 
            this.edadColumn.HeaderText = "Edad";
            this.edadColumn.MinimumWidth = 6;
            this.edadColumn.Name = "edadColumn";
            this.edadColumn.ReadOnly = true;
            this.edadColumn.Width = 50;
            // 
            // emailColumn
            // 
            this.emailColumn.HeaderText = "E-mail";
            this.emailColumn.MinimumWidth = 6;
            this.emailColumn.Name = "emailColumn";
            this.emailColumn.ReadOnly = true;
            this.emailColumn.Width = 150;
            // 
            // direccionColumn
            // 
            this.direccionColumn.HeaderText = "Direccion";
            this.direccionColumn.MinimumWidth = 6;
            this.direccionColumn.Name = "direccionColumn";
            this.direccionColumn.ReadOnly = true;
            this.direccionColumn.Width = 150;
            // 
            // btnMostrarTodosClientes
            // 
            this.btnMostrarTodosClientes.Enabled = false;
            this.btnMostrarTodosClientes.Image = global::Visual.Properties.Resources.imgUsuarios2;
            this.btnMostrarTodosClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMostrarTodosClientes.Location = new System.Drawing.Point(682, 58);
            this.btnMostrarTodosClientes.Name = "btnMostrarTodosClientes";
            this.btnMostrarTodosClientes.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnMostrarTodosClientes.Size = new System.Drawing.Size(113, 50);
            this.btnMostrarTodosClientes.TabIndex = 6;
            this.btnMostrarTodosClientes.Text = "Todos";
            this.btnMostrarTodosClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMostrarTodosClientes.UseVisualStyleBackColor = true;
            this.btnMostrarTodosClientes.Click += new System.EventHandler(this.btnMostrarTodosClientes_Click);
            // 
            // txtVolverCliente
            // 
            this.txtVolverCliente.BackColor = System.Drawing.Color.White;
            this.txtVolverCliente.Image = global::Visual.Properties.Resources.imgVolver;
            this.txtVolverCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtVolverCliente.Location = new System.Drawing.Point(416, 440);
            this.txtVolverCliente.Name = "txtVolverCliente";
            this.txtVolverCliente.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtVolverCliente.Size = new System.Drawing.Size(113, 50);
            this.txtVolverCliente.TabIndex = 5;
            this.txtVolverCliente.Text = "Volver";
            this.txtVolverCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txtVolverCliente.UseVisualStyleBackColor = false;
            this.txtVolverCliente.Click += new System.EventHandler(this.txtVolverCliente_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Image = global::Visual.Properties.Resources.imgBuscar;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(563, 58);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.button1.Size = new System.Drawing.Size(113, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buscar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.Location = new System.Drawing.Point(905, 176);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnEditarCliente.Size = new System.Drawing.Size(113, 50);
            this.btnEditarCliente.TabIndex = 7;
            this.btnEditarCliente.Text = "Editar";
            this.btnEditarCliente.UseVisualStyleBackColor = true;
            this.btnEditarCliente.Click += new System.EventHandler(this.btnEditarCliente_Click);
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.Location = new System.Drawing.Point(905, 262);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnEliminarCliente.Size = new System.Drawing.Size(113, 50);
            this.btnEliminarCliente.TabIndex = 8;
            this.btnEliminarCliente.Text = "Eliminar";
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // btnPdfCliente
            // 
            this.btnPdfCliente.Location = new System.Drawing.Point(905, 351);
            this.btnPdfCliente.Name = "btnPdfCliente";
            this.btnPdfCliente.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnPdfCliente.Size = new System.Drawing.Size(113, 50);
            this.btnPdfCliente.TabIndex = 9;
            this.btnPdfCliente.Text = "Generar Informe";
            this.btnPdfCliente.UseVisualStyleBackColor = true;
            this.btnPdfCliente.Click += new System.EventHandler(this.btnPdfCliente_Click);
            // 
            // FrmVisualizarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(1048, 517);
            this.Controls.Add(this.btnPdfCliente);
            this.Controls.Add(this.btnEliminarCliente);
            this.Controls.Add(this.btnEditarCliente);
            this.Controls.Add(this.btnMostrarTodosClientes);
            this.Controls.Add(this.txtVolverCliente);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBuscarCliente);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmVisualizarCliente";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Button txtVolverCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionColumn;
        private System.Windows.Forms.Button btnMostrarTodosClientes;
        private System.Windows.Forms.Button btnEditarCliente;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.Button btnPdfCliente;
    }
}