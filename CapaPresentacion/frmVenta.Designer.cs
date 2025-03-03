namespace CapaPresentacion
{
    partial class frmVenta
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnNuevo = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            dgvListadoProducto = new DataGridView();
            txtListadoTotalCoincidencia = new TextBox();
            txtListadoTotalImporte = new TextBox();
            label16 = new Label();
            label19 = new Label();
            txtTotalMesActual = new TextBox();
            txtTotalMesAnterior = new TextBox();
            lbnTotalMesAnterior = new Label();
            lbnTotalMesActual = new Label();
            btnNuevoPago = new Button();
            txtListadoTotalPago = new TextBox();
            label6 = new Label();
            groupBox1 = new GroupBox();
            txtCliente = new TextBox();
            lbnProductos = new Label();
            nudIdP = new NumericUpDown();
            btnListaProducto = new Button();
            cmbCliente = new ComboBox();
            btnCliente = new Label();
            btnProducto = new Label();
            cmbEstado = new ComboBox();
            txtImporteP = new TextBox();
            cmbCategoria = new ComboBox();
            label17 = new Label();
            nudIdV = new NumericUpDown();
            dtpFechaP = new DateTimePicker();
            label2 = new Label();
            btnCancelar = new Button();
            label18 = new Label();
            btnCategoria = new Label();
            btnGuardar = new Button();
            label12 = new Label();
            label25 = new Label();
            txtImporteV = new TextBox();
            dtpFechaV = new DateTimePicker();
            label26 = new Label();
            label27 = new Label();
            dgvListadoPago = new DataGridView();
            groupBox3 = new GroupBox();
            txtBuscarCliente = new TextBox();
            cmbBuscarMes = new ComboBox();
            chkIncluirFecha = new CheckBox();
            cmbBuscarEstado = new ComboBox();
            label20 = new Label();
            cmbBuscarCliente = new ComboBox();
            nudBuscarAnio = new NumericUpDown();
            label11 = new Label();
            cmbBuscarCategoria = new ComboBox();
            label15 = new Label();
            label14 = new Label();
            label9 = new Label();
            label5 = new Label();
            btnLimpiar = new Button();
            btnBuscar = new Button();
            dgvListadoVenta = new DataGridView();
            lbnMensajeEstado = new Label();
            label8 = new Label();
            label1 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvListadoProducto).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudIdP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudIdV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvListadoPago).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudBuscarAnio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvListadoVenta).BeginInit();
            SuspendLayout();
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.Silver;
            btnNuevo.Cursor = Cursors.Hand;
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            btnNuevo.ForeColor = Color.Blue;
            btnNuevo.Location = new Point(13, 628);
            btnNuevo.Margin = new Padding(4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(140, 35);
            btnNuevo.TabIndex = 34;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Silver;
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            btnEditar.ForeColor = Color.Blue;
            btnEditar.Location = new Point(437, 628);
            btnEditar.Margin = new Padding(4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(140, 35);
            btnEditar.TabIndex = 37;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Silver;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.Blue;
            btnEliminar.Location = new Point(604, 628);
            btnEliminar.Margin = new Padding(4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(140, 35);
            btnEliminar.TabIndex = 38;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvListadoProducto
            // 
            dgvListadoProducto.AllowUserToAddRows = false;
            dgvListadoProducto.AllowUserToDeleteRows = false;
            dgvListadoProducto.AllowUserToResizeColumns = false;
            dgvListadoProducto.AllowUserToResizeRows = false;
            dgvListadoProducto.BackgroundColor = Color.Silver;
            dgvListadoProducto.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvListadoProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvListadoProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListadoProducto.EnableHeadersVisualStyles = false;
            dgvListadoProducto.Location = new Point(372, 438);
            dgvListadoProducto.Margin = new Padding(4);
            dgvListadoProducto.MultiSelect = false;
            dgvListadoProducto.Name = "dgvListadoProducto";
            dgvListadoProducto.ReadOnly = true;
            dgvListadoProducto.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvListadoProducto.RowHeadersVisible = false;
            dgvListadoProducto.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvListadoProducto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListadoProducto.Size = new Size(382, 122);
            dgvListadoProducto.TabIndex = 40;
            dgvListadoProducto.SelectionChanged += dgvListadoProducto_SelectionChanged;
            // 
            // txtListadoTotalCoincidencia
            // 
            txtListadoTotalCoincidencia.BorderStyle = BorderStyle.FixedSingle;
            txtListadoTotalCoincidencia.Enabled = false;
            txtListadoTotalCoincidencia.Font = new Font("Microsoft Sans Serif", 11.25F);
            txtListadoTotalCoincidencia.ForeColor = Color.Black;
            txtListadoTotalCoincidencia.Location = new Point(147, 568);
            txtListadoTotalCoincidencia.Margin = new Padding(4);
            txtListadoTotalCoincidencia.Name = "txtListadoTotalCoincidencia";
            txtListadoTotalCoincidencia.Size = new Size(130, 24);
            txtListadoTotalCoincidencia.TabIndex = 85;
            txtListadoTotalCoincidencia.TextAlign = HorizontalAlignment.Right;
            // 
            // txtListadoTotalImporte
            // 
            txtListadoTotalImporte.BorderStyle = BorderStyle.FixedSingle;
            txtListadoTotalImporte.Enabled = false;
            txtListadoTotalImporte.Font = new Font("Microsoft Sans Serif", 11.25F);
            txtListadoTotalImporte.ForeColor = Color.Black;
            txtListadoTotalImporte.Location = new Point(437, 568);
            txtListadoTotalImporte.Margin = new Padding(4);
            txtListadoTotalImporte.Name = "txtListadoTotalImporte";
            txtListadoTotalImporte.Size = new Size(307, 24);
            txtListadoTotalImporte.TabIndex = 83;
            txtListadoTotalImporte.TextAlign = HorizontalAlignment.Right;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Underline);
            label16.Location = new Point(299, 572);
            label16.Name = "label16";
            label16.Size = new Size(132, 16);
            label16.TabIndex = 84;
            label16.Text = "IMPORTE TOTAL:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Underline);
            label19.Location = new Point(13, 572);
            label19.Name = "label19";
            label19.Size = new Size(127, 16);
            label19.TabIndex = 82;
            label19.Text = "COINCIDENCIAS:";
            // 
            // txtTotalMesActual
            // 
            txtTotalMesActual.BorderStyle = BorderStyle.FixedSingle;
            txtTotalMesActual.Enabled = false;
            txtTotalMesActual.Font = new Font("Microsoft Sans Serif", 11.25F);
            txtTotalMesActual.ForeColor = Color.Black;
            txtTotalMesActual.Location = new Point(929, 598);
            txtTotalMesActual.Margin = new Padding(4);
            txtTotalMesActual.Name = "txtTotalMesActual";
            txtTotalMesActual.Size = new Size(237, 24);
            txtTotalMesActual.TabIndex = 74;
            txtTotalMesActual.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTotalMesAnterior
            // 
            txtTotalMesAnterior.BorderStyle = BorderStyle.FixedSingle;
            txtTotalMesAnterior.Enabled = false;
            txtTotalMesAnterior.Font = new Font("Microsoft Sans Serif", 11.25F);
            txtTotalMesAnterior.ForeColor = Color.Black;
            txtTotalMesAnterior.Location = new Point(929, 571);
            txtTotalMesAnterior.Margin = new Padding(4);
            txtTotalMesAnterior.Name = "txtTotalMesAnterior";
            txtTotalMesAnterior.Size = new Size(237, 24);
            txtTotalMesAnterior.TabIndex = 73;
            txtTotalMesAnterior.TextAlign = HorizontalAlignment.Right;
            // 
            // lbnTotalMesAnterior
            // 
            lbnTotalMesAnterior.AutoSize = true;
            lbnTotalMesAnterior.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lbnTotalMesAnterior.ForeColor = Color.Black;
            lbnTotalMesAnterior.Location = new Point(760, 575);
            lbnTotalMesAnterior.Margin = new Padding(4, 0, 4, 0);
            lbnTotalMesAnterior.Name = "lbnTotalMesAnterior";
            lbnTotalMesAnterior.Size = new Size(88, 16);
            lbnTotalMesAnterior.TabIndex = 71;
            lbnTotalMesAnterior.Text = "TOTAL MM:";
            // 
            // lbnTotalMesActual
            // 
            lbnTotalMesActual.AutoSize = true;
            lbnTotalMesActual.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lbnTotalMesActual.ForeColor = Color.Black;
            lbnTotalMesActual.Location = new Point(760, 602);
            lbnTotalMesActual.Margin = new Padding(4, 0, 4, 0);
            lbnTotalMesActual.Name = "lbnTotalMesActual";
            lbnTotalMesActual.Size = new Size(88, 16);
            lbnTotalMesActual.TabIndex = 70;
            lbnTotalMesActual.Text = "TOTAL MM:";
            // 
            // btnNuevoPago
            // 
            btnNuevoPago.BackColor = Color.Silver;
            btnNuevoPago.Cursor = Cursors.Hand;
            btnNuevoPago.FlatAppearance.BorderSize = 0;
            btnNuevoPago.FlatStyle = FlatStyle.Flat;
            btnNuevoPago.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            btnNuevoPago.ForeColor = Color.Blue;
            btnNuevoPago.Location = new Point(171, 628);
            btnNuevoPago.Margin = new Padding(4);
            btnNuevoPago.Name = "btnNuevoPago";
            btnNuevoPago.Size = new Size(140, 35);
            btnNuevoPago.TabIndex = 87;
            btnNuevoPago.Text = "Nuevo Pago";
            btnNuevoPago.UseVisualStyleBackColor = false;
            btnNuevoPago.Click += btnNuevoPago_Click;
            // 
            // txtListadoTotalPago
            // 
            txtListadoTotalPago.BorderStyle = BorderStyle.FixedSingle;
            txtListadoTotalPago.Enabled = false;
            txtListadoTotalPago.Font = new Font("Microsoft Sans Serif", 11.25F);
            txtListadoTotalPago.ForeColor = Color.Black;
            txtListadoTotalPago.Location = new Point(437, 596);
            txtListadoTotalPago.Margin = new Padding(4);
            txtListadoTotalPago.Name = "txtListadoTotalPago";
            txtListadoTotalPago.Size = new Size(307, 24);
            txtListadoTotalPago.TabIndex = 90;
            txtListadoTotalPago.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Underline);
            label6.Location = new Point(299, 598);
            label6.Name = "label6";
            label6.Size = new Size(106, 16);
            label6.TabIndex = 91;
            label6.Text = "PAGO TOTAL:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCliente);
            groupBox1.Controls.Add(lbnProductos);
            groupBox1.Controls.Add(nudIdP);
            groupBox1.Controls.Add(btnListaProducto);
            groupBox1.Controls.Add(cmbCliente);
            groupBox1.Controls.Add(btnCliente);
            groupBox1.Controls.Add(btnProducto);
            groupBox1.Controls.Add(cmbEstado);
            groupBox1.Controls.Add(txtImporteP);
            groupBox1.Controls.Add(cmbCategoria);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(nudIdV);
            groupBox1.Controls.Add(dtpFechaP);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(btnCategoria);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label25);
            groupBox1.Controls.Add(txtImporteV);
            groupBox1.Controls.Add(dtpFechaV);
            groupBox1.Controls.Add(label26);
            groupBox1.Controls.Add(label27);
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Blue;
            groupBox1.Location = new Point(761, 103);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(405, 457);
            groupBox1.TabIndex = 97;
            groupBox1.TabStop = false;
            // 
            // txtCliente
            // 
            txtCliente.BorderStyle = BorderStyle.FixedSingle;
            txtCliente.Cursor = Cursors.IBeam;
            txtCliente.Enabled = false;
            txtCliente.Font = new Font("Microsoft Sans Serif", 11.25F);
            txtCliente.Location = new Point(112, 190);
            txtCliente.Margin = new Padding(5);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(278, 24);
            txtCliente.TabIndex = 131;
            txtCliente.TextChanged += txtCliente_TextChanged;
            // 
            // lbnProductos
            // 
            lbnProductos.AutoSize = true;
            lbnProductos.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbnProductos.ForeColor = Color.FromArgb(64, 64, 64);
            lbnProductos.Location = new Point(112, 160);
            lbnProductos.Margin = new Padding(5, 0, 5, 0);
            lbnProductos.Name = "lbnProductos";
            lbnProductos.Size = new Size(194, 18);
            lbnProductos.TabIndex = 129;
            lbnProductos.Text = "No hay productos añadidos.";
            // 
            // nudIdP
            // 
            nudIdP.Enabled = false;
            nudIdP.Font = new Font("Microsoft Sans Serif", 11.25F);
            nudIdP.Location = new Point(112, 307);
            nudIdP.Margin = new Padding(4);
            nudIdP.Name = "nudIdP";
            nudIdP.ReadOnly = true;
            nudIdP.Size = new Size(278, 24);
            nudIdP.TabIndex = 122;
            // 
            // btnListaProducto
            // 
            btnListaProducto.BackColor = Color.Silver;
            btnListaProducto.Cursor = Cursors.Hand;
            btnListaProducto.FlatAppearance.BorderSize = 0;
            btnListaProducto.FlatStyle = FlatStyle.Flat;
            btnListaProducto.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            btnListaProducto.ForeColor = Color.Blue;
            btnListaProducto.Location = new Point(321, 157);
            btnListaProducto.Margin = new Padding(4);
            btnListaProducto.Name = "btnListaProducto";
            btnListaProducto.Size = new Size(69, 24);
            btnListaProducto.TabIndex = 128;
            btnListaProducto.Text = "+";
            btnListaProducto.UseVisualStyleBackColor = false;
            btnListaProducto.Visible = false;
            btnListaProducto.Click += btnProductos_Click;
            // 
            // cmbCliente
            // 
            cmbCliente.Cursor = Cursors.Hand;
            cmbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCliente.Enabled = false;
            cmbCliente.FlatStyle = FlatStyle.Flat;
            cmbCliente.Font = new Font("Microsoft Sans Serif", 11.25F);
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(112, 218);
            cmbCliente.Margin = new Padding(4);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(278, 26);
            cmbCliente.TabIndex = 119;
            // 
            // btnCliente
            // 
            btnCliente.AutoSize = true;
            btnCliente.Cursor = Cursors.Hand;
            btnCliente.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            btnCliente.ForeColor = Color.Blue;
            btnCliente.Location = new Point(8, 194);
            btnCliente.Margin = new Padding(5, 0, 5, 0);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(74, 16);
            btnCliente.TabIndex = 118;
            btnCliente.Text = "CLIENTE:";
            btnCliente.Click += btnCliente_Click;
            // 
            // btnProducto
            // 
            btnProducto.AutoSize = true;
            btnProducto.Cursor = Cursors.Hand;
            btnProducto.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            btnProducto.ForeColor = Color.Blue;
            btnProducto.Location = new Point(8, 162);
            btnProducto.Margin = new Padding(5, 0, 5, 0);
            btnProducto.Name = "btnProducto";
            btnProducto.Size = new Size(96, 16);
            btnProducto.TabIndex = 120;
            btnProducto.Text = "PRODUCTO:";
            btnProducto.Click += btnProducto_Click;
            // 
            // cmbEstado
            // 
            cmbEstado.Cursor = Cursors.Hand;
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.Enabled = false;
            cmbEstado.FlatStyle = FlatStyle.Flat;
            cmbEstado.Font = new Font("Microsoft Sans Serif", 11.25F);
            cmbEstado.Location = new Point(112, 252);
            cmbEstado.Margin = new Padding(4);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(278, 26);
            cmbEstado.TabIndex = 117;
            cmbEstado.SelectedIndexChanged += cmbEstado_SelectedIndexChanged;
            // 
            // txtImporteP
            // 
            txtImporteP.BorderStyle = BorderStyle.FixedSingle;
            txtImporteP.Cursor = Cursors.IBeam;
            txtImporteP.Enabled = false;
            txtImporteP.Font = new Font("Microsoft Sans Serif", 11.25F);
            txtImporteP.Location = new Point(112, 375);
            txtImporteP.Margin = new Padding(5);
            txtImporteP.Name = "txtImporteP";
            txtImporteP.Size = new Size(278, 24);
            txtImporteP.TabIndex = 20;
            txtImporteP.TextAlign = HorizontalAlignment.Right;
            // 
            // cmbCategoria
            // 
            cmbCategoria.Cursor = Cursors.Hand;
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.Enabled = false;
            cmbCategoria.FlatStyle = FlatStyle.Flat;
            cmbCategoria.Font = new Font("Microsoft Sans Serif", 11.25F);
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(112, 89);
            cmbCategoria.Margin = new Padding(4);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(278, 26);
            cmbCategoria.TabIndex = 116;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label17.ForeColor = Color.FromArgb(64, 64, 64);
            label17.Location = new Point(8, 311);
            label17.Margin = new Padding(5, 0, 5, 0);
            label17.Name = "label17";
            label17.Size = new Size(97, 16);
            label17.TabIndex = 16;
            label17.Text = "Identificador:";
            // 
            // nudIdV
            // 
            nudIdV.Enabled = false;
            nudIdV.Font = new Font("Microsoft Sans Serif", 11.25F);
            nudIdV.Location = new Point(112, 24);
            nudIdV.Margin = new Padding(4);
            nudIdV.Name = "nudIdV";
            nudIdV.ReadOnly = true;
            nudIdV.Size = new Size(278, 24);
            nudIdV.TabIndex = 17;
            // 
            // dtpFechaP
            // 
            dtpFechaP.Cursor = Cursors.Hand;
            dtpFechaP.Enabled = false;
            dtpFechaP.Font = new Font("Microsoft Sans Serif", 11.25F);
            dtpFechaP.Format = DateTimePickerFormat.Short;
            dtpFechaP.Location = new Point(112, 341);
            dtpFechaP.Margin = new Padding(5);
            dtpFechaP.Name = "dtpFechaP";
            dtpFechaP.Size = new Size(278, 24);
            dtpFechaP.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(8, 63);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(61, 16);
            label2.TabIndex = 4;
            label2.Text = "FECHA:";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Silver;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.Blue;
            btnCancelar.Location = new Point(91, 410);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(140, 35);
            btnCancelar.TabIndex = 115;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Visible = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label18.ForeColor = Color.Black;
            label18.Location = new Point(8, 379);
            label18.Margin = new Padding(5, 0, 5, 0);
            label18.Name = "label18";
            label18.Size = new Size(79, 16);
            label18.TabIndex = 7;
            label18.Text = "IMPORTE:";
            // 
            // btnCategoria
            // 
            btnCategoria.AutoSize = true;
            btnCategoria.Cursor = Cursors.Hand;
            btnCategoria.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            btnCategoria.ForeColor = Color.Blue;
            btnCategoria.Location = new Point(8, 94);
            btnCategoria.Margin = new Padding(5, 0, 5, 0);
            btnCategoria.Name = "btnCategoria";
            btnCategoria.Size = new Size(98, 16);
            btnCategoria.TabIndex = 5;
            btnCategoria.Text = "CATEGORíA:";
            btnCategoria.Click += btnCategoria_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Silver;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.Blue;
            btnGuardar.Location = new Point(250, 410);
            btnGuardar.Margin = new Padding(4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(140, 35);
            btnGuardar.TabIndex = 114;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Visible = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(8, 348);
            label12.Margin = new Padding(5, 0, 5, 0);
            label12.Name = "label12";
            label12.Size = new Size(61, 16);
            label12.TabIndex = 25;
            label12.Text = "FECHA:";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label25.ForeColor = Color.Black;
            label25.Location = new Point(8, 128);
            label25.Margin = new Padding(5, 0, 5, 0);
            label25.Name = "label25";
            label25.Size = new Size(79, 16);
            label25.TabIndex = 6;
            label25.Text = "IMPORTE:";
            // 
            // txtImporteV
            // 
            txtImporteV.BorderStyle = BorderStyle.FixedSingle;
            txtImporteV.Cursor = Cursors.IBeam;
            txtImporteV.Enabled = false;
            txtImporteV.Font = new Font("Microsoft Sans Serif", 11.25F);
            txtImporteV.Location = new Point(112, 124);
            txtImporteV.Margin = new Padding(5);
            txtImporteV.Name = "txtImporteV";
            txtImporteV.Size = new Size(278, 24);
            txtImporteV.TabIndex = 8;
            txtImporteV.TextAlign = HorizontalAlignment.Right;
            txtImporteV.TextChanged += txtImporteV_TextChanged;
            // 
            // dtpFechaV
            // 
            dtpFechaV.Cursor = Cursors.Hand;
            dtpFechaV.Enabled = false;
            dtpFechaV.Font = new Font("Microsoft Sans Serif", 11.25F);
            dtpFechaV.Format = DateTimePickerFormat.Short;
            dtpFechaV.Location = new Point(112, 56);
            dtpFechaV.Margin = new Padding(5);
            dtpFechaV.Name = "dtpFechaV";
            dtpFechaV.Size = new Size(278, 24);
            dtpFechaV.TabIndex = 10;
            dtpFechaV.ValueChanged += dtpFechaV_ValueChanged;
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
            label27.Location = new Point(8, 257);
            label27.Margin = new Padding(5, 0, 5, 0);
            label27.Name = "label27";
            label27.Size = new Size(73, 16);
            label27.TabIndex = 46;
            label27.Text = "ESTADO:";
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
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvListadoPago.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvListadoPago.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListadoPago.Cursor = Cursors.Hand;
            dgvListadoPago.EnableHeadersVisualStyles = false;
            dgvListadoPago.Location = new Point(13, 438);
            dgvListadoPago.Margin = new Padding(4);
            dgvListadoPago.MultiSelect = false;
            dgvListadoPago.Name = "dgvListadoPago";
            dgvListadoPago.ReadOnly = true;
            dgvListadoPago.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvListadoPago.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvListadoPago.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListadoPago.Size = new Size(342, 122);
            dgvListadoPago.TabIndex = 121;
            dgvListadoPago.CellClick += dgvListadoPago_CellClick;
            dgvListadoPago.Enter += dgvListadoPago_Enter;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Controls.Add(txtBuscarCliente);
            groupBox3.Controls.Add(cmbBuscarMes);
            groupBox3.Controls.Add(chkIncluirFecha);
            groupBox3.Controls.Add(cmbBuscarEstado);
            groupBox3.Controls.Add(label20);
            groupBox3.Controls.Add(cmbBuscarCliente);
            groupBox3.Controls.Add(nudBuscarAnio);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(cmbBuscarCategoria);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(label14);
            groupBox3.FlatStyle = FlatStyle.Flat;
            groupBox3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ImeMode = ImeMode.NoControl;
            groupBox3.Location = new Point(13, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(681, 113);
            groupBox3.TabIndex = 124;
            groupBox3.TabStop = false;
            // 
            // txtBuscarCliente
            // 
            txtBuscarCliente.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarCliente.Cursor = Cursors.IBeam;
            txtBuscarCliente.Font = new Font("Microsoft Sans Serif", 11.25F);
            txtBuscarCliente.Location = new Point(121, 53);
            txtBuscarCliente.Margin = new Padding(5);
            txtBuscarCliente.Name = "txtBuscarCliente";
            txtBuscarCliente.Size = new Size(219, 24);
            txtBuscarCliente.TabIndex = 130;
            txtBuscarCliente.TextChanged += txtBuscarCliente_TextChanged;
            // 
            // cmbBuscarMes
            // 
            cmbBuscarMes.Cursor = Cursors.Hand;
            cmbBuscarMes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBuscarMes.FlatStyle = FlatStyle.Flat;
            cmbBuscarMes.Font = new Font("Microsoft Sans Serif", 11.25F);
            cmbBuscarMes.Location = new Point(439, 52);
            cmbBuscarMes.Margin = new Padding(4);
            cmbBuscarMes.Name = "cmbBuscarMes";
            cmbBuscarMes.Size = new Size(136, 26);
            cmbBuscarMes.TabIndex = 130;
            // 
            // chkIncluirFecha
            // 
            chkIncluirFecha.AutoSize = true;
            chkIncluirFecha.Location = new Point(583, 80);
            chkIncluirFecha.Name = "chkIncluirFecha";
            chkIncluirFecha.Size = new Size(72, 22);
            chkIncluirFecha.TabIndex = 47;
            chkIncluirFecha.Text = "Incluir";
            chkIncluirFecha.UseVisualStyleBackColor = true;
            // 
            // cmbBuscarEstado
            // 
            cmbBuscarEstado.Cursor = Cursors.Hand;
            cmbBuscarEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBuscarEstado.FlatStyle = FlatStyle.Flat;
            cmbBuscarEstado.Font = new Font("Microsoft Sans Serif", 11.25F);
            cmbBuscarEstado.FormattingEnabled = true;
            cmbBuscarEstado.Location = new Point(439, 22);
            cmbBuscarEstado.Name = "cmbBuscarEstado";
            cmbBuscarEstado.Size = new Size(219, 26);
            cmbBuscarEstado.TabIndex = 46;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label20.ForeColor = Color.Black;
            label20.Location = new Point(358, 27);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(73, 16);
            label20.TabIndex = 45;
            label20.Text = "ESTADO:";
            // 
            // cmbBuscarCliente
            // 
            cmbBuscarCliente.Cursor = Cursors.Hand;
            cmbBuscarCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBuscarCliente.FlatStyle = FlatStyle.Flat;
            cmbBuscarCliente.Font = new Font("Microsoft Sans Serif", 11.25F);
            cmbBuscarCliente.FormattingEnabled = true;
            cmbBuscarCliente.Location = new Point(121, 80);
            cmbBuscarCliente.Name = "cmbBuscarCliente";
            cmbBuscarCliente.Size = new Size(220, 26);
            cmbBuscarCliente.TabIndex = 44;
            // 
            // nudBuscarAnio
            // 
            nudBuscarAnio.BorderStyle = BorderStyle.FixedSingle;
            nudBuscarAnio.Cursor = Cursors.Hand;
            nudBuscarAnio.Font = new Font("Microsoft Sans Serif", 11.25F);
            nudBuscarAnio.Location = new Point(583, 52);
            nudBuscarAnio.Margin = new Padding(4);
            nudBuscarAnio.Name = "nudBuscarAnio";
            nudBuscarAnio.Size = new Size(75, 24);
            nudBuscarAnio.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(11, 25);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(98, 16);
            label11.TabIndex = 40;
            label11.Text = "CATEGORÍA:";
            // 
            // cmbBuscarCategoria
            // 
            cmbBuscarCategoria.Cursor = Cursors.Hand;
            cmbBuscarCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBuscarCategoria.FlatStyle = FlatStyle.Flat;
            cmbBuscarCategoria.Font = new Font("Microsoft Sans Serif", 11.25F);
            cmbBuscarCategoria.FormattingEnabled = true;
            cmbBuscarCategoria.Location = new Point(122, 22);
            cmbBuscarCategoria.Name = "cmbBuscarCategoria";
            cmbBuscarCategoria.Size = new Size(219, 26);
            cmbBuscarCategoria.TabIndex = 39;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(358, 57);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(61, 16);
            label15.TabIndex = 41;
            label15.Text = "FECHA:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(13, 57);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(74, 16);
            label14.TabIndex = 36;
            label14.Text = "CLIENTE:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Blue;
            label9.Location = new Point(13, 374);
            label9.Name = "label9";
            label9.Size = new Size(461, 16);
            label9.TabIndex = 123;
            label9.Text = "* Haz clic sobre un registro para visualizar los pagos y productos asociados.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Black", 11.25F, FontStyle.Bold | FontStyle.Underline);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(372, 412);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(343, 22);
            label5.TabIndex = 122;
            label5.Text = "HISTORIAL DE PRODUCTOS VENDIDOS:";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Silver;
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.Black;
            btnLimpiar.Location = new Point(708, 61);
            btnLimpiar.Margin = new Padding(4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(140, 35);
            btnLimpiar.TabIndex = 52;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Silver;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.Black;
            btnBuscar.Location = new Point(708, 20);
            btnBuscar.Margin = new Padding(4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(140, 35);
            btnBuscar.TabIndex = 39;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvListadoVenta
            // 
            dgvListadoVenta.AllowUserToAddRows = false;
            dgvListadoVenta.AllowUserToDeleteRows = false;
            dgvListadoVenta.AllowUserToResizeColumns = false;
            dgvListadoVenta.AllowUserToResizeRows = false;
            dgvListadoVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListadoVenta.BackgroundColor = Color.Silver;
            dgvListadoVenta.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvListadoVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvListadoVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListadoVenta.Cursor = Cursors.Hand;
            dgvListadoVenta.EnableHeadersVisualStyles = false;
            dgvListadoVenta.Location = new Point(12, 154);
            dgvListadoVenta.Margin = new Padding(4);
            dgvListadoVenta.MultiSelect = false;
            dgvListadoVenta.Name = "dgvListadoVenta";
            dgvListadoVenta.ReadOnly = true;
            dgvListadoVenta.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvListadoVenta.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvListadoVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListadoVenta.Size = new Size(742, 216);
            dgvListadoVenta.TabIndex = 27;
            dgvListadoVenta.CellClick += dgvListadoVenta_CellClick;
            dgvListadoVenta.RowPrePaint += dgvListadoVenta_RowPrePaint;
            dgvListadoVenta.Enter += dgvListadoVenta_Enter;
            // 
            // lbnMensajeEstado
            // 
            lbnMensajeEstado.AutoSize = true;
            lbnMensajeEstado.BackColor = Color.Transparent;
            lbnMensajeEstado.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbnMensajeEstado.ForeColor = Color.FromArgb(247, 248, 252);
            lbnMensajeEstado.Location = new Point(13, 128);
            lbnMensajeEstado.Margin = new Padding(4, 0, 4, 0);
            lbnMensajeEstado.Name = "lbnMensajeEstado";
            lbnMensajeEstado.Padding = new Padding(2);
            lbnMensajeEstado.Size = new Size(90, 22);
            lbnMensajeEstado.TabIndex = 125;
            lbnMensajeEstado.Text = "MENSAJE";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Black", 11.25F, FontStyle.Bold | FontStyle.Underline);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(13, 412);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(200, 22);
            label8.TabIndex = 94;
            label8.Text = "HISTORIAL DE PAGOS:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(909, 61);
            label1.Name = "label1";
            label1.Size = new Size(257, 16);
            label1.TabIndex = 126;
            label1.Text = " * Si la venta está 'PAGADA', los datos del";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(920, 77);
            label3.Name = "label3";
            label3.Size = new Size(218, 16);
            label3.TabIndex = 127;
            label3.Text = "pago coinciden con los de la venta.";
            // 
            // frmVenta
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 248, 252);
            ClientSize = new Size(1188, 674);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(lbnMensajeEstado);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBuscar);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(txtTotalMesActual);
            Controls.Add(dgvListadoVenta);
            Controls.Add(label9);
            Controls.Add(label5);
            Controls.Add(txtListadoTotalCoincidencia);
            Controls.Add(btnNuevo);
            Controls.Add(dgvListadoProducto);
            Controls.Add(label6);
            Controls.Add(txtListadoTotalPago);
            Controls.Add(txtListadoTotalImporte);
            Controls.Add(dgvListadoPago);
            Controls.Add(btnEditar);
            Controls.Add(label8);
            Controls.Add(btnNuevoPago);
            Controls.Add(lbnTotalMesActual);
            Controls.Add(lbnTotalMesAnterior);
            Controls.Add(btnEliminar);
            Controls.Add(label16);
            Controls.Add(txtTotalMesAnterior);
            Controls.Add(label19);
            Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "frmVenta";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += frmVenta_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListadoProducto).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudIdP).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudIdV).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvListadoPago).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudBuscarAnio).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvListadoVenta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnNuevo;
        private Button btnEditar;
        private Button btnEliminar;
        private DataGridView dgvListadoProducto;
        private TextBox txtListadoTotalCoincidencia;
        private TextBox txtListadoTotalImporte;
        private Label label16;
        private Label label19;
        private TextBox txtTotalMesActual;
        private TextBox txtTotalMesAnterior;
        private Label lbnTotalMesAnterior;
        private Label lbnTotalMesActual;
        private Button btnNuevoPago;
        private TextBox txtListadoTotalPago;
        private Label label6;
        private NumericUpDown nudIdP;
        private GroupBox groupBox1;
        private ComboBox cmbEstado;
        private TextBox txtImporteP;
        private ComboBox cmbCategoria;
        private Label label17;
        private NumericUpDown nudIdV;
        private DateTimePicker dtpFechaP;
        private Label label2;
        private Button btnCancelar;
        private Label label18;
        private Label btnCategoria;
        private Button btnGuardar;
        private Label label12;
        private Label label25;
        private TextBox txtImporteV;
        private DateTimePicker dtpFechaV;
        private Label label26;
        private Label label27;
        private ComboBox cmbCliente;
        private Label btnCliente;
        private DataGridView dgvListadoPago;
        private Label btnProducto;
        private Button btnLimpiar;
        private Button btnBuscar;
        private Label lbnMensajeEstado;
        private DataGridView dgvListadoVenta;
        private Label label5;
        private Label label9;
        private GroupBox groupBox3;
        private ComboBox cmbBuscarCliente;
        private NumericUpDown nudBuscarAnio;
        private Label label15;
        private Label label11;
        private ComboBox cmbBuscarCategoria;
        private Label label14;
        private ComboBox cmbBuscarEstado;
        private Label label20;
        private CheckBox chkIncluirFecha;
        private SplitContainer splitContainer1;
        private Label label8;
        private Button btnFiltro;
        private Panel pnlFiltro;
        private Button btnAplicarFiltro;
        private CheckedListBox clbColumnas;
        private Label label1;
        private Label label3;
        private Button btnListaProducto;
        private Label lbnProductos;
        private ComboBox cmbBuscarMes;
        private TextBox txtBuscarCliente;
        private TextBox txtCliente;
    }
}