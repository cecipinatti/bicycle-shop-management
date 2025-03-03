namespace CapaEntidad
{
    public class CELista
    {
        public int IdLista { get; set; }
        public int IdProveedor { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Porcentaje { get; set; }
        public EstadoLista Estado { get; set; }

        public enum EstadoLista
        {
            ACTIVA = 1,
            INACTIVA,
        }

    }
}
