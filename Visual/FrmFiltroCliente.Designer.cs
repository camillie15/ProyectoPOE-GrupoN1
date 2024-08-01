namespace Visual
{
    partial class FrmFiltroCliente
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.txtGmail = new System.Windows.Forms.TextBox();
            this.btnBuscarFiltro = new System.Windows.Forms.Button();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.clId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNombr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbConfirmacion = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dominio del correo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(259, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "BUSQUEDA ESPECIAL DE CLIENTES";
            // 
            // nudEdad
            // 
            this.nudEdad.BackColor = System.Drawing.SystemColors.HighlightText;
            this.nudEdad.ForeColor = System.Drawing.SystemColors.InfoText;
            this.nudEdad.Location = new System.Drawing.Point(212, 61);
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(120, 24);
            this.nudEdad.TabIndex = 3;
            this.nudEdad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGmail
            // 
            this.txtGmail.Location = new System.Drawing.Point(212, 105);
            this.txtGmail.Name = "txtGmail";
            this.txtGmail.Size = new System.Drawing.Size(293, 24);
            this.txtGmail.TabIndex = 4;
            // 
            // btnBuscarFiltro
            // 
            this.btnBuscarFiltro.Image = global::Visual.Properties.Resources.imgBuscar;
            this.btnBuscarFiltro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarFiltro.Location = new System.Drawing.Point(571, 66);
            this.btnBuscarFiltro.Name = "btnBuscarFiltro";
            this.btnBuscarFiltro.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnBuscarFiltro.Size = new System.Drawing.Size(113, 50);
            this.btnBuscarFiltro.TabIndex = 5;
            this.btnBuscarFiltro.Text = "Buscar";
            this.btnBuscarFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarFiltro.UseVisualStyleBackColor = true;
            this.btnBuscarFiltro.Click += new System.EventHandler(this.btnBuscarFiltro_Click);
            // 
            // dgvCliente
            // 
            this.dgvCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(192)))), ((int)(((byte)(179)))));
            this.dgvCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clId,
            this.clNombr,
            this.clApellido,
            this.clCedula,
            this.clEdad,
            this.clCorreo,
            this.clDireccion});
            this.dgvCliente.Location = new System.Drawing.Point(22, 153);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.Size = new System.Drawing.Size(743, 272);
            this.dgvCliente.TabIndex = 6;
            // 
            // clId
            // 
            this.clId.HeaderText = "ID";
            this.clId.Name = "clId";
            this.clId.ReadOnly = true;
            // 
            // clNombr
            // 
            this.clNombr.HeaderText = "Nombre";
            this.clNombr.Name = "clNombr";
            this.clNombr.ReadOnly = true;
            // 
            // clApellido
            // 
            this.clApellido.HeaderText = "Apellido";
            this.clApellido.Name = "clApellido";
            this.clApellido.ReadOnly = true;
            // 
            // clCedula
            // 
            this.clCedula.HeaderText = "Cedula";
            this.clCedula.Name = "clCedula";
            this.clCedula.ReadOnly = true;
            // 
            // clEdad
            // 
            this.clEdad.HeaderText = "Edad";
            this.clEdad.Name = "clEdad";
            this.clEdad.ReadOnly = true;
            // 
            // clCorreo
            // 
            this.clCorreo.HeaderText = "E-mail";
            this.clCorreo.Name = "clCorreo";
            this.clCorreo.ReadOnly = true;
            // 
            // clDireccion
            // 
            this.clDireccion.HeaderText = "Direccion";
            this.clDireccion.Name = "clDireccion";
            this.clDireccion.ReadOnly = true;
            // 
            // cbConfirmacion
            // 
            this.cbConfirmacion.AutoSize = true;
            this.cbConfirmacion.Location = new System.Drawing.Point(338, 63);
            this.cbConfirmacion.Name = "cbConfirmacion";
            this.cbConfirmacion.Size = new System.Drawing.Size(75, 21);
            this.cbConfirmacion.TabIndex = 7;
            this.cbConfirmacion.Text = "Activar";
            this.cbConfirmacion.UseVisualStyleBackColor = true;
            // 
            // FrmFiltroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(797, 452);
            this.Controls.Add(this.cbConfirmacion);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.btnBuscarFiltro);
            this.Controls.Add(this.txtGmail);
            this.Controls.Add(this.nudEdad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmFiltroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmFiltroCliente";
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.TextBox txtGmail;
        private System.Windows.Forms.Button btnBuscarFiltro;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNombr;
        private System.Windows.Forms.DataGridViewTextBoxColumn clApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDireccion;
        private System.Windows.Forms.CheckBox cbConfirmacion;
    }
}