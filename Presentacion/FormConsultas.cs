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

        private void FormConsultas_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(cmbFiltro.Text == "Todos")
            {
                ActualizarTabla();
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
    }
}
