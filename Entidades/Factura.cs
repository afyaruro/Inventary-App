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
            this.DetalleFactura = new List<Detalle_Factura>();
            this.cliente = new Cliente();
            this.TotalFactura = 0;
        }
        

        public void CalcularTotal()
        {
            TotalFactura = DetalleFactura.Sum(p => p.ValorSubtotal);
        } 
        public void AñadirDetalleFactura(int cantidad, Producto producto)
        {
            Detalle_Factura detalle_ = new Detalle_Factura(cantidad, producto, this);

            foreach (var item in DetalleFactura)
            {
                detalle_.idDetalle = detalle_.idDetalle + 1;
            }

            detalle_.CalcularValorSubtotal();
            this.DetalleFactura.Add(detalle_);
        }
        public string EliminarDetalleFactura(int id)
        {
            var detalle = BuscarDetalleFactura(id);
            if (detalle != null)
            {

                this.DetalleFactura.Remove(detalle);
                return "Detalle Eliminado Correctamente";
            }
            return "No se Encontro el Detalle a Eliminar..";
            
        }

        public Detalle_Factura BuscarDetalleFactura(int id)
        {
            foreach (var  detalle in this.DetalleFactura)
            {
                if (detalle.idDetalle == id)
                {
                    return detalle;
                }
            }
            return null;
        }

        
    }
}
