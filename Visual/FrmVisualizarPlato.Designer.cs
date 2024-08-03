namespace Visual
{
    partial class FrmVisualizarPlato
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvVisualizarPlato = new System.Windows.Forms.DataGridView();
            this.clmIdPlato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPlatoBaja = new System.Windows.Forms.Button();
            this.btnEditarPlato = new System.Windows.Forms.Button();
            this.btnAgregarPlato = new System.Windows.Forms.Button();
            this.cmbCampoBuscar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerarPdf = new System.Windows.Forms.Button();
            this.btnBuscarCampo = new System.Windows.Forms.Button();
            this.btnVolverPlato = new System.Windows.Forms.Button();
            this.btnEliminarPlato = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCampoNombre = new System.Windows.Forms.TextBox();
            this.btnBuscarNombre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizarPlato)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVisualizarPlato
            // 
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Verdana", 10F);
            this.dgvVisualizarPlato.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvVisualizarPlato.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(192)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Verdana", 10F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVisualizarPlato.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvVisualizarPlato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisualizarPlato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIdPlato,
            this.ClmNum,
            this.clmNombre,
            this.clmDescripcion,
            this.clmPrecio,
            this.clmEstado});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Verdana", 10F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVisualizarPlato.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvVisualizarPlato.EnableHeadersVisualStyles = false;
            this.dgvVisualizarPlato.Location = new System.Drawing.Point(34, 157);
            this.dgvVisualizarPlato.Name = "dgvVisualizarPlato";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Verdana", 10F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVisualizarPlato.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Verdana", 10F);
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White;
            this.dgvVisualizarPlato.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvVisualizarPlato.Size = new System.Drawing.Size(838, 291);
            this.dgvVisualizarPlato.TabIndex = 22;
            // 
            // clmIdPlato
            // 
            this.clmIdPlato.HeaderText = "ID Plato";
            this.clmIdPlato.Name = "clmIdPlato";
            this.clmIdPlato.ReadOnly = true;
            this.clmIdPlato.Visible = false;
            // 
            // ClmNum
            // 
            this.ClmNum.HeaderText = "Num";
            this.ClmNum.Name = "ClmNum";
            // 
            // clmNombre
            // 
            this.clmNombre.HeaderText = "Nombre";
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.ReadOnly = true;
            // 
            // clmDescripcion
            // 
            this.clmDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmDescripcion.HeaderText = "Descripcion";
            this.clmDescripcion.Name = "clmDescripcion";
            this.clmDescripcion.ReadOnly = true;
            // 
            // clmPrecio
            // 
            this.clmPrecio.HeaderText = "Precio";
            this.clmPrecio.Name = "clmPrecio";
            this.clmPrecio.ReadOnly = true;
            // 
            // clmEstado
            // 
            this.clmEstado.HeaderText = "Condicion";
            this.clmEstado.Name = "clmEstado";
            this.clmEstado.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(392, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "VISUALIZAR PLATO";
            // 
            // btnPlatoBaja
            // 
            this.btnPlatoBaja.Font = new System.Drawing.Font("Verdana", 10F);
            this.btnPlatoBaja.Location = new System.Drawing.Point(34, 455);
            this.btnPlatoBaja.Name = "btnPlatoBaja";
            this.btnPlatoBaja.Size = new System.Drawing.Size(113, 50);
            this.btnPlatoBaja.TabIndex = 19;
            this.btnPlatoBaja.Text = "Platos dados de baja";
            this.btnPlatoBaja.UseVisualStyleBackColor = true;
            this.btnPlatoBaja.Click += new System.EventHandler(this.btnPlatoBaja_Click);
            // 
            // btnEditarPlato
            // 
            this.btnEditarPlato.Font = new System.Drawing.Font("Verdana", 10F);
            this.btnEditarPlato.Location = new System.Drawing.Point(650, 74);
            this.btnEditarPlato.Name = "btnEditarPlato";
            this.btnEditarPlato.Size = new System.Drawing.Size(108, 30);
            this.btnEditarPlato.TabIndex = 18;
            this.btnEditarPlato.Text = "Editar";
            this.btnEditarPlato.UseVisualStyleBackColor = true;
            this.btnEditarPlato.Click += new System.EventHandler(this.btnEditarPlato_Click);
            // 
            // btnAgregarPlato
            // 
            this.btnAgregarPlato.Font = new System.Drawing.Font("Verdana", 10F);
            this.btnAgregarPlato.Location = new System.Drawing.Point(536, 74);
            this.btnAgregarPlato.Name = "btnAgregarPlato";
            this.btnAgregarPlato.Size = new System.Drawing.Size(108, 30);
            this.btnAgregarPlato.TabIndex = 17;
            this.btnAgregarPlato.Text = "Agregar";
            this.btnAgregarPlato.UseVisualStyleBackColor = true;
            this.btnAgregarPlato.Click += new System.EventHandler(this.btnAgregarPlato_Click);
            // 
            // cmbCampoBuscar
            // 
            this.cmbCampoBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCampoBuscar.Font = new System.Drawing.Font("Verdana", 10F);
            this.cmbCampoBuscar.FormattingEnabled = true;
            this.cmbCampoBuscar.Items.AddRange(new object[] {
            "Disponibles",
            "Agotados",
            "Todos"});
            this.cmbCampoBuscar.Location = new System.Drawing.Point(208, 58);
            this.cmbCampoBuscar.Name = "cmbCampoBuscar";
            this.cmbCampoBuscar.Size = new System.Drawing.Size(132, 24);
            this.cmbCampoBuscar.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10F);
            this.label1.Location = new System.Drawing.Point(38, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Buscar por Condicion:";
            // 
            // btnGenerarPdf
            // 
            this.btnGenerarPdf.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.btnGenerarPdf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarPdf.Location = new System.Drawing.Point(759, 455);
            this.btnGenerarPdf.Name = "btnGenerarPdf";
            this.btnGenerarPdf.Size = new System.Drawing.Size(113, 50);
            this.btnGenerarPdf.TabIndex = 24;
            this.btnGenerarPdf.Text = "Generar PDF";
            this.btnGenerarPdf.UseVisualStyleBackColor = true;
            this.btnGenerarPdf.Click += new System.EventHandler(this.btnGenerarPdf_Click);
            // 
            // btnBuscarCampo
            // 
            this.btnBuscarCampo.Font = new System.Drawing.Font("Verdana", 10F);
            this.btnBuscarCampo.Image = global::Visual.Properties.Resources.imgBuscar;
            this.btnBuscarCampo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarCampo.Location = new System.Drawing.Point(346, 49);
            this.btnBuscarCampo.Name = "btnBuscarCampo";
            this.btnBuscarCampo.Size = new System.Drawing.Size(109, 41);
            this.btnBuscarCampo.TabIndex = 23;
            this.btnBuscarCampo.Text = "Buscar";
            this.btnBuscarCampo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarCampo.UseVisualStyleBackColor = true;
            this.btnBuscarCampo.Click += new System.EventHandler(this.btnBuscarCampo_Click);
            // 
            // btnVolverPlato
            // 
            this.btnVolverPlato.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.btnVolverPlato.Image = global::Visual.Properties.Resources.imgVolver;
            this.btnVolverPlato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolverPlato.Location = new System.Drawing.Point(423, 454);
            this.btnVolverPlato.Name = "btnVolverPlato";
            this.btnVolverPlato.Size = new System.Drawing.Size(113, 50);
            this.btnVolverPlato.TabIndex = 20;
            this.btnVolverPlato.Text = "Volver";
            this.btnVolverPlato.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVolverPlato.UseVisualStyleBackColor = true;
            this.btnVolverPlato.Click += new System.EventHandler(this.btnVolverPlato_Click);
            // 
            // btnEliminarPlato
            // 
            this.btnEliminarPlato.Font = new System.Drawing.Font("Verdana", 10F);
            this.btnEliminarPlato.Location = new System.Drawing.Point(764, 74);
            this.btnEliminarPlato.Name = "btnEliminarPlato";
            this.btnEliminarPlato.Size = new System.Drawing.Size(108, 30);
            this.btnEliminarPlato.TabIndex = 25;
            this.btnEliminarPlato.Text = "Dar de baja";
            this.btnEliminarPlato.UseVisualStyleBackColor = true;
            this.btnEliminarPlato.Click += new System.EventHandler(this.btnEliminarPlato_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10F);
            this.label2.Location = new System.Drawing.Point(38, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Buscar por Nombre:";
            // 
            // txtCampoNombre
            // 
            this.txtCampoNombre.Font = new System.Drawing.Font("Verdana", 10F);
            this.txtCampoNombre.Location = new System.Drawing.Point(195, 104);
            this.txtCampoNombre.Name = "txtCampoNombre";
            this.txtCampoNombre.Size = new System.Drawing.Size(145, 24);
            this.txtCampoNombre.TabIndex = 27;
            // 
            // btnBuscarNombre
            // 
            this.btnBuscarNombre.Font = new System.Drawing.Font("Verdana", 10F);
            this.btnBuscarNombre.Image = global::Visual.Properties.Resources.imgBuscar;
            this.btnBuscarNombre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarNombre.Location = new System.Drawing.Point(346, 95);
            this.btnBuscarNombre.Name = "btnBuscarNombre";
            this.btnBuscarNombre.Size = new System.Drawing.Size(109, 41);
            this.btnBuscarNombre.TabIndex = 28;
            this.btnBuscarNombre.Text = "Buscar";
            this.btnBuscarNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarNombre.UseVisualStyleBackColor = true;
            this.btnBuscarNombre.Click += new System.EventHandler(this.btnBuscarNombre_Click);
            // 
            // FrmVisualizarPlato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(914, 517);
            this.Controls.Add(this.btnBuscarNombre);
            this.Controls.Add(this.txtCampoNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEliminarPlato);
            this.Controls.Add(this.btnGenerarPdf);
            this.Controls.Add(this.btnBuscarCampo);
            this.Controls.Add(this.dgvVisualizarPlato);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVolverPlato);
            this.Controls.Add(this.btnPlatoBaja);
            this.Controls.Add(this.btnEditarPlato);
            this.Controls.Add(this.btnAgregarPlato);
            this.Controls.Add(this.cmbCampoBuscar);
            this.Controls.Add(this.label1);
            this.Name = "FrmVisualizarPlato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "w";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizarPlato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarCampo;
        private System.Windows.Forms.DataGridView dgvVisualizarPlato;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVolverPlato;
        private System.Windows.Forms.Button btnPlatoBaja;
        private System.Windows.Forms.Button btnEditarPlato;
        private System.Windows.Forms.Button btnAgregarPlato;
        private System.Windows.Forms.ComboBox cmbCampoBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerarPdf;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdPlato;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEstado;
        private System.Windows.Forms.Button btnEliminarPlato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCampoNombre;
        private System.Windows.Forms.Button btnBuscarNombre;
    }
}