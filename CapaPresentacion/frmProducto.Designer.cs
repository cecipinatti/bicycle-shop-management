namespace CapaPresentacion
{
    partial class frmProducto
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
            txtListadoTotalImporte = new TextBox();
            label7 = new Label();
            btnCargarLista = new Button();
            dgvListadoProductoSeleccionado = new DataGridView();
            btnVenta = new Button();
            label1 = new Label();
            groupBox3 = new GroupBox();
            chkIncluirMasVendido = new CheckBox();
            txtBuscarDescripcion = new TextBox();
            label11 = new Label();
            cmbBuscarLista = new ComboBox();
            label14 = new Label();
            label4 = new Label();
            dgvListadoProducto = new DataGridView();
            btnCancelar = new Button();
            btnLimpiar = new Button();
            nudIdV = new NumericUpDown();
            nudIdP = new NumericUpDown();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvListadoProductoSeleccionado).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListadoProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudIdV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudIdP).BeginInit();
            SuspendLayout();
            // 
            // txtListadoTotalImporte
            // 
            txtListadoTotalImporte.BorderStyle = BorderStyle.FixedSingle;
            txtListadoTotalImporte.Enabled = false;
            txtListadoTotalImporte.Font = new Font("Microsoft Sans Serif", 11.25F);
            txtListadoTotalImporte.ForeColor = Color.Black;
            txtListadoTotalImporte.Location = new Point(868, 626);
            txtListadoTotalImporte.Margin = new Padding(4);
            txtListadoTotalImporte.Name = "txtListadoTotalImporte";
            txtListadoTotalImporte.Size = new Size(307, 24);
            txtListadoTotalImporte.TabIndex = 67;
            txtListadoTotalImporte.TextAlign = HorizontalAlignment.Right;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label7.Location = new Point(729, 630);
            label7.Name = "label7";
            label7.Size = new Size(132, 16);
            label7.TabIndex = 68;
            label7.Text = "IMPORTE TOTAL:";
            // 
            // btnCargarLista
            // 
            btnCargarLista.BackColor = Color.Silver;
            btnCargarLista.BackgroundImageLayout = ImageLayout.Zoom;
            btnCargarLista.Cursor = Cursors.Hand;
            btnCargarLista.FlatAppearance.BorderSize = 0;
            btnCargarLista.FlatStyle = FlatStyle.Flat;
            btnCargarLista.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            btnCargarLista.ForeColor = Color.Black;
            btnCargarLista.ImageAlign = ContentAlignment.MiddleLeft;
            btnCargarLista.Location = new Point(1035, 67);
            btnCargarLista.Margin = new Padding(4);
            btnCargarLista.Name = "btnCargarLista";
            btnCargarLista.Size = new Size(140, 35);
            btnCargarLista.TabIndex = 65;
            btnCargarLista.Text = "Listas";
            btnCargarLista.UseVisualStyleBackColor = false;
            btnCargarLista.Click += btnCargarLista_Click;
            // 
            // dgvListadoProductoSeleccionado
            // 
            dgvListadoProductoSeleccionado.AllowUserToAddRows = false;
            dgvListadoProductoSeleccionado.AllowUserToDeleteRows = false;
            dgvListadoProductoSeleccionado.AllowUserToResizeColumns = false;
            dgvListadoProductoSeleccionado.AllowUserToResizeRows = false;
            dgvListadoProductoSeleccionado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListadoProductoSeleccionado.BackgroundColor = Color.Silver;
            dgvListadoProductoSeleccionado.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvListadoProductoSeleccionado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvListadoProductoSeleccionado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListadoProductoSeleccionado.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvListadoProductoSeleccionado.DefaultCellStyle = dataGridViewCellStyle2;
            dgvListadoProductoSeleccionado.EnableHeadersVisualStyles = false;
            dgvListadoProductoSeleccionado.Location = new Point(13, 455);
            dgvListadoProductoSeleccionado.Margin = new Padding(4);
            dgvListadoProductoSeleccionado.MultiSelect = false;
            dgvListadoProductoSeleccionado.Name = "dgvListadoProductoSeleccionado";
            dgvListadoProductoSeleccionado.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvListadoProductoSeleccionado.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvListadoProductoSeleccionado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListadoProductoSeleccionado.Size = new Size(1162, 163);
            dgvListadoProductoSeleccionado.TabIndex = 70;
            dgvListadoProductoSeleccionado.CellClick += dgvListadoProductoSeleccionado_CellClick;
            dgvListadoProductoSeleccionado.CellEndEdit += dgvListadoProductoSeleccionado_CellEndEdit;
            // 
            // btnVenta
            // 
            btnVenta.BackColor = Color.Silver;
            btnVenta.Cursor = Cursors.Hand;
            btnVenta.FlatAppearance.BorderSize = 0;
            btnVenta.FlatStyle = FlatStyle.Flat;
            btnVenta.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            btnVenta.ForeColor = Color.Blue;
            btnVenta.Location = new Point(173, 630);
            btnVenta.Margin = new Padding(4);
            btnVenta.Name = "btnVenta";
            btnVenta.Size = new Size(140, 35);
            btnVenta.TabIndex = 71;
            btnVenta.Text = "Venta";
            btnVenta.UseVisualStyleBackColor = false;
            btnVenta.Click += btnVenta_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 429);
            label1.Name = "label1";
            label1.Size = new Size(274, 22);
            label1.TabIndex = 73;
            label1.Text = "PRODUCTOS SELECCIONADOS:";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Controls.Add(chkIncluirMasVendido);
            groupBox3.Controls.Add(txtBuscarDescripcion);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(cmbBuscarLista);
            groupBox3.Controls.Add(label14);
            groupBox3.FlatStyle = FlatStyle.Flat;
            groupBox3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ImeMode = ImeMode.NoControl;
            groupBox3.Location = new Point(12, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(798, 90);
            groupBox3.TabIndex = 125;
            groupBox3.TabStop = false;
            // 
            // chkIncluirMasVendido
            // 
            chkIncluirMasVendido.AutoSize = true;
            chkIncluirMasVendido.Location = new Point(651, 13);
            chkIncluirMasVendido.Name = "chkIncluirMasVendido";
            chkIncluirMasVendido.Size = new Size(131, 40);
            chkIncluirMasVendido.TabIndex = 132;
            chkIncluirMasVendido.Text = "Más vendidos\r\n(últ. 6 meses)";
            chkIncluirMasVendido.UseVisualStyleBackColor = true;
            chkIncluirMasVendido.CheckedChanged += chkIncluirMasVendido_CheckedChanged;
            // 
            // txtBuscarDescripcion
            // 
            txtBuscarDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarDescripcion.Cursor = Cursors.IBeam;
            txtBuscarDescripcion.Font = new Font("Microsoft Sans Serif", 11.25F);
            txtBuscarDescripcion.Location = new Point(135, 53);
            txtBuscarDescripcion.Margin = new Padding(5);
            txtBuscarDescripcion.Name = "txtBuscarDescripcion";
            txtBuscarDescripcion.Size = new Size(499, 24);
            txtBuscarDescripcion.TabIndex = 48;
            txtBuscarDescripcion.TextChanged += txtBuscarDescripcion_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(11, 25);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(53, 16);
            label11.TabIndex = 40;
            label11.Text = "LISTA:";
            // 
            // cmbBuscarLista
            // 
            cmbBuscarLista.Cursor = Cursors.Hand;
            cmbBuscarLista.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBuscarLista.FlatStyle = FlatStyle.Flat;
            cmbBuscarLista.Font = new Font("Microsoft Sans Serif", 11.25F);
            cmbBuscarLista.FormattingEnabled = true;
            cmbBuscarLista.Location = new Point(135, 20);
            cmbBuscarLista.Name = "cmbBuscarLista";
            cmbBuscarLista.Size = new Size(499, 26);
            cmbBuscarLista.TabIndex = 39;
            cmbBuscarLista.SelectedValueChanged += cmbBuscarLista_SelectedValueChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(13, 57);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(113, 16);
            label14.TabIndex = 36;
            label14.Text = "DESCRIPCIÓN:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Black", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 105);
            label4.Name = "label4";
            label4.Size = new Size(227, 22);
            label4.TabIndex = 130;
            label4.Text = "PRODUCTOS DE LISTA(S):";
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvListadoProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvListadoProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListadoProducto.Cursor = Cursors.Hand;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvListadoProducto.DefaultCellStyle = dataGridViewCellStyle4;
            dgvListadoProducto.EnableHeadersVisualStyles = false;
            dgvListadoProducto.Location = new Point(12, 131);
            dgvListadoProducto.Margin = new Padding(4);
            dgvListadoProducto.MultiSelect = false;
            dgvListadoProducto.Name = "dgvListadoProducto";
            dgvListadoProducto.ReadOnly = true;
            dgvListadoProducto.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvListadoProducto.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvListadoProducto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListadoProducto.Size = new Size(1163, 285);
            dgvListadoProducto.TabIndex = 62;
            dgvListadoProducto.CellDoubleClick += dgvListadoProducto_CellDoubleClick;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Silver;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.Blue;
            btnCancelar.Location = new Point(12, 630);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(140, 35);
            btnCancelar.TabIndex = 131;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
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
            btnLimpiar.Location = new Point(817, 67);
            btnLimpiar.Margin = new Padding(4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(140, 35);
            btnLimpiar.TabIndex = 134;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // nudIdV
            // 
            nudIdV.Enabled = false;
            nudIdV.Font = new Font("Microsoft Sans Serif", 11.25F);
            nudIdV.Location = new Point(611, 424);
            nudIdV.Margin = new Padding(4);
            nudIdV.Name = "nudIdV";
            nudIdV.ReadOnly = true;
            nudIdV.Size = new Size(278, 24);
            nudIdV.TabIndex = 136;
            // 
            // nudIdP
            // 
            nudIdP.Enabled = false;
            nudIdP.Font = new Font("Microsoft Sans Serif", 11.25F);
            nudIdP.Location = new Point(897, 424);
            nudIdP.Margin = new Padding(4);
            nudIdP.Name = "nudIdP";
            nudIdP.ReadOnly = true;
            nudIdP.Size = new Size(278, 24);
            nudIdP.TabIndex = 137;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Silver;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.Blue;
            btnEliminar.Location = new Point(572, 630);
            btnEliminar.Margin = new Padding(4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(140, 35);
            btnEliminar.TabIndex = 138;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // frmProducto
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 248, 252);
            ClientSize = new Size(1188, 674);
            Controls.Add(btnEliminar);
            Controls.Add(nudIdP);
            Controls.Add(nudIdV);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCancelar);
            Controls.Add(label4);
            Controls.Add(groupBox3);
            Controls.Add(label1);
            Controls.Add(btnVenta);
            Controls.Add(dgvListadoProductoSeleccionado);
            Controls.Add(txtListadoTotalImporte);
            Controls.Add(label7);
            Controls.Add(btnCargarLista);
            Controls.Add(dgvListadoProducto);
            Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "frmProducto";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmListaProducto_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListadoProductoSeleccionado).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListadoProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudIdV).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudIdP).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtListadoTotalImporte;
        private Label label7;
        private Button btnCargarLista;
        private DataGridView dgvListadoProductoSeleccionado;
        private Button btnVenta;
        private Label label1;
        private GroupBox groupBox3;
        private Label label11;
        private ComboBox cmbBuscarLista;
        private Label label14;
        private TextBox txtBuscarDescripcion;
        private Label label4;
        private DataGridView dgvListadoProducto;
        private Button btnCancelar;
        private CheckBox chkIncluirMasVendido;
        private Button btnLimpiar;
        private NumericUpDown nudIdV;
        private NumericUpDown nudIdP;
        private Button btnEliminar;
    }
}