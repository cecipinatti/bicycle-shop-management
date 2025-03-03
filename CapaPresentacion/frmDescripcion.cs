using CapaEntidad;
using CapaNegocio;
using System.Data;
using static CapaEntidad.CEDescripcion;

namespace CapaPresentacion
{
    public partial class frmDescripcion : Form
    {
        private readonly CEDescripcion cE;
        private readonly CNIDescripcion cN;

        public frmDescripcion(CEDescripcion cE, CNIDescripcion cN)
        {
            InitializeComponent();
            this.cE = cE;
            this.cN = cN;
        }

        /*
        * Métodos de ayuda
        */
        private void CargarListado(EstadoDescripcion estado = EstadoDescripcion.ACTIVO)
        {
            dgvListado.DataSource = cN.Obtener((int)estado);
            FormatearListado();
        }

        private void FormatearListado()
        {
            if (dgvListado.Columns.Contains("Id_Lista"))
                dgvListado.Columns["Id_Lista"].Visible = false;
            if (dgvListado.Columns.Contains("Precio"))
                dgvListado.Columns["Precio"].Visible = false;
            dgvListado.Columns["Id"].Visible = false;
            dgvListado.Columns["Estado"].Visible = false;
        }

        private void CargarEstados()
        {
            cmbBuscarEstado.DataSource = Enum.GetValues(typeof(EstadoDescripcion));
            cmbBuscarEstado.SelectedItem = EstadoDescripcion.ACTIVO;
        }

        private bool EsDescripcionSeleccionada()
        {
            DataGridViewRow filaSeleccionada = dgvListado.CurrentRow;

            if (filaSeleccionada != null && nudId.Value == Convert.ToInt32(filaSeleccionada.Cells["Id"].Value))
                return true;

            MessageBox.Show("Seleccione un registro haciendo clic en la fila para editar o eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }

        private void HabilitarFormulario(bool habilitar)
        {
            btnCancelar.Visible = habilitar;
            btnGuardar.Visible = habilitar;
            txtDescripcion.Enabled = habilitar;

            txtBuscarDescripcion.Enabled = !habilitar;
            cmbBuscarEstado.Enabled = !habilitar;
            dgvListado.Enabled = !habilitar;
            btnNuevo.Enabled = !habilitar;
            btnEditar.Enabled = !habilitar;
            btnEliminar.Enabled = !habilitar;
            btnSalir.Enabled = !habilitar;
        }

        private void LimpiarFormulario()
        {
            txtBuscarDescripcion.Clear();
            cmbBuscarEstado.SelectedItem = EstadoDescripcion.ACTIVO;

            nudId.Value = 0;
            txtDescripcion.Clear();
            txtDescripcion.Focus();
        }



        /*
        *  Eventos del formulario
        */

        private void frmCategoriaProducto_Load(object sender, EventArgs e)
        {
            UtilidadesControles.InicializarNumericUpDown(nudId);
            CargarListado();
            CargarEstados();

            // btnNuevo
            LimpiarFormulario();
            HabilitarFormulario(true);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            HabilitarFormulario(true);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (EsDescripcionSeleccionada())
            {
                HabilitarFormulario(true);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ActualizarEstado(EstadoDescripcion.INACTIVO);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            HabilitarFormulario(false);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var entidad = DescripcionFactory.CrearEntidad(cE);
            entidad.Descripcion = txtDescripcion.Text;

            if (!cN.Verificar(entidad, out string mensajeValidacion))
            {
                MessageBox.Show(mensajeValidacion, "Errores de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string resultado = entidad.Id == 0 ? cN.Agregar(entidad) : cN.ActualizarDescripcion(entidad);
            MessageBoxIcon icono = resultado.Contains("Error") ? MessageBoxIcon.Error : MessageBoxIcon.Information;
            MessageBox.Show(resultado, "Resultado de la operación", MessageBoxButtons.OK, icono);

            DialogResult respuesta = MessageBox.Show("¿Desea guardar otro registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                LimpiarFormulario();
                CargarListado();
            }
            else
            {
                this.Close();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (UtilidadesListado.ObtenerFilaSeleccionada(dgvListado, out DataGridViewRow filaSeleccionada))
            {
                nudId.Value = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);
                txtDescripcion.Text = filaSeleccionada.Cells["Descripcion"].Value.ToString();
            }
        }

        private void AplicarFiltro(string filtro)
        {
            if (dgvListado.DataSource is DataTable dt)
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

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            if (txtDescripcion.Enabled)
            {
                AplicarFiltro(txtDescripcion.Text.Trim());
            }
        }

        private void txtBuscarDescripcion_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltro(txtBuscarDescripcion.Text.Trim());
        }

        private void cmbBuscarEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            EstadoDescripcion estadoSeleccionado = (EstadoDescripcion)cmbBuscarEstado.SelectedItem;

            dgvListado.DataSource = cN.Obtener((int)estadoSeleccionado);
            FormatearListado();

            btnRestaurar.Enabled = estadoSeleccionado == EstadoDescripcion.INACTIVO;
            btnEliminar.Enabled = estadoSeleccionado == EstadoDescripcion.ACTIVO;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            ActualizarEstado(EstadoDescripcion.ACTIVO);
        }

        // Eliminar o Restarar
        private void ActualizarEstado(EstadoDescripcion estado)
        {
            if (EsDescripcionSeleccionada())
            {
                var entidad = DescripcionFactory.CrearEntidad(cE);
                entidad.Id = Convert.ToInt32(nudId.Value);

                string accion = (int)estado == 1 ? "restaurar" : "eliminar";
                string mensajeConfirmacion = $"¿Estás seguro de que deseas {accion} este registro?";
                string tituloConfirmacion = (int)estado == 1 ? "Confirmación de restauración" : "Confirmación de eliminación";

                DialogResult resultado = MessageBox.Show(mensajeConfirmacion, tituloConfirmacion, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    string mensajeResultado = cN.ActualizarEstado(entidad, estado);

                    MessageBoxIcon icono = mensajeResultado.Contains("Error") ? MessageBoxIcon.Error : MessageBoxIcon.Information;

                    if (icono == MessageBoxIcon.Information)
                    {
                        CargarListado();
                        LimpiarFormulario();
                        HabilitarFormulario(false);
                    }

                    MessageBox.Show(mensajeResultado, "Resultado de la operación", MessageBoxButtons.OK, icono);
                }
            }
        }

    }
}
