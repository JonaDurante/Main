using Lucas_Mata.Class;
using System.Data;
using System.Data.SqlClient;

namespace Lucas_Mata.DataBase
{
    public class VentasHandler : DBHandler
    {
        public Venta GetVentas(int IdUsuario)
        {
            Venta venta = new Venta();
            // el ConnectionString se encuientra en DBHandler
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                var query = "SELECT * FROM Venta WHERE IdUsuario = @IdUsuario";
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.BigInt) { Value = IdUsuario });
                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                venta.Id = Convert.ToInt32(dataReader["Id"]);
                                venta.Comentarios = dataReader["Comentarios"].ToString();
                            }
                        }
                    }
                    sqlConnection.Close();
                }
            }
            return venta;
        }
    }
}
