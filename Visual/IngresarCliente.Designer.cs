﻿using Controlador;
using System.Drawing;

namespace Visual
{
    partial class FrmIngresarCliente
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
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.lblApellidoCliente = new System.Windows.Forms.Label();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.lblCedulaCliente = new System.Windows.Forms.Label();
            this.txtCedulaCliente = new System.Windows.Forms.TextBox();
            this.lblEmailCliente = new System.Windows.Forms.Label();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.btnContinuarCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelarCliente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEdadCliente = new System.Windows.Forms.TextBox();
            this.txtDireccionCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCliente.ForeColor = System.Drawing.Color.White;
            this.lblIdCliente.Location = new System.Drawing.Point(45, 75);
            this.lblIdCliente.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(76, 17);
            this.lblIdCliente.TabIndex = 2;
            this.lblIdCliente.Text = "ID Cliente";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.ForeColor = System.Drawing.Color.White;
            this.lblNombreCliente.Location = new System.Drawing.Point(45, 153);
            this.lblNombreCliente.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(69, 17);
            this.lblNombreCliente.TabIndex = 8;
            this.lblNombreCliente.Text = "Nombre:";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.BackColor = System.Drawing.SystemColors.Window;
            this.txtIdCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdCliente.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCliente.Location = new System.Drawing.Point(144, 72);
            this.txtIdCliente.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.ReadOnly = true;
            this.txtIdCliente.Size = new System.Drawing.Size(174, 24);
            this.txtIdCliente.TabIndex = 3;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(49, 178);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(407, 24);
            this.txtNombreCliente.TabIndex = 9;
            this.txtNombreCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreCliente_KeyPress);
            // 
            // lblApellidoCliente
            // 
            this.lblApellidoCliente.AutoSize = true;
            this.lblApellidoCliente.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoCliente.ForeColor = System.Drawing.Color.White;
            this.lblApellidoCliente.Location = new System.Drawing.Point(489, 153);
            this.lblApellidoCliente.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblApellidoCliente.Name = "lblApellidoCliente";
            this.lblApellidoCliente.Size = new System.Drawing.Size(68, 17);
            this.lblApellidoCliente.TabIndex = 10;
            this.lblApellidoCliente.Text = "Apellido:";
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoCliente.Location = new System.Drawing.Point(493, 178);
            this.txtApellidoCliente.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.Size = new System.Drawing.Size(406, 24);
            this.txtApellidoCliente.TabIndex = 11;
            this.txtApellidoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoCliente_KeyPress);
            // 
            // lblCedulaCliente
            // 
            this.lblCedulaCliente.AutoSize = true;
            this.lblCedulaCliente.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedulaCliente.ForeColor = System.Drawing.Color.White;
            this.lblCedulaCliente.Location = new System.Drawing.Point(45, 116);
            this.lblCedulaCliente.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCedulaCliente.Name = "lblCedulaCliente";
            this.lblCedulaCliente.Size = new System.Drawing.Size(61, 17);
            this.lblCedulaCliente.TabIndex = 4;
            this.lblCedulaCliente.Text = "Cedula:";
            // 
            // txtCedulaCliente
            // 
            this.txtCedulaCliente.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaCliente.Location = new System.Drawing.Point(132, 113);
            this.txtCedulaCliente.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtCedulaCliente.MaxLength = 10;
            this.txtCedulaCliente.Name = "txtCedulaCliente";
            this.txtCedulaCliente.Size = new System.Drawing.Size(131, 24);
            this.txtCedulaCliente.TabIndex = 5;
            this.txtCedulaCliente.TextChanged += new System.EventHandler(this.txtCedulaCliente_TextChanged);
            this.txtCedulaCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedulaCliente_KeyPress);
            // 
            // lblEmailCliente
            // 
            this.lblEmailCliente.AutoSize = true;
            this.lblEmailCliente.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailCliente.ForeColor = System.Drawing.Color.White;
            this.lblEmailCliente.Location = new System.Drawing.Point(45, 219);
            this.lblEmailCliente.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEmailCliente.Name = "lblEmailCliente";
            this.lblEmailCliente.Size = new System.Drawing.Size(50, 17);
            this.lblEmailCliente.TabIndex = 12;
            this.lblEmailCliente.Text = "Email:";
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailCliente.Location = new System.Drawing.Point(49, 244);
            this.txtEmailCliente.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(414, 24);
            this.txtEmailCliente.TabIndex = 13;
            // 
            // btnContinuarCliente
            // 
            this.btnContinuarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(255)))), ((int)(((byte)(100)))));
            this.btnContinuarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuarCliente.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuarCliente.ForeColor = System.Drawing.Color.White;
            this.btnContinuarCliente.Location = new System.Drawing.Point(307, 306);
            this.btnContinuarCliente.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnContinuarCliente.Name = "btnContinuarCliente";
            this.btnContinuarCliente.Size = new System.Drawing.Size(156, 44);
            this.btnContinuarCliente.TabIndex = 16;
            this.btnContinuarCliente.Text = "Registrar";
            this.btnContinuarCliente.UseVisualStyleBackColor = false;
            this.btnContinuarCliente.Click += new System.EventHandler(this.btnContinuarCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "REGISTRO CLIENTES";
            // 
            // btnCancelarCliente
            // 
            this.btnCancelarCliente.BackColor = System.Drawing.Color.LightSalmon;
            this.btnCancelarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarCliente.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCliente.ForeColor = System.Drawing.Color.White;
            this.btnCancelarCliente.Location = new System.Drawing.Point(493, 306);
            this.btnCancelarCliente.Name = "btnCancelarCliente";
            this.btnCancelarCliente.Size = new System.Drawing.Size(156, 44);
            this.btnCancelarCliente.TabIndex = 17;
            this.btnCancelarCliente.Text = "Cancelar";
            this.btnCancelarCliente.UseVisualStyleBackColor = false;
            this.btnCancelarCliente.Click += new System.EventHandler(this.btnCancelarCliente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(489, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Edad: ";
            // 
            // txtEdadCliente
            // 
            this.txtEdadCliente.Location = new System.Drawing.Point(561, 113);
            this.txtEdadCliente.MaxLength = 2;
            this.txtEdadCliente.Name = "txtEdadCliente";
            this.txtEdadCliente.Size = new System.Drawing.Size(131, 24);
            this.txtEdadCliente.TabIndex = 7;
            this.txtEdadCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdadCliente_KeyPress);
            // 
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.Location = new System.Drawing.Point(493, 244);
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.Size = new System.Drawing.Size(406, 24);
            this.txtDireccionCliente.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(489, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Direccion:";
            // 
            // FrmIngresarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(952, 381);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDireccionCliente);
            this.Controls.Add(this.txtEdadCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancelarCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnContinuarCliente);
            this.Controls.Add(this.txtEmailCliente);
            this.Controls.Add(this.lblEmailCliente);
            this.Controls.Add(this.txtCedulaCliente);
            this.Controls.Add(this.lblCedulaCliente);
            this.Controls.Add(this.txtApellidoCliente);
            this.Controls.Add(this.lblApellidoCliente);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.lblIdCliente);
            this.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MaximizeBox = false;
            this.Name = "FrmIngresarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label lblApellidoCliente;
        private System.Windows.Forms.TextBox txtApellidoCliente;
        private System.Windows.Forms.Label lblCedulaCliente;
        private System.Windows.Forms.TextBox txtCedulaCliente;
        private System.Windows.Forms.Label lblEmailCliente;
        private System.Windows.Forms.TextBox txtEmailCliente;
        private System.Windows.Forms.Button btnContinuarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelarCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEdadCliente;
        private System.Windows.Forms.TextBox txtDireccionCliente;
        private System.Windows.Forms.Label label3;
    }
}