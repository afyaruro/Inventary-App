using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;
using Infraestructur;

namespace Logica
{
    public class ClienteService
    {
        private readonly ConnectionManager conexion;
        private readonly ClienteRepository repositorio;
        
        public ClienteService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new ClienteRepository(conexion);
            
        }

        public string Guardar(Cliente cliente)
        {
            Email email = new Email();
            string mensajeEmail = string.Empty;
            try
            {
                conexion.Open();
                if (repositorio.BuscarPorCedula(cliente.CedulaCliente) == null)
                {
                    repositorio.Guardar(cliente);
                    mensajeEmail = email.EnviarEmail(cliente);
                    return $"Se guardaron los datos satisfactoriamente";
                }
                return $"el Cliente ya existe";
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { conexion.Close(); }
        }

        public ConsultaClienteRespuesta ConsultarTodos()
        {
            ConsultaClienteRespuesta respuesta = new ConsultaClienteRespuesta();
            try
            {

                conexion.Open();
                respuesta.Clientes = repositorio.ConsultarTodos();
                conexion.Close();
                respuesta.Error = false;
                respuesta.Mensaje = (respuesta.Clientes.Count > 0) ? "Se consultan los Datos" : "No hay datos para consultar";
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

        public BusquedaClienteRespuesta BuscarxCedula(string cedula)
        {
            BusquedaClienteRespuesta respuesta = new BusquedaClienteRespuesta();
            try
            {
                conexion.Open();
                respuesta.Cliente = repositorio.BuscarPorCedula(cedula);
                conexion.Close();
                respuesta.Mensaje = (respuesta.Cliente != null) ? "Se encontró El Cliente buscado" : "El Cliente buscado no existe";
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
        public string Modificar(Cliente clienteNuevo)
        {
            try
            {
                conexion.Open();
                var clienteViejo = repositorio.BuscarPorCedula(clienteNuevo.CedulaCliente);
                if (clienteViejo != null)
                {
                    repositorio.Modificar(clienteNuevo);
                    return ($"El registro del Cliente: {clienteNuevo.NombreCliente} {clienteNuevo.ApellidoCliente}; se ha modificado satisfactoriamente.");
                }
                else
                {
                    return ($"Lo sentimos, El Cliente con el numero de cedula: {clienteNuevo.CedulaCliente} no se encuentra registrado.");
                }
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }
            finally { conexion.Close(); }

        }


    }
    public class ConsultaClienteRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public IList<Cliente> Clientes { get; set; }
    }


    public class BusquedaClienteRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Cliente Cliente { get; set; }
    }

}
