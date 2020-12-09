using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Factura
    {
        
        public string NumeroFactura { get; set; }
        public decimal TotalFactura { get; set; }
        public List<Detalle_Factura> DetalleFactura { get; set; }
        public Cliente cliente { get; set; }
        public DateTime Fecha { get; set; }


        public Factura()
        {

        }
        public Factura(Cliente client, DateTime fecha)
        {
            this.Fecha = fecha;
            this.DetalleFactura = new List<Detalle_Factura>();
            this.cliente = client;
            

        }

        public void CalcularTotal()
        {

            TotalFactura = DetalleFactura.Sum(p => p.ValorSubtotal);

        } 
        public void AñadirDetalleFactura(int cantidadProductosFacturados, Producto producto)
        {
            Detalle_Factura detalle_Factura = new Detalle_Factura(cantidadProductosFacturados, producto);
                this.DetalleFactura.Add(detalle_Factura);
        }
        public void EliminarDetalleFactura(string codigo)
        {
            var detalle = BuscarDetalleFactura(codigo);
            this.DetalleFactura.Remove(detalle);
        }

        public Detalle_Factura BuscarDetalleFactura(string codigo)
        {
            foreach (var  detalle in this.DetalleFactura)
            {
                if (detalle.Producto.CodigoProducto == codigo)
                {
                    return detalle;
                }
            }
            return null;
        }

        public void GenerarNumeroFactura()
        {
            Random random = new Random();
            var values = random.Next(5000);
            string NFactura = Convert.ToString(values);
            this.NumeroFactura = NFactura;
        }
    }
}
