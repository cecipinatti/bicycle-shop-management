using CapaDatos;
using CapaEntidad;
using CapaPresentacion;
using System.Data;

namespace CapaNegocio
{
    public class CNPagoProveedor
    {
        private readonly CDPagoProveedor cD = new();

        public bool ValidarDatos(CEPagoProveedor cE, out string mensaje)
        {
            List<string> errores = new List<string>();

            if (!UtilidadesImporte.EsDecimalMayorACero(cE.Importe.ToString(), out _))
                errores.Add("El importe debe ser un valor numérico mayor a 0.");

            mensaje = string.Join("\n", errores);
            return errores.Count == 0;
        }



        public DataTable ObtenerPagosProveedores()
        {
            return cD.Obtener();
        }

        public DataTable ObtenerPagosProveedor(int idGasto)
        {
            return cD.ObtenerPorId(idGasto);
        }

        public string AgregarPagoProveedor(CEPagoProveedor cE)
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

        public string ActualizarPagoProveedor(CEPagoProveedor cE)
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

        public string EliminarPagoProveedor(CEPagoProveedor cE)
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

    }
}
