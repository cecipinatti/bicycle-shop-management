using CapaEntidad;
using CapaNegocio;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;
using static CapaEntidad.CEDescripcion;
using static CapaEntidad.CELista;

namespace CapaPresentacion
{
    public partial class frmLista : Form
    {
        private readonly CNDescripcion<Proveedores> cNProveedor = new();
        private readonly CNDescripcion<Productos> cNProducto = new();
        private readonly CNLista cNLista = new();
        private List<Productos> productos;
        public frmLista()
        {
            InitializeComponent();
        }

        /*
         *  Métodos de ayuda
         */
        private void LimpiarFormulario()
        {
            nudId.Value = 0;
            txtRutaArchivo.Text = "";
            txtDescripcion.Text = "";
            dtpFecha.Value = DateTime.Now;
            cmbProveedor.SelectedIndex = -1;
            nudPorcentaje.Value = 0;
        }

        private void HabilitarFormulario(bool habilitar)
        {
            txtDescripcion.Enabled = habilitar;
            dtpFecha.Enabled = habilitar;
            cmbProveedor.Enabled = habilitar;
            nudPorcentaje.Enabled = habilitar;
            btnSeleccionarArchivo.Enabled = habilitar;
            btnCancelar.Visible = habilitar;
            btnGuardar.Visible = habilitar;
            btnAceptar.Visible = habilitar;

            btnNuevaLista.Enabled = !habilitar;
            btnActualizarLista.Enabled = !habilitar;
            btnEliminarLista.Enabled = !habilitar;
            dgvListadoLista.Enabled = !habilitar;
        }

        private void CargarListas()
        {
            try
            {
                dgvListadoLista.DataSource = cNLista.ObtenerListas((int)EstadoLista.ACTIVA);
                FormatearListado();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar las listas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatearListado()
        {
            dgvListadoLista.Columns["Id_Lista"].Visible = false;
            dgvListadoLista.Columns["Id_Proveedor"].Visible = false;
            dgvListadoLista.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void FormatearListadoProducto()
        {
            dgvListadoProducto.Columns["Id_Producto"].Visible = false;
            dgvListadoProducto.Columns["Precio_Final"].Visible = false;

            dgvListadoProducto.Columns[2].DefaultCellStyle.Format = "C";
            dgvListadoProducto.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            int totalWidth = dgvListadoProducto.Width;
            dgvListadoProducto.Columns[1].Width = (int)(totalWidth * 0.8);
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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar los proveedores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarEstados()
        {
            cmbBuscarEstado.DataSource = Enum.GetValues(typeof(EstadoLista));
            cmbBuscarEstado.SelectedItem = EstadoLista.ACTIVA;
        }

        private bool EsListaSeleccionada()
        {
            DataGridViewRow filaSeleccionada = dgvListadoLista.CurrentRow;

            if (filaSeleccionada != null && nudId.Value == Convert.ToInt32(filaSeleccionada.Cells["Id_Lista"].Value))
                return true;

            MessageBox.Show("Seleccione una lista válida haciendo clic en la fila correspondiente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }

        private bool HayProductosCargados()
        {
            if (productos == null || !productos.Any())
            {
                MessageBox.Show("No hay productos cargados para registrar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }



        /*
         *  Archivos
         */
        private string CargarArchivo()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos soportados (*.pdf;*.txt)|*.pdf;*.txt";
                openFileDialog.Title = "Seleccione un archivo";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    return openFileDialog.FileName;
                }
            }
            return string.Empty;
        }

        private string ObtenerNombreArchivo(string rutaArchivo)
        {
            return Path.GetFileName(rutaArchivo);
        }

        private string ExtraerTextoDeArchivo(string rutaArchivo)
        {
            string extension = Path.GetExtension(rutaArchivo).ToLower();

            return extension switch
            {
                ".pdf" => ExtraerTextoDePDF(rutaArchivo),
                ".txt" => ExtraerTextoDeTXT(rutaArchivo),
                _ => throw new NotSupportedException("Tipo de archivo no soportado."),
            };
        }

        private string ExtraerTextoDeTXT(string rutaArchivo)
        {
            try
            {
                string texto = File.ReadAllText(rutaArchivo);
                return NormalizarTexto(texto);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer el archivo TXT:\n {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }

        private string ExtraerTextoDePDF(string rutaArchivo)
        {
            try
            {
                using (PdfReader reader = new PdfReader(rutaArchivo))
                using (PdfDocument pdfDoc = new PdfDocument(reader))
                {
                    StringBuilder sb = new StringBuilder();
                    for (int i = 1; i <= pdfDoc.GetNumberOfPages(); i++)
                    {
                        ITextExtractionStrategy strategy = new LocationTextExtractionStrategy();
                        sb.Append(PdfTextExtractor.GetTextFromPage(pdfDoc.GetPage(i), strategy));
                    }
                    return NormalizarTexto(sb.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer el archivo PDF:\n {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }

        private string NormalizarTexto(string texto)
        {
            // Reemplazar tabulaciones con un solo espacio
            texto = texto.Replace("\t", " ");
            // Reemplazar múltiples espacios consecutivos con un solo espacio
            texto = Regex.Replace(texto, @"[^\S\r\n]{2,}", " ");

            return texto.Trim();
        }

        private List<Productos> ExtraerProductosDeTexto(string contenidoTexto)
        {
            // DESCRIPCION + espacio + $ + espacio + PRECIO (formato: 0.000,00)
            string patron = @"(?<Descripcion>.+?)\s+\$\s+(?<Precio>\d{1,3}(?:\.\d{3})*,\d{2})";
            Regex regex = new Regex(patron, RegexOptions.Multiline);
            MatchCollection matches = regex.Matches(contenidoTexto);
            var listaProductos = new List<Productos>();

            foreach (Match match in matches)
            {
                try
                {
                    Productos producto = new Productos
                    {
                        Descripcion = match.Groups["Descripcion"].Value.Trim(),
                        Precio = Convert.ToDecimal(match.Groups["Precio"].Value)
                    };
                    listaProductos.Add(producto);
                }
                catch
                {
                    continue; // Ignorar líneas mal formateadas
                }
            }
            return listaProductos;
        }

        private CELista ObtenerDatosLista()
        {
            return new CELista
            {
                IdLista = (int)nudId.Value,
                Descripcion = txtDescripcion.Text.Trim(),
                Fecha = dtpFecha.Value,
                IdProveedor = cmbProveedor.SelectedValue != null ? (int)(long)cmbProveedor.SelectedValue : -1,
                Porcentaje = nudPorcentaje.Value,
            };
        }

        /*
         *  Eventos del formulario
        */

        private void frmListaProducto_Load(object sender, EventArgs e)
        {
            CargarListas();
            CargarProveedores();
            CargarEstados();
            UtilidadesControles.InicializarNumericUpDown(nudId);
        }

        private void btnSeleccionarArchivo_Click(object sender, EventArgs e)
        {
            string ruta = CargarArchivo();
            txtRutaArchivo.Text = ruta;
            txtDescripcion.Text = ObtenerNombreArchivo(ruta);
        }

        private void btnNuevaLista_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que no has cargado la lista previamente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                LimpiarFormulario();
                HabilitarFormulario(true);
            }
        }

        private void btnActualizarLista_Click(object sender, EventArgs e)
        {
            if (EsListaSeleccionada())
            {
                HabilitarFormulario(true);
                cmbProveedor.Enabled = false;
                dtpFecha.Value = DateTime.Now;
            }
        }

        private void cmbBuscarEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            EstadoDescripcion estadoSeleccionado = (EstadoDescripcion)cmbBuscarEstado.SelectedItem;

            dgvListadoLista.DataSource = cNLista.ObtenerListas((int)estadoSeleccionado);
            FormatearListado();

            btnRestaurarLista.Enabled = estadoSeleccionado == EstadoDescripcion.INACTIVO;
            btnEliminarLista.Enabled = estadoSeleccionado == EstadoDescripcion.ACTIVO;
        }

        private void btnEliminarLista_Click(object sender, EventArgs e)
        {
            ActualizarEstado(EstadoLista.INACTIVA);
        }

        private void btnRestaurarLista_Click(object sender, EventArgs e)
        {
            ActualizarEstado(EstadoLista.ACTIVA);
        }

        // Eliminar o Restarar
        private void ActualizarEstado(EstadoLista estado)
        {
            if (EsListaSeleccionada())
            {
                CELista lista = ObtenerDatosLista();

                string accion = (int)estado == 1 ? "restaurar" : "eliminar";
                string mensajeConfirmacion = $"¿Estás seguro de que deseas {accion} este registro?";
                string tituloConfirmacion = (int)estado == 1 ? "Confirmación de restauración" : "Confirmación de eliminación";

                DialogResult resultado = MessageBox.Show(mensajeConfirmacion, tituloConfirmacion, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    // Lista: 
                    string mensajeResultado = cNLista.ActualizarEstado(lista, estado);
                    // Productos asociados:
                    cNProducto.ActualizarEstadoProductos(lista.IdLista, (EstadoDescripcion)estado);

                    MessageBoxIcon icono = mensajeResultado.Contains("Error") ? MessageBoxIcon.Error : MessageBoxIcon.Information;

                    if (icono == MessageBoxIcon.Information)
                    {
                        LimpiarFormulario();
                        HabilitarFormulario(false);
                        CargarEstados();
                    }

                    MessageBox.Show(mensajeResultado, "Resultado de la operación", MessageBoxButtons.OK, icono);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            HabilitarFormulario(false);
            dgvListadoProducto.DataSource = null;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            RegistrarLista();
        }

        private void RegistrarLista()
        {
            if (string.IsNullOrWhiteSpace(txtRutaArchivo.Text) || !File.Exists(txtRutaArchivo.Text))
            {
                MessageBox.Show("Debe seleccionar un archivo válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CELista cELista = ObtenerDatosLista();

            bool esNueva = (cELista.IdLista == 0);

            if (!cNLista.ValidarDatos(cELista, esNueva, out string mensajeValidacion))
            {
                MessageBox.Show(mensajeValidacion, "Errores de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string resultado;
            if (esNueva)
            {
                var (id, mensaje) = cNLista.AgregarLista(cELista);
                resultado = mensaje;
                nudId.Value = id; // IMPORTANTE para registrar productos
            }
            else
            {
                resultado = cNLista.ActualizarLista(cELista);
            }

            MessageBoxIcon icono = resultado.Contains("Error") ? MessageBoxIcon.Error : MessageBoxIcon.Information;
            MessageBox.Show(resultado, "Resultado de la operación", MessageBoxButtons.OK, icono);
            if (icono == MessageBoxIcon.Information)
            {
                PreRegistrarProductos();
            }
        }

        private void PreRegistrarProductos()
        {
            try
            {
                string contenidoArchivo = ExtraerTextoDeArchivo(txtRutaArchivo.Text);
                productos = ExtraerProductosDeTexto(contenidoArchivo);

                if (!HayProductosCargados()) return;
                MessageBox.Show("Los productos han sido cargados.\nVerifica que estén correctos antes de aceptar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DataTable table = new();
                table.Columns.Add("Descripción", typeof(string));
                table.Columns.Add("Precio", typeof(string));

                foreach (var producto in productos)
                {
                    table.Rows.Add(
                        producto.Descripcion,
                        producto.Precio.ToString("C")
                    );
                }

                dgvListadoProducto.DataSource = table;
                dgvListadoProducto.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar los productos:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Registrar productos
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!HayProductosCargados()) return;

            string resultado = cNProducto.AgregarProductos((int)nudId.Value, productos);
            MessageBoxIcon icono = resultado.Contains("Error") ? MessageBoxIcon.Error : MessageBoxIcon.Information;
            MessageBox.Show(resultado, "Resultado de la operación", MessageBoxButtons.OK, icono);

            if (icono == MessageBoxIcon.Information)
            {
                Close();
            }
        }

        private void dgvListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (UtilidadesListado.ObtenerFilaSeleccionada(dgvListadoLista, out DataGridViewRow filaSeleccionada))
            {
                int idLista = Convert.ToInt32(filaSeleccionada.Cells["Id_Lista"].Value);
                dgvListadoProducto.DataSource = cNProducto.ObtenerProductos(idLista);
                FormatearListadoProducto();

                nudId.Value = idLista;
                txtDescripcion.Text = filaSeleccionada.Cells["Descripcion"].Value.ToString();
                dtpFecha.Value = Convert.ToDateTime(filaSeleccionada.Cells["Fecha"].Value);
                cmbProveedor.SelectedValue = filaSeleccionada.Cells["Id_Proveedor"].Value;
                nudPorcentaje.Value = Convert.ToInt32(filaSeleccionada.Cells["Porcentaje"].Value);
            }

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
