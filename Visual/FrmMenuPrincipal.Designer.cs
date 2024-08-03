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
            this.btnAutores = new System.Windows.Forms.Button();
            this.btnRegistrarCliente = new System.Windows.Forms.Button();
            this.btnOpcionesUsuario = new System.Windows.Forms.Button();
            this.btnMenuPedido = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTituloPrincipal
            // 
            this.lblTituloPrincipal.AutoSize = true;
            this.lblTituloPrincipal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPrincipal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTituloPrincipal.Location = new System.Drawing.Point(232, 79);
            this.lblTituloPrincipal.Name = "lblTituloPrincipal";
            this.lblTituloPrincipal.Size = new System.Drawing.Size(355, 25);
            this.lblTituloPrincipal.TabIndex = 0;
            this.lblTituloPrincipal.Text = "BIENVENIDO A NOT DELICIUS";
            // 
            // btnAutores
            // 
            this.btnAutores.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAutores.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAutores.Location = new System.Drawing.Point(612, 368);
            this.btnAutores.Name = "btnAutores";
            this.btnAutores.Size = new System.Drawing.Size(133, 45);
            this.btnAutores.TabIndex = 4;
            this.btnAutores.Text = "Autores";
            this.btnAutores.UseVisualStyleBackColor = false;
            this.btnAutores.Click += new System.EventHandler(this.btnAutores_Click);
            // 
            // btnRegistrarCliente
            // 
            this.btnRegistrarCliente.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegistrarCliente.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRegistrarCliente.Image = global::Visual.Properties.Resources.imgCliente;
            this.btnRegistrarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarCliente.Location = new System.Drawing.Point(289, 295);
            this.btnRegistrarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarCliente.Name = "btnRegistrarCliente";
            this.btnRegistrarCliente.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.btnRegistrarCliente.Size = new System.Drawing.Size(221, 100);
            this.btnRegistrarCliente.TabIndex = 3;
            this.btnRegistrarCliente.Text = "Registrar\nCliente";
            this.btnRegistrarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrarCliente.UseVisualStyleBackColor = false;
            this.btnRegistrarCliente.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOpcionesUsuario
            // 
            this.btnOpcionesUsuario.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOpcionesUsuario.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpcionesUsuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOpcionesUsuario.Image = global::Visual.Properties.Resources.imgConfig1;
            this.btnOpcionesUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpcionesUsuario.Location = new System.Drawing.Point(439, 162);
            this.btnOpcionesUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpcionesUsuario.Name = "btnOpcionesUsuario";
            this.btnOpcionesUsuario.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnOpcionesUsuario.Size = new System.Drawing.Size(221, 100);
            this.btnOpcionesUsuario.TabIndex = 2;
            this.btnOpcionesUsuario.Text = "Opciones\nUsuario";
            this.btnOpcionesUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpcionesUsuario.UseVisualStyleBackColor = false;
            this.btnOpcionesUsuario.Click += new System.EventHandler(this.btnOpcionesUsuario_Click);
            // 
            // btnMenuPedido
            // 
            this.btnMenuPedido.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMenuPedido.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuPedido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMenuPedido.Image = global::Visual.Properties.Resources.imgPedido;
            this.btnMenuPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuPedido.Location = new System.Drawing.Point(157, 162);
            this.btnMenuPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenuPedido.Name = "btnMenuPedido";
            this.btnMenuPedido.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnMenuPedido.Size = new System.Drawing.Size(221, 100);
            this.btnMenuPedido.TabIndex = 1;
            this.btnMenuPedido.Text = "Registrar\nPedido";
            this.btnMenuPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenuPedido.UseVisualStyleBackColor = false;
            this.btnMenuPedido.Click += new System.EventHandler(this.btnMenuPedido_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(800, 443);
            this.Controls.Add(this.btnAutores);
            this.Controls.Add(this.btnRegistrarCliente);
            this.Controls.Add(this.btnOpcionesUsuario);
            this.Controls.Add(this.btnMenuPedido);
            this.Controls.Add(this.lblTituloPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button btnAutores;
    }
}