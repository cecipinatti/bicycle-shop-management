using CapaNegocio;
using CapaEntidad;
using System.Data;
namespace CapaPresentacion
{
    public partial class frmProducto : Form
    {
        private readonly CNDescripcion<Productos> cNProducto = new();
        private readonly CNLista cNLista = new();
        // Cargar productos provenientes del formulario frmVenta
        private DataTable productosSeleccionados;

        /*
        *   Intercambio de datos entre formularios
        *   Se enviarán al formulario frmVenta
        */
        private frmPrincipal _parentForm;
        private CEVenta ventaActual;
        private List<CEProductoVenta> productosVenta;
        private bool EsEdicion;

        public frmProducto(frmPrincipal parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }

        public frmProducto(frmPrincipal parentForm, List<CEProductoVenta> productos = null, CEVenta venta = null, bool esEdicion = false)
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
                foreach (var producto in productosVenta)
                {
                    DataRow nuevaFila = productosSeleccionados.NewRow();

                    nuevaFila["Id_Producto"] = producto.IdProducto;
                    nuevaFila["Descripcion"] = cNProducto.ObtenerDescripcionProductoPorId(producto.IdProducto);
                    nuevaFila["Cantidad"] = producto.Cantidad;
                    nuevaFila["Precio"] = 0;
                    nuevaFila["Precio_Final"] = 0;
                    nuevaFila["Precio_Total"] = 0;

                    productosSeleccionados.Rows.Add(nuevaFila);
                }

                nudIdV.Value = ventaActual.IdVenta;
                dgvListadoProductoSeleccionado.DataSource = productosSeleccionados;
            }
        }

        private List<CEProductoVenta> ExtraerProductoVentaSeleccionado()
        {
            var listaProductoVenta = new List<CEProductoVenta>();

            foreach (DataGridViewRow row in dgvListadoProductoSeleccionado.Rows)
            {
                CEProductoVenta cE = new CEProductoVenta
                {
                    IdVenta = (int)nudIdV.Value,
                    IdProducto = (int)row.Cells["Id_Producto"].Value,
                    Cantidad = (int)row.Cells["Cantidad"].Value,
                };
                listaProductoVenta.Add(cE);
            }
            return listaProductoVenta;
        }



        /*
        *   Métodos de ayuda
        */
        private void LimpiarFormulario()
        {
            cmbBuscarLista.SelectedIndex = -1;
            txtBuscarDescripcion.Text = "";
            chkIncluirMasVendido.Checked = false;
            CargarListas();
            nudIdV.Value = 0;
            nudIdP.Value = 0;
            txtListadoTotalImporte.Text = "";
        }

        private void CargarListas()
        {
            try
            {
                DataTable listas = cNLista.ObtenerListas((int)CELista.EstadoLista.ACTIVA);

                DataRow rowProductosSinLista = listas.NewRow();
                rowProductosSinLista["Id_Lista"] = 0;
                rowProductosSinLista["Descripcion"] = "PRODUCTOS SIN LISTA";
                listas.Rows.InsertAt(rowProductosSinLista, 0);

                cmbBuscarLista.DataSource = listas;
                cmbBuscarLista.ValueMember = "Id_Lista";
                cmbBuscarLista.DisplayMember = "Descripcion";
                cmbBuscarLista.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar las listas:\n {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarProductos()
        {
            try
            {
                int idLista = ObtenerIdListaSeleccionado();
                Productos cE = new Productos
                {
                    IdLista = idLista,
                    Descripcion = txtBuscarDescripcion.Text.Trim(),
                };

                bool incluirMasVendidos = chkIncluirMasVendido.Checked;

                //  | Vendidos "Vds." | Precio | Precio_Final "Precio Final"|
                DataTable productos = cNProducto.BuscarProductos(cE, incluirMasVendidos);
                dgvListadoProducto.DataSource = productos;

                FormatearColumnas(dgvListadoProducto, "Productos");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los productos:\n {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarProductosSeleccionados()
        {
            productosSeleccionados = CrearEstructuraProductosSeleccionados();
            dgvListadoProductoSeleccionado.DataSource = productosSeleccionados;
            FormatearColumnas(dgvListadoProductoSeleccionado, "ProductosSeleccionados");
        }

        private int ObtenerIdListaSeleccionado()
        {
            if (cmbBuscarLista.SelectedValue == null || cmbBuscarLista.SelectedValue == DBNull.Value)
            {
                return -1;
            }

            return int.TryParse(cmbBuscarLista.SelectedValue.ToString(), out int idLista) ? idLista : -1;
        }

        private DataTable CrearEstructuraProductosSeleccionados()
        {
            // | Cantidad "Cant." | Precio | Precio_Final "Precio Unit." | Precio_Total "Precio Total" |
            DataTable productosSeleccionados = new DataTable();
            productosSeleccionados.Columns.Add("Id_Producto", typeof(int));
            productosSeleccionados.Columns.Add("Cantidad", typeof(int));
            productosSeleccionados.Columns.Add("Descripcion", typeof(string));
            productosSeleccionados.Columns.Add("Precio", typeof(decimal));
            productosSeleccionados.Columns.Add("Precio_Final", typeof(decimal));
            productosSeleccionados.Columns.Add("Precio_Total", typeof(decimal));
            return productosSeleccionados;
        }

        private void FormatearColumnas(DataGridView dgv, string tipoListado)
        {
            if (tipoListado == "Productos")
            {
                dgv.Columns["Id_Producto"].Visible = false;
                dgv.Columns["Precio_Final"].HeaderText = "Precio Final";
                dgv.Columns["Vendidos"].HeaderText = "Vds.";

                dgv.Columns["Precio"].DefaultCellStyle.Format = "C";
                dgv.Columns["Precio_Final"].DefaultCellStyle.Format = "C";
                dgv.Columns["Vendidos"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns["Precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv.Columns["Precio_Final"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                dgv.Columns["Precio"].DefaultCellStyle.Font = new Font(dgv.Font.FontFamily, 11);
                dgv.Columns["Precio_Final"].DefaultCellStyle.Font = new Font(dgv.Font.FontFamily, 11);

                dgv.Columns["Vendidos"].Width = 50;
                dgv.Columns["Descripcion"].Width = (int)(dgv.Width * 0.6);
            }
            else if (tipoListado == "ProductosSeleccionados")
            {
                dgv.Columns["Id_Producto"].Visible = false;
                dgv.Columns["Cantidad"].HeaderText = "Cant.";
                dgv.Columns["Precio_Final"].HeaderText = "Precio Unit.";
                dgv.Columns["Precio_Total"].HeaderText = "Precio Total";

                foreach (DataGridViewColumn col in dgv.Columns)
                {
                    col.ReadOnly = true;
                }
                dgv.Columns["Cantidad"].ReadOnly = false;

                dgv.Columns["Precio"].DefaultCellStyle.Format = "C";
                dgv.Columns["Precio_Final"].DefaultCellStyle.Format = "C";
                dgv.Columns["Precio_Total"].DefaultCellStyle.Format = "C";
                dgv.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns["Precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv.Columns["Precio_Final"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv.Columns["Precio_Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                dgv.Columns["Cantidad"].DefaultCellStyle.ForeColor = Color.Blue;
                dgv.Columns["Precio"].DefaultCellStyle.Font = new Font(dgv.Font.FontFamily, 11);
                dgv.Columns["Precio_Final"].DefaultCellStyle.Font = new Font(dgv.Font.FontFamily, 11);
                dgv.Columns["Precio_Total"].DefaultCellStyle.Font = new Font(dgv.Font.FontFamily, 11);

                dgv.Columns["Cantidad"].Width = 50;
                dgv.Columns["Descripcion"].Width = (int)(dgv.Width * 0.6);
            }

            AjustarAlturaFilas(dgv);
        }

        private void AjustarAlturaFilas(DataGridView dgv)
        {
            using (Graphics g = dgv.CreateGraphics())
            {
                dgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                SizeF textSize = g.MeasureString("Sample Text", dgv.Font);
                int desiredHeight = (int)(textSize.Height * 2);
                dgv.RowTemplate.Height = desiredHeight;
            }
        }

        private bool EsProductoSeleccionado()
        {
            DataGridViewRow filaSeleccionada = dgvListadoProductoSeleccionado.CurrentRow;

            if (filaSeleccionada != null && nudIdP.Value == Convert.ToInt32(filaSeleccionada.Cells["Id_Producto"].Value))
                return true;

            MessageBox.Show("Seleccione un producto válido haciendo clic en la fila correspondiente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }


        /*
        *   Eventos del formulario
        */
        private void frmListaProducto_Load(object sender, EventArgs e)
        {
            UtilidadesControles.InicializarNumericUpDown(nudIdV);
            UtilidadesControles.InicializarNumericUpDown(nudIdP);
            CargarListas();
            CargarProductos();
            CargarProductosSeleccionados();
            CargarProductosVenta();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnCargarLista_Click(object sender, EventArgs e)
        {
            frmLista frmLista = new frmLista();
            frmLista.FormClosed += (s, ev) => CargarListas();
            frmLista.ShowDialog();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            productosVenta = ExtraerProductoVentaSeleccionado();

            frmVenta frmVenta = new frmVenta(_parentForm, productosVenta, ventaActual, EsEdicion);
            _parentForm.AbrirFormEnPanel(frmVenta, _parentForm.BotonVenta);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            productosSeleccionados.Clear();

        }

        private void dgvListadoProductoSeleccionado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (UtilidadesListado.ObtenerFilaSeleccionada(dgvListadoProductoSeleccionado, out DataGridViewRow filaSeleccionada))
            {
                nudIdP.Value = Convert.ToInt32(filaSeleccionada.Cells["Id_Producto"].Value);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (EsProductoSeleccionado())
            {
                dgvListadoProductoSeleccionado.Rows.RemoveAt(dgvListadoProductoSeleccionado.SelectedRows[0].Index);
                CalcularImporteTotal();
            }
        }

        // Cargar productos
        private void txtBuscarDescripcion_TextChanged(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void cmbBuscarLista_SelectedValueChanged(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void chkIncluirMasVendido_CheckedChanged(object sender, EventArgs e)
        {
            CargarProductos();
        }



        private void dgvListadoProducto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataRow productoSeleccionado = ((DataRowView)dgvListadoProducto.Rows[e.RowIndex].DataBoundItem).Row;

                bool productoExiste = false;
                foreach (DataGridViewRow row in dgvListadoProductoSeleccionado.Rows)
                {
                    if (row.Cells["Id_Producto"].Value.ToString() == productoSeleccionado["Id_Producto"].ToString())
                    {
                        productoExiste = true;
                        break;
                    }
                }

                if (!productoExiste)
                {
                    DataRow nuevaFila = productosSeleccionados.NewRow();
                    nuevaFila["Id_Producto"] = productoSeleccionado["Id_Producto"];
                    nuevaFila["Cantidad"] = 1;
                    nuevaFila["Descripcion"] = productoSeleccionado["Descripcion"];
                    nuevaFila["Precio"] = productoSeleccionado["Precio"];
                    nuevaFila["Precio_Final"] = productoSeleccionado["Precio_Final"];

                    decimal precio = Convert.ToDecimal(productoSeleccionado["Precio_Final"]);
                    int cantidad = Convert.ToInt32(nuevaFila["Cantidad"]);
                    nuevaFila["Precio_Total"] = precio * cantidad;

                    productosSeleccionados.Rows.Add(nuevaFila);
                }

                CalcularImporteTotal();
            }

        }

        private void dgvListadoProductoSeleccionado_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvListadoProductoSeleccionado.Columns[e.ColumnIndex].Name == "Cantidad")
            {
                DataGridViewRow row = dgvListadoProductoSeleccionado.Rows[e.RowIndex];

                int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                decimal precioFinal = Convert.ToDecimal(row.Cells["Precio_Final"].Value);

                // Por fila: Cantidad * Precio Final = Precio Total
                row.Cells["Precio_Total"].Value = precioFinal * cantidad;

                // Por columna:
                CalcularImporteTotal();
            }
        }

        private void CalcularImporteTotal()
        {
            var (cantidadRegistros, sumaPrecioTotal) = UtilidadesListado.ObtenerTotales(dgvListadoProductoSeleccionado, "Precio_Total");
            txtListadoTotalImporte.Text = sumaPrecioTotal.ToString("C", new System.Globalization.CultureInfo("es-AR"));
        }

    }
}
