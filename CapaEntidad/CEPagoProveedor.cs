namespace CapaEntidad
{
    public class CEPagoProveedor : IEliminable
    {
        public int IdPagoProveedor { get; set; }
        public int IdGastoProveedor { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Importe { get; set; }

        public int Id => IdPagoProveedor;
        public string ObtenerDescripcion()
        {
            return $"PAGO A PROVEEDOR ID: {IdPagoProveedor}\n";
        }

    }
}
