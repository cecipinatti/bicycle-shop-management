using CapaEntidad;
using CapaNegocio;
using System.Data;
using static CapaEntidad.CEVenta;

namespace CapaPresentacion
{
    public partial class frmVenta : Form
    {
        private readonly CNVenta cNVenta = new();
        private readonly CNPagoCliente cNPago = new();
        private readonly CNDescripcion<Productos> cNProducto = new();
        private readonly CNProductoVenta cNProductoVenta = new();
        private readonly CNDescripcion<Categoria_Venta> cNCategoria = new();
        private readonly CNDescripcion<Clientes> cNCliente = new();
        private readonly CNTotal cNTotal = new();
        private readonly CNEliminable cNEliminar = new();

        private bool EsVenta;
        private bool EsEdicion;



        /*
        *   Intercambio de datos entre formularios
        */
        private frmPrincipal _parentForm;
        private CEVenta ventaActual;
        private List<CEProductoVenta> productosVenta;
        // bool esEdicion

        public frmVenta(frmPrincipal parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }

        public frmVenta(frmPrincipal parentForm, List<CEProductoVenta> productos = null, CEVenta venta = null, bool esEdicion = false)
            : this(parentForm)
        {
            productosVenta = productos ?? new List<CEProductoVenta>();
            ventaActual = venta ?? new CEVenta();
            EsEdicion = esEdicion;
        }

        private bool HayProductosCargados()
        {
            return productosVenta != null && productosVenta.Any();
        }

        private void CargarProductosVenta()
        {
            if (HayProductosCargados())
            {
                // venta
                int idVenta = ventaActual.IdVenta;
                nudIdV.Value = idVenta;
                dtpFechaV.Value = ventaActual.Fecha != DateTime.MinValue ? ventaActual.Fecha : DateTime.Now;
                cmbCategoria.SelectedValue = ventaActual.IdCategoriaVenta != null ? ventaActual.IdCategoriaVenta : -1;
                txtImporteV.Text = ventaActual.ImporteTotal.ToString("F2");
                lbnProductos.Text = $"{productosVenta.Count} producto(s) añadido(s).";
                cmbCliente.SelectedValue = ventaActual.IdCliente != null ? ventaActual.IdCliente : -1;
                cmbEstado.SelectedItem = ventaActual.Estado;

                // producto venta
                foreach (var producto in productosVenta)
                {
                    producto.Descripcion = cNProducto.ObtenerDescripcionProductoPorId(producto.IdProducto);
                }

                dgvListadoProducto.DataSource = null;
                dgvListadoProducto.DataSource = productosVenta;
                FormatearListadoProducto();

                // operacion
                ActualizarEstadoFormulario(idVenta == 0, idVenta > 0, true, idVenta == 0);
            }
        }

        private List<CEProductoVenta> ExtraerProductoVentaSeleccionado()
        {
            var listaProductoVenta = new List<CEProductoVenta>();

            foreach (DataGridViewRow row in dgvListadoProducto.Rows)
            {
                CEProductoVenta cE = new CEProductoVenta
                {
                    IdVenta = (int)nudIdV.Value,
                    IdProducto = Convert.ToInt32(row.Cells["Id_Producto"].Value),
                    Cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value),
                };
                listaProductoVenta.Add(cE);
            }
            return listaProductoVenta;
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            CEVenta ventaActual = ObtenerDatosVenta();

            frmProducto frmListaProducto = new frmProducto(_parentForm, productosVenta, ventaActual, EsEdicion);
            _parentForm.AbrirFormEnPanel(frmListaProducto, _parentForm.BotonProducto);
        }

        private CEVenta ObtenerDatosVenta()
        {
            return new CEVenta
            {
                IdVenta = (int)nudIdV.Value,
                Fecha = dtpFechaV.Value,
                IdCategoriaVenta = cmbCategoria.SelectedValue != null ? (int)(long)cmbCategoria.SelectedValue : -1,
                IdCliente = cmbCliente.SelectedValue != null ? (int?)(long)cmbCliente.SelectedValue : null,
                ImporteTotal = decimal.TryParse(txtImporteV.Text, out decimal importeTotal) ? importeTotal : 0,
                Estado = (EstadoVenta)cmbEstado.SelectedItem
            };
        }


        /*
        *   Métodos de ayuda
        */
        private void CargarVentas()
        {
            try
            {
                dgvListadoVenta.DataSource = cNVenta.ObtenerVentas();
                dgvListadoPago.DataSource = cNPago.ObtenerPagosClientes();
                FormatearListadoVentaYPago();
                CargarProductos();

                txtListadoTotalCoincidencia.Text = "";
                txtListadoTotalImporte.Text = "";
                txtListadoTotalPago.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar las ventas y/o pagos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarProductos()
        {
            try
            {
                dgvListadoProducto.DataSource = cNProductoVenta.ObtenerProductosVendidos();
                FormatearListadoProducto();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar los productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCategorias()
        {
            try
            {
                DataTable categorias = cNCategoria.Obtener((int)CEDescripcion.EstadoDescripcion.ACTIVO);

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

        private void CargarClientes()
        {
            try
            {
                DataTable clientes = cNCliente.Obtener((int)CEDescripcion.EstadoDescripcion.ACTIVO);
                cmbCliente.DataSource = clientes;
                cmbCliente.ValueMember = "Id";
                cmbCliente.DisplayMember = "Descripcion";
                cmbCliente.SelectedIndex = -1;

                cmbBuscarCliente.DataSource = clientes.Copy();
                cmbBuscarCliente.ValueMember = "Id";
                cmbBuscarCliente.DisplayMember = "Descripcion";
                cmbBuscarCliente.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar los clientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarEstados()
        {
            cmbEstado.DataSource = Enum.GetValues(typeof(CEVenta.EstadoVenta));
            cmbEstado.SelectedIndex = 1; // PAGADA

            cmbBuscarEstado.DataSource = Enum.GetValues(typeof(CEVenta.EstadoVenta));
            cmbBuscarEstado.SelectedIndex = -1;
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

                txtTotalMesAnterior.Text = totalIngresoMesAnterior.ToString("C", new System.Globalization.CultureInfo("es-AR"));
                txtTotalMesActual.Text = totalIngresoMesActual.ToString("C", new System.Globalization.CultureInfo("es-AR"));

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

        private void FormatearListadoVentaYPago(bool visible = false)
        {
            // listado venta
            dgvListadoVenta.Columns["Id_Venta"].Visible = false;
            dgvListadoVenta.Columns["Id_Categoria_Venta"].Visible = false;
            dgvListadoVenta.Columns["Id_Cliente"].Visible = false;
            dgvListadoVenta.Columns["Estado"].Visible = false;

            // columnas visibles en búsquedas
            dgvListadoVenta.Columns["Cliente"].Visible = visible;
            dgvListadoVenta.Columns["Saldo"].Visible = visible;

            dgvListadoVenta.Columns[3].HeaderText = "Categoría";
            dgvListadoVenta.Columns[5].HeaderText = "Cliente";
            dgvListadoVenta.Columns[6].HeaderText = "Importe";
            dgvListadoVenta.Columns[7].HeaderText = "Pagos";

            dgvListadoVenta.Columns[6].DefaultCellStyle.Format = "C";
            dgvListadoVenta.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvListadoVenta.Columns[7].DefaultCellStyle.Format = "C";
            dgvListadoVenta.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvListadoVenta.Columns[8].DefaultCellStyle.Format = "C";
            dgvListadoVenta.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // listado pago
            dgvListadoPago.Columns["Id_Pago_Cliente"].Visible = false;
            dgvListadoPago.Columns["Id_Venta"].Visible = false;
            dgvListadoPago.Columns[3].DefaultCellStyle.Format = "C";
            dgvListadoPago.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void FormatearListadoProducto()
        {
            if (dgvListadoProducto.Columns.Contains("Id_Producto"))
                dgvListadoProducto.Columns["Id_Producto"].Visible = false;
            if (dgvListadoProducto.Columns.Contains("IdProducto"))
                dgvListadoProducto.Columns["IdProducto"].Visible = false;
            if (dgvListadoProducto.Columns.Contains("IdVenta"))
                dgvListadoProducto.Columns["IdVenta"].Visible = false;
            dgvListadoProducto.Columns["Cantidad"].Width = 70;
            dgvListadoProducto.Columns["Cantidad"].HeaderText = "Cant.";
            dgvListadoProducto.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvListadoProducto.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private bool EsVentaSeleccionada()
        {
            DataGridViewRow filaSeleccionada = dgvListadoVenta.CurrentRow;

            if (filaSeleccionada != null && nudIdV.Value == Convert.ToInt32(filaSeleccionada.Cells["Id_Venta"].Value))
                return true;

            MessageBox.Show("Seleccione una venta válida haciendo clic en la fila correspondiente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false; // la venta no fue seleccionada o no coincide (con el nudIdV)
        }

        private bool EsPagoSeleccionado()
        {
            DataGridViewRow filaSeleccionada = dgvListadoPago.CurrentRow;

            if (filaSeleccionada != null && nudIdP.Value == Convert.ToInt32(filaSeleccionada.Cells["Id_Pago_Cliente"].Value))
                return true;
            return false;
        }

        private void HabilitarFormularioVenta(bool habilitar)
        {
            dtpFechaV.Enabled = habilitar;
            cmbCategoria.Enabled = habilitar;
            txtImporteV.Enabled = habilitar;
            txtCliente.Enabled = habilitar;
            cmbCliente.Enabled = habilitar;
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
            btnListaProducto.Visible = !habilitar;
            cmbEstado.Enabled = !habilitar;

            btnBuscar.Enabled = habilitar;
            btnLimpiar.Enabled = habilitar;
            cmbBuscarCategoria.Enabled = habilitar;
            txtBuscarCliente.Enabled = habilitar;
            cmbBuscarCliente.Enabled = habilitar;
            cmbBuscarEstado.Enabled = habilitar;
            cmbBuscarMes.Enabled = habilitar;
            nudBuscarAnio.Enabled = habilitar;

            dgvListadoVenta.Enabled = habilitar;
            dgvListadoPago.Enabled = habilitar;
            dgvListadoProducto.Enabled = habilitar;
            btnNuevo.Enabled = habilitar;
            btnNuevoPago.Enabled = habilitar;
            btnEditar.Enabled = habilitar;
            btnEliminar.Enabled = habilitar;
        }

        private void LimpiarFormularioVenta()
        {
            nudIdV.Value = 0;
            dtpFechaV.Value = DateTime.Now;
            cmbCategoria.SelectedIndex = -1;
            txtImporteV.Text = "";
            productosVenta.Clear();
            lbnProductos.Text = "No hay productos añadidos.";
            txtCliente.Text = "";
            cmbCliente.SelectedIndex = -1;
            cmbEstado.SelectedIndex = 1;
        }

        private void LimpiarFormularioPago()
        {
            nudIdP.Value = 0;
            dtpFechaP.Value = DateTime.Now;
            txtImporteP.Text = "";
        }

        private void SincronizarFechaConVenta()
        {
            dtpFechaP.Value = dtpFechaV.Value;
        }

        private void SincronizarImporteConVenta()
        {
            txtImporteP.Text = txtImporteV.Text;
        }


        /*
        *  EsVenta = true,  EsEdicion = false   --> NUEVA VENTA (Y PAGO)
        *  EsVenta = false, EsEdicion = false   --> NUEVO PAGO
        *  EsVenta = true,  EsEdicion = true    --> EDICIÓN VENTA
        *  EsVenta = false, EsEdicion = true    --> EDICIÓN PAGO
        */
        private void ActualizarEstadoFormulario(bool esVenta, bool esEdicion, bool habilitarVenta, bool habilitarPago)
        {
            EsVenta = esVenta;
            EsEdicion = esEdicion;
            HabilitarFormularioVenta(habilitarVenta);
            HabilitarFormularioPago(habilitarPago);
            HabilitarComponentesSecundarios(false);
            _ = EsVenta ? txtImporteV.Focus() : txtImporteP.Focus();
        }

        private void ActualizarDatos()
        {
            CargarVentas();
            CargarClientes();
            CargarTotalesMensuales();
            HabilitarFormularioVenta(false);
            HabilitarFormularioPago(false);
            HabilitarComponentesSecundarios(true);
            LimpiarFormularioVenta();
            LimpiarFormularioPago();
        }



        /*
        * Eventos del formulario
        */
        private void frmVenta_Load(object sender, EventArgs e)
        {
            CargarVentas();
            CargarCategorias();
            CargarClientes();
            CargarEstados();
            CargarTotalesMensuales();
            CargarProductosVenta(); // Si hay productos = btnNuevo
            UtilidadesControles.InicializarNumericUpDown(nudIdV);
            UtilidadesControles.InicializarNumericUpDown(nudIdP);
            UtilidadesFecha.CargarMeses(cmbBuscarMes);
            UtilidadesFecha.ObtenerAnios(nudBuscarAnio);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormularioVenta();
            LimpiarFormularioPago();
            productosVenta.Clear();
            ActualizarEstadoFormulario(true, false, true, true);
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EsVenta && !EsEdicion)
            {
                EstadoVenta estadoSeleccionado = (EstadoVenta)cmbEstado.SelectedValue;

                if (estadoSeleccionado == EstadoVenta.PENDIENTE)
                {
                    LimpiarFormularioPago();
                }
                else if (estadoSeleccionado == EstadoVenta.PAGADA)
                {
                    SincronizarFechaConVenta();
                    SincronizarImporteConVenta();
                }
            }
        }

        private void dtpFechaV_ValueChanged(object sender, EventArgs e)
        {
            dtpFechaP.Value = dtpFechaV.Value;
        }

        private void txtImporteV_TextChanged(object sender, EventArgs e)
        {
            txtImporteP.Text = txtImporteV.Text;
        }

        private void btnNuevoPago_Click(object sender, EventArgs e)
        {
            if (EsVentaSeleccionada())
            {
                LimpiarFormularioPago();
                ActualizarEstadoFormulario(false, false, false, true);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (EsVentaSeleccionada())
            {
                if (EsPagoSeleccionado())
                {
                    ActualizarEstadoFormulario(false, true, false, true);
                }
                else
                {
                    LimpiarFormularioPago();
                    productosVenta = ExtraerProductoVentaSeleccionado();
                    ActualizarEstadoFormulario(true, true, true, false);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (EsPagoSeleccionado())
            {
                cNEliminar.EliminarEntidad(
                    crearEntidad: () => new CEPagoCliente { IdPagoCliente = (int)nudIdP.Value },
                    eliminarEntidad: cNPago.EliminarPagoCliente
                );
            }
            else if (EsVentaSeleccionada())
            {
                cNEliminar.EliminarEntidad(
                    crearEntidad: () => new CEVenta { IdVenta = (int)nudIdV.Value },
                    eliminarEntidad: cNVenta.EliminarVenta
                );
            }

            ActualizarDatos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbBuscarCategoria.SelectedIndex = -1;
            cmbBuscarMes.SelectedIndex = -1;
            nudBuscarAnio.Value = DateTime.Now.Year;

            txtBuscarCliente.Text = "";
            cmbBuscarCliente.SelectedIndex = -1;
            cmbBuscarEstado.SelectedIndex = -1;
            lbnMensajeEstado.Text = "";

            //txtListadoTotalCoincidencia.Text = "";
            //txtListadoTotalImporte.Text = "";
            //txtListadoTotalPago.Text = "";

            CargarVentas();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CEVenta cE = new CEVenta
            {
                IdCategoriaVenta = cmbBuscarCategoria.SelectedValue != null ? (int)(long)cmbBuscarCategoria.SelectedValue : -1,
                Estado = cmbBuscarEstado.SelectedItem != null ? (EstadoVenta)cmbBuscarEstado.SelectedItem : 0,
                IdCliente = cmbBuscarCliente.SelectedValue != null ? (int)(long)cmbBuscarCliente.SelectedValue : -1,
                Mes = cmbBuscarMes.SelectedItem != null ? (int)(UtilidadesFecha.Meses)cmbBuscarMes.SelectedItem : 0,
                Anio = chkIncluirFecha.Checked ? (int)nudBuscarAnio.Value : 0,
            };

            try
            {
                BuscarVentas(cE);
                UtilidadesListado.VerificarYMostrarPendientes(dgvListadoVenta, "Estado", (int)EstadoVenta.PENDIENTE, lbnMensajeEstado);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar las ventas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscarVentas(CEVenta cE)
        {
            dgvListadoVenta.DataSource = cNVenta.BuscarVentas(cE);
            FormatearListadoVentaYPago(true);

            var (cantidadRegistros, sumaImportes) = UtilidadesListado.ObtenerTotales(dgvListadoVenta, "Importe_Total");
            var (_, sumaPagos) = UtilidadesListado.ObtenerTotales(dgvListadoVenta, "Pago_Total");

            txtListadoTotalCoincidencia.Text = cantidadRegistros.ToString();
            txtListadoTotalImporte.Text = sumaImportes.ToString("C", new System.Globalization.CultureInfo("es-AR"));
            txtListadoTotalPago.Text = sumaPagos.ToString("C", new System.Globalization.CultureInfo("es-AR"));
        }

        private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarCliente.Enabled)
            {
                AplicarFiltro(txtBuscarCliente.Text.Trim(), cmbBuscarCliente);
            }
        }

        private void AplicarFiltro(string filtro, ComboBox comboBox)
        {
            if (comboBox.DataSource is DataTable dt)
            {
                if (string.IsNullOrEmpty(filtro))
                {
                    dt.DefaultView.RowFilter = string.Empty;
                }
                else
                {
                    dt.DefaultView.RowFilter = $"Descripcion LIKE '%{filtro}%'";
                }
            }
        }

        private void dgvListadoVenta_Enter(object sender, EventArgs e)
        {
            UtilidadesListado.FormatoSeleccion(dgvListadoVenta, dgvListadoPago);
        }

        private void dgvListadoPago_Enter(object sender, EventArgs e)
        {
            UtilidadesListado.FormatoSeleccion(dgvListadoPago, dgvListadoVenta);
        }

        private void dgvListadoProducto_SelectionChanged(object sender, EventArgs e)
        {
            dgvListadoProducto.ClearSelection();
        }

        private void dgvListadoVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (UtilidadesListado.ObtenerFilaSeleccionada(dgvListadoVenta, out DataGridViewRow filaSeleccionada))
            {
                int idVenta = Convert.ToInt32(filaSeleccionada.Cells["Id_Venta"].Value);
                dgvListadoProducto.DataSource = cNProductoVenta.ObtenerProductosPorId(idVenta);
                dgvListadoPago.DataSource = cNPago.ObtenerPagosClientes(idVenta);

                int totalCantidad = 0;
                foreach (DataGridViewRow row in dgvListadoProducto.Rows)
                {
                    if (row.Cells["Cantidad"].Value != null) { totalCantidad += Convert.ToInt32(row.Cells["Cantidad"].Value); }
                }

                nudIdV.Value = idVenta;
                lbnProductos.Text = $"{totalCantidad} producto(s) añadido(s).";
                dtpFechaV.Value = Convert.ToDateTime(filaSeleccionada.Cells["Fecha"].Value);
                cmbCategoria.SelectedValue = Convert.ToInt32(filaSeleccionada.Cells["Id_Categoria_Venta"].Value);
                txtImporteV.Text = filaSeleccionada.Cells["Importe_Total"].Value.ToString();
                cmbEstado.SelectedIndex = Convert.ToInt32(filaSeleccionada.Cells["Estado"].Value) == 1 ? 0 : 1;

                if (filaSeleccionada.Cells["Id_Cliente"].Value == DBNull.Value)
                {
                    cmbCliente.SelectedIndex = -1;
                }
                else
                {
                    cmbCliente.SelectedValue = Convert.ToInt32(filaSeleccionada.Cells["Id_Cliente"].Value);
                }

                LimpiarFormularioPago();
            }
        }

        private void dgvListadoPago_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (UtilidadesListado.ObtenerFilaSeleccionada(dgvListadoPago, out DataGridViewRow filaSeleccionada))
            {
                nudIdP.Value = Convert.ToInt32(filaSeleccionada.Cells["Id_Pago_Cliente"].Value);
                dtpFechaP.Value = Convert.ToDateTime(filaSeleccionada.Cells["Fecha"].Value);
                txtImporteP.Text = filaSeleccionada.Cells["Importe"].Value.ToString();
            }
        }

        private void dgvListadoVenta_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex >= 0 && !dgvListadoVenta.Rows[e.RowIndex].IsNewRow)
            {
                DataGridViewRow fila = dgvListadoVenta.Rows[e.RowIndex];
                var estadoValor = fila.Cells["Estado"].Value;

                if (estadoValor != null)
                {
                    int estado = Convert.ToInt32(estadoValor);

                    if (estado == 1)
                    {
                        fila.DefaultCellStyle.BackColor = Color.LightYellow;
                        fila.DefaultCellStyle.ForeColor = Color.Black;
                    }
                    else if (estado == 2)
                    {
                        fila.DefaultCellStyle.BackColor = Color.LightGreen;
                        fila.DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
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

            if (HayProductosCargados()) EsVenta = true;
            if (EsVenta)
            {
                RegistrarVenta();
            }
            else
            {
                RegistrarPago((int)nudIdV.Value);
            };
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtCliente.Enabled)
            {
                AplicarFiltro(txtCliente.Text.Trim(), cmbCliente);
            }
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

        private void RegistrarVenta()
        {
            CEVenta cEVenta = ObtenerDatosVenta();

            if (!cNVenta.ValidarDatos(cEVenta, out string mensajeValidacion))
            {
                MostrarMensaje(mensajeValidacion, true);
                return;
            }

            var (id, mensaje) = EsEdicion
                ? cNVenta.ActualizarVenta(cEVenta)
                : cNVenta.AgregarVenta(cEVenta);

            if (!HayProductosCargados())
            {
                MostrarMensaje("Debes añadir al menos un producto.", true);
                return;
            }

            RegistrarProductoVenta(id);


            if (id > 0 && !string.IsNullOrWhiteSpace(txtImporteP.Text))
            {
                RegistrarPago(id);
            }

            MostrarMensaje(mensaje, mensaje.Contains("Error"));
        }

        private void RegistrarProductoVenta(int idVenta)
        {
            string mensaje = EsEdicion
                ? cNProductoVenta.ActualizarProductoVenta(idVenta, productosVenta)
                : cNProductoVenta.AgregarProductoVenta(idVenta, productosVenta);
        }

        private void RegistrarPago(int idVenta)
        {
            CEPagoCliente cEPago = new CEPagoCliente
            {
                IdVenta = idVenta,
                IdPagoCliente = (int)nudIdP.Value,
                Fecha = dtpFechaP.Value,
                Importe = decimal.TryParse(txtImporteP.Text, out decimal importePago) ? importePago : 0
            };

            if (!cNPago.ValidarDatos(cEPago, out string mensajeValidacion))
            {
                MostrarMensaje(mensajeValidacion, true);
                return;
            }

            string mensaje = EsEdicion
                ? cNPago.ActualizarPagoCliente(cEPago)
                : cNPago.AgregarPagoCliente(cEPago);

            if (!EsVenta)
            {
                CEVenta cEVenta = new CEVenta
                {
                    IdVenta = idVenta,
                    Estado = (EstadoVenta)cmbEstado.SelectedItem,
                };

                mensaje += cNVenta.ActualizarEstadoVenta(cEVenta);
            }

            MostrarMensaje(mensaje, mensaje.Contains("Error"));
        }



        // frmDescripcion
        private void btnCategoria_Click(object sender, EventArgs e)
        {
            var categoria = new Categoria_Venta();
            var servicio = new CNDescripcion<Categoria_Venta>();

            var frm = new frmDescripcion(categoria, servicio);
            frm.FormClosed += (s, ev) => CargarCategorias();
            frm.ShowDialog();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            var categoria = new Productos();
            var servicio = new CNDescripcion<Productos>();

            var frm = new frmDescripcion(categoria, servicio);
            frm.FormClosed += (s, ev) => CargarCategorias();
            frm.ShowDialog();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            var categoria = new Clientes();
            var servicio = new CNDescripcion<Clientes>();

            var frm = new frmDescripcion(categoria, servicio);
            frm.FormClosed += (s, ev) => CargarClientes();
            frm.ShowDialog();
        }

    }
}
