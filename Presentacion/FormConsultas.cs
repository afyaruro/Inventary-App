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
    public partial class FormConsultas : Form
    {
    
        FacturaService facturaService;
        List<DetalleService> detalleService;
        List<Factura> facturas;
    public FormConsultas()
        {
            facturaService = new FacturaService(ConfigConnection.ConnectionString);
            InitializeComponent();
            facturas = new List<Factura>();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(cmbFiltro.Text == "Todos")
            {
                ActualizarTabla();
            }
            else
            {
                CosultaPorNumeroDeFactura();
            }
        }

        public void ActualizarTabla()
        {
            ConsultaFacturaRespuesta respuesta = new ConsultaFacturaRespuesta();

            ListaFactura.DataSource = null;
            respuesta = facturaService.ConsultarTodos();
            facturas = respuesta.Facturas.ToList();
            ListaFactura.DataSource = respuesta.Facturas;

        }

        public void CosultaPorNumeroDeFactura()
        {
            BusquedaFacturaRespuesta respuesta = new BusquedaFacturaRespuesta();
            string NFactura = txtFiltro.Text;

            if (NFactura != "")
            {
                respuesta = facturaService.BuscarxNumero(NFactura);
             
                if(respuesta.Factura != null)
                {
                    MessageBox.Show("Factura Encontrada");
                    MostrarDetalles(respuesta.Factura);
                }
                else
                {
                    MessageBox.Show("No Existe La Factura...");
                }
            }
            else
            {
                MessageBox.Show("No se ha Ingresado Ningun Numero de Factura");
                
            }
        }
        public void MostrarDetalles(Factura factura)
        {
            txtCedula.Text = factura.cliente.CedulaCliente;
            txtTotal.Text = Convert.ToString(factura.TotalFactura);
            txtNumero.Text = factura.NumeroFactura;


        }
    }
}
