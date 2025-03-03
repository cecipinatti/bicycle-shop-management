namespace CapaEntidad
{
    public class CEVenta : IEliminable
    {
        public int IdVenta { get; set; }
        public int IdCategoriaVenta { get; set; }
        public int? IdCliente { get; set; }
        public DateTime Fecha { get; set; }
        public decimal ImporteTotal { get; set; }
        public EstadoVenta Estado { get; set; }

        public enum EstadoVenta
        {
            PENDIENTE = 1,
            PAGADA,
        }

        public int Id => IdVenta;
        public string ObtenerDescripcion()
        {
            return $"VENTA ID: {IdVenta}\n";
        }

        /*
         *  Campos para consultas de búsqueda
         */
        public int Mes { get; set; }
        public int Anio { get; set; }

    }
}
