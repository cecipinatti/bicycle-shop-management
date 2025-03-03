using CapaEntidad;
using System.Data;
using static CapaEntidad.CEDescripcion;

namespace CapaNegocio
{
    public interface CNIDescripcion
    {
        DataTable Obtener(int estado);
        string Agregar(CEDescripcion cE);
        string ActualizarDescripcion(CEDescripcion cE);
        string ActualizarEstado(CEDescripcion cE, EstadoDescripcion estado); // Eliminar
        bool Verificar(CEDescripcion cE, out string mensajeValidacion);

    }
}
