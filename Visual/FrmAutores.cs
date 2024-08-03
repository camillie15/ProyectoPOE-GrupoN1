using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;

namespace Visual
{
    public partial class FrmAutores : Form
    {
        CtrlAutores ctrlAutores = new CtrlAutores();
        private Label lblAutores;
        private DataGridView dgvAutores;
        private ComboBox cmbModulos;
        private Label lblBuscar;
        private Button btnBuscar;
        public FrmAutores()
        {
            CreateComponents();
        }

        private void CreateComponents()
        {
            this.BackColor = Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(800, 600);
            this.Text = "Autores";

            lblAutores = new Label();
            lblAutores.Text = "Autores Proyecto POE: ";
            lblAutores.Size = new Size(175, 20);
            lblAutores.Location = new Point(20, 20);
            lblAutores.ForeColor = Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(223)))));
            lblAutores.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            lblBuscar = new Label();
            lblBuscar.Text = "Modulo a Buscar:";
            lblBuscar.Location = new Point(40, 53);
            lblBuscar.ForeColor = Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(223)))));
            lblBuscar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            cmbModulos = new ComboBox();
            string[] modulos = new string[] { "Pedido", "Cliente", "Plato", "Factura", "TODOS" };
            foreach (string mod in modulos)
            {
                cmbModulos.Items.Add(mod);

            }
            cmbModulos.Location = new Point(140, 53);
            cmbModulos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbModulos.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            btnBuscar = new Button();
            btnBuscar.Text = "Buscar";
            btnBuscar.Size = new System.Drawing.Size(130, 30);
            btnBuscar.Location = new Point(300, 50);
            btnBuscar.Click += BtnBuscar_Click;
            btnBuscar.BackColor = Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(209)))), ((int)(((byte)(120)))));
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(223)))));
            btnBuscar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            dgvAutores = new DataGridView();
            dgvAutores.Location = new Point(70, 100);
            dgvAutores.Size = new Size(645, 425);
            dgvAutores.AllowUserToAddRows = false;
            dgvAutores.BorderStyle = BorderStyle.Fixed3D;
            dgvAutores.RowTemplate.Height = 100;
            dgvAutores.Font = new Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dgvAutores.BackgroundColor = Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(62)))));
            dgvAutores.BorderStyle = BorderStyle.Fixed3D;

            DataGridViewTextBoxColumn nombres = new DataGridViewTextBoxColumn();
            nombres.HeaderText = "Nombres";
            DataGridViewTextBoxColumn apellidos = new DataGridViewTextBoxColumn();
            apellidos.HeaderText = "Apellidos";
            DataGridViewTextBoxColumn cedula = new DataGridViewTextBoxColumn();
            cedula.HeaderText = "Cedula";
            DataGridViewTextBoxColumn email = new DataGridViewTextBoxColumn();
            email.HeaderText = "Email";
            DataGridViewTextBoxColumn modulo = new DataGridViewTextBoxColumn();
            modulo.HeaderText = "Modulo";
            DataGridViewImageColumn foto = new DataGridViewImageColumn();
            foto.HeaderText = "Foto";
            dgvAutores.Columns.AddRange(new DataGridViewColumn[] { nombres, apellidos, cedula, email, modulo, foto });

            Controls.Add(lblAutores);
            Controls.Add(lblBuscar);
            Controls.Add(cmbModulos);
            Controls.Add(btnBuscar);
            Controls.Add(dgvAutores);

            dgvAutores = ctrlAutores.AutocompletarGrid(dgvAutores);

            InsertarImg();

        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string moduloBuscar = (string)cmbModulos.SelectedItem;

            ctrlAutores.Buscar(moduloBuscar, dgvAutores);

            InsertarImg();
        }
        private void InsertarImg()
        {
            if (dgvAutores.RowCount > 0)
            {
                foreach (DataGridViewRow row in dgvAutores.Rows)
                {
                    if (row.Cells[4].Value.Equals("Pedido"))
                    {
                        dgvAutores.Rows[row.Index].Cells[5].Value = Image.FromFile("..\\..\\Resources\\imgCami.jpg");
                    }
                    else if (row.Cells[4].Value.Equals("Cliente"))
                    {
                        dgvAutores.Rows[row.Index].Cells[5].Value = Image.FromFile("..\\..\\Resources\\imgErick.jpg");
                    }
                    else if (row.Cells[4].Value.Equals("Plato"))
                    {
                        dgvAutores.Rows[row.Index].Cells[5].Value = Image.FromFile("..\\..\\Resources\\imgMateo.jpg");
                    }
                    else if (row.Cells[4].Value.Equals("Factura"))
                    {
                        dgvAutores.Rows[row.Index].Cells[5].Value = Image.FromFile("..\\..\\Resources\\imgJuliet.jpg");
                    }
                }
            }
        }
    }
}
