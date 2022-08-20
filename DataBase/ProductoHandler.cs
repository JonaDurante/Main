using Lucas_Mata.Class;
using System.Data;
using System.Data.SqlClient;

namespace Lucas_Mata.DataBase
{
    public class ProductoHandler : DBHandler
    {
        public List<Producto> GetProducto(int IdUsuario)
        {
            ProductoMapper productoMapper = new ProductoMapper();   
            var query = "SELECT * FROM Producto WHERE IdUsuario = @IdUsuario";
            var sqlParamenter = new SqlParameter("IdUsuario", SqlDbType.BigInt) { Value = IdUsuario };
            var P = DBHandler.Execute(query, sqlParamenter, productoMapper);
            return (List<Producto>)P;

        }
    }
}
