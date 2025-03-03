namespace CapaEntidad
{
    public class CEPagoCliente : IEliminable
    {
        public int IdPagoCliente { get; set; }
        public int IdVenta { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Importe { get; set; }

        public int Id => IdPagoCliente;
        public string ObtenerDescripcion()
        {
            return $"PAGO CLIENTE ID: {IdPagoCliente}\n";
        }

    }
}
