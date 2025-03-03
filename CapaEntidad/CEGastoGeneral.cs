namespace CapaEntidad
{
    public class CEGastoGeneral : IEliminable
    {
        public int IdGastoGeneral { get; set; }
        public int IdCategoriaGasto { get; set; }
        public DateTime Fecha { get; set; }
        public decimal ImporteTotal { get; set; } 
        public string Concepto { get; set; }

        public int Id => IdGastoGeneral;
        public string ObtenerDescripcion()
        {
            return $"GASTO GENERAL ID: {IdGastoGeneral}\n";
        }

        /*
         *  Campos para consultas de búsqueda
         */
        public int Mes { get; set; }
        public int Anio { get; set; }

    }
}
