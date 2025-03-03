using CapaDatos;
using CapaEntidad;
using CapaPresentacion;
using System.Data;

namespace CapaNegocio
{
    public class CNGastoGeneral
    {
        private readonly CDGastoGeneral cD = new();

        public bool ValidarDatos(CEGastoGeneral cE, out string mensaje)
        {
            List<string> errores = [];

            if (!UtilidadesImporte.EsDecimalMayorACero(cE.ImporteTotal.ToString(), out _))
                errores.Add("El importe debe ser un valor numérico mayor a 0.");

            if (cE.IdCategoriaGasto <= 0)
                errores.Add("Debes seleccionar una categoría válida.");

            mensaje = string.Join("\n", errores);
            return errores.Count == 0;
        }



        public DataTable ObtenerGastosGenerales()
        {
            return cD.Obtener();
        }

        public string AgregarGastoGeneral(CEGastoGeneral cE)
        {
            try
            {
                cD.Agregar(cE);
                return "Registro creado exitosamente.";
            }
            catch (Exception ex)
            {
                return "Error al crear el registro:\n" + ex.Message;
            }
        }

        public string ActualizarGastoGeneral(CEGastoGeneral cE)
        {
            try
            {
                cD.Actualizar(cE);
                return "Registro actualizado exitosamente.";
            }
            catch (Exception ex)
            {
                return "Error al actualizar el registro:\n" + ex.Message;
            }
        }

        public string EliminarGastoGeneral(CEGastoGeneral cE)
        {
            try
            {
                cD.Eliminar(cE);
                return "Registro eliminado exitosamente.";
            }
            catch (Exception ex)
            {
                return "Error al eliminar el registro:\n" + ex.Message;
            }
        }

        public DataTable BuscarGastosGenerales(CEGastoGeneral cE)
        {
            return cD.Buscar(cE);
        }

    }
}
