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
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(214, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 18);
            this.label3.TabIndex = 46;
            this.label3.Text = "REGISTRAR PLATO";
            // 
            // btnRegistrarPlato
            // 
            this.btnRegistrarPlato.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarPlato.Location = new System.Drawing.Point(245, 257);
            this.btnRegistrarPlato.Name = "btnRegistrarPlato";
            this.btnRegistrarPlato.Size = new System.Drawing.Size(85, 30);
            this.btnRegistrarPlato.TabIndex = 45;
            this.btnRegistrarPlato.Text = "Registrar";
            this.btnRegistrarPlato.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnRegistrarPlato.UseVisualStyleBackColor = true;
            this.btnRegistrarPlato.Click += new System.EventHandler(this.btnRegistrarPlato_Click);
            // 
            // cmbEstadoPlato
            // 
            this.cmbEstadoPlato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoPlato.FormattingEnabled = true;
            this.cmbEstadoPlato.Items.AddRange(new object[] {
            "Disponible",
            "Agotado",
            "Todos"});
            this.cmbEstadoPlato.Location = new System.Drawing.Point(367, 196);
            this.cmbEstadoPlato.Name = "cmbEstadoPlato";
            this.cmbEstadoPlato.Size = new System.Drawing.Size(121, 21);
            this.cmbEstadoPlato.TabIndex = 44;
            // 
            // txtPrecioPlato
            // 
            this.txtPrecioPlato.Location = new System.Drawing.Point(143, 196);
            this.txtPrecioPlato.Name = "txtPrecioPlato";
            this.txtPrecioPlato.Size = new System.Drawing.Size(105, 20);
            this.txtPrecioPlato.TabIndex = 43;
            // 
            // txtDescripcionPlato
            // 
            this.txtDescripcionPlato.Location = new System.Drawing.Point(169, 151);
            this.txtDescripcionPlato.Name = "txtDescripcionPlato";
            this.txtDescripcionPlato.Size = new System.Drawing.Size(349, 20);
            this.txtDescripcionPlato.TabIndex = 42;
            // 
            // txtNombrePlato
            // 
            this.txtNombrePlato.Location = new System.Drawing.Point(150, 106);
            this.txtNombrePlato.Name = "txtNombrePlato";
            this.txtNombrePlato.Size = new System.Drawing.Size(368, 20);
            this.txtNombrePlato.TabIndex = 41;
            // 
            // txtIdPlato
            // 
            this.txtIdPlato.Location = new System.Drawing.Point(148, 61);
            this.txtIdPlato.Name = "txtIdPlato";
            this.txtIdPlato.ReadOnly = true;
            this.txtIdPlato.Size = new System.Drawing.Size(100, 20);
            this.txtIdPlato.TabIndex = 40;
            // 
            // lblDescripcionPlato
            // 
            this.lblDescripcionPlato.AutoSize = true;
            this.lblDescripcionPlato.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionPlato.Location = new System.Drawing.Point(75, 155);
            this.lblDescripcionPlato.Name = "lblDescripcionPlato";
            this.lblDescripcionPlato.Size = new System.Drawing.Size(88, 16);
            this.lblDescripcionPlato.TabIndex = 39;
            this.lblDescripcionPlato.Text = "Descripcion:";
            // 
            // lblPrecioPlato
            // 
            this.lblPrecioPlato.AutoSize = true;
            this.lblPrecioPlato.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioPlato.Location = new System.Drawing.Point(84, 200);
            this.lblPrecioPlato.Name = "lblPrecioPlato";
            this.lblPrecioPlato.Size = new System.Drawing.Size(53, 16);
            this.lblPrecioPlato.TabIndex = 38;
            this.lblPrecioPlato.Text = "Precio:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(303, 201);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(58, 16);
            this.lblEstado.TabIndex = 37;
            this.lblEstado.Text = "Estado:";
            // 
            // lblNombrePlato
            // 
            this.lblNombrePlato.AutoSize = true;
            this.lblNombrePlato.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePlato.Location = new System.Drawing.Point(82, 110);
            this.lblNombrePlato.Name = "lblNombrePlato";
            this.lblNombrePlato.Size = new System.Drawing.Size(62, 16);
            this.lblNombrePlato.TabIndex = 36;
            this.lblNombrePlato.Text = "Nombre:";
            // 
            // lblIdPlato
            // 
            this.lblIdPlato.AutoSize = true;
            this.lblIdPlato.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPlato.Location = new System.Drawing.Point(83, 65);
            this.lblIdPlato.Name = "lblIdPlato";
            this.lblIdPlato.Size = new System.Drawing.Size(59, 16);
            this.lblIdPlato.TabIndex = 35;
            this.lblIdPlato.Text = "ID Plato";
            // 
            // FrmIngresarPlato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(593, 307);
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
            this.Text = "IngresarPlato";
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