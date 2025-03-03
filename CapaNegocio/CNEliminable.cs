using CapaEntidad;

namespace CapaNegocio
{
    public class CNEliminable
    {
        public void EliminarEntidad<T>(Func<T> crearEntidad, Func<T, string> eliminarEntidad) where T : IEliminable
        {
            var entidad = crearEntidad();
            var descripcionEntidad = entidad.ObtenerDescripcion();

            DialogResult resultado = MessageBox.Show(
                $"¿Estás seguro de que deseas eliminar este registro?\n{descripcionEntidad}",
                "Confirmación de eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    string mensajeResultado = eliminarEntidad(entidad);
                    MessageBoxIcon icono = mensajeResultado.Contains("Error") ? MessageBoxIcon.Error : MessageBoxIcon.Information;
                    MessageBox.Show(mensajeResultado, "Resultado de la operación", MessageBoxButtons.OK, icono);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
