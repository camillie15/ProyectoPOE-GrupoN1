namespace Visual
{
    partial class FrmIngresarPlato
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
            this.btnRegistrarPlato = new System.Windows.Forms.Button();
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
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(45, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "REGISTRO PLATO";
            // 
            // btnRegistrarPlato
            // 
            this.btnRegistrarPlato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(209)))), ((int)(((byte)(120)))));
            this.btnRegistrarPlato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarPlato.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnRegistrarPlato.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarPlato.Image = global::Visual.Properties.Resources.guardar;
            this.btnRegistrarPlato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarPlato.Location = new System.Drawing.Point(306, 307);
            this.btnRegistrarPlato.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarPlato.Name = "btnRegistrarPlato";
            this.btnRegistrarPlato.Size = new System.Drawing.Size(124, 50);
            this.btnRegistrarPlato.TabIndex = 24;
            this.btnRegistrarPlato.Text = "Registrar";
            this.btnRegistrarPlato.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrarPlato.UseVisualStyleBackColor = false;
            this.btnRegistrarPlato.Click += new System.EventHandler(this.btnRegistrarPlato_Click);
            // 
            // cmbEstadoPlato
            // 
            this.cmbEstadoPlato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoPlato.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.cmbEstadoPlato.FormattingEnabled = true;
            this.cmbEstadoPlato.Items.AddRange(new object[] {
            "Disponible",
            "Agotado"});
            this.cmbEstadoPlato.Location = new System.Drawing.Point(502, 244);
            this.cmbEstadoPlato.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEstadoPlato.Name = "cmbEstadoPlato";
            this.cmbEstadoPlato.Size = new System.Drawing.Size(180, 25);
            this.cmbEstadoPlato.TabIndex = 23;
            // 
            // txtPrecioPlato
            // 
            this.txtPrecioPlato.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.txtPrecioPlato.Location = new System.Drawing.Point(49, 244);
            this.txtPrecioPlato.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioPlato.Name = "txtPrecioPlato";
            this.txtPrecioPlato.Size = new System.Drawing.Size(156, 24);
            this.txtPrecioPlato.TabIndex = 22;
            this.txtPrecioPlato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioPlato_KeyPress);
            // 
            // txtDescripcionPlato
            // 
            this.txtDescripcionPlato.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.txtDescripcionPlato.Location = new System.Drawing.Point(49, 178);
            this.txtDescripcionPlato.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcionPlato.Name = "txtDescripcionPlato";
            this.txtDescripcionPlato.Size = new System.Drawing.Size(522, 24);
            this.txtDescripcionPlato.TabIndex = 21;
            this.txtDescripcionPlato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcionPlato_KeyPress);
            // 
            // txtNombrePlato
            // 
            this.txtNombrePlato.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.txtNombrePlato.Location = new System.Drawing.Point(132, 113);
            this.txtNombrePlato.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombrePlato.Name = "txtNombrePlato";
            this.txtNombrePlato.Size = new System.Drawing.Size(550, 24);
            this.txtNombrePlato.TabIndex = 20;
            this.txtNombrePlato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombrePlato_KeyPress);
            // 
            // txtIdPlato
            // 
            this.txtIdPlato.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.txtIdPlato.Location = new System.Drawing.Point(144, 72);
            this.txtIdPlato.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdPlato.Name = "txtIdPlato";
            this.txtIdPlato.ReadOnly = true;
            this.txtIdPlato.Size = new System.Drawing.Size(148, 24);
            this.txtIdPlato.TabIndex = 19;
            // 
            // lblDescripcionPlato
            // 
            this.lblDescripcionPlato.AutoSize = true;
            this.lblDescripcionPlato.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.lblDescripcionPlato.ForeColor = System.Drawing.Color.White;
            this.lblDescripcionPlato.Location = new System.Drawing.Point(45, 153);
            this.lblDescripcionPlato.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcionPlato.Name = "lblDescripcionPlato";
            this.lblDescripcionPlato.Size = new System.Drawing.Size(94, 17);
            this.lblDescripcionPlato.TabIndex = 18;
            this.lblDescripcionPlato.Text = "Descripcion:";
            // 
            // lblPrecioPlato
            // 
            this.lblPrecioPlato.AutoSize = true;
            this.lblPrecioPlato.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.lblPrecioPlato.ForeColor = System.Drawing.Color.White;
            this.lblPrecioPlato.Location = new System.Drawing.Point(45, 219);
            this.lblPrecioPlato.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioPlato.Name = "lblPrecioPlato";
            this.lblPrecioPlato.Size = new System.Drawing.Size(55, 17);
            this.lblPrecioPlato.TabIndex = 17;
            this.lblPrecioPlato.Text = "Precio:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.Location = new System.Drawing.Point(499, 219);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(63, 17);
            this.lblEstado.TabIndex = 16;
            this.lblEstado.Text = "Estado:";
            // 
            // lblNombrePlato
            // 
            this.lblNombrePlato.AutoSize = true;
            this.lblNombrePlato.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.lblNombrePlato.ForeColor = System.Drawing.Color.White;
            this.lblNombrePlato.Location = new System.Drawing.Point(45, 116);
            this.lblNombrePlato.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombrePlato.Name = "lblNombrePlato";
            this.lblNombrePlato.Size = new System.Drawing.Size(69, 17);
            this.lblNombrePlato.TabIndex = 15;
            this.lblNombrePlato.Text = "Nombre:";
            // 
            // lblIdPlato
            // 
            this.lblIdPlato.AutoSize = true;
            this.lblIdPlato.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.lblIdPlato.ForeColor = System.Drawing.Color.White;
            this.lblIdPlato.Location = new System.Drawing.Point(45, 75);
            this.lblIdPlato.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdPlato.Name = "lblIdPlato";
            this.lblIdPlato.Size = new System.Drawing.Size(63, 17);
            this.lblIdPlato.TabIndex = 14;
            this.lblIdPlato.Text = "ID Plato";
            // 
            // FrmIngresarPlato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(732, 381);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRegistrarPlato);
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
            this.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmIngresarPlato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresar Plato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegistrarPlato;
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