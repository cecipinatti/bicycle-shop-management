using CapaDatos;
using CapaEntidad;
using CapaPresentacion;
using System.Data;

namespace CapaNegocio
{
    public class CNVenta
    {
        private readonly CDVenta cD = new();

        public bool ValidarDatos(CEVenta cE, out string mensaje)
        {
            List<string> errores = new List<string>();

            if (!UtilidadesImporte.EsDecimalMayorACero(cE.ImporteTotal.ToString(), out _))
                errores.Add("El importe debe ser un valor numérico mayor a 0.");

            if (cE.IdCategoriaVenta <= 0)
                errores.Add("Debes seleccionar una categoría válida.");

            mensaje = string.Join("\n", errores);
            return errores.Count == 0;
        }



        public DataTable ObtenerVentas()
        {
            return cD.Obtener();
        }

        public (int id, string mensaje) AgregarVenta(CEVenta cE)
        {
            try
            {
                int idGenerado = cD.Agregar(cE);
                return (idGenerado, "Registro creado exitosamente.");
            }
            catch (Exception ex)
            {
                return (-1, "Error al crear el registro:\n" + ex.Message);
            }
        }

        public (int id, string mensaje) ActualizarVenta(CEVenta cE)
        {
            try
            {
                int idVenta = cD.Actualizar(cE);
                return (idVenta, "Registro actualizado exitosamente.");

            }
            catch (Exception ex)
            {
                return (-1, "Error al actualizar el registro:\n" + ex.Message);
            }
        }

        // Actualizar estado junto con la inserción o edición de pagos
        public string ActualizarEstadoVenta(CEVenta cE)
        {
            try
            {
                cD.ActualizarEstado(cE);
                return "\nEstado del registro actualizado exitosamente.";

            }
            catch (Exception ex)
            {
                return "\nError al actualizar el estado del registro:\n" + ex.Message;
            }
        }

        public string EliminarVenta(CEVenta cE)
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

        public DataTable BuscarVentas(CEVenta cE)
        {
            return cD.Buscar(cE);
        }

    }
}
