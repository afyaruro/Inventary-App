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
                commando.CommandText = "Insert Into Producto (Codigo, Nombre, Estado, Cantidad, Talla, Precio) " +
                    "Values (@Codigo, @Nombre, @Apellido, @Celular, @Email)";
                commando.Parameters.AddWithValue("@Cedula", cliente.CedulaCliente);
                commando.Parameters.AddWithValue("@Nombre", cliente.NombreCliente);
                commando.Parameters.AddWithValue("@Apellido", cliente.ApellidoCliente);
                commando.Parameters.AddWithValue("@Celular", cliente.CelularCliente);
                commando.Parameters.AddWithValue("@Email", cliente.Email);
                commando.ExecuteNonQuery();

            }

        }

    }
    
}
