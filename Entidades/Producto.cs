using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        public decimal PrecioUnitario { get; set; }
        public int CantidadExistencias { get; set; }
        public string NombreProducto { get; set; }
        public string TallaProducto { get; set; }
        public string CodigoProducto { get; set; }

        public Producto()
        {

        }

        public Producto(decimal precioUnitario, int cantidadExistencias, string nombreProducto, string tallaProducto, string codigoProducto)
        {
            this.PrecioUnitario = precioUnitario;
            this.CantidadExistencias = cantidadExistencias;
            this.NombreProducto = nombreProducto;
            this.TallaProducto = tallaProducto;
            this.CodigoProducto = codigoProducto;
        }

        public void AgregarExistencias(int cantidad)
        {
            this.CantidadExistencias = this.CantidadExistencias + cantidad;
        }

        public void DescontarExistencias(int cantidad)
        {
            this.CantidadExistencias = this.CantidadExistencias - cantidad;
        }

    }
}
