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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBuscarCampo = new System.Windows.Forms.Button();
            this.dgvVisualizarPlato = new System.Windows.Forms.DataGridView();
            this.clmIdPlato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVolverPlato = new System.Windows.Forms.Button();
            this.btnEliminarPlato = new System.Windows.Forms.Button();
            this.btnEditarPlato = new System.Windows.Forms.Button();
            this.btnAgregarPlato = new System.Windows.Forms.Button();
            this.cmbCampoBuscar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizarPlato)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarCampo
            // 
            this.btnBuscarCampo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCampo.Location = new System.Drawing.Point(532, 61);
            this.btnBuscarCampo.Name = "btnBuscarCampo";
            this.btnBuscarCampo.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCampo.TabIndex = 23;
            this.btnBuscarCampo.Text = "Buscar";
            this.btnBuscarCampo.UseVisualStyleBackColor = true;
            this.btnBuscarCampo.Click += new System.EventHandler(this.btnBuscarCampo_Click);
            // 
            // dgvVisualizarPlato
            // 
            this.dgvVisualizarPlato.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVisualizarPlato.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvVisualizarPlato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisualizarPlato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIdPlato,
            this.clmNombre,
            this.clmDescripcion,
            this.clmPrecio,
            this.clmEstado});
            this.dgvVisualizarPlato.EnableHeadersVisualStyles = false;
            this.dgvVisualizarPlato.GridColor = System.Drawing.SystemColors.InfoText;
            this.dgvVisualizarPlato.Location = new System.Drawing.Point(14, 108);
            this.dgvVisualizarPlato.Name = "dgvVisualizarPlato";
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            this.dgvVisualizarPlato.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvVisualizarPlato.Size = new System.Drawing.Size(777, 150);
            this.dgvVisualizarPlato.TabIndex = 22;
            // 
            // clmIdPlato
            // 
            this.clmIdPlato.HeaderText = "ID Plato";
            this.clmIdPlato.Name = "clmIdPlato";
            this.clmIdPlato.ReadOnly = true;
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
            this.clmEstado.HeaderText = "Estado";
            this.clmEstado.Name = "clmEstado";
            this.clmEstado.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(351, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "VISUALIZAR PLATO";
            // 
            // btnVolverPlato
            // 
            this.btnVolverPlato.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.btnVolverPlato.Image = global::Visual.Properties.Resources.imgVolver;
            this.btnVolverPlato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolverPlato.Location = new System.Drawing.Point(354, 342);
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
            this.btnEliminarPlato.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPlato.Location = new System.Drawing.Point(797, 180);
            this.btnEliminarPlato.Name = "btnEliminarPlato";
            this.btnEliminarPlato.Size = new System.Drawing.Size(68, 30);
            this.btnEliminarPlato.TabIndex = 19;
            this.btnEliminarPlato.Text = "Eliminar";
            this.btnEliminarPlato.UseVisualStyleBackColor = true;
            this.btnEliminarPlato.Click += new System.EventHandler(this.btnEliminarPlato_Click);
            // 
            // btnEditarPlato
            // 
            this.btnEditarPlato.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarPlato.Location = new System.Drawing.Point(797, 144);
            this.btnEditarPlato.Name = "btnEditarPlato";
            this.btnEditarPlato.Size = new System.Drawing.Size(68, 30);
            this.btnEditarPlato.TabIndex = 18;
            this.btnEditarPlato.Text = "Editar";
            this.btnEditarPlato.UseVisualStyleBackColor = true;
            this.btnEditarPlato.Click += new System.EventHandler(this.btnEditarPlato_Click);
            // 
            // btnAgregarPlato
            // 
            this.btnAgregarPlato.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPlato.Location = new System.Drawing.Point(797, 108);
            this.btnAgregarPlato.Name = "btnAgregarPlato";
            this.btnAgregarPlato.Size = new System.Drawing.Size(68, 30);
            this.btnAgregarPlato.TabIndex = 17;
            this.btnAgregarPlato.Text = "Agregar";
            this.btnAgregarPlato.UseVisualStyleBackColor = true;
            this.btnAgregarPlato.Click += new System.EventHandler(this.btnAgregarPlato_Click);
            // 
            // cmbCampoBuscar
            // 
            this.cmbCampoBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCampoBuscar.FormattingEnabled = true;
            this.cmbCampoBuscar.Items.AddRange(new object[] {
            "Disponibles",
            "Agotados",
            "Todos"});
            this.cmbCampoBuscar.Location = new System.Drawing.Point(405, 63);
            this.cmbCampoBuscar.Name = "cmbCampoBuscar";
            this.cmbCampoBuscar.Size = new System.Drawing.Size(121, 21);
            this.cmbCampoBuscar.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Campo a Buscar";
            // 
            // FrmVisualizarPlato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(878, 398);
            this.Controls.Add(this.btnBuscarCampo);
            this.Controls.Add(this.dgvVisualizarPlato);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVolverPlato);
            this.Controls.Add(this.btnEliminarPlato);
            this.Controls.Add(this.btnEditarPlato);
            this.Controls.Add(this.btnAgregarPlato);
            this.Controls.Add(this.cmbCampoBuscar);
            this.Controls.Add(this.label1);
            this.Name = "FrmVisualizarPlato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizarPlato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarCampo;
        private System.Windows.Forms.DataGridView dgvVisualizarPlato;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdPlato;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVolverPlato;
        private System.Windows.Forms.Button btnEliminarPlato;
        private System.Windows.Forms.Button btnEditarPlato;
        private System.Windows.Forms.Button btnAgregarPlato;
        private System.Windows.Forms.ComboBox cmbCampoBuscar;
        private System.Windows.Forms.Label label1;
    }
}