namespace Visual
{
    partial class EditarPlato
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
            this.cmbEstadoPlato = new System.Windows.Forms.ComboBox();
            this.txtPrecioPlato = new System.Windows.Forms.TextBox();
            this.txtDescripcionPlato = new System.Windows.Forms.TextBox();
            this.txtNombrePlato = new System.Windows.Forms.TextBox();
            this.txtIdPlato = new System.Windows.Forms.TextBox();
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
            this.label3.Location = new System.Drawing.Point(288, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 23);
            this.label3.TabIndex = 34;
            this.label3.Text = "EDITAR PLATO";
            // 
            // btnEditarPlato
            // 
            this.btnEditarPlato.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarPlato.Location = new System.Drawing.Point(337, 315);
            this.btnEditarPlato.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditarPlato.Name = "btnEditarPlato";
            this.btnEditarPlato.Size = new System.Drawing.Size(97, 37);
            this.btnEditarPlato.TabIndex = 33;
            this.btnEditarPlato.Text = "Editar";
            this.btnEditarPlato.UseVisualStyleBackColor = true;
            this.btnEditarPlato.Click += new System.EventHandler(this.btnEditarPlato_Click);
            // 
            // cmbEstadoPlato
            // 
            this.cmbEstadoPlato.FormattingEnabled = true;
            this.cmbEstadoPlato.Items.AddRange(new object[] {
            "Disponible",
            "Agotado",
            "Todos"});
            this.cmbEstadoPlato.Location = new System.Drawing.Point(492, 235);
            this.cmbEstadoPlato.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbEstadoPlato.Name = "cmbEstadoPlato";
            this.cmbEstadoPlato.Size = new System.Drawing.Size(160, 24);
            this.cmbEstadoPlato.TabIndex = 32;
            // 
            // txtPrecioPlato
            // 
            this.txtPrecioPlato.Location = new System.Drawing.Point(193, 235);
            this.txtPrecioPlato.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecioPlato.Name = "txtPrecioPlato";
            this.txtPrecioPlato.Size = new System.Drawing.Size(139, 22);
            this.txtPrecioPlato.TabIndex = 31;
            // 
            // txtDescripcionPlato
            // 
            this.txtDescripcionPlato.Location = new System.Drawing.Point(228, 180);
            this.txtDescripcionPlato.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcionPlato.Name = "txtDescripcionPlato";
            this.txtDescripcionPlato.Size = new System.Drawing.Size(464, 22);
            this.txtDescripcionPlato.TabIndex = 30;
            // 
            // txtNombrePlato
            // 
            this.txtNombrePlato.Location = new System.Drawing.Point(203, 124);
            this.txtNombrePlato.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombrePlato.Name = "txtNombrePlato";
            this.txtNombrePlato.Size = new System.Drawing.Size(489, 22);
            this.txtNombrePlato.TabIndex = 29;
            // 
            // txtIdPlato
            // 
            this.txtIdPlato.Location = new System.Drawing.Point(200, 69);
            this.txtIdPlato.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdPlato.Name = "txtIdPlato";
            this.txtIdPlato.ReadOnly = true;
            this.txtIdPlato.Size = new System.Drawing.Size(132, 22);
            this.txtIdPlato.TabIndex = 28;
            // 
            // lblDescripcionPlato
            // 
            this.lblDescripcionPlato.AutoSize = true;
            this.lblDescripcionPlato.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionPlato.Location = new System.Drawing.Point(103, 185);
            this.lblDescripcionPlato.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcionPlato.Name = "lblDescripcionPlato";
            this.lblDescripcionPlato.Size = new System.Drawing.Size(116, 20);
            this.lblDescripcionPlato.TabIndex = 27;
            this.lblDescripcionPlato.Text = "Descripcion:";
            // 
            // lblPrecioPlato
            // 
            this.lblPrecioPlato.AutoSize = true;
            this.lblPrecioPlato.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioPlato.Location = new System.Drawing.Point(115, 240);
            this.lblPrecioPlato.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioPlato.Name = "lblPrecioPlato";
            this.lblPrecioPlato.Size = new System.Drawing.Size(68, 20);
            this.lblPrecioPlato.TabIndex = 26;
            this.lblPrecioPlato.Text = "Precio:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(407, 241);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(75, 20);
            this.lblEstado.TabIndex = 25;
            this.lblEstado.Text = "Estado:";
            // 
            // lblNombrePlato
            // 
            this.lblNombrePlato.AutoSize = true;
            this.lblNombrePlato.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePlato.Location = new System.Drawing.Point(112, 129);
            this.lblNombrePlato.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombrePlato.Name = "lblNombrePlato";
            this.lblNombrePlato.Size = new System.Drawing.Size(85, 20);
            this.lblNombrePlato.TabIndex = 24;
            this.lblNombrePlato.Text = "Nombre:";
            // 
            // lblIdPlato
            // 
            this.lblIdPlato.AutoSize = true;
            this.lblIdPlato.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPlato.Location = new System.Drawing.Point(113, 74);
            this.lblIdPlato.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdPlato.Name = "lblIdPlato";
            this.lblIdPlato.Size = new System.Drawing.Size(78, 20);
            this.lblIdPlato.TabIndex = 23;
            this.lblIdPlato.Text = "ID Plato";
            // 
            // EditarPlato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 378);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEditarPlato);
            this.Controls.Add(this.cmbEstadoPlato);
            this.Controls.Add(this.txtPrecioPlato);
            this.Controls.Add(this.txtDescripcionPlato);
            this.Controls.Add(this.txtNombrePlato);
            this.Controls.Add(this.txtIdPlato);
            this.Controls.Add(this.lblDescripcionPlato);
            this.Controls.Add(this.lblPrecioPlato);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblNombrePlato);
            this.Controls.Add(this.lblIdPlato);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditarPlato";
            this.Text = "EditarPlato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEditarPlato;
        private System.Windows.Forms.ComboBox cmbEstadoPlato;
        private System.Windows.Forms.TextBox txtPrecioPlato;
        private System.Windows.Forms.TextBox txtDescripcionPlato;
        private System.Windows.Forms.TextBox txtNombrePlato;
        private System.Windows.Forms.TextBox txtIdPlato;
        private System.Windows.Forms.Label lblDescripcionPlato;
        private System.Windows.Forms.Label lblPrecioPlato;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblNombrePlato;
        private System.Windows.Forms.Label lblIdPlato;
    }
}