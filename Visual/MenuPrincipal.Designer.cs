namespace Visual
{
    partial class MenuPrincipal
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
            this.btnMenuPedido = new System.Windows.Forms.Button();
            this.btnOpcionesUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTituloPrincipal
            // 
            this.lblTituloPrincipal.AutoSize = true;
            this.lblTituloPrincipal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPrincipal.Location = new System.Drawing.Point(196, 68);
            this.lblTituloPrincipal.Name = "lblTituloPrincipal";
            this.lblTituloPrincipal.Size = new System.Drawing.Size(355, 25);
            this.lblTituloPrincipal.TabIndex = 0;
            this.lblTituloPrincipal.Text = "BIENVENIDO A NOT DELICIUS";
            // 
            // btnMenuPedido
            // 
            this.btnMenuPedido.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuPedido.Location = new System.Drawing.Point(132, 198);
            this.btnMenuPedido.Name = "btnMenuPedido";
            this.btnMenuPedido.Size = new System.Drawing.Size(165, 75);
            this.btnMenuPedido.TabIndex = 1;
            this.btnMenuPedido.Text = "Registrar Pedido";
            this.btnMenuPedido.UseVisualStyleBackColor = true;
            this.btnMenuPedido.Click += new System.EventHandler(this.btnMenuPedido_Click);
            // 
            // btnOpcionesUsuario
            // 
            this.btnOpcionesUsuario.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpcionesUsuario.Location = new System.Drawing.Point(462, 198);
            this.btnOpcionesUsuario.Name = "btnOpcionesUsuario";
            this.btnOpcionesUsuario.Size = new System.Drawing.Size(165, 75);
            this.btnOpcionesUsuario.TabIndex = 2;
            this.btnOpcionesUsuario.Text = "Opciones de Usuario";
            this.btnOpcionesUsuario.UseVisualStyleBackColor = true;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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