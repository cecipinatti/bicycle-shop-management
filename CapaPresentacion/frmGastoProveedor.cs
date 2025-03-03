using CapaEntidad;
using CapaNegocio;
using System.Data;
using System.Windows.Forms;
using static CapaEntidad.CEGastoProveedor;

namespace CapaPresentacion
{
    public partial class frmGastoProveedor : Form
    {
        private readonly CNGastoProveedor cNGasto = new();
        private readonly CNPagoProveedor cNPago = new();
        private readonly CNDescripcion<Proveedores> cNProveedor = new();
        private readonly CNTotal cNTotal = new();
        private readonly CNEliminable cNEliminar = new();

        private bool EsGasto = true;
        private bool EsEdicion;

        public frmGastoProveedor()
        {
            InitializeComponent();
        }

        /*
         *  Métodos de ayuda
        */

        private void CargarGastosProveedores()
        {
            try
            {
                if (cNGasto.VerificarExistenciaPorEstado((int)EstadoGasto.PENDIENTE))
                {
                    dgvListadoGasto.DataSource = cNGasto.ObtenerGastosProveedores((int)EstadoGasto.PENDIENTE); // 1
                }
                else
                {
                    dgvListadoGasto.DataSource = cNGasto.ObtenerGastosProveedores((int)EstadoGasto.PAGADO); // 2
                }

                dgvListadoPago.DataSource = cNPago.ObtenerPagosProveedores();
                UtilidadesListado.VerificarYMostrarPendientes(dgvListadoGasto, "Estado", (int)EstadoGasto.PENDIENTE, lbnMensajeEstado);
                FormatearListado();

                txtListadoTotalCoincidencia.Text = "";
                txtListadoTotalImporte.Text = "";
                txtListadoTotalPago.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al verificar los pagos pendientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarProveedores()
        {
            try
            {
                DataTable proveedores = cNProveedor.Obtener((int)CEDescripcion.EstadoDescripcion.ACTIVO);
                cmbProveedor.DataSource = proveedores;
                cmbProveedor.ValueMember = "Id";
                cmbProveedor.DisplayMember = "Descripcion";
                cmbProveedor.SelectedIndex = -1;

                cmbBuscarProveedor.DataSource = proveedores.Copy();
                cmbBuscarProveedor.ValueMember = "Id";
                cmbBuscarProveedor.DisplayMember = "Descripcion";
                cmbBuscarProveedor.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar los proveedores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarEstados()
        {
            cmbBuscarEstado.DataSource = Enum.GetValues(typeof(EstadoGasto));
            cmbBuscarEstado.SelectedIndex = -1;

            cmbEstado.DataSource = Enum.GetValues(typeof(EstadoGasto));
            cmbEstado.SelectedIndex = 0;
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
            // listado gasto
            dgvListadoGasto.Columns["Id_Gasto_Proveedor"].Visible = false;
            dgvListadoGasto.Columns["Id_Proveedor"].Visible = false;
            dgvListadoGasto.Columns["Estado"].Visible = false;
            dgvListadoGasto.Columns[3].HeaderText = "Proveedor";
            dgvListadoGasto.Columns[4].HeaderText = "Importe";
            dgvListadoGasto.Columns[6].HeaderText = "Pagos";
            dgvListadoGasto.Columns[4].DefaultCellStyle.Format = "C";
            dgvListadoGasto.Columns[6].DefaultCellStyle.Format = "C";
            dgvListadoGasto.Columns[7].DefaultCellStyle.Format = "C";
            dgvListadoGasto.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvListadoGasto.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvListadoGasto.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // listado pago
            dgvListadoPago.Columns["Id_Pago_Proveedor"].Visible = false;
            dgvListadoPago.Columns["Id_Gasto_Proveedor"].Visible = false;
            dgvListadoPago.Columns[3].DefaultCellStyle.Format = "C";
            dgvListadoPago.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private bool EsGastoSeleccionado()
        {
            DataGridViewRow filaSeleccionada = dgvListadoGasto.CurrentRow;

            if (filaSeleccionada != null && nudIdG.Value == Convert.ToInt32(filaSeleccionada.Cells["Id_Gasto_Proveedor"].Value))
                return true;
            MessageBox.Show("Seleccione un gasto válido haciendo clic en la fila correspondiente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false; // el gasto no fue seleccionado o no coincide (con el nudIdG)
        }

        private bool EsPagoSeleccionado()
        {
            DataGridViewRow filaSeleccionada = dgvListadoPago.CurrentRow;

            if (filaSeleccionada != null && nudIdP.Value == Convert.ToInt32(filaSeleccionada.Cells["Id_Pago_Proveedor"].Value))
                return true;
            return false;
        }

        private void HabilitarFormularioGasto(bool habilitar)
        {
            cmbProveedor.Enabled = habilitar;
            dtpFechaG.Enabled = habilitar;
            txtImporteG.Enabled = habilitar;
        }

        private void HabilitarFormularioPago(bool habilitar)
        {
            dtpFechaP.Enabled = habilitar;
            txtImporteP.Enabled = habilitar;
        }

        private void HabilitarComponentesSecundarios(bool habilitar)
        {
            btnCancelar.Visible = !habilitar;
            btnGuardar.Visible = !habilitar;
            cmbEstado.Enabled = !habilitar;

            btnBuscar.Enabled = habilitar;
            btnLimpiar.Enabled = habilitar;
            cmbBuscarProveedor.Enabled = habilitar;
            cmbBuscarEstado.Enabled = habilitar;
            cmbBuscarMes.Enabled = habilitar;
            nudBuscarAnio.Enabled = habilitar;
            dgvListadoGasto.Enabled = habilitar;
            dgvListadoPago.Enabled = habilitar;
            btnNuevo.Enabled = habilitar;
            btnNuevoPago.Enabled = habilitar;
            btnEditar.Enabled = habilitar;
            btnEliminar.Enabled = habilitar;
        }

        private void LimpiarFormularioGasto()
        {
            nudIdG.Value = 0;
            dtpFechaG.Value = DateTime.Now;
            cmbProveedor.SelectedIndex = -1;
            txtImporteG.Text = "";
            cmbEstado.SelectedIndex = 0;
        }

        private void LimpiarFormularioPago()
        {
            nudIdP.Value = 0;
            dtpFechaP.Value = DateTime.Now;
            txtImporteP.Text = "";
        }

        /*
        *  EsGasto = true,  EsEdicion = false    --> NUEVO GASTO (Y PAGO)
        *  EsGasto = false, EsEdicion = false    --> NUEVO PAGO
        *  EsGasto = true,  EsEdicion = true     --> EDICIÓN GASTO
        *  EsGasto = false, EsEdicion = true     --> EDICIÓN PAGO
        */
        private void ActualizarEstadoFormulario(bool esGasto, bool esEdicion, bool habilitarGasto, bool habilitarPago)
        {
            EsGasto = esGasto;
            EsEdicion = esEdicion;
            HabilitarFormularioGasto(habilitarGasto);
            HabilitarFormularioPago(habilitarPago);
            HabilitarComponentesSecundarios(false);
            _ = EsGasto ? txtImporteG.Focus() : txtImporteP.Focus();
        }

        private void ActualizarDatos()
        {
            CargarGastosProveedores();
            CargarProveedores();
            CargarTotalesMensuales();
            HabilitarFormularioGasto(false);
            HabilitarFormularioPago(false);
            HabilitarComponentesSecundarios(true);
            LimpiarFormularioGasto();
            LimpiarFormularioPago();

        }



        /*
         *  Eventos del formulario
        */

        private void frmGastoProveedor_Load(object sender, EventArgs e)
        {
            CargarGastosProveedores();
            CargarEstados();
            CargarProveedores();
            CargarTotalesMensuales();
            UtilidadesControles.InicializarNumericUpDown(nudIdG);
            UtilidadesControles.InicializarNumericUpDown(nudIdP);
            UtilidadesFecha.ObtenerAnios(nudBuscarAnio);
            UtilidadesFecha.CargarMeses(cmbBuscarMes);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormularioGasto();
            LimpiarFormularioPago();
            ActualizarEstadoFormulario(true, false, true, true);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (EsGastoSeleccionado())
            {
                if (EsPagoSeleccionado())
                {
                    ActualizarEstadoFormulario(false, true, false, true);
                }
                else
                {
                    LimpiarFormularioPago();
                    ActualizarEstadoFormulario(true, true, true, false);
                }
            }
        }

        private void btnNuevoPago_Click(object sender, EventArgs e)
        {
            if (EsGastoSeleccionado())
            {
                LimpiarFormularioPago();
                ActualizarEstadoFormulario(false, false, false, true);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (EsPagoSeleccionado())
            {
                cNEliminar.EliminarEntidad(
                    crearEntidad: () => new CEPagoProveedor { IdPagoProveedor = (int)nudIdP.Value },
                    eliminarEntidad: cNPago.EliminarPagoProveedor
                );
            }
            else if (EsGastoSeleccionado())
            {
                cNEliminar.EliminarEntidad(
                    crearEntidad: () => new CEGastoProveedor { IdGastoProveedor = (int)nudIdG.Value },
                    eliminarEntidad: cNGasto.EliminarGastoProveedor
                );
            }

            ActualizarDatos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CEGastoProveedor cE = new CEGastoProveedor
            {
                IdProveedor = cmbBuscarProveedor.SelectedValue != null ? (int)(long)cmbBuscarProveedor.SelectedValue : -1,
                Estado = cmbBuscarEstado.SelectedItem != null ? (EstadoGasto)cmbBuscarEstado.SelectedItem : 0,
                Mes = cmbBuscarMes.SelectedItem != null ? (int)(UtilidadesFecha.Meses)cmbBuscarMes.SelectedItem : 0,
                Anio = (int)nudBuscarAnio.Value,
            };

            cmbBuscarEstado.SelectedItem = cE.Estado;

            try
            {
                BuscarGastos(cE);
                UtilidadesListado.VerificarYMostrarPendientes(dgvListadoGasto, "Estado", (int)EstadoGasto.PENDIENTE, lbnMensajeEstado);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar los gastos a proveedores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscarGastos(CEGastoProveedor cE)
        {
            dgvListadoGasto.DataSource = cNGasto.BuscarGastosProveedores(cE);
            FormatearListado();

            var (cantidadRegistros, sumaImportes) = UtilidadesListado.ObtenerTotales(dgvListadoGasto, "Importe_Total");
            var (_, sumaPagos) = UtilidadesListado.ObtenerTotales(dgvListadoGasto, "Pago_Total");

            txtListadoTotalCoincidencia.Text = cantidadRegistros.ToString();
            txtListadoTotalImporte.Text = sumaImportes.ToString("C", new System.Globalization.CultureInfo("es-AR"));
            txtListadoTotalPago.Text = sumaPagos.ToString("C", new System.Globalization.CultureInfo("es-AR"));
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbBuscarProveedor.SelectedIndex = -1;
            cmbBuscarEstado.SelectedIndex = -1;
            cmbBuscarMes.SelectedIndex = -1;
            nudBuscarAnio.Value = DateTime.Now.Year;

            //txtListadoTotalCoincidencia.Text = "";
            //txtListadoTotalImporte.Text = "";
            //txtListadoTotalPago.Text = "";

            CargarGastosProveedores();
        }

        private void dgvListadoGasto_Enter(object sender, EventArgs e)
        {
            UtilidadesListado.FormatoSeleccion(dgvListadoGasto, dgvListadoPago);
        }

        private void dgvListadoPago_Enter(object sender, EventArgs e)
        {
            UtilidadesListado.FormatoSeleccion(dgvListadoPago, dgvListadoGasto);
        }

        private void dgvListadoGasto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (UtilidadesListado.ObtenerFilaSeleccionada(dgvListadoGasto, out DataGridViewRow filaSeleccionada))
            {
                int idGasto = Convert.ToInt32(filaSeleccionada.Cells["Id_Gasto_Proveedor"].Value);

                dgvListadoPago.DataSource = cNPago.ObtenerPagosProveedor(idGasto);

                nudIdG.Value = idGasto;
                dtpFechaG.Value = Convert.ToDateTime(filaSeleccionada.Cells["Fecha"].Value);
                cmbProveedor.SelectedValue = Convert.ToInt32(filaSeleccionada.Cells["Id_Proveedor"].Value);
                txtImporteG.Text = filaSeleccionada.Cells["Importe_Total"].Value.ToString();
                cmbEstado.SelectedIndex = Convert.ToInt32(filaSeleccionada.Cells["Estado"].Value) == 1 ? 0 : 1;
         
                LimpiarFormularioPago();
            }
        }

        private void dgvListadoPago_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (UtilidadesListado.ObtenerFilaSeleccionada(dgvListadoPago, out DataGridViewRow filaSeleccionada))
            {
                nudIdP.Value = Convert.ToInt32(filaSeleccionada.Cells["Id_Pago_Proveedor"].Value);
                dtpFechaP.Value = Convert.ToDateTime(filaSeleccionada.Cells["Fecha"].Value);
                txtImporteP.Text = filaSeleccionada.Cells["Importe"].Value.ToString();
            }

        }

        /*
         *  Formulario
         */
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ActualizarDatos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (EsGasto)
            {
                RegistrarGasto();
            }
            else
            {
                RegistrarPago((int)nudIdG.Value);
            };
        }

        private void MostrarMensaje(string mensaje, bool esError)
        {
            MessageBoxIcon icono = esError ? MessageBoxIcon.Error : MessageBoxIcon.Information;
            string titulo = esError ? "Errores de validación" : "Resultado de la operación";
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, icono);

            if (!esError)
            {
                ActualizarDatos();
            }
        }

        public void RegistrarGasto()
        {
            CEGastoProveedor cEGasto = new CEGastoProveedor
            {
                IdGastoProveedor = (int)nudIdG.Value,
                Fecha = dtpFechaG.Value,
                IdProveedor = cmbProveedor.SelectedValue != null ? (int)(long)cmbProveedor.SelectedValue : -1,
                ImporteTotal = decimal.TryParse(txtImporteG.Text, out decimal importeTotal) ? importeTotal : 0,
                Estado = (EstadoGasto)cmbEstado.SelectedItem
            };

            if (!cNGasto.ValidarDatos(cEGasto, out string mensajeValidacion))
            {
                MostrarMensaje(mensajeValidacion, true);
                return;
            }

            var (id, mensaje) = EsEdicion
                ? (-1, cNGasto.ActualizarGastoProveedor(cEGasto))
                : cNGasto.AgregarGastoProveedor(cEGasto);

            if (id > 0 && !string.IsNullOrWhiteSpace(txtImporteP.Text))
            {
                RegistrarPago(id);
            }

            MostrarMensaje(mensaje, mensaje.Contains("Error"));
        }

        public void RegistrarPago(int idGasto)
        {
            CEPagoProveedor cEPago = new CEPagoProveedor
            {
                IdGastoProveedor = idGasto,
                IdPagoProveedor = (int)nudIdP.Value,
                Fecha = dtpFechaP.Value,
                Importe = decimal.TryParse(txtImporteP.Text, out decimal importePago) ? importePago : 0
            };

            if (!cNPago.ValidarDatos(cEPago, out string mensajeValidacion))
            {
                MostrarMensaje(mensajeValidacion, true);
                return;
            }

            string mensaje = EsEdicion
                ? cNPago.ActualizarPagoProveedor(cEPago)
                : cNPago.AgregarPagoProveedor(cEPago);


            CEGastoProveedor cEGasto = new CEGastoProveedor
            {
                IdGastoProveedor = idGasto,
                Estado = (EstadoGasto)cmbEstado.SelectedItem,
            };

            mensaje += cNGasto.ActualizarEstadoGastoProveedor(cEGasto);

            MostrarMensaje(mensaje, mensaje.Contains("Error"));
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            var categoria = new Proveedores();
            var servicio = new CNDescripcion<Proveedores>();

            var frm = new frmDescripcion(categoria, servicio);
            frm.FormClosed += (s, ev) => CargarProveedores();
            frm.ShowDialog();
        }

    }
}
