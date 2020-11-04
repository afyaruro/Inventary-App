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
    public partial class FormProducto : Form
    {
        public FormProducto()
        {
            InitializeComponent();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Form formulario = new FormEditarProducto();
            formulario.Show();
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtCodigo.Text = "";
            this.txtNombre.Text = "";
            this.txtTalla.Text = "";
            this.txtCantidad.Text = "";
            this.txtPrecio.Text = "";
            this.txtCodigoBusqueda.Text = "";
        }
    }
}
