using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class CNTotal
    {
        private readonly CDTotal cD = new CDTotal();

        public DataTable ObtenerTotalesMensuales(int anio)
        {
            return cD.ObtenerPorMes(anio);
        }

        public DataTable ObtenerTotalesAnuales()
        {
            return cD.ObtenerPorAnio();
        }

        public (decimal TotalIngreso, decimal TotalGasto) ObtenerPorMesyAnio(int mes, int anio)
        {
            return cD.ObtenerPorMesYAnio(mes, anio);
        }

    }
}
