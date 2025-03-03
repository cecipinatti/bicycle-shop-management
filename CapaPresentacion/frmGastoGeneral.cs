using CapaEntidad;
using CapaNegocio;
using System.Data;

namespace CapaPresentacion
{
    public partial class frmGastoGeneral : Form
    {
        private readonly CNGastoGeneral cNGasto = new();
        private readonly CNDescripcion<Categoria_Gasto> cNCategoria = new();
        private readonly CNTotal cNTotal = new();
        private readonly CNEliminable cNEliminar = new();

        public frmGastoGeneral()
        {
            InitializeComponent();
        }

        /*
         * Métodos de ayuda
         */

        private void LimpiarFormulario()
        {
            nudId.Value = 0;
            dtpFecha.Value = DateTime.Now;
            txtImporte.Text = "";
            cmbCategoria.SelectedIndex = -1;
            txtConcepto.Text = "";
        }

        private void HabilitarFormulario(bool habilitar)
        {
            btnCancelar.Visible = habilitar;
            btnGuardar.Visible = habilitar;
            dtpFecha.Enabled = habilitar;
            txtImporte.Enabled = habilitar;
            cmbCategoria.Enabled = habilitar;
            txtConcepto.Enabled = habilitar;

            btnBuscar.Enabled = !habilitar;
            btnLimpiar.Enabled = !habilitar;
            txtBuscarConcepto.Enabled = !habilitar;
            cmbBuscarCategoria.Enabled = !habilitar;
            cmbBuscarMes.Enabled = !habilitar;
            nudBuscarAnio.Enabled = !habilitar;
            dgvListado.Enabled = !habilitar;
            btnNuevo.Enabled = !habilitar;
            btnEditar.Enabled = !habilitar;
            btnEliminar.Enabled = !habilitar;
        }

        private void CargarGastosGenerales()
        {
            try
            {
                dgvListado.DataSource = cNGasto.ObtenerGastosGenerales();
                FormatearListado();

                txtListadoTotalCoincidencia.Text = "";
                txtListadoTotalImporte.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar los gastos generales: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCategorias()
        {
            try
            {
                DataTable categorias = cNCategoria.Obtener((int)CEDescripcion.EstadoDescripcion.ACTIVO);

                //if (categorias == null || categorias.Rows.Count == 0)
                //{
                //    MessageBox.Show("No se encontraron categorías activas.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}

                cmbCategoria.DataSource = categorias;
                cmbCategoria.ValueMember = "Id";
                cmbCategoria.DisplayMember = "Descripcion";
                cmbCategoria.SelectedIndex = -1;

                cmbBuscarCategoria.DataSource = categorias.Copy();
                cmbBuscarCategoria.ValueMember = "Id";
                cmbBuscarCategoria.DisplayMember = "Descripcion";
                cmbBuscarCategoria.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar las categorías: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarTotalesMensuales()
        {
            int mesActual = DateTime.Now.Month;
            int anioActual = DateTime.Now.Year;
            var (mesAnterior, anioMesAnterior) = UtilidadesFecha.ObtenerMesYAnioAnterior(mesActual, anioActual);

            try
            {
                var (totalIngresoMesAnterior, totalGastoMesAnterior) = cNTotal.ObtenerPorMesyAnio(mesAnterior, anioMesAnterior);
                var (totalIngresoMesActual, totalGastoMesActual) = cNTotal.ObtenerPorMesyAnio(mesActual, anioActual);

                txtTotalMesAnterior.Text = totalGastoMesAnterior.ToString("C", new System.Globalization.CultureInfo("es-AR"));
                txtTotalMesActual.Text = totalGastoMesActual.ToString("C", new System.Globalization.CultureInfo("es-AR"));

                string nombreMesAnterior = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(mesAnterior);
                string nombreMesActual = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(mesActual);
                lbnTotalMesAnterior.Text = $"TOTAL {nombreMesAnterior.ToUpper()}:";
                lbnTotalMesActual.Text = $"TOTAL {nombreMesActual.ToUpper()}:";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar los totales mensuales: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatearListado()
        {
            dgvListado.Columns["Id_Gasto_General"].Visible = false;
            dgvListado.Columns["Id_Categoria_Gasto"].Visible = false;
            dgvListado.Columns[3].HeaderText = "Categoría";
            dgvListado.Columns[4].HeaderText = "Importe";
            dgvListado.Columns[4].DefaultCellStyle.Format = "C";
            dgvListado.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private bool EsGastoSeleccionado()
        {
            DataGridViewRow filaSeleccionada = dgvListado.CurrentRow;

            if (filaSeleccionada != null && nudId.Value == Convert.ToInt32(filaSeleccionada.Cells["Id_Gasto_General"].Value))
                return true;

            MessageBox.Show("Seleccione un gasto válido haciendo clic en la fila correspondiente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false; // el gasto no fue seleccionado o no coincide (con el nudId)
        }



        /*
         *  Eventos del formulario
         */

        private void frmGastoGeneral_Load(object sender, EventArgs e)
        {
            CargarGastosGenerales();
            CargarCategorias();
            CargarTotalesMensuales();
            UtilidadesControles.InicializarNumericUpDown(nudId);
            UtilidadesImporte.FormatearImporte(txtImporte);
            UtilidadesFecha.ObtenerAnios(nudBuscarAnio);
            UtilidadesFecha.CargarMeses(cmbBuscarMes);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            HabilitarFormulario(true);
            txtImporte.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CEGastoGeneral cE = new CEGastoGeneral
            {
                IdGastoGeneral = (int)nudId.Value,
                Fecha = dtpFecha.Value,
                IdCategoriaGasto = cmbCategoria.SelectedValue != null ? (int)(long)cmbCategoria.SelectedValue : -1,
                ImporteTotal = decimal.TryParse(txtImporte.Text, out decimal importe) ? importe : 0,
                Concepto = txtConcepto.Text.Trim()
            };

            if (!cNGasto.ValidarDatos(cE, out string mensajeValidacion))
            {
                MessageBox.Show(mensajeValidacion, "Errores de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Agregar o actualizar
            string resultado = cE.IdGastoGeneral == 0 ? cNGasto.AgregarGastoGeneral(cE) : cNGasto.ActualizarGastoGeneral(cE);
            MessageBoxIcon icono = resultado.Contains("Error") ? MessageBoxIcon.Error : MessageBoxIcon.Information;
            MessageBox.Show(resultado, "Resultado de la operación", MessageBoxButtons.OK, icono);

            if (icono == MessageBoxIcon.Information)
            {
                CargarGastosGenerales();
                CargarTotalesMensuales();
                LimpiarFormulario();
                HabilitarFormulario(false);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            HabilitarFormulario(false);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (EsGastoSeleccionado())
            {
                HabilitarFormulario(true);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (EsGastoSeleccionado())
            {
                cNEliminar.EliminarEntidad(
                    crearEntidad: () => new CEGastoGeneral { IdGastoGeneral = (int)nudId.Value },
                    eliminarEntidad: cNGasto.EliminarGastoGeneral
                );

                CargarGastosGenerales();
                CargarTotalesMensuales();
                LimpiarFormulario();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            AplicarFiltrosDeBusqueda();
        }

        private void txtBuscarConcepto_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarConcepto.Text.Trim().Length >= 3 || string.IsNullOrEmpty(txtBuscarConcepto.Text.Trim()))
            {
                AplicarFiltrosDeBusqueda();
            }
        }

        private void AplicarFiltrosDeBusqueda()
        {
            CEGastoGeneral cE = new CEGastoGeneral
            {
                IdCategoriaGasto = cmbBuscarCategoria.SelectedValue != null ? (int)(long)cmbBuscarCategoria.SelectedValue : -1,
                Concepto = txtBuscarConcepto.Text.Trim(),
                Mes = cmbBuscarMes.SelectedItem != null ? (int)(UtilidadesFecha.Meses)cmbBuscarMes.SelectedItem : 0,
                Anio = (int)nudBuscarAnio.Value,
            };

            try
            {
                BuscarGastos(cE);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar los gastos generales: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscarGastos(CEGastoGeneral cE)
        {
            dgvListado.DataSource = cNGasto.BuscarGastosGenerales(cE);
            FormatearListado();
            var (cantidadRegistros, sumaImportes) = UtilidadesListado.ObtenerTotales(dgvListado, "Importe_Total");
            txtListadoTotalCoincidencia.Text = cantidadRegistros.ToString();
            txtListadoTotalImporte.Text = sumaImportes.ToString("C", new System.Globalization.CultureInfo("es-AR"));
        }

        private void dgvListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (UtilidadesListado.ObtenerFilaSeleccionada(dgvListado, out DataGridViewRow filaSeleccionada))
            {
                nudId.Value = Convert.ToInt32(filaSeleccionada.Cells["Id_Gasto_General"].Value);
                dtpFecha.Value = Convert.ToDateTime(filaSeleccionada.Cells["Fecha"].Value);
                txtImporte.Text = filaSeleccionada.Cells["Importe_Total"].Value.ToString();
                cmbCategoria.SelectedValue = filaSeleccionada.Cells["Id_Categoria_Gasto"].Value;
                txtConcepto.Text = filaSeleccionada.Cells["Concepto"].Value.ToString();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbBuscarCategoria.SelectedIndex = -1;
            txtBuscarConcepto.Text = "";
            cmbBuscarMes.SelectedIndex = -1;
            nudBuscarAnio.Value = DateTime.Now.Year;

            //txtListadoTotalCoincidencia.Text = "";
            //txtListadoTotalImporte.Text = "";

            CargarGastosGenerales();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            var cE = new Categoria_Gasto();
            var cN = new CNDescripcion<Categoria_Gasto>();

            var frm = new frmDescripcion(cE, cN);
            frm.FormClosed += (s, ev) => CargarCategorias();
            frm.ShowDialog();
        }
    }
}