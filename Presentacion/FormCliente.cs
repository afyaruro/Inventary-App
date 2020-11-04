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
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Form formulario = new FormEditarCliente();
            formulario.Show();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtCedula.Text = "";
            this.txtNombre.Text = "";
            this.txtApellido.Text = "";
            this.txtCelular.Text = "";
            this.txtCedulaBusqueda.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
