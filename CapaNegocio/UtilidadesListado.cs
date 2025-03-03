namespace CapaNegocio
{
    public class UtilidadesListado
    {
        public static bool ObtenerFilaSeleccionada(DataGridView dgv, out DataGridViewRow filaSeleccionada)
        {
            filaSeleccionada = dgv?.CurrentRow;
            return filaSeleccionada != null;
        }

        public static (int cantidadRegistros, decimal sumaImportes) ObtenerTotales(DataGridView dgv, string nombreColumna)
        {
            int cantidadRegistros = 0;
            decimal sumaImportes = 0;

            if (dgv.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.Cells[nombreColumna]?.Value != null &&
                        decimal.TryParse(row.Cells[nombreColumna].Value.ToString(), out decimal importe))
                    {
                        sumaImportes += importe;
                        cantidadRegistros++;
                    }
                }
            }

            return (cantidadRegistros, sumaImportes);
        }

        public static void FormatoSeleccion(DataGridView activo, DataGridView inactivo)
        {
            activo.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
            activo.DefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
            inactivo.DefaultCellStyle.SelectionBackColor = SystemColors.Window;
            inactivo.DefaultCellStyle.SelectionForeColor = SystemColors.ControlText; 
        }

        public static void VerificarYMostrarPendientes(DataGridView dgv, string nombreColumna, int valorPendiente, Label lbnMensajeEstado)
        {
            int cantidadPendientes = 0;

            if (dgv.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.Cells[nombreColumna]?.Value != null &&
                        int.TryParse(row.Cells[nombreColumna].Value.ToString(), out int estado) &&
                        estado == valorPendiente)
                    {
                        cantidadPendientes++;
                    }
                }
            }

            if (cantidadPendientes > 0)
            {
                if (cantidadPendientes == 1)
                {
                    lbnMensajeEstado.Text = "SE ENCONTRÓ 1 REGISTRO PENDIENTE";
                }
                else
                {
                    lbnMensajeEstado.Text = $"SE ENCONTRARON {cantidadPendientes} REGISTROS PENDIENTES";
                }
                lbnMensajeEstado.BackColor = Color.Chocolate;
            }
            else
            {
                lbnMensajeEstado.Text = "NO SE ENCONTRARON REGISTROS PENDIENTES";
                lbnMensajeEstado.BackColor = Color.DarkOliveGreen;
            }
        }

    }
}
