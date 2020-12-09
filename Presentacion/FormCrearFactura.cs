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
    public partial class FormCrearFactura : Form
    {
        FacturaService facturaService;
        Factura factura;
        ProductoService productoService;
        ClienteService clienteService;
        List<Factura> facturas;
        public FormCrearFactura()
        {
            
            facturaService = new FacturaService(ConfigConnection.ConnectionString);
            productoService = new ProductoService(ConfigConnection.ConnectionString);
            clienteService = new ClienteService(ConfigConnection.ConnectionString);
            facturas = new List<Factura>();
            
            InitializeComponent();
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            Factura factura  = MapearFactura();
            string mensaje = facturaService.GuardarFactura(factura);
            MessageBox.Show(mensaje, "Mensaje de Guardado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            Limpiar();
        }
        private Factura MapearFactura()
        {
            factura = new Factura();
            factura.NumeroFactura = txtNumeroFactura.Text;
            factura.TotalFactura = decimal.Parse(txtTotal.Text);
            factura.Fecha = DateTime.Parse(this.Fecha.Text);
            BusquedaClienteRespuesta respuesta = new BusquedaClienteRespuesta();
            string cedula = txtCedula.Text;
            respuesta = clienteService.BuscarxCedula(cedula);
            factura.cliente = respuesta.Cliente;
            
          
            return factura;

        }
        public void Limpiar()
        {
            this.txtNumeroFactura.Text = "";
            this.txtCedula.Text = "";
            this.txtNombre.Text = "";
            this.txtApellido.Text = "";
            this.txtCelular.Text = "";
            this.txtCodigo.Text = "";
            this.txtNombreProducto.Text = "";
            this.txtCantidad.Text = "";
            this.txtTalla.Text = "";
            this.txtPrecio.Text = "";
            this.txtTotal.Text = "";
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            int cantidadProductosaFacturar = int.Parse(txtCantidad.Text);
            BusquedaProductoRespuesta respuesta = new BusquedaProductoRespuesta();
            string codigo = txtCodigo.Text;
            if (codigo != "")
            {
                respuesta = productoService.BuscarxCodigo(codigo);
                factura.AñadirDetalleFactura(cantidadProductosaFacturar, respuesta.Producto);
                Limpiar();
            }
        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {
            BusquedaClienteRespuesta respuesta = new BusquedaClienteRespuesta();
            string cedula = txtCedula.Text;
            if (cedula != "")
            {
                respuesta = clienteService.BuscarxCedula(cedula);

                if (respuesta.Cliente != null)
                {
                    txtNombre.Text = respuesta.Cliente.NombreCliente;
                    txtApellido.Text = respuesta.Cliente.ApellidoCliente;
                    txtCelular.Text = respuesta.Cliente.CelularCliente;

                }
                
            }

            else
            {
                MessageBox.Show("ingrese un numero de Cedula de un cliente que este registrado...");
            }


        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            BusquedaProductoRespuesta respuesta = new BusquedaProductoRespuesta();
            string codigo = txtCodigo.Text;
            if (codigo != "")
            {
                respuesta = productoService.BuscarxCodigo(codigo);

                if (respuesta.Producto != null)
                {
                    txtNombreProducto.Text = respuesta.Producto.NombreProducto;
                    txtTalla.Text = respuesta.Producto.TallaProducto.ToString();
                    txtPrecio.Text = respuesta.Producto.PrecioUnitario.ToString();
                    
                }
                
            }

            else
            {
                MessageBox.Show("Ingrese Un Codigo de Producto que este registrado...");
            }

        }

        private void FormCrearFactura_Load(object sender, EventArgs e)
        {
            ActualizarNumeroFactura();
        }

        public void ActualizarNumeroFactura()
        {
            Random random = new Random();
            var values = random.Next(5000);
            string NFactura = Convert.ToString(values);
            txtNumeroFactura.Text = NFactura;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarNumeroFactura();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            string numeroFactura = txtNumeroFactura.Text;
            BusquedaFacturaRespuesta facturaRespuesta = new BusquedaFacturaRespuesta();


            facturaRespuesta = facturaService.BuscarxNumero(numeroFactura);




        }
    }
}
