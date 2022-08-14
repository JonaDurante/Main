using System.Collections.Generic;
namespace Lucas_Mata
{
    public class ProductoVendido
    {
        //---- Property 
        public int Stock { get; set; }
        public Venta IdVenta { get; set; }
        public Producto IdProducto { get; set; }

    }
}
