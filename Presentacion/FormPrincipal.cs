using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormProducto>();
        }

        private void AbrirFormulario<Miform>() where Miform : Form , new()
        {
            Form formulario;
            formulario = panelContenedor.Controls.OfType<Miform>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new Miform();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelContenedor.Controls.Add(formulario);
                panelContenedor.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormCliente>();
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormCrearFactura>();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnListasFactura_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormConsultas>();
        }
    }
}
