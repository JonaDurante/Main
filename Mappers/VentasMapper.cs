using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace Lucas_Mata.Mappers
{
    public class VentasMapper
    {
        public dynamic Mapper([Optional] SqlDataReader dataReader)
        {
            List<Venta> ventas = new List<Venta>();
            Venta venta = new Venta();
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    venta.Id = Convert.ToInt32(dataReader["Id"]);
                    venta.Comentarios = dataReader["Comentarios"].ToString();
                    ventas.Add(venta);
                }
            }
            return ventas;
        }
    }
}
