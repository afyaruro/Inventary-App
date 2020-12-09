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
            this.cliente = new Cliente();
            this.TotalFactura = 0;
        }
        public Factura(Cliente client, DateTime fecha)
        {
            this.Fecha = fecha;
            this.DetalleFactura = new List<Detalle_Factura>();
            this.cliente = client;
            

        }

        public decimal CalcularTotal()
        {
            foreach (var item in DetalleFactura)
            {
                TotalFactura = TotalFactura + item.ValorSubtotal;
            }

            return TotalFactura;

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
