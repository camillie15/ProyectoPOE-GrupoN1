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
            this.btnVisualizarCliente = new System.Windows.Forms.Button();
            this.btnVisualizarPedido = new System.Windows.Forms.Button();
            this.btnVisualizarFactura = new System.Windows.Forms.Button();
            this.btnPlatoOA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVolverOA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVisualizarCliente
            // 
            this.btnVisualizarCliente.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizarCliente.Location = new System.Drawing.Point(192, 107);
            this.btnVisualizarCliente.Name = "btnVisualizarCliente";
            this.btnVisualizarCliente.Size = new System.Drawing.Size(165, 75);
            this.btnVisualizarCliente.TabIndex = 0;
            this.btnVisualizarCliente.Text = "Visualizar Cliente";
            this.btnVisualizarCliente.UseVisualStyleBackColor = true;
            // 
            // btnVisualizarPedido
            // 
            this.btnVisualizarPedido.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizarPedido.Location = new System.Drawing.Point(442, 107);
            this.btnVisualizarPedido.Name = "btnVisualizarPedido";
            this.btnVisualizarPedido.Size = new System.Drawing.Size(165, 75);
            this.btnVisualizarPedido.TabIndex = 1;
            this.btnVisualizarPedido.Text = "Visualizar Pedido";
            this.btnVisualizarPedido.UseVisualStyleBackColor = true;
            this.btnVisualizarPedido.Click += new System.EventHandler(this.btnVisualizarPedido_Click);
            // 
            // btnVisualizarFactura
            // 
            this.btnVisualizarFactura.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizarFactura.Location = new System.Drawing.Point(192, 232);
            this.btnVisualizarFactura.Name = "btnVisualizarFactura";
            this.btnVisualizarFactura.Size = new System.Drawing.Size(165, 75);
            this.btnVisualizarFactura.TabIndex = 2;
            this.btnVisualizarFactura.Text = "Visualizar Factura";
            this.btnVisualizarFactura.UseVisualStyleBackColor = true;
            // 
            // btnPlatoOA
            // 
            this.btnPlatoOA.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlatoOA.Location = new System.Drawing.Point(442, 232);
            this.btnPlatoOA.Name = "btnPlatoOA";
            this.btnPlatoOA.Size = new System.Drawing.Size(165, 75);
            this.btnPlatoOA.TabIndex = 3;
            this.btnPlatoOA.Text = "Plato";
            this.btnPlatoOA.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "OPCIONES DE ADMINISTRACION";
            // 
            // btnVolverOA
            // 
            this.btnVolverOA.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverOA.Location = new System.Drawing.Point(319, 354);
            this.btnVolverOA.Name = "btnVolverOA";
            this.btnVolverOA.Size = new System.Drawing.Size(156, 44);
            this.btnVolverOA.TabIndex = 5;
            this.btnVolverOA.Text = "Volver";
            this.btnVolverOA.UseVisualStyleBackColor = true;
            this.btnVolverOA.Click += new System.EventHandler(this.btnVolverOA_Click);
            // 
            // OpcionesAdministracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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