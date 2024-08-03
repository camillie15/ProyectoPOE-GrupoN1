namespace Visual
{
    partial class FrmEditarPlato
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
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEditarEstadoPlato = new System.Windows.Forms.ComboBox();
            this.txtEditarPrecioPlato = new System.Windows.Forms.TextBox();
            this.txtEditarDescripcionPlato = new System.Windows.Forms.TextBox();
            this.txtEditarNombrePlato = new System.Windows.Forms.TextBox();
            this.txtEditarIdPlato = new System.Windows.Forms.TextBox();
            this.lblDescripcionPlato = new System.Windows.Forms.Label();
            this.lblPrecioPlato = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblNombrePlato = new System.Windows.Forms.Label();
            this.lblIdPlato = new System.Windows.Forms.Label();
            this.btnEditarPlato = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(45, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "EDITAR PLATO";
            // 
            // cmbEditarEstadoPlato
            // 
            this.cmbEditarEstadoPlato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditarEstadoPlato.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.cmbEditarEstadoPlato.FormattingEnabled = true;
            this.cmbEditarEstadoPlato.Items.AddRange(new object[] {
            "Disponible",
            "Agotado"});
            this.cmbEditarEstadoPlato.Location = new System.Drawing.Point(502, 244);
            this.cmbEditarEstadoPlato.Name = "cmbEditarEstadoPlato";
            this.cmbEditarEstadoPlato.Size = new System.Drawing.Size(180, 25);
            this.cmbEditarEstadoPlato.TabIndex = 33;
            // 
            // txtEditarPrecioPlato
            // 
            this.txtEditarPrecioPlato.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.txtEditarPrecioPlato.Location = new System.Drawing.Point(49, 244);
            this.txtEditarPrecioPlato.Name = "txtEditarPrecioPlato";
            this.txtEditarPrecioPlato.Size = new System.Drawing.Size(156, 24);
            this.txtEditarPrecioPlato.TabIndex = 32;
            // 
            // txtEditarDescripcionPlato
            // 
            this.txtEditarDescripcionPlato.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.txtEditarDescripcionPlato.Location = new System.Drawing.Point(49, 178);
            this.txtEditarDescripcionPlato.Name = "txtEditarDescripcionPlato";
            this.txtEditarDescripcionPlato.Size = new System.Drawing.Size(522, 24);
            this.txtEditarDescripcionPlato.TabIndex = 31;
            // 
            // txtEditarNombrePlato
            // 
            this.txtEditarNombrePlato.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.txtEditarNombrePlato.Location = new System.Drawing.Point(132, 113);
            this.txtEditarNombrePlato.Name = "txtEditarNombrePlato";
            this.txtEditarNombrePlato.Size = new System.Drawing.Size(550, 24);
            this.txtEditarNombrePlato.TabIndex = 30;
            // 
            // txtEditarIdPlato
            // 
            this.txtEditarIdPlato.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.txtEditarIdPlato.Location = new System.Drawing.Point(144, 72);
            this.txtEditarIdPlato.Name = "txtEditarIdPlato";
            this.txtEditarIdPlato.ReadOnly = true;
            this.txtEditarIdPlato.Size = new System.Drawing.Size(148, 24);
            this.txtEditarIdPlato.TabIndex = 29;
            // 
            // lblDescripcionPlato
            // 
            this.lblDescripcionPlato.AutoSize = true;
            this.lblDescripcionPlato.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblDescripcionPlato.ForeColor = System.Drawing.Color.White;
            this.lblDescripcionPlato.Location = new System.Drawing.Point(45, 153);
            this.lblDescripcionPlato.Name = "lblDescripcionPlato";
            this.lblDescripcionPlato.Size = new System.Drawing.Size(94, 17);
            this.lblDescripcionPlato.TabIndex = 28;
            this.lblDescripcionPlato.Text = "Descripcion:";
            // 
            // lblPrecioPlato
            // 
            this.lblPrecioPlato.AutoSize = true;
            this.lblPrecioPlato.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblPrecioPlato.ForeColor = System.Drawing.Color.White;
            this.lblPrecioPlato.Location = new System.Drawing.Point(45, 219);
            this.lblPrecioPlato.Name = "lblPrecioPlato";
            this.lblPrecioPlato.Size = new System.Drawing.Size(55, 17);
            this.lblPrecioPlato.TabIndex = 27;
            this.lblPrecioPlato.Text = "Precio:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.Location = new System.Drawing.Point(499, 219);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(63, 17);
            this.lblEstado.TabIndex = 26;
            this.lblEstado.Text = "Estado:";
            // 
            // lblNombrePlato
            // 
            this.lblNombrePlato.AutoSize = true;
            this.lblNombrePlato.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblNombrePlato.ForeColor = System.Drawing.Color.White;
            this.lblNombrePlato.Location = new System.Drawing.Point(45, 116);
            this.lblNombrePlato.Name = "lblNombrePlato";
            this.lblNombrePlato.Size = new System.Drawing.Size(69, 17);
            this.lblNombrePlato.TabIndex = 25;
            this.lblNombrePlato.Text = "Nombre:";
            // 
            // lblIdPlato
            // 
            this.lblIdPlato.AutoSize = true;
            this.lblIdPlato.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblIdPlato.ForeColor = System.Drawing.Color.White;
            this.lblIdPlato.Location = new System.Drawing.Point(45, 75);
            this.lblIdPlato.Name = "lblIdPlato";
            this.lblIdPlato.Size = new System.Drawing.Size(63, 17);
            this.lblIdPlato.TabIndex = 24;
            this.lblIdPlato.Text = "ID Plato";
            // 
            // btnEditarPlato
            // 
            this.btnEditarPlato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(209)))), ((int)(((byte)(120)))));
            this.btnEditarPlato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarPlato.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnEditarPlato.ForeColor = System.Drawing.Color.White;
            this.btnEditarPlato.Image = global::Visual.Properties.Resources.guardar;
            this.btnEditarPlato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarPlato.Location = new System.Drawing.Point(305, 307);
            this.btnEditarPlato.Name = "btnEditarPlato";
            this.btnEditarPlato.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnEditarPlato.Size = new System.Drawing.Size(124, 50);
            this.btnEditarPlato.TabIndex = 35;
            this.btnEditarPlato.Text = "Guardar";
            this.btnEditarPlato.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarPlato.UseVisualStyleBackColor = false;
            this.btnEditarPlato.Click += new System.EventHandler(this.btnEditarPlato_Click);
            // 
            // FrmEditarPlato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(732, 381);
            this.Controls.Add(this.btnEditarPlato);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbEditarEstadoPlato);
            this.Controls.Add(this.txtEditarPrecioPlato);
            this.Controls.Add(this.txtEditarDescripcionPlato);
            this.Controls.Add(this.txtEditarNombrePlato);
            this.Controls.Add(this.txtEditarIdPlato);
            this.Controls.Add(this.lblDescripcionPlato);
            this.Controls.Add(this.lblPrecioPlato);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblNombrePlato);
            this.Controls.Add(this.lblIdPlato);
            this.Name = "FrmEditarPlato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Plato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditarPlato;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbEditarEstadoPlato;
        private System.Windows.Forms.TextBox txtEditarPrecioPlato;
        private System.Windows.Forms.TextBox txtEditarDescripcionPlato;
        private System.Windows.Forms.TextBox txtEditarNombrePlato;
        private System.Windows.Forms.TextBox txtEditarIdPlato;
        private System.Windows.Forms.Label lblDescripcionPlato;
        private System.Windows.Forms.Label lblPrecioPlato;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblNombrePlato;
        private System.Windows.Forms.Label lblIdPlato;
    }
}