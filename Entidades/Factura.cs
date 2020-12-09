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
        

        public string CalcularTotal()
        {
            if (DetalleFactura != null)
            {
                foreach (var item in DetalleFactura)
                {
                    TotalFactura = TotalFactura + item.ValorSubtotal;
                }

                return "Se calculo el total Correctamente";
            }
            else
            {
                return "No hay detalles de factura";
            }
            
        } 
        public void AñadirDetalleFactura(int cantidad, Producto producto)
        {
            Detalle_Factura detalle_ = new Detalle_Factura();
            this.DetalleFactura.Add(detalle_);
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
