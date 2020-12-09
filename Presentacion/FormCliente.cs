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
        List<Cliente> clientes;

        public FormCliente()
        {
            Service = new ClienteService(ConfigConnection.ConnectionString);
            InitializeComponent();
            clientes = new List<Cliente>();
            ActualizarTabla();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("Está seguro de Modificar la información", "Mensaje de Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                Cliente cliente = MapearCliente();
                string mensaje = Service.Modificar(cliente);
            }
            ActualizarTabla();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BusquedaClienteRespuesta respuesta = new BusquedaClienteRespuesta();
            string cedula = txtCedula.Text;
            if (cedula != "")
            {
                respuesta = Service.BuscarxCedula(cedula);

                if (respuesta.Cliente != null)
                {
                    txtCedula.Text = respuesta.Cliente.CedulaCliente;
                    txtNombre.Text = respuesta.Cliente.NombreCliente;
                    txtApellido.Text = respuesta.Cliente.ApellidoCliente;
                    txtCelular.Text = respuesta.Cliente.CelularCliente;
                    txtEmail.Text = respuesta.Cliente.Email;
                    
                    MessageBox.Show(respuesta.Mensaje, "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(respuesta.Mensaje, "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Por favor digite un numero de Cedula", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
            string mensaje = Service.Guardar(cliente);
            MessageBox.Show(mensaje, "Mensaje de Guardado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            Limpiar();
            ActualizarTabla();
        }

        public void ActualizarTabla()
        {
            ConsultaClienteRespuesta respuesta = new ConsultaClienteRespuesta();

            tablaCliente.DataSource = null;
            respuesta = Service.ConsultarTodos();
            clientes = respuesta.Clientes.ToList();
            tablaCliente.DataSource = respuesta.Clientes;

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

        public void Pdf()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Guardar Informe de Clientes";
            saveFileDialog.InitialDirectory = @"C:/document";
            saveFileDialog.DefaultExt = "pdf";
            string filename = "";
            ValidarCedula(saveFileDialog, filename);
            
        }

        public void ValidarCedula(SaveFileDialog saveFileDialog, string filename)
        {
            if (txtCedula.Text == "")
            {
                MessageBox.Show("Por favor Ingrese un numero de Cedula");
            }
            else
            {
                GenerarPdf(saveFileDialog, filename);
            }
            
        }

        public void GenerarPdf(SaveFileDialog saveFileDialog, string filename)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialog.FileName;
                if (filename != "" && clientes.Count > 0)
                {
                    string mensaje = Service.GenerarPdf(clientes, filename, txtCedula.Text);
                    MessageBox.Show(mensaje);
                }
                else
                {
                    MessageBox.Show("No se especifico una ruta o no hay datos para generar el reporte", "generar pdf", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            Pdf();
        }
    }
}
