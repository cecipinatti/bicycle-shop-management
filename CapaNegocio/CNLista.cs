using CapaDatos;
using CapaEntidad;
using System.Data;
using static CapaEntidad.CEDescripcion;
using static CapaEntidad.CELista;

namespace CapaNegocio
{
    public class CNLista
    {
        private readonly CDLista cD = new();

        public bool ValidarDatos(CELista cE, bool esNueva, out string mensaje)
        {
            List<string> errores = new List<string>();

            if (string.IsNullOrWhiteSpace(cE.Descripcion))
            {
                errores.Add("La descripción no puede estar vacía.");
            }
            else if (cE.Descripcion.Length > 70)
            {
                errores.Add("La descripción no debe exceder los 70 caracteres.");
            }
            else if (esNueva && cD.Verificar(cE.Descripcion))
            {
                errores.Add("La descripción ya existe. Debe ser única.");
            }

            if (cE.IdProveedor <= 0)
            {
                errores.Add("Debes seleccionar un proveedor válido.");
            }

            if (cE.Porcentaje <= 0)
            {
                errores.Add("El porcentaje debe ser mayor a 0.");
            }

            mensaje = string.Join("\n", errores);

            return errores.Count == 0;
        }



        public DataTable ObtenerListas(int estado = -1)
        {
            return cD.Obtener(estado);
        }

        public (int id, string mensaje) AgregarLista(CELista cE)
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

        public string ActualizarLista(CELista cE)
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

        public string ActualizarEstado(CELista cE, EstadoLista estado)
        {
            try
            {
                cD.ActualizarEstado(cE, estado);
                return estado == EstadoLista.ACTIVA ? "Registro restaurado exitosamente." : "Registro eliminado exitosamente.";
            }
            catch (Exception ex)
            {
                return $"Error al actualizar el estado del registro:\n{ex.Message}";
            }
        }

    }
}
