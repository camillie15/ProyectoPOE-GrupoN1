namespace Visual
{
    partial class FrmEliminarPlato
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvEliminarPlato = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVolverPlato = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerarPdfEli = new System.Windows.Forms.Button();
            this.btnBuscarPrecio = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarNunEli = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuscarNumEli = new System.Windows.Forms.TextBox();
            this.nunPrecio = new System.Windows.Forms.NumericUpDown();
            this.clmIdPlato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmNumEli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombreEli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescripcionEli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrecioEli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEstadoEli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCondicionEli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTodos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminarPlato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nunPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEliminarPlato
            // 
            this.dgvEliminarPlato.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(62)))));
            this.dgvEliminarPlato.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 10.2F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEliminarPlato.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvEliminarPlato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEliminarPlato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIdPlato,
            this.ClmNumEli,
            this.clmNombreEli,
            this.clmDescripcionEli,
            this.clmPrecioEli,
            this.clmEstadoEli,
            this.clmCondicionEli});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Verdana", 10.2F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEliminarPlato.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvEliminarPlato.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvEliminarPlato.Location = new System.Drawing.Point(65, 164);
            this.dgvEliminarPlato.Name = "dgvEliminarPlato";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Verdana", 10.2F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEliminarPlato.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvEliminarPlato.Size = new System.Drawing.Size(922, 291);
            this.dgvEliminarPlato.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(444, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "ELIMINAR PLATO";
            // 
            // btnVolverPlato
            // 
            this.btnVolverPlato.BackColor = System.Drawing.Color.LightSalmon;
            this.btnVolverPlato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverPlato.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnVolverPlato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnVolverPlato.Image = global::Visual.Properties.Resources.imgVolver;
            this.btnVolverPlato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolverPlato.Location = new System.Drawing.Point(468, 484);
            this.btnVolverPlato.Name = "btnVolverPlato";
            this.btnVolverPlato.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnVolverPlato.Size = new System.Drawing.Size(113, 50);
            this.btnVolverPlato.TabIndex = 5;
            this.btnVolverPlato.Text = "Volver";
            this.btnVolverPlato.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVolverPlato.UseVisualStyleBackColor = false;
            this.btnVolverPlato.Click += new System.EventHandler(this.btnVolverPlato_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(62, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Los Platos dados de baja son:";
            // 
            // btnGenerarPdfEli
            // 
            this.btnGenerarPdfEli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(209)))), ((int)(((byte)(120)))));
            this.btnGenerarPdfEli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarPdfEli.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarPdfEli.ForeColor = System.Drawing.Color.White;
            this.btnGenerarPdfEli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarPdfEli.Location = new System.Drawing.Point(923, 484);
            this.btnGenerarPdfEli.Name = "btnGenerarPdfEli";
            this.btnGenerarPdfEli.Size = new System.Drawing.Size(113, 50);
            this.btnGenerarPdfEli.TabIndex = 34;
            this.btnGenerarPdfEli.Text = "Generar PDF";
            this.btnGenerarPdfEli.UseVisualStyleBackColor = false;
            this.btnGenerarPdfEli.Click += new System.EventHandler(this.btnGenerarPdfEli_Click);
            // 
            // btnBuscarPrecio
            // 
            this.btnBuscarPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(209)))), ((int)(((byte)(120)))));
            this.btnBuscarPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPrecio.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.btnBuscarPrecio.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPrecio.Image = global::Visual.Properties.Resources.imgBuscar;
            this.btnBuscarPrecio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarPrecio.Location = new System.Drawing.Point(874, 76);
            this.btnBuscarPrecio.Name = "btnBuscarPrecio";
            this.btnBuscarPrecio.Size = new System.Drawing.Size(113, 50);
            this.btnBuscarPrecio.TabIndex = 40;
            this.btnBuscarPrecio.Text = "Buscar";
            this.btnBuscarPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarPrecio.UseVisualStyleBackColor = false;
            this.btnBuscarPrecio.Click += new System.EventHandler(this.btnBuscarPrecio_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(602, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "Buscar por Precio:";
            // 
            // btnBuscarNunEli
            // 
            this.btnBuscarNunEli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(209)))), ((int)(((byte)(120)))));
            this.btnBuscarNunEli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarNunEli.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.btnBuscarNunEli.ForeColor = System.Drawing.Color.White;
            this.btnBuscarNunEli.Image = global::Visual.Properties.Resources.imgBuscar;
            this.btnBuscarNunEli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarNunEli.Location = new System.Drawing.Point(339, 76);
            this.btnBuscarNunEli.Name = "btnBuscarNunEli";
            this.btnBuscarNunEli.Size = new System.Drawing.Size(113, 50);
            this.btnBuscarNunEli.TabIndex = 37;
            this.btnBuscarNunEli.Text = "Buscar";
            this.btnBuscarNunEli.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarNunEli.UseVisualStyleBackColor = false;
            this.btnBuscarNunEli.Click += new System.EventHandler(this.btnBuscarNunEli_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(61, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "Buscar por ID:";
            // 
            // txtBuscarNumEli
            // 
            this.txtBuscarNumEli.Font = new System.Drawing.Font("Verdana", 10F);
            this.txtBuscarNumEli.Location = new System.Drawing.Point(179, 90);
            this.txtBuscarNumEli.Name = "txtBuscarNumEli";
            this.txtBuscarNumEli.Size = new System.Drawing.Size(154, 24);
            this.txtBuscarNumEli.TabIndex = 41;
            // 
            // nunPrecio
            // 
            this.nunPrecio.BackColor = System.Drawing.Color.White;
            this.nunPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nunPrecio.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.nunPrecio.Location = new System.Drawing.Point(745, 90);
            this.nunPrecio.Name = "nunPrecio";
            this.nunPrecio.Size = new System.Drawing.Size(123, 24);
            this.nunPrecio.TabIndex = 42;
            // 
            // clmIdPlato
            // 
            this.clmIdPlato.HeaderText = "ID Plato";
            this.clmIdPlato.Name = "clmIdPlato";
            this.clmIdPlato.ReadOnly = true;
            this.clmIdPlato.Visible = false;
            // 
            // ClmNumEli
            // 
            this.ClmNumEli.HeaderText = "ID";
            this.ClmNumEli.Name = "ClmNumEli";
            // 
            // clmNombreEli
            // 
            this.clmNombreEli.HeaderText = "Nombre";
            this.clmNombreEli.Name = "clmNombreEli";
            this.clmNombreEli.ReadOnly = true;
            // 
            // clmDescripcionEli
            // 
            this.clmDescripcionEli.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmDescripcionEli.HeaderText = "Descripcion";
            this.clmDescripcionEli.Name = "clmDescripcionEli";
            this.clmDescripcionEli.ReadOnly = true;
            // 
            // clmPrecioEli
            // 
            this.clmPrecioEli.HeaderText = "Precio";
            this.clmPrecioEli.Name = "clmPrecioEli";
            this.clmPrecioEli.ReadOnly = true;
            // 
            // clmEstadoEli
            // 
            this.clmEstadoEli.HeaderText = "Condicion";
            this.clmEstadoEli.Name = "clmEstadoEli";
            this.clmEstadoEli.ReadOnly = true;
            this.clmEstadoEli.Width = 150;
            // 
            // clmCondicionEli
            // 
            this.clmCondicionEli.HeaderText = "Estado";
            this.clmCondicionEli.Name = "clmCondicionEli";
            // 
            // btnTodos
            // 
            this.btnTodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(209)))), ((int)(((byte)(120)))));
            this.btnTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodos.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodos.ForeColor = System.Drawing.Color.White;
            this.btnTodos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTodos.Location = new System.Drawing.Point(12, 484);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(113, 50);
            this.btnTodos.TabIndex = 43;
            this.btnTodos.Text = "Todos";
            this.btnTodos.UseVisualStyleBackColor = false;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // FrmEliminarPlato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(1048, 546);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.nunPrecio);
            this.Controls.Add(this.txtBuscarNumEli);
            this.Controls.Add(this.btnBuscarPrecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscarNunEli);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGenerarPdfEli);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEliminarPlato);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVolverPlato);
            this.Name = "FrmEliminarPlato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminarPlato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nunPrecio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvEliminarPlato;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVolverPlato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerarPdfEli;
        private System.Windows.Forms.Button btnBuscarPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarNunEli;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBuscarNumEli;
        private System.Windows.Forms.NumericUpDown nunPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdPlato;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmNumEli;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombreEli;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescripcionEli;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrecioEli;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEstadoEli;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCondicionEli;
        private System.Windows.Forms.Button btnTodos;
    }
}