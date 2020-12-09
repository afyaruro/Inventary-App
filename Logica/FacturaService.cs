using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Logica
{
    public class FacturaService
    {
        private readonly ConnectionManager conexion;
        private readonly FacturaRepository repositorio;
        public FacturaService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new FacturaRepository(conexion);
        }

        public string GuardarFactura(Factura factura)
        {
            try
            {
                conexion.Open();
                if (repositorio.BuscarPorNumero(factura.NumeroFactura) == null)
                {
                    repositorio.GuardarFactura(factura);
                    return $"Se guardaron los datos satisfactoriamente";
                }
                return $"La Factura ya existe";
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { conexion.Close(); }
        }

        public ConsultaFacturaRespuesta ConsultarTodos()
        {
            ConsultaFacturaRespuesta respuesta = new ConsultaFacturaRespuesta();
            try
            {

                conexion.Open();
                respuesta.Facturas = repositorio.ConsultarTodos();
                conexion.Close();
                respuesta.Error = false;
                respuesta.Mensaje = (respuesta.Facturas.Count > 0) ? "Se consultan los Datos" : "No hay datos para consultar";
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Mensaje = $"Error de la Aplicacion: {e.Message}";
                respuesta.Error = true;
                return respuesta;
            }
            finally { conexion.Close(); }

        }

        public BusquedaFacturaRespuesta BuscarxNumero(string numero)
        {
            BusquedaFacturaRespuesta respuesta = new BusquedaFacturaRespuesta();
            try
            {
                conexion.Open();
                respuesta.Factura = repositorio.BuscarPorNumero(numero);
                conexion.Close();
                respuesta.Mensaje = (respuesta.Factura != null) ? "Se encontró El Producto buscado" : "El producto buscado no existe";
                respuesta.Error = false;
                return respuesta;
            }
            catch (Exception e)
            {

                respuesta.Mensaje = $"Error de la Aplicacion: {e.Message}";
                respuesta.Error = true;
                return respuesta;
            }
            finally { conexion.Close(); }
        }

    }

    public class ConsultaFacturaRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public IList<Factura> Facturas { get; set; }
    }


    public class BusquedaFacturaRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Factura Factura{ get; set; }
    }
}
