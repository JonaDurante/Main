using System.Data.SqlClient;

namespace Lucas_Mata.DataBase
{
    public class DBHandler
    {
        public const string ConnectionString = "Data Source=NKO\\SQLEXPRESS;Initial Catalog=SistemaGestion; Integrated Security=True;";
        
        public static object Execute(string query, SqlParameter sqlParameter, dynamic Obj)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.Parameters.Add(sqlParameter);
                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        var Exe = Obj.Mapper(dataReader);
                        sqlConnection.Close();
                        return Exe;
                    }
                }
                
            }
        }
    }
}
