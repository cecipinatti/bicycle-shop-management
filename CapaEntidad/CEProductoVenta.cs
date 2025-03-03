namespace CapaEntidad
{
    public class CEProductoVenta
    {
        public int IdProducto { get; set; }
        public int IdVenta { get; set; }
        public int Cantidad { get; set; }

        // Para UI
        public string Descripcion { get; set; }

    }
}
