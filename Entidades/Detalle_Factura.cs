using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Detalle_Factura
    {
        public string idDetalle { get; set; }
        public int CantidadProductosFacturados { get; set; }

        public decimal ValorSubtotal { get; set; }
        public Producto Producto { get; set; }

        public Detalle_Factura()
        {

        }

        public Detalle_Factura(int cantidadProductosFacturados, Producto producto)
        {
            this.Producto = producto;
            this.CantidadProductosFacturados = cantidadProductosFacturados;
        }

        public decimal CalcularValorSubtotal()
        {
            decimal subTotal;
            subTotal = this.Producto.PrecioUnitario * Convert.ToDecimal(this.CantidadProductosFacturados);
            return this.ValorSubtotal = subTotal;
        }


    }
}
