using Lucas_Mata.Class;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace Lucas_Mata.Mappers
{
    public class ProductoMapper
    {
        public dynamic Mapper([Optional] SqlDataReader dataReader)
        {
            List<Producto> productos = new List<Producto>();
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    Producto producto = new Producto();
                    producto.Id = Convert.ToInt32(dataReader["ID"]);
                    producto.Descripcion = dataReader["Descripciones"].ToString();
                    producto.Costo = Convert.ToDouble(dataReader["Costo"]);
                    producto.PrecioVenta = Convert.ToDouble(dataReader["PrecioVenta"]);
                    producto.Stock = Convert.ToInt32(dataReader["Stock"]);
                    producto.IdUsuario = Convert.ToInt32(dataReader["IdUsuario"]);
                    productos.Add(producto);
                }
            }
            return productos;
        }
    }
}
