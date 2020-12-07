using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Logica;

namespace Presentacion
{
    public partial class FormCliente : Form
    {
        ClienteService Service;
        Cliente cliente;
        public FormCliente()
        {
            InitializeComponent();
            // Service = new ClienteService(ConfigConnection.ConnectionString);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }
        public void Limpiar()
        {
            this.txtCedula.Text = "";
            this.txtNombre.Text = "";
            this.txtApellido.Text = "";
            this.txtCelular.Text = "";
            this.txtEmail.Text = "";
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            Cliente cliente = MapearCliente();
          //  string mensaje = Service.Guardar(cliente);
          //  MessageBox.Show(mensaje, "Mensaje de Guardado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            Limpiar();
        }

        private Cliente MapearCliente()
        {
            cliente = new Cliente();
            cliente.CedulaCliente = txtCedula.Text;
            cliente.ApellidoCliente = txtApellido.Text;
            cliente.NombreCliente = txtNombre.Text;
            cliente.CelularCliente = txtCelular.Text;
            cliente.Email = txtEmail.Text;


            return cliente;

        }
    }
}
