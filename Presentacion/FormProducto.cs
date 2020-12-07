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
    public partial class FormProducto : Form
    {
        ProductoService productoService;
        Producto producto;

        public FormProducto()
        {
            InitializeComponent();
            productoService = new ProductoService(ConfigConnection.ConnectionString);
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        public void Limpiar()
        {
            this.txtCodigo.Text = "";
            this.txtNombre.Text = "";
            this.txtTalla.Text = "";
            this.txtCantidad.Text = "";
            this.txtPrecio.Text = "";
            this.cbmEstado.Text = "";
        }

        
        private Producto MapearProducto()
        {
            producto = new Producto();
            producto.CodigoProducto = txtCodigo.Text;
            producto.NombreProducto = txtNombre.Text;
            producto.Estado = cbmEstado.Text;
            producto.CantidadExistencias = int.Parse(txtCantidad.Text);
            producto.TallaProducto = txtCantidad.Text;
            producto.PrecioUnitario = decimal.Parse(txtPrecio.Text);
    
            return producto;

        }

        private void btnConsultar_Click_1(object sender, EventArgs e)
        {
           BusquedaProductoRespuesta respuesta = new BusquedaProductoRespuesta();
            string codigo = txtCodigo.Text;
            if (codigo != "")
            {
                respuesta = productoService.BuscarxCodigo(codigo);

                if (respuesta.Producto != null)
                {
                    txtCodigo.Text = respuesta.Producto.CodigoProducto;
                    txtNombre.Text = respuesta.Producto.NombreProducto;
                    cbmEstado.Text = respuesta.Producto.Estado;
                    txtCantidad.Text = respuesta.Producto.CantidadExistencias.ToString();
                    txtTalla.Text = respuesta.Producto.TallaProducto.ToString();
                    txtPrecio.Text = respuesta.Producto.PrecioUnitario.ToString();
                    MessageBox.Show(respuesta.Mensaje, "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(respuesta.Mensaje, "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Por favor digite un Codigo", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("Está seguro de Modificar la información", "Mensaje de Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                Producto producto = MapearProducto();
                string mensaje = productoService.Modificar(producto);
            }
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            Producto producto = MapearProducto();
            string mensaje = productoService.Guardar(producto);
            MessageBox.Show(mensaje, "Mensaje de Guardado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            Limpiar();
        }
    }
}
