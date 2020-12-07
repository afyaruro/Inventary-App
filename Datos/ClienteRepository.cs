using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;

namespace Datos
{
    public class ClienteRepository
    {
        private readonly SqlConnection _conection;

        public ClienteRepository(ConnectionManager connection)
        {
            _conection = connection._conexion;
        }

        public void Guardar(Cliente cliente)
        {
            using (var commando = _conection.CreateCommand())
            {
                commando.CommandText = "Insert Into Cliente (Cedula, Nombre, Apellido, Celular, Email) " +
                    "Values (@Cedula, @Nombre, @Apellido, @Celular, @Email)";
                commando.Parameters.AddWithValue("@Cedula", cliente.CedulaCliente);
                commando.Parameters.AddWithValue("@Nombre", cliente.NombreCliente);
                commando.Parameters.AddWithValue("@Apellido", cliente.ApellidoCliente);
                commando.Parameters.AddWithValue("@Celular", cliente.CelularCliente);
                commando.Parameters.AddWithValue("@Email", cliente.Email);
                commando.ExecuteNonQuery();

            }

        }

        public List<Cliente> ConsultarTodos()
        {
            List<Cliente> clientes = new List<Cliente>();
            using (var command = _conection.CreateCommand())
            {
                command.CommandText = "Select Cedula,Nombre,Apellido, Celular, Email from Cliente ";
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Cliente cliente = DataReaderMapToCliente(dataReader);
                        clientes.Add(cliente);
                    }

                }
            }

            return clientes;
        }

        public Cliente BuscarPorCedula(string cedula)
        {
            SqlDataReader dataReader;
            Cliente cliente;

            using (var command = _conection.CreateCommand())
            {
                command.CommandText = "select * from Cliente where Cedula=@Cedula";
                command.Parameters.AddWithValue("@Cedula", cedula);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                cliente = DataReaderMapToCliente(dataReader);
                dataReader.Close();
            }

            return cliente;

        }

        public void Modificar(Cliente cliente)
        {
            using (var command = _conection.CreateCommand())
            {
                command.CommandText = @"update Cliente set Nombre=@Nombre,Apellido=@Apellido, Celular=@Celular, Email= @Email
                                        where Cedula=@Cedula";
                command.Parameters.AddWithValue("@Cedula", cliente.CedulaCliente);
                command.Parameters.AddWithValue("@Nombre", cliente.NombreCliente);
                command.Parameters.AddWithValue("@Apellido", cliente.ApellidoCliente);
                command.Parameters.AddWithValue("@Celular", cliente.CelularCliente);
                command.Parameters.AddWithValue("@Email", cliente.Email);
                var filas = command.ExecuteNonQuery();
            }
        }

        private Cliente DataReaderMapToCliente(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Cliente cliente = new Cliente();
            cliente.CedulaCliente = (string)dataReader["Cedula"];
            cliente.NombreCliente = (string)dataReader["Nombre"];
            cliente.ApellidoCliente = (string)dataReader["Apellido"];
            cliente.CelularCliente = (string)dataReader["Celular"];
            cliente.Email = (string)dataReader["Email"];
            return cliente;
        }

    }

}
