using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Factura
    {
        public int DiaFactura { get; set; }
        public int MesFactura { get; set; }
        public int AñoFactura { get; set; }
        public string NumeroFactura { get; set; }
        public decimal TotalFactura { get; set; }
        public List<Detalle_Factura> DetalleFactura { get; set; }
        public Cliente cliente { get; set; }

        public Factura()
        {

        }
        public Factura(int dia, int mes, int año, string numeroFactura, Cliente client)
        {
            this.AñoFactura = año;
            this.DiaFactura = dia;
            this.MesFactura = mes;
            this.NumeroFactura = numeroFactura;
            this.DetalleFactura = new List<Detalle_Factura>();
            this.cliente = client;

        }

        public decimal CalcularTotal()
        {
            
            foreach (var detalle in this.DetalleFactura)
            {

                this.TotalFactura = this.TotalFactura + detalle.ValorSubtotal;
                    
            }
            return this.TotalFactura;

        } 
        public void AñadirDetalleFactura(Detalle_Factura detalleFactura)
        {
                this.DetalleFactura.Add(detalleFactura);
        }
        public void EliminarDetalleFactura(Detalle_Factura detalleFactura)
        {
            this.DetalleFactura.Remove(detalleFactura);
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
