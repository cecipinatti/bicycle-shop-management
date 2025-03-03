using CapaDatos;
using CapaEntidad;
using CapaPresentacion;
using System.Data;

namespace CapaNegocio
{
    public class CNGastoProveedor
    {
        private readonly CDGastoProveedor cD = new();

        public bool ValidarDatos(CEGastoProveedor cE, out string mensaje)
        {
            List<string> errores = new List<string>();

            if (!UtilidadesImporte.EsDecimalMayorACero(cE.ImporteTotal.ToString(), out _))
                errores.Add("El importe debe ser un valor numérico mayor a 0.");

            if (cE.IdProveedor <= 0)
                errores.Add("Debes seleccionar un proveedor válido.");

            mensaje = string.Join("\n", errores);
            return errores.Count == 0;
        }



        public DataTable ObtenerGastosProveedores(int estado = -1)
        {
            return cD.Obtener(estado);
        }
  
        public (int id, string mensaje) AgregarGastoProveedor(CEGastoProveedor cE)
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

        public string ActualizarGastoProveedor(CEGastoProveedor cE)
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

        // Actualizar estado junto con la inserción o edición de pagos
        public string ActualizarEstadoGastoProveedor(CEGastoProveedor cE)
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

        public string EliminarGastoProveedor(CEGastoProveedor cE)
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

        public bool VerificarExistenciaPorEstado(int estado)
        {
            return cD.Verificar(estado);
        }

        public DataTable BuscarGastosProveedores(CEGastoProveedor cE)
        {
            return cD.Buscar(cE);
        }

    }
}
