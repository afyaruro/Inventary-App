using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Factura
    {
        public DateTime Fecha { get; set; }
        public string NumeroFactura { get; set; }
        public decimal TotalFactura { get; set; }
        public List<Detalle_Factura> DetalleFactura { get; set; }
        public Cliente cliente { get; set; }
        

        public Factura()
        {

        }
        public Factura(string numeroFactura, Cliente client, DateTime fecha)
        {
            this.Fecha = fecha;
            this.NumeroFactura = numeroFactura;
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
    }
}
