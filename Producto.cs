namespace Lucas_Mata 
{
    public class Producto
    {
        //---- Property
        public long Id { get; set; }
        public string Descripcion { get; set; }
        public double Costo { get; set; }
        public double PrecioVenta { get; set; }
        public int Stock { get; set; }
        public Usuario IdUsuario { get; set; } 
    }
}
