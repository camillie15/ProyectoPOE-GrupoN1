namespace Visual
{
    partial class VisualizarPlato
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
            this.txtCampoBusqueda = new System.Windows.Forms.TextBox();
            this.btnEliminarPlato = new System.Windows.Forms.Button();
            this.btnEditarPlato = new System.Windows.Forms.Button();
            this.btnAgregarPlato = new System.Windows.Forms.Button();
            this.btnBuscarPlato = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCampoBuscar = new System.Windows.Forms.TextBox();
            this.cmbCampoBuscar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVolverPlato = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(195, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 18);
            this.label3.TabIndex = 32;
            this.label3.Text = "VISUALIZAR PLATO";
            // 
            // txtCampoBusqueda
            // 
            this.txtCampoBusqueda.Location = new System.Drawing.Point(47, 100);
            this.txtCampoBusqueda.Multiline = true;
            this.txtCampoBusqueda.Name = "txtCampoBusqueda";
            this.txtCampoBusqueda.Size = new System.Drawing.Size(431, 195);
            this.txtCampoBusqueda.TabIndex = 31;
            // 
            // btnEliminarPlato
            // 
            this.btnEliminarPlato.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPlato.Location = new System.Drawing.Point(518, 190);
            this.btnEliminarPlato.Name = "btnEliminarPlato";
            this.btnEliminarPlato.Size = new System.Drawing.Size(68, 30);
            this.btnEliminarPlato.TabIndex = 30;
            this.btnEliminarPlato.Text = "Eliminar";
            this.btnEliminarPlato.UseVisualStyleBackColor = true;
            // 
            // btnEditarPlato
            // 
            this.btnEditarPlato.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarPlato.Location = new System.Drawing.Point(518, 145);
            this.btnEditarPlato.Name = "btnEditarPlato";
            this.btnEditarPlato.Size = new System.Drawing.Size(68, 30);
            this.btnEditarPlato.TabIndex = 29;
            this.btnEditarPlato.Text = "Editar";
            this.btnEditarPlato.UseVisualStyleBackColor = true;
            // 
            // btnAgregarPlato
            // 
            this.btnAgregarPlato.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPlato.Location = new System.Drawing.Point(518, 100);
            this.btnAgregarPlato.Name = "btnAgregarPlato";
            this.btnAgregarPlato.Size = new System.Drawing.Size(68, 30);
            this.btnAgregarPlato.TabIndex = 28;
            this.btnAgregarPlato.Text = "Agregar";
            this.btnAgregarPlato.UseVisualStyleBackColor = true;
            // 
            // btnBuscarPlato
            // 
            this.btnBuscarPlato.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPlato.Location = new System.Drawing.Point(451, 56);
            this.btnBuscarPlato.Name = "btnBuscarPlato";
            this.btnBuscarPlato.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPlato.TabIndex = 27;
            this.btnBuscarPlato.Text = "Buscar";
            this.btnBuscarPlato.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "->";
            // 
            // txtCampoBuscar
            // 
            this.txtCampoBuscar.Location = new System.Drawing.Point(276, 55);
            this.txtCampoBuscar.Name = "txtCampoBuscar";
            this.txtCampoBuscar.Size = new System.Drawing.Size(169, 20);
            this.txtCampoBuscar.TabIndex = 25;
            // 
            // cmbCampoBuscar
            // 
            this.cmbCampoBuscar.FormattingEnabled = true;
            this.cmbCampoBuscar.Items.AddRange(new object[] {
            "Disponibles",
            "Agotados",
            "Todos"});
            this.cmbCampoBuscar.Location = new System.Drawing.Point(127, 56);
            this.cmbCampoBuscar.Name = "cmbCampoBuscar";
            this.cmbCampoBuscar.Size = new System.Drawing.Size(121, 21);
            this.cmbCampoBuscar.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Campo a Buscar";
            // 
            // btnVolverPlato
            // 
            this.btnVolverPlato.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverPlato.Location = new System.Drawing.Point(230, 305);
            this.btnVolverPlato.Name = "btnVolverPlato";
            this.btnVolverPlato.Size = new System.Drawing.Size(73, 30);
            this.btnVolverPlato.TabIndex = 33;
            this.btnVolverPlato.Text = "Volver";
            this.btnVolverPlato.UseVisualStyleBackColor = true;
            // 
            // VisualizarPlato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 347);
            this.Controls.Add(this.btnVolverPlato);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCampoBusqueda);
            this.Controls.Add(this.btnEliminarPlato);
            this.Controls.Add(this.btnEditarPlato);
            this.Controls.Add(this.btnAgregarPlato);
            this.Controls.Add(this.btnBuscarPlato);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCampoBuscar);
            this.Controls.Add(this.cmbCampoBuscar);
            this.Controls.Add(this.label1);
            this.Name = "VisualizarPlato";
            this.Text = "VisualizarPlato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCampoBusqueda;
        private System.Windows.Forms.Button btnEliminarPlato;
        private System.Windows.Forms.Button btnEditarPlato;
        private System.Windows.Forms.Button btnAgregarPlato;
        private System.Windows.Forms.Button btnBuscarPlato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCampoBuscar;
        private System.Windows.Forms.ComboBox cmbCampoBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVolverPlato;
    }
}