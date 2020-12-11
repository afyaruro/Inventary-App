using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;

namespace Datos
{
    public class DetalleRepository
    {
        private readonly SqlConnection _conection;

        public DetalleRepository(ConnectionManager connection)
        {
            _conection = connection._conexion;
        }

        public void GuardarFactura(Detalle_Factura detalle_)
        {
            using (var commando = _conection.CreateCommand())
            {
                commando.CommandText = "Insert Into Detalle (Cantidad, Valor_Subtotal, CodigoProducto, NumeroFactura) " +
                    "Values (@Cantidad, @Valor_Subtotal, @CodigoProducto, @NumeroFactura)";

                commando.Parameters.AddWithValue("@Cantidad", detalle_.CantidadProductosFacturados);
                commando.Parameters.AddWithValue("@Valor_Subtotal", detalle_.ValorSubtotal);
                commando.Parameters.AddWithValue("@CodigoProducto", detalle_.Producto.CodigoProducto);
                commando.Parameters.AddWithValue("@NumeroFactura", detalle_.factura.NumeroFactura);
                commando.ExecuteNonQuery();

            }

        }

        public List<Detalle_Factura> ConsultarTodos()
        {
            List<Detalle_Factura> detalles = new List<Detalle_Factura>();
            using (var command = _conection.CreateCommand())
            {
                command.CommandText = "Select Id, Cantidad, Valor_Subtotal, CodigoProducto, NumeroFactura from Detalle ";
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Detalle_Factura detalle = DataReaderMapToDetalle(dataReader);
                        detalles.Add(detalle);
                    }

                }
            }

            return detalles;
        }


        public Detalle_Factura BuscarPorNumero(int idDetalle)
        {
            SqlDataReader dataReader;
            Detalle_Factura detalle;

            using (var command = _conection.CreateCommand())
            {
                command.CommandText = "select * from Detalle where Id=@Id";
                command.Parameters.AddWithValue("@Id", idDetalle);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                detalle = DataReaderMapToDetalle(dataReader);
                dataReader.Close();
            }

            return detalle;

        }

        private Detalle_Factura DataReaderMapToDetalle(SqlDataReader dataReader)
        {
            
            if (!dataReader.HasRows) return null;
            Detalle_Factura detalle = new Detalle_Factura();
            detalle.idDetalle = (int)dataReader["Id"];
            detalle.CantidadProductosFacturados = (int)dataReader["Cantidad"];
            detalle.ValorSubtotal = (decimal)dataReader["Valor_Subtotal"];
            detalle.Producto.CodigoProducto = (string)dataReader["CodigoProducto"];
            detalle.factura.NumeroFactura = (string)dataReader["NumeroFactura"];

            return detalle;
        }
    }
}
