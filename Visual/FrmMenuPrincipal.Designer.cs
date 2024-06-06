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
            this.btnRegistrarCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTituloPrincipal
            // 
            this.lblTituloPrincipal.AutoSize = true;
            this.lblTituloPrincipal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPrincipal.Location = new System.Drawing.Point(174, 64);
            this.lblTituloPrincipal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTituloPrincipal.Name = "lblTituloPrincipal";
            this.lblTituloPrincipal.Size = new System.Drawing.Size(275, 18);
            this.lblTituloPrincipal.TabIndex = 0;
            this.lblTituloPrincipal.Text = "BIENVENIDO A NOT DELICIUS";
            // 
            // btnOpcionesUsuario
            // 
            this.btnOpcionesUsuario.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpcionesUsuario.Image = global::Visual.Properties.Resources.imgConfig1;
            this.btnOpcionesUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpcionesUsuario.Location = new System.Drawing.Point(329, 132);
            this.btnOpcionesUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpcionesUsuario.Name = "btnOpcionesUsuario";
            this.btnOpcionesUsuario.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnOpcionesUsuario.Size = new System.Drawing.Size(166, 81);
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
            this.btnMenuPedido.Location = new System.Drawing.Point(118, 132);
            this.btnMenuPedido.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenuPedido.Name = "btnMenuPedido";
            this.btnMenuPedido.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnMenuPedido.Size = new System.Drawing.Size(166, 81);
            this.btnMenuPedido.TabIndex = 1;
            this.btnMenuPedido.Text = "Registrar\nPedido";
            this.btnMenuPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenuPedido.UseVisualStyleBackColor = true;
            this.btnMenuPedido.Click += new System.EventHandler(this.btnMenuPedido_Click);
            // 
            // btnRegistrarCliente
            // 
            this.btnRegistrarCliente.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.btnRegistrarCliente.Image = global::Visual.Properties.Resources.imgCliente;
            this.btnRegistrarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarCliente.Location = new System.Drawing.Point(217, 240);
            this.btnRegistrarCliente.Name = "btnRegistrarCliente";
            this.btnRegistrarCliente.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnRegistrarCliente.Size = new System.Drawing.Size(166, 81);
            this.btnRegistrarCliente.TabIndex = 3;
            this.btnRegistrarCliente.Text = "Registrar\nCliente";
            this.btnRegistrarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrarCliente.UseVisualStyleBackColor = true;
            this.btnRegistrarCliente.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.btnRegistrarCliente);
            this.Controls.Add(this.btnOpcionesUsuario);
            this.Controls.Add(this.btnMenuPedido);
            this.Controls.Add(this.lblTituloPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloPrincipal;
        private System.Windows.Forms.Button btnMenuPedido;
        private System.Windows.Forms.Button btnOpcionesUsuario;
        private System.Windows.Forms.Button btnRegistrarCliente;
    }
}