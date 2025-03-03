namespace CapaPresentacion
{
    partial class frmGastoGeneral
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            btnCancelar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            label1 = new Label();
            label2 = new Label();
            btnCategoria = new Label();
            label4 = new Label();
            txtImporte = new TextBox();
            txtConcepto = new TextBox();
            dtpFecha = new DateTimePicker();
            cmbCategoria = new ComboBox();
            btnEditar = new Button();
            btnEliminar = new Button();
            dgvListado = new DataGridView();
            label5 = new Label();
            nudId = new NumericUpDown();
            txtBuscarConcepto = new TextBox();
            groupBox1 = new GroupBox();
            btnBuscar = new Button();
            groupBox2 = new GroupBox();
            cmbBuscarMes = new ComboBox();
            nudBuscarAnio = new NumericUpDown();
            label15 = new Label();
            label16 = new Label();
            cmbBuscarCategoria = new ComboBox();
            label6 = new Label();
            lbnTotalMesActual = new Label();
            lbnTotalMesAnterior = new Label();
            btnLimpiar = new Button();
            txtListadoTotalCoincidencia = new TextBox();
            txtListadoTotalImporte = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtTotalMesAnterior = new TextBox();
            txtTotalMesActual = new TextBox();
            label17 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvListado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudId).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudBuscarAnio).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Silver;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.Blue;
            btnCancelar.Location = new Point(116, 324);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(140, 35);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Visible = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Silver;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.Blue;
            btnGuardar.Location = new Point(264, 324);
            btnGuardar.Margin = new Padding(4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(140, 35);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Visible = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.Silver;
            btnNuevo.BackgroundImageLayout = ImageLayout.Zoom;
            btnNuevo.Cursor = Cursors.Hand;
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            btnNuevo.ForeColor = Color.Blue;
            btnNuevo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevo.Location = new Point(12, 628);
            btnNuevo.Margin = new Padding(4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(140, 35);
            btnNuevo.TabIndex = 3;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 85);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 16);
            label1.TabIndex = 4;
            label1.Text = "FECHA:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 124);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(79, 16);
            label2.TabIndex = 5;
            label2.Text = "IMPORTE:";
            // 
            // btnCategoria
            // 
            btnCategoria.AutoSize = true;
            btnCategoria.Cursor = Cursors.Hand;
            btnCategoria.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            btnCategoria.ForeColor = Color.Blue;
            btnCategoria.Location = new Point(12, 165);
            btnCategoria.Margin = new Padding(4, 0, 4, 0);
            btnCategoria.Name = "btnCategoria";
            btnCategoria.Size = new Size(98, 16);
            btnCategoria.TabIndex = 6;
            btnCategoria.Text = "CATEGORÍA:";
            btnCategoria.Click += btnCategoria_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(12, 202);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(94, 16);
            label4.TabIndex = 7;
            label4.Text = "CONCEPTO:";
            // 
            // txtImporte
            // 
            txtImporte.BorderStyle = BorderStyle.FixedSingle;
            txtImporte.Cursor = Cursors.IBeam;
            txtImporte.Enabled = false;
            txtImporte.Font = new Font("Microsoft Sans Serif", 11.25F);
            txtImporte.Location = new Point(126, 122);
            txtImporte.Margin = new Padding(4);
            txtImporte.Name = "txtImporte";
            txtImporte.Size = new Size(278, 24);
            txtImporte.TabIndex = 8;
            txtImporte.TextAlign = HorizontalAlignment.Right;
            // 
            // txtConcepto
            // 
            txtConcepto.BorderStyle = BorderStyle.FixedSingle;
            txtConcepto.Cursor = Cursors.IBeam;
            txtConcepto.Enabled = false;
            txtConcepto.Font = new Font("Microsoft Sans Serif", 11.25F);
            txtConcepto.Location = new Point(126, 200);
            txtConcepto.Margin = new Padding(4);
            txtConcepto.Multiline = true;
            txtConcepto.Name = "txtConcepto";
            txtConcepto.Size = new Size(278, 105);
            txtConcepto.TabIndex = 9;
            // 
            // dtpFecha
            // 
            dtpFecha.Cursor = Cursors.Hand;
            dtpFecha.Enabled = false;
            dtpFecha.Font = new Font("Microsoft Sans Serif", 11.25F);
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(126, 80);
            dtpFecha.Margin = new Padding(4);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(278, 24);
            dtpFecha.TabIndex = 10;
            // 
            // cmbCategoria
            // 
            cmbCategoria.Cursor = Cursors.Hand;
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.Enabled = false;
            cmbCategoria.FlatStyle = FlatStyle.Flat;
            cmbCategoria.Font = new Font("Microsoft Sans Serif", 11.25F);
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(126, 160);
            cmbCategoria.Margin = new Padding(4);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(278, 26);
            cmbCategoria.TabIndex = 11;
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
            btnEditar.TabIndex = 12;
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
            btnEliminar.Location = new Point(603, 628);
            btnEliminar.Margin = new Padding(4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(140, 35);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvListado
            // 
            dgvListado.AllowUserToAddRows = false;
            dgvListado.AllowUserToDeleteRows = false;
            dgvListado.AllowUserToResizeColumns = false;
            dgvListado.AllowUserToResizeRows = false;
            dgvListado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListado.BackgroundColor = Color.Silver;
            dgvListado.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvListado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListado.Cursor = Cursors.Hand;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvListado.DefaultCellStyle = dataGridViewCellStyle6;
            dgvListado.EnableHeadersVisualStyles = false;
            dgvListado.Location = new Point(12, 108);
            dgvListado.Margin = new Padding(4);
            dgvListado.MultiSelect = false;
            dgvListado.Name = "dgvListado";
            dgvListado.ReadOnly = true;
            dgvListado.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvListado.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvListado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListado.Size = new Size(731, 478);
            dgvListado.TabIndex = 14;
            dgvListado.CellClick += dgvListado_CellClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(12, 46);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(97, 16);
            label5.TabIndex = 16;
            label5.Text = "Identificador:";
            // 
            // nudId
            // 
            nudId.Enabled = false;
            nudId.Font = new Font("Microsoft Sans Serif", 11.25F);
            nudId.Location = new Point(126, 44);
            nudId.Margin = new Padding(4);
            nudId.Name = "nudId";
            nudId.Size = new Size(278, 24);
            nudId.TabIndex = 17;
            // 
            // txtBuscarConcepto
            // 
            txtBuscarConcepto.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarConcepto.Cursor = Cursors.IBeam;
            txtBuscarConcepto.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtBuscarConcepto.Location = new Point(115, 55);
            txtBuscarConcepto.Margin = new Padding(4);
            txtBuscarConcepto.Name = "txtBuscarConcepto";
            txtBuscarConcepto.Size = new Size(219, 22);
            txtBuscarConcepto.TabIndex = 18;
            txtBuscarConcepto.TextChanged += txtBuscarConcepto_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(nudId);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cmbCategoria);
            groupBox1.Controls.Add(dtpFecha);
            groupBox1.Controls.Add(txtConcepto);
            groupBox1.Controls.Add(txtImporte);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnCategoria);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ImeMode = ImeMode.NoControl;
            groupBox1.Location = new Point(750, 99);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(420, 376);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
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
            btnBuscar.Location = new Point(603, 17);
            btnBuscar.Margin = new Padding(4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(140, 35);
            btnBuscar.TabIndex = 27;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(cmbBuscarMes);
            groupBox2.Controls.Add(nudBuscarAnio);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(cmbBuscarCategoria);
            groupBox2.Controls.Add(txtBuscarConcepto);
            groupBox2.Controls.Add(label6);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ImeMode = ImeMode.NoControl;
            groupBox2.Location = new Point(12, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(584, 97);
            groupBox2.TabIndex = 27;
            groupBox2.TabStop = false;
            // 
            // cmbBuscarMes
            // 
            cmbBuscarMes.Cursor = Cursors.Hand;
            cmbBuscarMes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBuscarMes.FlatStyle = FlatStyle.Flat;
            cmbBuscarMes.Font = new Font("Microsoft Sans Serif", 11.25F);
            cmbBuscarMes.Location = new Point(428, 21);
            cmbBuscarMes.Margin = new Padding(4);
            cmbBuscarMes.Name = "cmbBuscarMes";
            cmbBuscarMes.Size = new Size(136, 26);
            cmbBuscarMes.TabIndex = 131;
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
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label16.ForeColor = Color.Black;
            label16.Location = new Point(11, 25);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(98, 16);
            label16.TabIndex = 40;
            label16.Text = "CATEGORÍA:";
            // 
            // cmbBuscarCategoria
            // 
            cmbBuscarCategoria.Cursor = Cursors.Hand;
            cmbBuscarCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBuscarCategoria.FlatStyle = FlatStyle.Flat;
            cmbBuscarCategoria.Font = new Font("Microsoft Sans Serif", 9.75F);
            cmbBuscarCategoria.FormattingEnabled = true;
            cmbBuscarCategoria.Location = new Point(115, 23);
            cmbBuscarCategoria.Name = "cmbBuscarCategoria";
            cmbBuscarCategoria.Size = new Size(219, 24);
            cmbBuscarCategoria.TabIndex = 39;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(11, 57);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(94, 16);
            label6.TabIndex = 36;
            label6.Text = "CONCEPTO:";
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
            lbnTotalMesActual.TabIndex = 29;
            lbnTotalMesActual.Text = "TOTAL MM:";
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
            lbnTotalMesAnterior.TabIndex = 30;
            lbnTotalMesAnterior.Text = "TOTAL MM:";
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
            btnLimpiar.Location = new Point(603, 65);
            btnLimpiar.Margin = new Padding(4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(140, 35);
            btnLimpiar.TabIndex = 31;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtListadoTotalCoincidencia
            // 
            txtListadoTotalCoincidencia.BorderStyle = BorderStyle.FixedSingle;
            txtListadoTotalCoincidencia.Enabled = false;
            txtListadoTotalCoincidencia.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtListadoTotalCoincidencia.ForeColor = Color.Black;
            txtListadoTotalCoincidencia.Location = new Point(146, 596);
            txtListadoTotalCoincidencia.Margin = new Padding(4);
            txtListadoTotalCoincidencia.Name = "txtListadoTotalCoincidencia";
            txtListadoTotalCoincidencia.Size = new Size(130, 24);
            txtListadoTotalCoincidencia.TabIndex = 60;
            txtListadoTotalCoincidencia.TextAlign = HorizontalAlignment.Right;
            // 
            // txtListadoTotalImporte
            // 
            txtListadoTotalImporte.BorderStyle = BorderStyle.FixedSingle;
            txtListadoTotalImporte.Enabled = false;
            txtListadoTotalImporte.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtListadoTotalImporte.ForeColor = Color.Black;
            txtListadoTotalImporte.Location = new Point(436, 596);
            txtListadoTotalImporte.Margin = new Padding(4);
            txtListadoTotalImporte.Name = "txtListadoTotalImporte";
            txtListadoTotalImporte.Size = new Size(307, 24);
            txtListadoTotalImporte.TabIndex = 58;
            txtListadoTotalImporte.TextAlign = HorizontalAlignment.Right;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Underline);
            label7.Location = new Point(298, 598);
            label7.Name = "label7";
            label7.Size = new Size(132, 16);
            label7.TabIndex = 59;
            label7.Text = "IMPORTE TOTAL:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Underline);
            label8.Location = new Point(12, 598);
            label8.Name = "label8";
            label8.Size = new Size(127, 16);
            label8.TabIndex = 57;
            label8.Text = "COINCIDENCIAS:";
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
            txtTotalMesAnterior.Size = new Size(232, 24);
            txtTotalMesAnterior.TabIndex = 62;
            txtTotalMesAnterior.TextAlign = HorizontalAlignment.Right;
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
            txtTotalMesActual.Size = new Size(232, 24);
            txtTotalMesActual.TabIndex = 63;
            txtTotalMesActual.TextAlign = HorizontalAlignment.Right;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.Blue;
            label17.Location = new Point(938, 627);
            label17.Name = "label17";
            label17.Size = new Size(196, 16);
            label17.TabIndex = 64;
            label17.Text = "* Incluye gastos a proveedores.";
            // 
            // frmGastoGeneral
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(247, 248, 252);
            ClientSize = new Size(1188, 674);
            Controls.Add(label17);
            Controls.Add(txtTotalMesActual);
            Controls.Add(txtTotalMesAnterior);
            Controls.Add(txtListadoTotalCoincidencia);
            Controls.Add(txtListadoTotalImporte);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(btnLimpiar);
            Controls.Add(lbnTotalMesAnterior);
            Controls.Add(lbnTotalMesActual);
            Controls.Add(btnBuscar);
            Controls.Add(groupBox1);
            Controls.Add(dgvListado);
            Controls.Add(btnEditar);
            Controls.Add(btnNuevo);
            Controls.Add(btnEliminar);
            Controls.Add(groupBox2);
            Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "frmGastoGeneral";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmGastoGeneral_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListado).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudId).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudBuscarAnio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCancelar;
        private Button btnGuardar;
        private Button btnNuevo;
        private Label label1;
        private Label label2;
        private Label btnCategoria;
        private Label label4;
        private TextBox txtImporte;
        private TextBox txtConcepto;
        private DateTimePicker dtpFecha;
        private ComboBox cmbCategoria;
        private Button btnEditar;
        private Button btnEliminar;
        private DataGridView dgvListado;
        private Label label5;
        private NumericUpDown nudId;
        private TextBox txtBuscarConcepto;
        private GroupBox groupBox1;
        private Button btnBuscar;
        private GroupBox groupBox2;
        private Label label6;
        private Label lbnTotalMesActual;
        private Label lbnTotalMesAnterior;
        private Label label16;
        private ComboBox cmbBuscarCategoria;
        private Button btnLimpiar;
        private TextBox txtListadoTotalCoincidencia;
        private TextBox txtListadoTotalImporte;
        private Label label7;
        private Label label8;
        private TextBox txtTotalMesAnterior;
        private TextBox txtTotalMesActual;
        private Label label15;
        private Label label17;
        private NumericUpDown nudBuscarAnio;
        private ComboBox cmbBuscarMes;
    }
}
