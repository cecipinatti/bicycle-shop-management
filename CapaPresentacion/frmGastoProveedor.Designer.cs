namespace CapaPresentacion
{
    partial class frmGastoProveedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lbnMensajeEstado = new Label();
            label3 = new Label();
            txtListadoTotalPago = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            cmbBuscarMes = new ComboBox();
            cmbBuscarEstado = new ComboBox();
            nudBuscarAnio = new NumericUpDown();
            label15 = new Label();
            label1 = new Label();
            cmbBuscarProveedor = new ComboBox();
            label6 = new Label();
            btnLimpiar = new Button();
            btnBuscar = new Button();
            label20 = new Label();
            txtTotalMesActual = new TextBox();
            txtTotalMesAnterior = new TextBox();
            lbnTotalMesAnterior = new Label();
            lbnTotalMesActual = new Label();
            txtListadoTotalCoincidencia = new TextBox();
            txtListadoTotalImporte = new TextBox();
            label16 = new Label();
            label19 = new Label();
            label14 = new Label();
            btnNuevoPago = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            dgvListadoPago = new DataGridView();
            txtImporteP = new TextBox();
            nudIdP = new NumericUpDown();
            label17 = new Label();
            dtpFechaP = new DateTimePicker();
            label18 = new Label();
            label12 = new Label();
            groupBox1 = new GroupBox();
            cmbEstado = new ComboBox();
            cmbProveedor = new ComboBox();
            nudIdG = new NumericUpDown();
            label13 = new Label();
            btnCancelar = new Button();
            btnProveedor = new Label();
            btnGuardar = new Button();
            label25 = new Label();
            txtImporteG = new TextBox();
            dtpFechaG = new DateTimePicker();
            label26 = new Label();
            label27 = new Label();
            btnNuevo = new Button();
            dgvListadoGasto = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudBuscarAnio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvListadoPago).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudIdP).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudIdG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvListadoGasto).BeginInit();
            SuspendLayout();
            // 
            // lbnMensajeEstado
            // 
            lbnMensajeEstado.AutoSize = true;
            lbnMensajeEstado.BackColor = Color.Transparent;
            lbnMensajeEstado.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbnMensajeEstado.ForeColor = Color.FromArgb(247, 248, 252);
            lbnMensajeEstado.Location = new Point(16, 113);
            lbnMensajeEstado.Margin = new Padding(4, 0, 4, 0);
            lbnMensajeEstado.Name = "lbnMensajeEstado";
            lbnMensajeEstado.Padding = new Padding(2);
            lbnMensajeEstado.Size = new Size(90, 22);
            lbnMensajeEstado.TabIndex = 111;
            lbnMensajeEstado.Text = "MENSAJE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(12, 384);
            label3.Name = "label3";
            label3.Size = new Size(388, 16);
            label3.TabIndex = 106;
            label3.Text = "* Haz clic sobre un registro para visualizar los pagos asociados.";
            // 
            // txtListadoTotalPago
            // 
            txtListadoTotalPago.BorderStyle = BorderStyle.FixedSingle;
            txtListadoTotalPago.Enabled = false;
            txtListadoTotalPago.Font = new Font("Microsoft Sans Serif", 11.25F);
            txtListadoTotalPago.ForeColor = Color.Black;
            txtListadoTotalPago.Location = new Point(436, 596);
            txtListadoTotalPago.Margin = new Padding(4);
            txtListadoTotalPago.Name = "txtListadoTotalPago";
            txtListadoTotalPago.Size = new Size(307, 24);
            txtListadoTotalPago.TabIndex = 104;
            txtListadoTotalPago.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Underline);
            label2.Location = new Point(298, 598);
            label2.Name = "label2";
            label2.Size = new Size(106, 16);
            label2.TabIndex = 105;
            label2.Text = "PAGO TOTAL:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(cmbBuscarMes);
            groupBox2.Controls.Add(cmbBuscarEstado);
            groupBox2.Controls.Add(nudBuscarAnio);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(cmbBuscarProveedor);
            groupBox2.Controls.Add(label6);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ImeMode = ImeMode.NoControl;
            groupBox2.Location = new Point(12, 11);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(584, 97);
            groupBox2.TabIndex = 103;
            groupBox2.TabStop = false;
            // 
            // cmbBuscarMes
            // 
            cmbBuscarMes.Cursor = Cursors.Hand;
            cmbBuscarMes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBuscarMes.FlatStyle = FlatStyle.Flat;
            cmbBuscarMes.Font = new Font("Microsoft Sans Serif", 11.25F);
            cmbBuscarMes.Location = new Point(428, 22);
            cmbBuscarMes.Margin = new Padding(4);
            cmbBuscarMes.Name = "cmbBuscarMes";
            cmbBuscarMes.Size = new Size(136, 26);
            cmbBuscarMes.TabIndex = 132;
            // 
            // cmbBuscarEstado
            // 
            cmbBuscarEstado.Cursor = Cursors.Hand;
            cmbBuscarEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBuscarEstado.FlatStyle = FlatStyle.Flat;
            cmbBuscarEstado.Font = new Font("Microsoft Sans Serif", 11.25F);
            cmbBuscarEstado.FormattingEnabled = true;
            cmbBuscarEstado.Location = new Point(122, 54);
            cmbBuscarEstado.Name = "cmbBuscarEstado";
            cmbBuscarEstado.Size = new Size(219, 26);
            cmbBuscarEstado.TabIndex = 44;
            // 
            // nudBuscarAnio
            // 
            nudBuscarAnio.BorderStyle = BorderStyle.FixedSingle;
            nudBuscarAnio.Cursor = Cursors.Hand;
            nudBuscarAnio.Font = new Font("Microsoft Sans Serif", 11.25F);
            nudBuscarAnio.Location = new Point(428, 53);
            nudBuscarAnio.Margin = new Padding(4);
            nudBuscarAnio.Name = "nudBuscarAnio";
            nudBuscarAnio.Size = new Size(136, 24);
            nudBuscarAnio.TabIndex = 19;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(357, 26);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(61, 16);
            label15.TabIndex = 41;
            label15.Text = "FECHA:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(11, 25);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(106, 16);
            label1.TabIndex = 40;
            label1.Text = "PROVEEDOR:";
            // 
            // cmbBuscarProveedor
            // 
            cmbBuscarProveedor.Cursor = Cursors.Hand;
            cmbBuscarProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBuscarProveedor.FlatStyle = FlatStyle.Flat;
            cmbBuscarProveedor.Font = new Font("Microsoft Sans Serif", 11.25F);
            cmbBuscarProveedor.FormattingEnabled = true;
            cmbBuscarProveedor.Location = new Point(122, 22);
            cmbBuscarProveedor.Name = "cmbBuscarProveedor";
            cmbBuscarProveedor.Size = new Size(219, 26);
            cmbBuscarProveedor.TabIndex = 39;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(13, 57);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(73, 16);
            label6.TabIndex = 36;
            label6.Text = "ESTADO:";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Silver;
            btnLimpiar.BackgroundImageLayout = ImageLayout.Zoom;
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.Black;
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(608, 73);
            btnLimpiar.Margin = new Padding(4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(140, 35);
            btnLimpiar.TabIndex = 102;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Silver;
            btnBuscar.BackgroundImageLayout = ImageLayout.Zoom;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.Black;
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(608, 22);
            btnBuscar.Margin = new Padding(4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(140, 35);
            btnBuscar.TabIndex = 101;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.Blue;
            label20.Location = new Point(938, 627);
            label20.Name = "label20";
            label20.Size = new Size(168, 16);
            label20.TabIndex = 100;
            label20.Text = "* Incluye gastos generales.";
            // 
            // txtTotalMesActual
            // 
            txtTotalMesActual.BorderStyle = BorderStyle.FixedSingle;
            txtTotalMesActual.Enabled = false;
            txtTotalMesActual.Font = new Font("Microsoft Sans Serif", 11.25F);
            txtTotalMesActual.ForeColor = Color.Black;
            txtTotalMesActual.Location = new Point(938, 599);
            txtTotalMesActual.Margin = new Padding(4);
            txtTotalMesActual.Name = "txtTotalMesActual";
            txtTotalMesActual.Size = new Size(237, 24);
            txtTotalMesActual.TabIndex = 99;
            txtTotalMesActual.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTotalMesAnterior
            // 
            txtTotalMesAnterior.BorderStyle = BorderStyle.FixedSingle;
            txtTotalMesAnterior.Enabled = false;
            txtTotalMesAnterior.Font = new Font("Microsoft Sans Serif", 11.25F);
            txtTotalMesAnterior.ForeColor = Color.Black;
            txtTotalMesAnterior.Location = new Point(938, 572);
            txtTotalMesAnterior.Margin = new Padding(4);
            txtTotalMesAnterior.Name = "txtTotalMesAnterior";
            txtTotalMesAnterior.Size = new Size(237, 24);
            txtTotalMesAnterior.TabIndex = 98;
            txtTotalMesAnterior.TextAlign = HorizontalAlignment.Right;
            // 
            // lbnTotalMesAnterior
            // 
            lbnTotalMesAnterior.AutoSize = true;
            lbnTotalMesAnterior.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Underline);
            lbnTotalMesAnterior.ForeColor = Color.Black;
            lbnTotalMesAnterior.Location = new Point(762, 576);
            lbnTotalMesAnterior.Margin = new Padding(4, 0, 4, 0);
            lbnTotalMesAnterior.Name = "lbnTotalMesAnterior";
            lbnTotalMesAnterior.Size = new Size(88, 16);
            lbnTotalMesAnterior.TabIndex = 96;
            lbnTotalMesAnterior.Text = "TOTAL MM:";
            // 
            // lbnTotalMesActual
            // 
            lbnTotalMesActual.AutoSize = true;
            lbnTotalMesActual.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Underline);
            lbnTotalMesActual.ForeColor = Color.Black;
            lbnTotalMesActual.Location = new Point(762, 603);
            lbnTotalMesActual.Margin = new Padding(4, 0, 4, 0);
            lbnTotalMesActual.Name = "lbnTotalMesActual";
            lbnTotalMesActual.Size = new Size(88, 16);
            lbnTotalMesActual.TabIndex = 95;
            lbnTotalMesActual.Text = "TOTAL MM:";
            // 
            // txtListadoTotalCoincidencia
            // 
            txtListadoTotalCoincidencia.BorderStyle = BorderStyle.FixedSingle;
            txtListadoTotalCoincidencia.Enabled = false;
            txtListadoTotalCoincidencia.Font = new Font("Microsoft Sans Serif", 11.25F);
            txtListadoTotalCoincidencia.ForeColor = Color.Black;
            txtListadoTotalCoincidencia.Location = new Point(146, 568);
            txtListadoTotalCoincidencia.Margin = new Padding(4);
            txtListadoTotalCoincidencia.Name = "txtListadoTotalCoincidencia";
            txtListadoTotalCoincidencia.Size = new Size(130, 24);
            txtListadoTotalCoincidencia.TabIndex = 94;
            txtListadoTotalCoincidencia.TextAlign = HorizontalAlignment.Right;
            // 
            // txtListadoTotalImporte
            // 
            txtListadoTotalImporte.BorderStyle = BorderStyle.FixedSingle;
            txtListadoTotalImporte.Enabled = false;
            txtListadoTotalImporte.Font = new Font("Microsoft Sans Serif", 11.25F);
            txtListadoTotalImporte.ForeColor = Color.Black;
            txtListadoTotalImporte.Location = new Point(436, 568);
            txtListadoTotalImporte.Margin = new Padding(4);
            txtListadoTotalImporte.Name = "txtListadoTotalImporte";
            txtListadoTotalImporte.Size = new Size(307, 24);
            txtListadoTotalImporte.TabIndex = 92;
            txtListadoTotalImporte.TextAlign = HorizontalAlignment.Right;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Underline);
            label16.Location = new Point(298, 572);
            label16.Name = "label16";
            label16.Size = new Size(132, 16);
            label16.TabIndex = 93;
            label16.Text = "IMPORTE TOTAL:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Underline);
            label19.Location = new Point(12, 572);
            label19.Name = "label19";
            label19.Size = new Size(127, 16);
            label19.TabIndex = 91;
            label19.Text = "COINCIDENCIAS:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial Black", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(12, 414);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(200, 22);
            label14.TabIndex = 90;
            label14.Text = "HISTORIAL DE PAGOS:";
            // 
            // btnNuevoPago
            // 
            btnNuevoPago.BackColor = Color.Silver;
            btnNuevoPago.Cursor = Cursors.Hand;
            btnNuevoPago.FlatAppearance.BorderSize = 0;
            btnNuevoPago.FlatStyle = FlatStyle.Flat;
            btnNuevoPago.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            btnNuevoPago.ForeColor = Color.Blue;
            btnNuevoPago.Location = new Point(170, 628);
            btnNuevoPago.Margin = new Padding(4);
            btnNuevoPago.Name = "btnNuevoPago";
            btnNuevoPago.Size = new Size(140, 35);
            btnNuevoPago.TabIndex = 88;
            btnNuevoPago.Text = "Nuevo Pago";
            btnNuevoPago.UseVisualStyleBackColor = false;
            btnNuevoPago.Click += btnNuevoPago_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Silver;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.Blue;
            btnEliminar.Location = new Point(603, 628);
            btnEliminar.Margin = new Padding(4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(140, 35);
            btnEliminar.TabIndex = 86;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Silver;
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            btnEditar.ForeColor = Color.Blue;
            btnEditar.Location = new Point(436, 628);
            btnEditar.Margin = new Padding(4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(140, 35);
            btnEditar.TabIndex = 85;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // dgvListadoPago
            // 
            dgvListadoPago.AllowUserToAddRows = false;
            dgvListadoPago.AllowUserToDeleteRows = false;
            dgvListadoPago.AllowUserToResizeColumns = false;
            dgvListadoPago.AllowUserToResizeRows = false;
            dgvListadoPago.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListadoPago.BackgroundColor = Color.Silver;
            dgvListadoPago.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvListadoPago.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvListadoPago.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListadoPago.Cursor = Cursors.Hand;
            dgvListadoPago.EnableHeadersVisualStyles = false;
            dgvListadoPago.Location = new Point(12, 438);
            dgvListadoPago.Margin = new Padding(4);
            dgvListadoPago.MultiSelect = false;
            dgvListadoPago.Name = "dgvListadoPago";
            dgvListadoPago.ReadOnly = true;
            dgvListadoPago.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvListadoPago.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvListadoPago.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListadoPago.Size = new Size(400, 122);
            dgvListadoPago.TabIndex = 84;
            dgvListadoPago.CellClick += dgvListadoPago_CellClick;
            dgvListadoPago.Enter += dgvListadoPago_Enter;
            // 
            // txtImporteP
            // 
            txtImporteP.BorderStyle = BorderStyle.FixedSingle;
            txtImporteP.Cursor = Cursors.IBeam;
            txtImporteP.Enabled = false;
            txtImporteP.Font = new Font("Microsoft Sans Serif", 11.25F);
            txtImporteP.Location = new Point(122, 241);
            txtImporteP.Margin = new Padding(5);
            txtImporteP.Name = "txtImporteP";
            txtImporteP.Size = new Size(278, 24);
            txtImporteP.TabIndex = 20;
            txtImporteP.TextAlign = HorizontalAlignment.Right;
            // 
            // nudIdP
            // 
            nudIdP.Enabled = false;
            nudIdP.Font = new Font("Microsoft Sans Serif", 11.25F);
            nudIdP.Location = new Point(122, 173);
            nudIdP.Margin = new Padding(4);
            nudIdP.Name = "nudIdP";
            nudIdP.ReadOnly = true;
            nudIdP.Size = new Size(278, 24);
            nudIdP.TabIndex = 24;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label17.ForeColor = Color.FromArgb(64, 64, 64);
            label17.Location = new Point(8, 177);
            label17.Margin = new Padding(5, 0, 5, 0);
            label17.Name = "label17";
            label17.Size = new Size(97, 16);
            label17.TabIndex = 16;
            label17.Text = "Identificador:";
            // 
            // dtpFechaP
            // 
            dtpFechaP.Cursor = Cursors.Hand;
            dtpFechaP.Enabled = false;
            dtpFechaP.Font = new Font("Microsoft Sans Serif", 11.25F);
            dtpFechaP.Format = DateTimePickerFormat.Short;
            dtpFechaP.Location = new Point(122, 206);
            dtpFechaP.Margin = new Padding(5);
            dtpFechaP.Name = "dtpFechaP";
            dtpFechaP.Size = new Size(278, 24);
            dtpFechaP.TabIndex = 26;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label18.ForeColor = Color.Black;
            label18.Location = new Point(8, 245);
            label18.Margin = new Padding(5, 0, 5, 0);
            label18.Name = "label18";
            label18.Size = new Size(79, 16);
            label18.TabIndex = 7;
            label18.Text = "IMPORTE:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(8, 211);
            label12.Margin = new Padding(5, 0, 5, 0);
            label12.Name = "label12";
            label12.Size = new Size(61, 16);
            label12.TabIndex = 25;
            label12.Text = "FECHA:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbEstado);
            groupBox1.Controls.Add(txtImporteP);
            groupBox1.Controls.Add(nudIdP);
            groupBox1.Controls.Add(cmbProveedor);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(nudIdG);
            groupBox1.Controls.Add(dtpFechaP);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(btnProveedor);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label25);
            groupBox1.Controls.Add(txtImporteG);
            groupBox1.Controls.Add(dtpFechaG);
            groupBox1.Controls.Add(label26);
            groupBox1.Controls.Add(label27);
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Blue;
            groupBox1.Location = new Point(762, 131);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(413, 395);
            groupBox1.TabIndex = 52;
            groupBox1.TabStop = false;
            // 
            // cmbEstado
            // 
            cmbEstado.Cursor = Cursors.Hand;
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.Enabled = false;
            cmbEstado.FlatStyle = FlatStyle.Flat;
            cmbEstado.Font = new Font("Microsoft Sans Serif", 11.25F);
            cmbEstado.Location = new Point(122, 274);
            cmbEstado.Margin = new Padding(4);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(278, 26);
            cmbEstado.TabIndex = 117;
            // 
            // cmbProveedor
            // 
            cmbProveedor.Cursor = Cursors.Hand;
            cmbProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProveedor.Enabled = false;
            cmbProveedor.FlatStyle = FlatStyle.Flat;
            cmbProveedor.Font = new Font("Microsoft Sans Serif", 11.25F);
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Location = new Point(122, 91);
            cmbProveedor.Margin = new Padding(4);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(278, 26);
            cmbProveedor.TabIndex = 116;
            // 
            // nudIdG
            // 
            nudIdG.Enabled = false;
            nudIdG.Font = new Font("Microsoft Sans Serif", 11.25F);
            nudIdG.Location = new Point(122, 24);
            nudIdG.Margin = new Padding(4);
            nudIdG.Name = "nudIdG";
            nudIdG.ReadOnly = true;
            nudIdG.Size = new Size(278, 24);
            nudIdG.TabIndex = 17;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(8, 62);
            label13.Margin = new Padding(5, 0, 5, 0);
            label13.Name = "label13";
            label13.Size = new Size(61, 16);
            label13.TabIndex = 4;
            label13.Text = "FECHA:";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Silver;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.Blue;
            btnCancelar.Location = new Point(105, 340);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(140, 35);
            btnCancelar.TabIndex = 115;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Visible = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnProveedor
            // 
            btnProveedor.AutoSize = true;
            btnProveedor.Cursor = Cursors.Hand;
            btnProveedor.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            btnProveedor.ForeColor = Color.Blue;
            btnProveedor.Location = new Point(8, 96);
            btnProveedor.Margin = new Padding(5, 0, 5, 0);
            btnProveedor.Name = "btnProveedor";
            btnProveedor.Size = new Size(106, 16);
            btnProveedor.TabIndex = 5;
            btnProveedor.Text = "PROVEEDOR:";
            btnProveedor.Click += btnProveedor_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Silver;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.Blue;
            btnGuardar.Location = new Point(260, 340);
            btnGuardar.Margin = new Padding(4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(140, 35);
            btnGuardar.TabIndex = 114;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Visible = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label25.ForeColor = Color.Black;
            label25.Location = new Point(8, 130);
            label25.Margin = new Padding(5, 0, 5, 0);
            label25.Name = "label25";
            label25.Size = new Size(79, 16);
            label25.TabIndex = 6;
            label25.Text = "IMPORTE:";
            // 
            // txtImporteG
            // 
            txtImporteG.BorderStyle = BorderStyle.FixedSingle;
            txtImporteG.Cursor = Cursors.IBeam;
            txtImporteG.Enabled = false;
            txtImporteG.Font = new Font("Microsoft Sans Serif", 11.25F);
            txtImporteG.Location = new Point(122, 126);
            txtImporteG.Margin = new Padding(5);
            txtImporteG.Name = "txtImporteG";
            txtImporteG.Size = new Size(278, 24);
            txtImporteG.TabIndex = 8;
            txtImporteG.TextAlign = HorizontalAlignment.Right;
            // 
            // dtpFechaG
            // 
            dtpFechaG.Cursor = Cursors.Hand;
            dtpFechaG.Enabled = false;
            dtpFechaG.Font = new Font("Microsoft Sans Serif", 11.25F);
            dtpFechaG.Format = DateTimePickerFormat.Short;
            dtpFechaG.Location = new Point(122, 58);
            dtpFechaG.Margin = new Padding(5);
            dtpFechaG.Name = "dtpFechaG";
            dtpFechaG.Size = new Size(278, 24);
            dtpFechaG.TabIndex = 10;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label26.ForeColor = Color.FromArgb(64, 64, 64);
            label26.Location = new Point(8, 28);
            label26.Margin = new Padding(5, 0, 5, 0);
            label26.Name = "label26";
            label26.Size = new Size(97, 16);
            label26.TabIndex = 16;
            label26.Text = "Identificador:";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label27.ForeColor = Color.Black;
            label27.Location = new Point(8, 279);
            label27.Margin = new Padding(5, 0, 5, 0);
            label27.Name = "label27";
            label27.Size = new Size(73, 16);
            label27.TabIndex = 46;
            label27.Text = "ESTADO:";
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.Silver;
            btnNuevo.Cursor = Cursors.Hand;
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            btnNuevo.ForeColor = Color.Blue;
            btnNuevo.Location = new Point(12, 628);
            btnNuevo.Margin = new Padding(4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(140, 35);
            btnNuevo.TabIndex = 113;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // dgvListadoGasto
            // 
            dgvListadoGasto.AllowUserToAddRows = false;
            dgvListadoGasto.AllowUserToDeleteRows = false;
            dgvListadoGasto.AllowUserToResizeColumns = false;
            dgvListadoGasto.AllowUserToResizeRows = false;
            dgvListadoGasto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListadoGasto.BackgroundColor = Color.Silver;
            dgvListadoGasto.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvListadoGasto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvListadoGasto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListadoGasto.Cursor = Cursors.Hand;
            dgvListadoGasto.EnableHeadersVisualStyles = false;
            dgvListadoGasto.Location = new Point(14, 140);
            dgvListadoGasto.Margin = new Padding(4);
            dgvListadoGasto.MultiSelect = false;
            dgvListadoGasto.Name = "dgvListadoGasto";
            dgvListadoGasto.ReadOnly = true;
            dgvListadoGasto.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvListadoGasto.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvListadoGasto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListadoGasto.Size = new Size(734, 240);
            dgvListadoGasto.TabIndex = 89;
            dgvListadoGasto.CellClick += dgvListadoGasto_CellClick;
            dgvListadoGasto.Enter += dgvListadoGasto_Enter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(762, 22);
            label4.Name = "label4";
            label4.Size = new Size(279, 16);
            label4.TabIndex = 114;
            label4.Text = "* Los gastos pendientes se muestran primero,";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(771, 38);
            label5.Name = "label5";
            label5.Size = new Size(253, 16);
            label5.TabIndex = 115;
            label5.Text = "si no hay, se listarán los gastos pagados.";
            // 
            // frmGastoProveedor
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 248, 252);
            ClientSize = new Size(1188, 674);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lbnMensajeEstado);
            Controls.Add(btnNuevo);
            Controls.Add(groupBox2);
            Controls.Add(dgvListadoGasto);
            Controls.Add(btnBuscar);
            Controls.Add(btnLimpiar);
            Controls.Add(groupBox1);
            Controls.Add(label14);
            Controls.Add(btnEditar);
            Controls.Add(dgvListadoPago);
            Controls.Add(txtListadoTotalPago);
            Controls.Add(txtListadoTotalCoincidencia);
            Controls.Add(txtTotalMesActual);
            Controls.Add(txtListadoTotalImporte);
            Controls.Add(btnEliminar);
            Controls.Add(label2);
            Controls.Add(txtTotalMesAnterior);
            Controls.Add(label20);
            Controls.Add(lbnTotalMesAnterior);
            Controls.Add(label3);
            Controls.Add(btnNuevoPago);
            Controls.Add(label16);
            Controls.Add(lbnTotalMesActual);
            Controls.Add(label19);
            Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "frmGastoProveedor";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmGastoProveedor_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudBuscarAnio).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvListadoPago).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudIdP).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudIdG).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvListadoGasto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbnMensajeEstado;
        private TextBox txtListadoTotalPago;
        private Label label2;
        private GroupBox groupBox2;
        private ComboBox cmbBuscarEstado;
        private NumericUpDown nudBuscarAnio;
        private Label label15;
        private Label label1;
        private ComboBox cmbBuscarProveedor;
        private Label label6;
        private Button btnLimpiar;
        private Button btnBuscar;
        private Label label20;
        private TextBox txtTotalMesActual;
        private TextBox txtTotalMesAnterior;
        private Label lbnTotalMesAnterior;
        private Label lbnTotalMesActual;
        private TextBox txtListadoTotalCoincidencia;
        private TextBox txtListadoTotalImporte;
        private Label label16;
        private Label label19;
        private Label label14;
        private Button btnNuevoPago;
        private Button btnEliminar;
        private Button btnEditar;
        private DataGridView dgvListadoPago;
        private TextBox txtImporteP;
        private NumericUpDown nudIdP;
        private Label label17;
        private DateTimePicker dtpFechaP;
        private Label label18;
        private Label label12;
        private NumericUpDown nudIdG;
        private Label label13;
        private Label btnProveedor;
        private Label label25;
        private TextBox txtImporteG;
        private DateTimePicker dtpFechaG;
        private Label label26;
        private Label label27;
        private Label label3;
        private GroupBox groupBox1;
        private Button btnGuardar;
        private Button btnCancelar;
        private Button btnNuevo;
        private DataGridView dgvListadoGasto;
        private ComboBox cmbProveedor;
        private ComboBox cmbEstado;
        private Label label4;
        private Label label5;
        private ComboBox cmbBuscarMes;
    }
}