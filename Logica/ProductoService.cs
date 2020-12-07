using Datos;
using Entidades;
using System;
using System.Collections.Generic;

namespace Logica
{
    public class ProductoService
    {
        private readonly ConnectionManager conexion;
        private readonly ProductoRepository repositorio;
        public ProductoService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new ProductoRepository(conexion);
        }

        public string Guardar(Producto producto)
        {
            try
            {
                conexion.Open();
                if (repositorio.BuscarPorCodigo(producto.CodigoProducto) == null)
                {
                    repositorio.Guardar(producto);
                    return $"Se guardaron los datos satisfactoriamente";
                }
                return $"el Producto ya existe";
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { conexion.Close(); }
        }

        public BusquedaProductoRespuesta BuscarxCodigo(string codigo)
        {
            BusquedaProductoRespuesta respuesta = new BusquedaProductoRespuesta();
            try
            {
                conexion.Open();
                respuesta.Producto = repositorio.BuscarPorCodigo(codigo);
                conexion.Close();
                respuesta.Mensaje = (respuesta.Producto != null) ? "Se encontró El Producto buscado" : "El producto buscado no existe";
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
        public string Modificar(Producto productoNuevo)
        {
            try
            {
                conexion.Open();
                var productoViejo = repositorio.BuscarPorCodigo(productoNuevo.CodigoProducto);
                if (productoViejo != null)
                {
                    repositorio.Modificar(productoNuevo);
                    return ($"El registro del Producto: {productoNuevo.NombreProducto}; se ha modificado satisfactoriamente.");
                }
                else
                {
                    return ($"Lo sentimos, El Producto con el codigo: {productoNuevo.CodigoProducto} no se encuentra registrado.");
                }
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }
            finally { conexion.Close(); }

        }


    }

    public class ConsultaProductoRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public IList<Producto> Productos { get; set; }
    }


    public class BusquedaProductoRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Producto Producto { get; set; }
    }
}
