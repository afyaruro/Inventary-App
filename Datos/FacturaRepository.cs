using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;

namespace Datos
{
    public class FacturaRepository
    {
        private readonly SqlConnection _conection;

        public FacturaRepository(ConnectionManager connection)
        {
            _conection = connection._conexion;
        }

        public void GuardarFactura(Factura factura)
        {
            using (var commando = _conection.CreateCommand())
            {
                commando.CommandText = "Insert Into Factura (NumeroFactura, TotalFactura, Fecha, CedulaCliente) " +
                    "Values (@NumeroFactura, @TotalFactura, @Fecha, @CedulaCliente)";

                commando.Parameters.AddWithValue("@NumeroFactura", factura.NumeroFactura);
                commando.Parameters.AddWithValue("@TotalFactura", factura.TotalFactura);
                commando.Parameters.AddWithValue("@Fecha", factura.Fecha.ToString("dd/MM/yyyy"));
                commando.Parameters.AddWithValue("@CedulaCliente", factura.cliente.CedulaCliente);
                commando.ExecuteNonQuery();

            }

        }

        public List<Factura> ConsultarTodos()
        {
            List<Factura> facturas = new List<Factura>();
            using (var command = _conection.CreateCommand())
            {
                command.CommandText = "Select NumeroFactura, TotalFactura, Fecha, CedulaCliente from Factura ";
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Factura factura = DataReaderMapToFactura(dataReader);
                        facturas.Add(factura);
                    }

                }
            }

            return facturas;
        }


        public Factura BuscarPorNumero(string numeroFactura)
        {
            SqlDataReader dataReader;
            Factura factura;

            using (var command = _conection.CreateCommand())
            {
                command.CommandText = "select * from Factura where NumeroFactura=@NumeroFactura";
                command.Parameters.AddWithValue("@NumeroFactura", numeroFactura);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                factura = DataReaderMapToFactura(dataReader);
                dataReader.Close();
            }

            return factura;

        }

        private Factura DataReaderMapToFactura(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Factura factura = new Factura();
            factura.NumeroFactura = (string)dataReader["NumeroFactura"];
            factura.TotalFactura = (decimal)dataReader["TotalFactura"];
            factura.Fecha = (DateTime)dataReader["Fecha"];
            factura.cliente.CedulaCliente = (string)dataReader["CedulaCliente"];

            return factura;
        }

    }
}
