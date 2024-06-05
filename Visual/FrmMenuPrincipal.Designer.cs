namespace Visual
{
    partial class FrmMenuPrincipal
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
            this.lblTituloPrincipal = new System.Windows.Forms.Label();
            this.btnOpcionesUsuario = new System.Windows.Forms.Button();
            this.btnMenuPedido = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTituloPrincipal
            // 
            this.lblTituloPrincipal.AutoSize = true;
            this.lblTituloPrincipal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPrincipal.Location = new System.Drawing.Point(232, 79);
            this.lblTituloPrincipal.Name = "lblTituloPrincipal";
            this.lblTituloPrincipal.Size = new System.Drawing.Size(355, 25);
            this.lblTituloPrincipal.TabIndex = 0;
            this.lblTituloPrincipal.Text = "BIENVENIDO A NOT DELICIUS";
            // 
            // btnOpcionesUsuario
            // 
            this.btnOpcionesUsuario.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpcionesUsuario.Image = global::Visual.Properties.Resources.imgConfig1;
            this.btnOpcionesUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpcionesUsuario.Location = new System.Drawing.Point(439, 163);
            this.btnOpcionesUsuario.Name = "btnOpcionesUsuario";
            this.btnOpcionesUsuario.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnOpcionesUsuario.Size = new System.Drawing.Size(221, 100);
            this.btnOpcionesUsuario.TabIndex = 2;
            this.btnOpcionesUsuario.Text = "Opciones\nUsuario";
            this.btnOpcionesUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpcionesUsuario.UseVisualStyleBackColor = true;
            this.btnOpcionesUsuario.Click += new System.EventHandler(this.btnOpcionesUsuario_Click);
            // 
            // btnMenuPedido
            // 
            this.btnMenuPedido.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuPedido.Image = global::Visual.Properties.Resources.imgPedido;
            this.btnMenuPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuPedido.Location = new System.Drawing.Point(158, 163);
            this.btnMenuPedido.Name = "btnMenuPedido";
            this.btnMenuPedido.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnMenuPedido.Size = new System.Drawing.Size(221, 100);
            this.btnMenuPedido.TabIndex = 1;
            this.btnMenuPedido.Text = "Registrar\nPedido";
            this.btnMenuPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenuPedido.UseVisualStyleBackColor = true;
            this.btnMenuPedido.Click += new System.EventHandler(this.btnMenuPedido_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(800, 374);
            this.Controls.Add(this.btnOpcionesUsuario);
            this.Controls.Add(this.btnMenuPedido);
            this.Controls.Add(this.lblTituloPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloPrincipal;
        private System.Windows.Forms.Button btnMenuPedido;
        private System.Windows.Forms.Button btnOpcionesUsuario;
    }
}