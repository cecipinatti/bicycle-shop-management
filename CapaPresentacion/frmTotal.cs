using CapaNegocio;
using ScottPlot;
using Color = System.Drawing.Color;

namespace CapaPresentacion
{
    public partial class frmTotal : Form
    {
        private CNTotal cNTotal = new CNTotal();

        public frmTotal()
        {
            InitializeComponent();
        }

        /*
         *  Métodos de ayuda
        */
        private void CargarTotales()
        {
            try
            {
                dgvListadoMensual.DataSource = cNTotal.ObtenerTotalesMensuales((int)nudBuscarAnio.Value);
                dgvListadoAnual.DataSource = cNTotal.ObtenerTotalesAnuales();
                FormatearListados();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar los totales: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatearListados()
        {
            foreach (DataGridView grid in new[] { dgvListadoMensual, dgvListadoAnual })
            {
                if (grid.Columns.Count == 0) continue;
                grid.Columns["Total_Ingreso"].HeaderText = "Ingresos";
                grid.Columns["Total_Gasto"].HeaderText = "Gastos";
                if (grid.Columns.Contains("Mes"))
                    grid.Columns["Mes"].DefaultCellStyle.Font = new Font(grid.Font.FontFamily, 11, System.Drawing.FontStyle.Bold);
                if (grid.Columns.Contains("Anio"))
                {
                    grid.Columns["Anio"].DefaultCellStyle.Font = new Font(grid.Font.FontFamily, 11, System.Drawing.FontStyle.Bold);
                    grid.Columns["Anio"].HeaderText = "Año";
                }
                grid.Columns["Total_Ingreso"].DefaultCellStyle.Format = "C";
                grid.Columns["Total_Gasto"].DefaultCellStyle.Format = "C";
                grid.Columns["Total_Ingreso"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                grid.Columns["Total_Gasto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        private void FormatearCeldas(DataGridView dgv)
        {
            foreach (DataGridViewRow fila in dgv.Rows)
            {
                if (fila.Cells["Total_Ingreso"].Value != null && fila.Cells["Total_Gasto"].Value != null)
                {
                    fila.Cells["Total_Gasto"].Style.BackColor = Color.LightYellow;
                    fila.Cells["Total_Gasto"].Style.ForeColor = Color.Black;

                    fila.Cells["Total_Ingreso"].Style.BackColor = Color.LightGreen;
                    fila.Cells["Total_Ingreso"].Style.ForeColor = Color.Black;
                }
            }
        }

        private void GenerarGraficoMensual()
        {
            int anio = (int)nudBuscarAnio.Value;
            List<double> ingresosTotales = new();
            List<double> gastosTotales = new();
            List<double> posicionesIngresos = new();
            List<double> posicionesGastos = new();
            double separacionGrupoBarras = 2;
            double separacionBarras = 0.8;

            plotMensual.Plot.FigureBackground.Color = Colors.GhostWhite;
            plotMensual.Plot.DataBackground.Color = Colors.White;

            for (int mes = 1; mes <= 12; mes++)
            {
                double basePos = mes * separacionGrupoBarras;
                posicionesIngresos.Add(basePos + separacionBarras / 2); // derecha
                posicionesGastos.Add(basePos - separacionBarras / 2);   // izquierda

                var (totalIngreso, totalGasto) = cNTotal.ObtenerPorMesyAnio(mes, anio);
                gastosTotales.Add((double)totalGasto);
                ingresosTotales.Add((double)totalIngreso);
            }

            plotMensual.Plot.Clear();

            var barrasGastos = posicionesGastos.Select((p, i) => new ScottPlot.Bar()
            {
                Position = p,
                Value = gastosTotales[i],
                FillColor = Colors.LightYellow,
                Error = 0
            }).ToArray();

            var barrasIngresos = posicionesIngresos.Select((p, i) => new ScottPlot.Bar()
            {
                Position = p,
                Value = ingresosTotales[i],
                FillColor = Colors.LightGreen,
                Error = 0
            }).ToArray();

            plotMensual.Plot.Add.Bars(barrasGastos);
            plotMensual.Plot.Add.Bars(barrasIngresos);

            Tick[] ticks = Enumerable.Range(1, 12)
                .Select(m => new Tick(m * separacionGrupoBarras, new DateTime(anio, m, 1).ToString("MMM")))
                .ToArray();

            plotMensual.Plot.Axes.Bottom.TickLabelStyle.FontSize = 15;
            plotMensual.Plot.Axes.Left.TickLabelStyle.FontSize = 14;

            plotMensual.Plot.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericManual(ticks);
            plotMensual.Plot.Axes.Bottom.MajorTickStyle.Length = 0;

            plotMensual.Plot.Axes.Margins(bottom: 0);
            plotMensual.Refresh();

        }



        /*
        *   Eventos del formulario
        */
        private void frmTotal_Load(object sender, EventArgs e)
        {
            UtilidadesFecha.ObtenerAnios(nudBuscarAnio);
            CargarTotales();
            GenerarGraficoMensual();
        }

        private void nudBuscarAnio_ValueChanged(object sender, EventArgs e)
        {
            dgvListadoMensual.DataSource = cNTotal.ObtenerTotalesMensuales((int)nudBuscarAnio.Value);
            FormatearListados();
            GenerarGraficoMensual();
        }

        private void dgvListadoMensual_SelectionChanged(object sender, EventArgs e)
        {
            dgvListadoMensual.ClearSelection();
        }

        private void dgvListadoAnual_SelectionChanged(object sender, EventArgs e)
        {
            dgvListadoAnual.ClearSelection();
        }

        private void dgvListadoMensual_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvListadoMensual.Columns[e.ColumnIndex].Name == "Mes" && e.Value != null)
            {
                if (int.TryParse(e.Value.ToString(), out int mesInt) && mesInt >= 1 && mesInt <= 12)
                {
                    e.Value = Enum.GetName(typeof(UtilidadesFecha.Meses), mesInt);
                    e.FormattingApplied = true;
                }
            }
        }

        private void dgvListadoMensual_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            FormatearCeldas(dgvListadoMensual);
        }

        private void dgvListadoAnual_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            FormatearCeldas(dgvListadoAnual);
        }

    }
}
