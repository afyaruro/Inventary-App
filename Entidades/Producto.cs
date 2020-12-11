using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        public string CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public string Estado { get; set; }
        public string TallaProducto { get; set; }
        public int CantidadExistencias { get; set; }
        public decimal PrecioUnitario { get; set; }
        
        
       
        
       

        public Producto()
        {

        }

        public Producto(decimal precioUnitario, int cantidadExistencias, string nombreProducto, string tallaProducto, string codigoProducto, string estado)
        {
            this.PrecioUnitario = precioUnitario;
            this.CantidadExistencias = cantidadExistencias;
            this.NombreProducto = nombreProducto;
            this.TallaProducto = tallaProducto;
            this.CodigoProducto = codigoProducto;
            this.Estado = estado;
        }

        public void DescontarExistencias(int cantidad)
        {
            int Nuevacantidad = this.CantidadExistencias - cantidad;

            if (Nuevacantidad >= 0)
            {
                this.CantidadExistencias = Nuevacantidad;
            }
            
        }

    }
}
