namespace Visual
{
    partial class OpcionesAdministracion
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnVolverOA = new System.Windows.Forms.Button();
            this.btnPlatoOA = new System.Windows.Forms.Button();
            this.btnVisualizarFactura = new System.Windows.Forms.Button();
            this.btnVisualizarPedido = new System.Windows.Forms.Button();
            this.btnVisualizarCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "OPCIONES DE ADMINISTRACION";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnVolverOA
            // 
            this.btnVolverOA.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverOA.Image = global::Visual.Properties.Resources.imgVolver;
            this.btnVolverOA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolverOA.Location = new System.Drawing.Point(318, 341);
            this.btnVolverOA.Name = "btnVolverOA";
            this.btnVolverOA.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnVolverOA.Size = new System.Drawing.Size(145, 50);
            this.btnVolverOA.TabIndex = 5;
            this.btnVolverOA.Text = "Volver";
            this.btnVolverOA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVolverOA.UseVisualStyleBackColor = true;
            this.btnVolverOA.Click += new System.EventHandler(this.btnVolverOA_Click);
            // 
            // btnPlatoOA
            // 
            this.btnPlatoOA.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlatoOA.Image = global::Visual.Properties.Resources.imgPlato;
            this.btnPlatoOA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlatoOA.Location = new System.Drawing.Point(424, 215);
            this.btnPlatoOA.Name = "btnPlatoOA";
            this.btnPlatoOA.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnPlatoOA.Size = new System.Drawing.Size(221, 100);
            this.btnPlatoOA.TabIndex = 3;
            this.btnPlatoOA.Text = "Plato";
            this.btnPlatoOA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlatoOA.UseVisualStyleBackColor = true;
            // 
            // btnVisualizarFactura
            // 
            this.btnVisualizarFactura.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizarFactura.Image = global::Visual.Properties.Resources.imgFactura;
            this.btnVisualizarFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisualizarFactura.Location = new System.Drawing.Point(174, 215);
            this.btnVisualizarFactura.Name = "btnVisualizarFactura";
            this.btnVisualizarFactura.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnVisualizarFactura.Size = new System.Drawing.Size(221, 100);
            this.btnVisualizarFactura.TabIndex = 2;
            this.btnVisualizarFactura.Text = "Visualizar\nFactura";
            this.btnVisualizarFactura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVisualizarFactura.UseVisualStyleBackColor = true;
            // 
            // btnVisualizarPedido
            // 
            this.btnVisualizarPedido.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizarPedido.Image = global::Visual.Properties.Resources.imgPedidoOAA;
            this.btnVisualizarPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisualizarPedido.Location = new System.Drawing.Point(424, 90);
            this.btnVisualizarPedido.Name = "btnVisualizarPedido";
            this.btnVisualizarPedido.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnVisualizarPedido.Size = new System.Drawing.Size(221, 100);
            this.btnVisualizarPedido.TabIndex = 1;
            this.btnVisualizarPedido.Text = "Visualizar\nPedido";
            this.btnVisualizarPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVisualizarPedido.UseVisualStyleBackColor = true;
            this.btnVisualizarPedido.Click += new System.EventHandler(this.btnVisualizarPedido_Click);
            // 
            // btnVisualizarCliente
            // 
            this.btnVisualizarCliente.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizarCliente.Image = global::Visual.Properties.Resources.imgCliente;
            this.btnVisualizarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisualizarCliente.Location = new System.Drawing.Point(174, 90);
            this.btnVisualizarCliente.Name = "btnVisualizarCliente";
            this.btnVisualizarCliente.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnVisualizarCliente.Size = new System.Drawing.Size(221, 100);
            this.btnVisualizarCliente.TabIndex = 0;
            this.btnVisualizarCliente.Text = "Visualizar\nCliente";
            this.btnVisualizarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVisualizarCliente.UseVisualStyleBackColor = true;
            // 
            // OpcionesAdministracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(800, 434);
            this.Controls.Add(this.btnVolverOA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPlatoOA);
            this.Controls.Add(this.btnVisualizarFactura);
            this.Controls.Add(this.btnVisualizarPedido);
            this.Controls.Add(this.btnVisualizarCliente);
            this.MaximizeBox = false;
            this.Name = "OpcionesAdministracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opciones Administracion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVisualizarCliente;
        private System.Windows.Forms.Button btnVisualizarPedido;
        private System.Windows.Forms.Button btnVisualizarFactura;
        private System.Windows.Forms.Button btnPlatoOA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVolverOA;
    }
}