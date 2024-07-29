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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvEliminarPlato = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVolverPlato = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.clmIdPlato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmNumEli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombreEli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescripcionEli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrecioEli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEstadoEli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCondicionEli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminarPlato)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEliminarPlato
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 10F);
            this.dgvEliminarPlato.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEliminarPlato.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(192)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEliminarPlato.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEliminarPlato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEliminarPlato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIdPlato,
            this.ClmNumEli,
            this.clmNombreEli,
            this.clmDescripcionEli,
            this.clmPrecioEli,
            this.clmEstadoEli,
            this.clmCondicionEli});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEliminarPlato.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEliminarPlato.EnableHeadersVisualStyles = false;
            this.dgvEliminarPlato.Location = new System.Drawing.Point(39, 105);
            this.dgvEliminarPlato.Name = "dgvEliminarPlato";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEliminarPlato.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 10F);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvEliminarPlato.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvEliminarPlato.Size = new System.Drawing.Size(922, 291);
            this.dgvEliminarPlato.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(442, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "ELIMINAR PLATO";
            // 
            // btnVolverPlato
            // 
            this.btnVolverPlato.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.btnVolverPlato.Image = global::Visual.Properties.Resources.imgVolver;
            this.btnVolverPlato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolverPlato.Location = new System.Drawing.Point(475, 428);
            this.btnVolverPlato.Name = "btnVolverPlato";
            this.btnVolverPlato.Size = new System.Drawing.Size(113, 50);
            this.btnVolverPlato.TabIndex = 30;
            this.btnVolverPlato.Text = "Volver";
            this.btnVolverPlato.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVolverPlato.UseVisualStyleBackColor = true;
            this.btnVolverPlato.Click += new System.EventHandler(this.btnVolverPlato_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(36, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Los Platos dados de baja son:";
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
            this.ClmNumEli.HeaderText = "Num";
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
            // FrmEliminarPlato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(1003, 517);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEliminarPlato);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVolverPlato);
            this.Name = "FrmEliminarPlato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminarPlato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvEliminarPlato;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVolverPlato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdPlato;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmNumEli;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombreEli;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescripcionEli;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrecioEli;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEstadoEli;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCondicionEli;
    }
}