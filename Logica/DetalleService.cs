using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Logica
{
    public class DetalleService
    {

        private readonly ConnectionManager conexion;
        private readonly DetalleRepository repositorio;
        public DetalleService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new DetalleRepository(conexion);
        }

        public string GuardarDetalle(Detalle_Factura detalle)
        {
            try
            {
                conexion.Open();
                if (repositorio.BuscarPorNumero(detalle.idDetalle) == null)
                {
                    repositorio.GuardarFactura(detalle);
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

        public ConsultaDetalleRespuesta ConsultarTodos()
        {
            ConsultaDetalleRespuesta respuesta = new ConsultaDetalleRespuesta();
            try
            {

                conexion.Open();
                respuesta.Detalles = repositorio.ConsultarTodos();
                conexion.Close();
                respuesta.Error = false;
                respuesta.Mensaje = (respuesta.Detalles.Count > 0) ? "Se consultan los Datos" : "No hay datos para consultar";
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

        public BusquedaDetalleRespuesta BuscarxNumero(int idDetalle)
        {
            BusquedaDetalleRespuesta respuesta = new BusquedaDetalleRespuesta();
            try
            {
                conexion.Open();
                respuesta.detalle = repositorio.BuscarPorNumero(idDetalle);
                conexion.Close();
                respuesta.Mensaje = (respuesta.detalle != null) ? "Se encontró El Producto buscado" : "El producto buscado no existe";
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

    public class ConsultaDetalleRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public IList<Detalle_Factura> Detalles { get; set; }
    }
}

public class BusquedaDetalleRespuesta
{
    public bool Error { get; set; }
    public string Mensaje { get; set; }
    public Detalle_Factura detalle { get; set; }
}

