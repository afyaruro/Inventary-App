using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class ProductoRepository
    {

        private readonly SqlConnection _conection;

        public ProductoRepository(ConnectionManager connection)
        {
            _conection = connection._conexion;
        }

        public void Guardar(Producto producto)
        {
            using (var commando = _conection.CreateCommand())
            {
                commando.CommandText = "Insert Into Producto (Codigo, Nombre, Estado, Cantidad, Talla, Precio) " +
                    "Values (@Codigo, @Nombre, @Estado, @Cantidad, @Talla, @Precio)";
                commando.Parameters.AddWithValue("@Codigo", producto.CodigoProducto);
                commando.Parameters.AddWithValue("@Nombre", producto.NombreProducto);
                commando.Parameters.AddWithValue("@Estado", producto.Estado);
                commando.Parameters.AddWithValue("@Cantidad", producto.CantidadExistencias);
                commando.Parameters.AddWithValue("@Talla", producto.TallaProducto);
                commando.Parameters.AddWithValue("@Precio", producto.PrecioUnitario);
                commando.ExecuteNonQuery();

            }

        }


        public List<Producto> ConsultarTodos()
        {
            List<Producto> productos = new List<Producto>();
            using (var command = _conection.CreateCommand())
            {
                command.CommandText = "Select Codigo,Nombre,Estado, Cantidad, Talla, Precio from Producto ";
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Producto producto = DataReaderMapToProducto(dataReader);
                        productos.Add(producto);
                    }
                  
                }
            }
            
            return productos;
        }


        public Producto BuscarPorCodigo(string codigo)
        {
            SqlDataReader dataReader;
            Producto producto;

            using (var command = _conection.CreateCommand())
            {
                command.CommandText = "select * from Producto where Codigo=@Codigo";
                command.Parameters.AddWithValue("@Codigo", codigo);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                producto = DataReaderMapToProducto(dataReader);
                dataReader.Close();
            }

            return producto;
            
        }

        public void Modificar(Producto producto)
        {
            using (var command = _conection.CreateCommand())
            {
                command.CommandText = @"update Producto set Nombre=@Nombre,Cantidad=@Cantidad, Talla=@Talla, Precio= @Precio 
                                        where Codigo=@Codigo";
                command.Parameters.AddWithValue("@Codigo", producto.CodigoProducto);
                command.Parameters.AddWithValue("@Nombre", producto.NombreProducto);
                command.Parameters.AddWithValue("@Estado", producto.Estado);
                command.Parameters.AddWithValue("@Cantidad", producto.CantidadExistencias);
                command.Parameters.AddWithValue("@Talla", producto.TallaProducto);
                command.Parameters.AddWithValue("@Precio", producto.PrecioUnitario);
                var filas = command.ExecuteNonQuery();
            }
        }

        private Producto DataReaderMapToProducto(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Producto producto = new Producto();
            producto.CodigoProducto = (string)dataReader["Codigo"];
            producto.NombreProducto = (string)dataReader["Nombre"];
            producto.Estado = (string)dataReader["Estado"];
            producto.CantidadExistencias = (int)dataReader["Cantidad"];
            producto.TallaProducto = (string)dataReader["Talla"];
            producto.PrecioUnitario = (decimal)dataReader["Precio"];
            return producto;
        }
    }

}
