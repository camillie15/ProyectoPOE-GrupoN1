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
            this.label3.Location = new System.Drawing.Point(281, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "INGRESAR PLATO";
            // 
            // btnRegistrarPlato
            // 
            this.btnRegistrarPlato.Font = new System.Drawing.Font("Verdana", 10F);
            this.btnRegistrarPlato.Image = global::Visual.Properties.Resources.guardar;
            this.btnRegistrarPlato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarPlato.Location = new System.Drawing.Point(286, 327);
            this.btnRegistrarPlato.Name = "btnRegistrarPlato";
            this.btnRegistrarPlato.Size = new System.Drawing.Size(128, 44);
            this.btnRegistrarPlato.TabIndex = 24;
            this.btnRegistrarPlato.Text = "Registrar";
            this.btnRegistrarPlato.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrarPlato.UseVisualStyleBackColor = true;
            this.btnRegistrarPlato.Click += new System.EventHandler(this.btnRegistrarPlato_Click);
            // 
            // cmbEstadoPlato
            // 
            this.cmbEstadoPlato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoPlato.Font = new System.Drawing.Font("Verdana", 10F);
            this.cmbEstadoPlato.FormattingEnabled = true;
            this.cmbEstadoPlato.Items.AddRange(new object[] {
            "Disponible",
            "Agotado"});
            this.cmbEstadoPlato.Location = new System.Drawing.Point(420, 236);
            this.cmbEstadoPlato.Name = "cmbEstadoPlato";
            this.cmbEstadoPlato.Size = new System.Drawing.Size(121, 24);
            this.cmbEstadoPlato.TabIndex = 23;
            // 
            // txtPrecioPlato
            // 
            this.txtPrecioPlato.Font = new System.Drawing.Font("Verdana", 10F);
            this.txtPrecioPlato.Location = new System.Drawing.Point(196, 236);
            this.txtPrecioPlato.Name = "txtPrecioPlato";
            this.txtPrecioPlato.Size = new System.Drawing.Size(105, 24);
            this.txtPrecioPlato.TabIndex = 22;
            this.txtPrecioPlato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioPlato_KeyPress);
            // 
            // txtDescripcionPlato
            // 
            this.txtDescripcionPlato.Font = new System.Drawing.Font("Verdana", 10F);
            this.txtDescripcionPlato.Location = new System.Drawing.Point(222, 191);
            this.txtDescripcionPlato.Name = "txtDescripcionPlato";
            this.txtDescripcionPlato.Size = new System.Drawing.Size(349, 24);
            this.txtDescripcionPlato.TabIndex = 21;
            this.txtDescripcionPlato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcionPlato_KeyPress);
            // 
            // txtNombrePlato
            // 
            this.txtNombrePlato.Font = new System.Drawing.Font("Verdana", 10F);
            this.txtNombrePlato.Location = new System.Drawing.Point(203, 146);
            this.txtNombrePlato.Name = "txtNombrePlato";
            this.txtNombrePlato.Size = new System.Drawing.Size(368, 24);
            this.txtNombrePlato.TabIndex = 20;
            this.txtNombrePlato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombrePlato_KeyPress);
            // 
            // txtIdPlato
            // 
            this.txtIdPlato.Font = new System.Drawing.Font("Verdana", 10F);
            this.txtIdPlato.Location = new System.Drawing.Point(201, 101);
            this.txtIdPlato.Name = "txtIdPlato";
            this.txtIdPlato.ReadOnly = true;
            this.txtIdPlato.Size = new System.Drawing.Size(100, 24);
            this.txtIdPlato.TabIndex = 19;
            // 
            // lblDescripcionPlato
            // 
            this.lblDescripcionPlato.AutoSize = true;
            this.lblDescripcionPlato.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblDescripcionPlato.Location = new System.Drawing.Point(128, 195);
            this.lblDescripcionPlato.Name = "lblDescripcionPlato";
            this.lblDescripcionPlato.Size = new System.Drawing.Size(94, 17);
            this.lblDescripcionPlato.TabIndex = 18;
            this.lblDescripcionPlato.Text = "Descripcion:";
            // 
            // lblPrecioPlato
            // 
            this.lblPrecioPlato.AutoSize = true;
            this.lblPrecioPlato.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblPrecioPlato.Location = new System.Drawing.Point(137, 240);
            this.lblPrecioPlato.Name = "lblPrecioPlato";
            this.lblPrecioPlato.Size = new System.Drawing.Size(55, 17);
            this.lblPrecioPlato.TabIndex = 17;
            this.lblPrecioPlato.Text = "Precio:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblEstado.Location = new System.Drawing.Point(356, 241);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(63, 17);
            this.lblEstado.TabIndex = 16;
            this.lblEstado.Text = "Estado:";
            // 
            // lblNombrePlato
            // 
            this.lblNombrePlato.AutoSize = true;
            this.lblNombrePlato.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblNombrePlato.Location = new System.Drawing.Point(135, 150);
            this.lblNombrePlato.Name = "lblNombrePlato";
            this.lblNombrePlato.Size = new System.Drawing.Size(69, 17);
            this.lblNombrePlato.TabIndex = 15;
            this.lblNombrePlato.Text = "Nombre:";
            // 
            // lblIdPlato
            // 
            this.lblIdPlato.AutoSize = true;
            this.lblIdPlato.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblIdPlato.Location = new System.Drawing.Point(136, 105);
            this.lblIdPlato.Name = "lblIdPlato";
            this.lblIdPlato.Size = new System.Drawing.Size(63, 17);
            this.lblIdPlato.TabIndex = 14;
            this.lblIdPlato.Text = "ID Plato";
            // 
            // FrmIngresarPlato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(698, 398);
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
            this.Name = "FrmIngresarPlato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
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