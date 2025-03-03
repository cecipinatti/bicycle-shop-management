using CapaDatos;
using CapaEntidad;
using CapaPresentacion;
using System.Data;

namespace CapaNegocio
{
    public class CNPagoCliente
    {
        private readonly CDPagoCliente cD = new();

        public bool ValidarDatos(CEPagoCliente cE, out string mensaje)
        {
            List<string> errores = new List<string>();

            if (!UtilidadesImporte.EsDecimalMayorACero(cE.Importe.ToString(), out _))
                errores.Add("El importe debe ser un valor numérico mayor a 0.");

            mensaje = string.Join("\n", errores);
            return errores.Count == 0;
        }



        public DataTable ObtenerPagosClientes()
        {
            return cD.Obtener();
        }

        public DataTable ObtenerPagosClientes(int idVenta)
        {
            return cD.ObtenerPorId(idVenta);
        }

        public string AgregarPagoCliente(CEPagoCliente cE)
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

        public string ActualizarPagoCliente(CEPagoCliente cE)
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

        public string EliminarPagoCliente(CEPagoCliente cE)
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
