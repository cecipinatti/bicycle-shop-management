namespace CapaPresentacion
{
    partial class frmLista
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            nudId = new NumericUpDown();
            label6 = new Label();
            txtDescripcion = new TextBox();
            label3 = new Label();
            txtRutaArchivo = new TextBox();
            label1 = new Label();
            nudPorcentaje = new NumericUpDown();
            cmbProveedor = new ComboBox();
            label13 = new Label();
            btnCancelar = new Button();
            btnProveedor = new Label();
            btnGuardar = new Button();
            label25 = new Label();
            dtpFecha = new DateTimePicker();
            btnSeleccionarArchivo = new Button();
            label17 = new Label();
            dgvListadoProducto = new DataGridView();
            label2 = new Label();
            btnNuevaLista = new Button();
            btnActualizarLista = new Button();
            dgvListadoLista = new DataGridView();
            btnEliminarLista = new Button();
            label4 = new Label();
            btnAceptar = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label5 = new Label();
            cmbBuscarEstado = new ComboBox();
            btnRestaurarLista = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPorcentaje).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvListadoProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvListadoLista).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(nudId);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtRutaArchivo);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(nudPorcentaje);
            groupBox1.Controls.Add(cmbProveedor);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnProveedor);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(label25);
            groupBox1.Controls.Add(dtpFecha);
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Blue;
            groupBox1.Location = new Point(468, 95);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(426, 297);
            groupBox1.TabIndex = 53;
            groupBox1.TabStop = false;
            // 
            // nudId
            // 
            nudId.Enabled = false;
            nudId.Font = new Font("Microsoft Sans Serif", 11.25F);
            nudId.Location = new Point(130, 28);
            nudId.Margin = new Padding(4);
            nudId.Name = "nudId";
            nudId.Size = new Size(280, 24);
            nudId.TabIndex = 139;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(11, 32);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(97, 16);
            label6.TabIndex = 138;
            label6.Text = "Identificador:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Enabled = false;
            txtDescripcion.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescripcion.Location = new Point(130, 95);
            txtDescripcion.Margin = new Padding(5);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.ScrollBars = ScrollBars.Horizontal;
            txtDescripcion.Size = new Size(280, 24);
            txtDescripcion.TabIndex = 135;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(10, 97);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(113, 16);
            label3.TabIndex = 135;
            label3.Text = "DESCRIPCIÓN:";
            // 
            // txtRutaArchivo
            // 
            txtRutaArchivo.BorderStyle = BorderStyle.FixedSingle;
            txtRutaArchivo.Enabled = false;
            txtRutaArchivo.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRutaArchivo.Location = new Point(130, 61);
            txtRutaArchivo.Margin = new Padding(5);
            txtRutaArchivo.Name = "txtRutaArchivo";
            txtRutaArchivo.ReadOnly = true;
            txtRutaArchivo.Size = new Size(280, 24);
            txtRutaArchivo.TabIndex = 118;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(11, 63);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 16);
            label1.TabIndex = 117;
            label1.Text = "ARCHIVO:";
            // 
            // nudPorcentaje
            // 
            nudPorcentaje.Enabled = false;
            nudPorcentaje.Font = new Font("Microsoft Sans Serif", 11.25F);
            nudPorcentaje.Location = new Point(130, 197);
            nudPorcentaje.Margin = new Padding(4);
            nudPorcentaje.Name = "nudPorcentaje";
            nudPorcentaje.Size = new Size(280, 24);
            nudPorcentaje.TabIndex = 54;
            // 
            // cmbProveedor
            // 
            cmbProveedor.Cursor = Cursors.Hand;
            cmbProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProveedor.Enabled = false;
            cmbProveedor.FlatStyle = FlatStyle.Flat;
            cmbProveedor.Font = new Font("Microsoft Sans Serif", 11.25F);
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Location = new Point(130, 160);
            cmbProveedor.Margin = new Padding(4);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(278, 26);
            cmbProveedor.TabIndex = 116;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(10, 132);
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
            btnCancelar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.Blue;
            btnCancelar.Location = new Point(115, 245);
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
            btnProveedor.Location = new Point(11, 165);
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
            btnGuardar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.Blue;
            btnGuardar.Location = new Point(270, 245);
            btnGuardar.Margin = new Padding(4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(140, 35);
            btnGuardar.TabIndex = 134;
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
            label25.Location = new Point(11, 201);
            label25.Margin = new Padding(5, 0, 5, 0);
            label25.Name = "label25";
            label25.Size = new Size(112, 16);
            label25.TabIndex = 6;
            label25.Text = "PORCENTAJE:";
            // 
            // dtpFecha
            // 
            dtpFecha.Cursor = Cursors.Hand;
            dtpFecha.Enabled = false;
            dtpFecha.Font = new Font("Microsoft Sans Serif", 11.25F);
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(130, 125);
            dtpFecha.Margin = new Padding(5);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(278, 24);
            dtpFecha.TabIndex = 10;
            // 
            // btnSeleccionarArchivo
            // 
            btnSeleccionarArchivo.BackColor = Color.Silver;
            btnSeleccionarArchivo.Cursor = Cursors.Hand;
            btnSeleccionarArchivo.Enabled = false;
            btnSeleccionarArchivo.FlatAppearance.BorderSize = 0;
            btnSeleccionarArchivo.FlatStyle = FlatStyle.Flat;
            btnSeleccionarArchivo.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnSeleccionarArchivo.ForeColor = Color.Blue;
            btnSeleccionarArchivo.Location = new Point(468, 65);
            btnSeleccionarArchivo.Margin = new Padding(4);
            btnSeleccionarArchivo.Name = "btnSeleccionarArchivo";
            btnSeleccionarArchivo.Size = new Size(156, 35);
            btnSeleccionarArchivo.TabIndex = 119;
            btnSeleccionarArchivo.Text = "Seleccionar archivo";
            btnSeleccionarArchivo.UseVisualStyleBackColor = false;
            btnSeleccionarArchivo.Click += btnSeleccionarArchivo_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 9.75F);
            label17.ForeColor = Color.DarkRed;
            label17.Location = new Point(172, 90);
            label17.Name = "label17";
            label17.RightToLeft = RightToLeft.Yes;
            label17.Size = new Size(289, 32);
            label17.TabIndex = 65;
            label17.Text = "Si el archivo es de tipo Excel (.xlsx), conviértelo \r\n.a formato de texto / Documento Unicode (.txt)";
            // 
            // dgvListadoProducto
            // 
            dgvListadoProducto.AllowUserToAddRows = false;
            dgvListadoProducto.AllowUserToDeleteRows = false;
            dgvListadoProducto.AllowUserToResizeColumns = false;
            dgvListadoProducto.AllowUserToResizeRows = false;
            dgvListadoProducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListadoProducto.BackgroundColor = Color.Silver;
            dgvListadoProducto.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvListadoProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvListadoProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListadoProducto.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvListadoProducto.DefaultCellStyle = dataGridViewCellStyle2;
            dgvListadoProducto.EnableHeadersVisualStyles = false;
            dgvListadoProducto.Location = new Point(16, 438);
            dgvListadoProducto.Margin = new Padding(4);
            dgvListadoProducto.MultiSelect = false;
            dgvListadoProducto.Name = "dgvListadoProducto";
            dgvListadoProducto.ReadOnly = true;
            dgvListadoProducto.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvListadoProducto.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvListadoProducto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListadoProducto.Size = new Size(878, 144);
            dgvListadoProducto.TabIndex = 135;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(351, 65);
            label2.Name = "label2";
            label2.Size = new Size(110, 16);
            label2.TabIndex = 136;
            label2.Text = "IMPORTANTE:";
            // 
            // btnNuevaLista
            // 
            btnNuevaLista.BackColor = Color.Silver;
            btnNuevaLista.Cursor = Cursors.Hand;
            btnNuevaLista.FlatAppearance.BorderSize = 0;
            btnNuevaLista.FlatStyle = FlatStyle.Flat;
            btnNuevaLista.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnNuevaLista.ForeColor = Color.Blue;
            btnNuevaLista.Location = new Point(16, 65);
            btnNuevaLista.Margin = new Padding(4);
            btnNuevaLista.Name = "btnNuevaLista";
            btnNuevaLista.Size = new Size(140, 35);
            btnNuevaLista.TabIndex = 135;
            btnNuevaLista.Text = "Nueva lista";
            btnNuevaLista.UseVisualStyleBackColor = false;
            btnNuevaLista.Click += btnNuevaLista_Click;
            // 
            // btnActualizarLista
            // 
            btnActualizarLista.BackColor = Color.Silver;
            btnActualizarLista.Cursor = Cursors.Hand;
            btnActualizarLista.FlatAppearance.BorderSize = 0;
            btnActualizarLista.FlatStyle = FlatStyle.Flat;
            btnActualizarLista.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnActualizarLista.ForeColor = Color.Blue;
            btnActualizarLista.Location = new Point(16, 107);
            btnActualizarLista.Margin = new Padding(4);
            btnActualizarLista.Name = "btnActualizarLista";
            btnActualizarLista.Size = new Size(140, 35);
            btnActualizarLista.TabIndex = 137;
            btnActualizarLista.Text = "Actualizar lista";
            btnActualizarLista.UseVisualStyleBackColor = false;
            btnActualizarLista.Click += btnActualizarLista_Click;
            // 
            // dgvListadoLista
            // 
            dgvListadoLista.AllowUserToAddRows = false;
            dgvListadoLista.AllowUserToDeleteRows = false;
            dgvListadoLista.AllowUserToResizeColumns = false;
            dgvListadoLista.AllowUserToResizeRows = false;
            dgvListadoLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListadoLista.BackgroundColor = Color.Silver;
            dgvListadoLista.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvListadoLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvListadoLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListadoLista.Cursor = Cursors.Hand;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvListadoLista.DefaultCellStyle = dataGridViewCellStyle4;
            dgvListadoLista.EnableHeadersVisualStyles = false;
            dgvListadoLista.Location = new Point(16, 272);
            dgvListadoLista.Margin = new Padding(4);
            dgvListadoLista.MultiSelect = false;
            dgvListadoLista.Name = "dgvListadoLista";
            dgvListadoLista.ReadOnly = true;
            dgvListadoLista.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvListadoLista.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvListadoLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListadoLista.Size = new Size(445, 120);
            dgvListadoLista.TabIndex = 138;
            dgvListadoLista.CellClick += dgvListado_CellClick;
            // 
            // btnEliminarLista
            // 
            btnEliminarLista.BackColor = Color.Silver;
            btnEliminarLista.Cursor = Cursors.Hand;
            btnEliminarLista.FlatAppearance.BorderSize = 0;
            btnEliminarLista.FlatStyle = FlatStyle.Flat;
            btnEliminarLista.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnEliminarLista.ForeColor = Color.Blue;
            btnEliminarLista.Location = new Point(16, 149);
            btnEliminarLista.Margin = new Padding(4);
            btnEliminarLista.Name = "btnEliminarLista";
            btnEliminarLista.Size = new Size(140, 35);
            btnEliminarLista.TabIndex = 139;
            btnEliminarLista.Text = "Eliminar lista";
            btnEliminarLista.UseVisualStyleBackColor = false;
            btnEliminarLista.Click += btnEliminarLista_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Black", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(16, 240);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(75, 22);
            label4.TabIndex = 140;
            label4.Text = "LISTAS:";
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.Silver;
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnAceptar.ForeColor = Color.Blue;
            btnAceptar.Location = new Point(754, 590);
            btnAceptar.Margin = new Padding(4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(140, 35);
            btnAceptar.TabIndex = 140;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Visible = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkRed;
            label7.Location = new Point(199, 170);
            label7.Name = "label7";
            label7.Size = new Size(262, 16);
            label7.TabIndex = 142;
            label7.Text = "|   DESCRIPCIÓN   |   PRECIO ($ 0.000,00)   |";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DarkRed;
            label8.Location = new Point(181, 145);
            label8.Name = "label8";
            label8.Size = new Size(280, 16);
            label8.TabIndex = 143;
            label8.Text = "FORMATO DEL ARCHIVO NECESARIO:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9.75F);
            label9.ForeColor = Color.Blue;
            label9.Location = new Point(16, 586);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.Yes;
            label9.Size = new Size(658, 16);
            label9.TabIndex = 144;
            label9.Text = ".Si hay errores en la carga, NO ACEPTES. Corrige el archivo según el formato solicitado y vuelve a intentarlo *";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(265, 9);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(409, 27);
            label10.TabIndex = 146;
            label10.Text = "LISTAS (PRODUCTOS PROVEEDORES)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Black", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(16, 412);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(204, 22);
            label5.TabIndex = 147;
            label5.Text = "PRODUCTOS DE LISTA:";
            // 
            // cmbBuscarEstado
            // 
            cmbBuscarEstado.Cursor = Cursors.Hand;
            cmbBuscarEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBuscarEstado.FlatStyle = FlatStyle.Flat;
            cmbBuscarEstado.Font = new Font("Microsoft Sans Serif", 11.25F);
            cmbBuscarEstado.FormattingEnabled = true;
            cmbBuscarEstado.Location = new Point(99, 239);
            cmbBuscarEstado.Name = "cmbBuscarEstado";
            cmbBuscarEstado.Size = new Size(191, 26);
            cmbBuscarEstado.TabIndex = 148;
            cmbBuscarEstado.SelectedIndexChanged += cmbBuscarEstado_SelectedIndexChanged;
            // 
            // btnRestaurarLista
            // 
            btnRestaurarLista.BackColor = Color.Silver;
            btnRestaurarLista.Cursor = Cursors.Hand;
            btnRestaurarLista.FlatAppearance.BorderSize = 0;
            btnRestaurarLista.FlatStyle = FlatStyle.Flat;
            btnRestaurarLista.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnRestaurarLista.ForeColor = Color.Blue;
            btnRestaurarLista.Location = new Point(16, 191);
            btnRestaurarLista.Margin = new Padding(4);
            btnRestaurarLista.Name = "btnRestaurarLista";
            btnRestaurarLista.Size = new Size(140, 35);
            btnRestaurarLista.TabIndex = 149;
            btnRestaurarLista.Text = "Restaurar lista";
            btnRestaurarLista.UseVisualStyleBackColor = false;
            btnRestaurarLista.Click += btnRestaurarLista_Click;
            // 
            // frmLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(907, 638);
            Controls.Add(btnRestaurarLista);
            Controls.Add(cmbBuscarEstado);
            Controls.Add(label5);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btnAceptar);
            Controls.Add(label4);
            Controls.Add(btnEliminarLista);
            Controls.Add(dgvListadoLista);
            Controls.Add(btnActualizarLista);
            Controls.Add(btnNuevaLista);
            Controls.Add(label2);
            Controls.Add(btnSeleccionarArchivo);
            Controls.Add(dgvListadoProducto);
            Controls.Add(label17);
            Controls.Add(groupBox1);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLista";
            StartPosition = FormStartPosition.CenterParent;
            Load += frmListaProducto_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudId).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPorcentaje).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvListadoProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvListadoLista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private ComboBox cmbProveedor;
        private Label label13;
        private Button btnCancelar;
        private Label btnProveedor;
        private Label label25;
        private DateTimePicker dtpFecha;
        private NumericUpDown nudPorcentaje;
        private Label label1;
        private TextBox txtRutaArchivo;
        private Button btnSeleccionarArchivo;
        private Label label17;
        private Button btnGuardar;
        private DataGridView dgvListadoProducto;
        private Label label2;
        private Button btnNuevaLista;
        private Button btnActualizarLista;
        private TextBox txtDescripcion;
        private Label label3;
        private NumericUpDown nudId;
        private Label label6;
        private DataGridView dgvListadoLista;
        private Button btnEliminarLista;
        private Label label4;
        private Button btnAceptar;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label5;
        private ComboBox cmbBuscarEstado;
        private Button btnRestaurarLista;
    }
}