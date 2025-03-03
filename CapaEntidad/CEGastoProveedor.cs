using System.ComponentModel;

namespace CapaEntidad
{
    public class CEGastoProveedor : IEliminable
    {
        public int IdGastoProveedor { get; set; }
        public int IdProveedor { get; set; }
        public DateTime Fecha { get; set; }
        public decimal ImporteTotal { get; set; }
        public EstadoGasto Estado { get; set; }

        public enum EstadoGasto
        {
            PENDIENTE = 1,
            PAGADO,
        }

        public int Id => IdGastoProveedor;
        public string ObtenerDescripcion()
        {
            return $"GASTO A PROVEEDOR ID: {IdGastoProveedor}";
        }

        /*
        *   Campos para consultas de búsqueda
        */
        public int Mes { get; set; }
        public int Anio { get; set; }

    }
}
