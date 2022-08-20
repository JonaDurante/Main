using Lucas_Mata.Class;
using System.Data;
using System.Data.SqlClient;

namespace Lucas_Mata.DataBase
{
    public class VentasHandler : DBHandler
    {
        public List<Venta> GetVentas(int IdUsuario)
        {
            VentasMapper ventasMapper = new VentasMapper();
            var query = "SELECT V.Id, V.Comentarios FROM Venta as V " +
                "inner join ProductoVendido as PV on PV.IdVenta = V.Id " +
                "inner join Producto as P on PV.IdProducto = P.Id " +
                "WHERE P.IdUsuario = @IdUsuario";
            var sqlParamenter = new SqlParameter("IdUsuario", SqlDbType.BigInt) { Value = IdUsuario };
            var V = DBHandler.Execute(query, sqlParamenter, ventasMapper);
            return (List<Venta>)V;
        }
    }
}
