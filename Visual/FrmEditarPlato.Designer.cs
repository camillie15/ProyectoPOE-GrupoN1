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
            this.btnEditarPlato = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(216, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 18);
            this.label3.TabIndex = 34;
            this.label3.Text = "EDITAR PLATO";
            // 
            // btnEditarPlato
            // 
            this.btnEditarPlato.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarPlato.Location = new System.Drawing.Point(253, 256);
            this.btnEditarPlato.Name = "btnEditarPlato";
            this.btnEditarPlato.Size = new System.Drawing.Size(73, 30);
            this.btnEditarPlato.TabIndex = 33;
            this.btnEditarPlato.Text = "Editar";
            this.btnEditarPlato.UseVisualStyleBackColor = true;
            this.btnEditarPlato.Click += new System.EventHandler(this.btnEditarPlato_Click);
            // 
            // cmbEditarEstadoPlato
            // 
            this.cmbEditarEstadoPlato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditarEstadoPlato.FormattingEnabled = true;
            this.cmbEditarEstadoPlato.Items.AddRange(new object[] {
            "Disponible",
            "Agotado",
            "Todos"});
            this.cmbEditarEstadoPlato.Location = new System.Drawing.Point(369, 191);
            this.cmbEditarEstadoPlato.Name = "cmbEditarEstadoPlato";
            this.cmbEditarEstadoPlato.Size = new System.Drawing.Size(121, 21);
            this.cmbEditarEstadoPlato.TabIndex = 32;
            // 
            // txtEditarPrecioPlato
            // 
            this.txtEditarPrecioPlato.Location = new System.Drawing.Point(145, 191);
            this.txtEditarPrecioPlato.Name = "txtEditarPrecioPlato";
            this.txtEditarPrecioPlato.Size = new System.Drawing.Size(105, 20);
            this.txtEditarPrecioPlato.TabIndex = 31;
            // 
            // txtEditarDescripcionPlato
            // 
            this.txtEditarDescripcionPlato.Location = new System.Drawing.Point(171, 146);
            this.txtEditarDescripcionPlato.Name = "txtEditarDescripcionPlato";
            this.txtEditarDescripcionPlato.Size = new System.Drawing.Size(349, 20);
            this.txtEditarDescripcionPlato.TabIndex = 30;
            // 
            // txtEditarNombrePlato
            // 
            this.txtEditarNombrePlato.Location = new System.Drawing.Point(152, 101);
            this.txtEditarNombrePlato.Name = "txtEditarNombrePlato";
            this.txtEditarNombrePlato.Size = new System.Drawing.Size(368, 20);
            this.txtEditarNombrePlato.TabIndex = 29;
            // 
            // txtEditarIdPlato
            // 
            this.txtEditarIdPlato.Location = new System.Drawing.Point(150, 56);
            this.txtEditarIdPlato.Name = "txtEditarIdPlato";
            this.txtEditarIdPlato.ReadOnly = true;
            this.txtEditarIdPlato.Size = new System.Drawing.Size(100, 20);
            this.txtEditarIdPlato.TabIndex = 28;
            // 
            // lblDescripcionPlato
            // 
            this.lblDescripcionPlato.AutoSize = true;
            this.lblDescripcionPlato.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionPlato.Location = new System.Drawing.Point(77, 150);
            this.lblDescripcionPlato.Name = "lblDescripcionPlato";
            this.lblDescripcionPlato.Size = new System.Drawing.Size(88, 16);
            this.lblDescripcionPlato.TabIndex = 27;
            this.lblDescripcionPlato.Text = "Descripcion:";
            // 
            // lblPrecioPlato
            // 
            this.lblPrecioPlato.AutoSize = true;
            this.lblPrecioPlato.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioPlato.Location = new System.Drawing.Point(86, 195);
            this.lblPrecioPlato.Name = "lblPrecioPlato";
            this.lblPrecioPlato.Size = new System.Drawing.Size(53, 16);
            this.lblPrecioPlato.TabIndex = 26;
            this.lblPrecioPlato.Text = "Precio:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(305, 196);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(58, 16);
            this.lblEstado.TabIndex = 25;
            this.lblEstado.Text = "Estado:";
            // 
            // lblNombrePlato
            // 
            this.lblNombrePlato.AutoSize = true;
            this.lblNombrePlato.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePlato.Location = new System.Drawing.Point(84, 105);
            this.lblNombrePlato.Name = "lblNombrePlato";
            this.lblNombrePlato.Size = new System.Drawing.Size(62, 16);
            this.lblNombrePlato.TabIndex = 24;
            this.lblNombrePlato.Text = "Nombre:";
            // 
            // lblIdPlato
            // 
            this.lblIdPlato.AutoSize = true;
            this.lblIdPlato.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPlato.Location = new System.Drawing.Point(85, 60);
            this.lblIdPlato.Name = "lblIdPlato";
            this.lblIdPlato.Size = new System.Drawing.Size(59, 16);
            this.lblIdPlato.TabIndex = 23;
            this.lblIdPlato.Text = "ID Plato";
            // 
            // FrmEditarPlato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(593, 307);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEditarPlato);
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
            this.Text = "EditarPlato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEditarPlato;
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