using Lucas_Mata.Class;
using System.Data;
using System.Data.SqlClient;

namespace Lucas_Mata.DataBase
{
    public class ProductoHandler : DBHandler
    {
        public Producto GetProducto(int IdUsuario)
        {
            Producto producto = new Producto();

            // el ConnectionString se encuientra en DBHandler
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                var query = "SELECT * FROM Producto WHERE IdUsuario = @IdUsuario";
                using (SqlCommand sqlCommand = new SqlCommand(
                    query, sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.BigInt) { Value = IdUsuario });
                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                producto.Id = Convert.ToInt32(dataReader["ID"]);
                                producto.Descripcion = dataReader["Descripciones"].ToString();
                                producto.Costo = Convert.ToDouble(dataReader["Costo"]);
                                producto.PrecioVenta = Convert.ToDouble(dataReader["PrecioVenta"]);
                                producto.Stock = Convert.ToInt32(dataReader["Stock"]);
                                producto.IdUsuario = Convert.ToInt32(dataReader["IdUsuario"]);
                            }
                        }
                    }
                    sqlConnection.Close();
                }
            }
            return producto;
        }
    }
}
