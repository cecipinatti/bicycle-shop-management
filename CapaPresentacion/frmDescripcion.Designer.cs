namespace CapaPresentacion
{
    partial class frmDescripcion
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
            lbnTitulo = new Label();
            groupBox2 = new GroupBox();
            cmbBuscarEstado = new ComboBox();
            txtBuscarDescripcion = new TextBox();
            label2 = new Label();
            label6 = new Label();
            dgvListado = new DataGridView();
            btnNuevo = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            groupBox1 = new GroupBox();
            nudId = new NumericUpDown();
            label5 = new Label();
            txtDescripcion = new TextBox();
            label4 = new Label();
            btnCancelar = new Button();
            btnGuardar = new Button();
            btnRestaurar = new Button();
            btnSalir = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListado).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudId).BeginInit();
            SuspendLayout();
            // 
            // lbnTitulo
            // 
            lbnTitulo.AutoSize = true;
            lbnTitulo.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbnTitulo.ForeColor = Color.Black;
            lbnTitulo.Location = new Point(233, 9);
            lbnTitulo.Margin = new Padding(4, 0, 4, 0);
            lbnTitulo.Name = "lbnTitulo";
            lbnTitulo.Size = new Size(345, 27);
            lbnTitulo.TabIndex = 26;
            lbnTitulo.Text = "ADMINISTRAR DESCRIPCIONES";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(cmbBuscarEstado);
            groupBox2.Controls.Add(txtBuscarDescripcion);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label6);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ImeMode = ImeMode.NoControl;
            groupBox2.Location = new Point(42, 39);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(436, 83);
            groupBox2.TabIndex = 28;
            groupBox2.TabStop = false;
            // 
            // cmbBuscarEstado
            // 
            cmbBuscarEstado.Cursor = Cursors.Hand;
            cmbBuscarEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBuscarEstado.FlatStyle = FlatStyle.Flat;
            cmbBuscarEstado.Font = new Font("Microsoft Sans Serif", 11.25F);
            cmbBuscarEstado.FormattingEnabled = true;
            cmbBuscarEstado.Location = new Point(124, 47);
            cmbBuscarEstado.Name = "cmbBuscarEstado";
            cmbBuscarEstado.Size = new Size(293, 26);
            cmbBuscarEstado.TabIndex = 68;
            cmbBuscarEstado.SelectedIndexChanged += cmbBuscarEstado_SelectedIndexChanged;
            // 
            // txtBuscarDescripcion
            // 
            txtBuscarDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarDescripcion.Cursor = Cursors.IBeam;
            txtBuscarDescripcion.Font = new Font("Microsoft Sans Serif", 11.25F);
            txtBuscarDescripcion.Location = new Point(124, 18);
            txtBuscarDescripcion.Margin = new Padding(4);
            txtBuscarDescripcion.Name = "txtBuscarDescripcion";
            txtBuscarDescripcion.Size = new Size(293, 24);
            txtBuscarDescripcion.TabIndex = 18;
            txtBuscarDescripcion.TextChanged += txtBuscarDescripcion_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(7, 50);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(73, 16);
            label2.TabIndex = 67;
            label2.Text = "ESTADO:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(7, 20);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(113, 16);
            label6.TabIndex = 36;
            label6.Text = "DESCRIPCIÓN:";
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvListado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListado.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvListado.DefaultCellStyle = dataGridViewCellStyle2;
            dgvListado.EnableHeadersVisualStyles = false;
            dgvListado.Location = new Point(41, 129);
            dgvListado.Margin = new Padding(4);
            dgvListado.MultiSelect = false;
            dgvListado.Name = "dgvListado";
            dgvListado.ReadOnly = true;
            dgvListado.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvListado.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvListado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListado.Size = new Size(717, 232);
            dgvListado.TabIndex = 45;
            dgvListado.CellClick += dgvListado_CellClick;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.Silver;
            btnNuevo.BackgroundImageLayout = ImageLayout.Zoom;
            btnNuevo.Cursor = Cursors.Hand;
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnNuevo.ForeColor = Color.Blue;
            btnNuevo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevo.Location = new Point(42, 369);
            btnNuevo.Margin = new Padding(4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(137, 32);
            btnNuevo.TabIndex = 46;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Silver;
            btnEliminar.BackgroundImageLayout = ImageLayout.Zoom;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.Blue;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(621, 369);
            btnEliminar.Margin = new Padding(4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(137, 32);
            btnEliminar.TabIndex = 47;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Silver;
            btnEditar.BackgroundImageLayout = ImageLayout.Zoom;
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnEditar.ForeColor = Color.Blue;
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(331, 369);
            btnEditar.Margin = new Padding(4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(137, 32);
            btnEditar.TabIndex = 48;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(nudId);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ImeMode = ImeMode.NoControl;
            groupBox1.Location = new Point(41, 408);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(496, 172);
            groupBox1.TabIndex = 49;
            groupBox1.TabStop = false;
            // 
            // nudId
            // 
            nudId.Enabled = false;
            nudId.Font = new Font("Microsoft Sans Serif", 11.25F);
            nudId.Location = new Point(146, 28);
            nudId.Margin = new Padding(4);
            nudId.Name = "nudId";
            nudId.Size = new Size(301, 24);
            nudId.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(15, 30);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(97, 16);
            label5.TabIndex = 16;
            label5.Text = "Identificador:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Cursor = Cursors.IBeam;
            txtDescripcion.Enabled = false;
            txtDescripcion.Font = new Font("Microsoft Sans Serif", 11.25F);
            txtDescripcion.Location = new Point(146, 58);
            txtDescripcion.Margin = new Padding(4);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(301, 44);
            txtDescripcion.TabIndex = 9;
            txtDescripcion.TextChanged += txtDescripcion_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(15, 60);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(113, 16);
            label4.TabIndex = 7;
            label4.Text = "DESCRIPCIÓN:";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Silver;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.Blue;
            btnCancelar.Location = new Point(146, 119);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(137, 32);
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
            btnGuardar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.Blue;
            btnGuardar.Location = new Point(310, 119);
            btnGuardar.Margin = new Padding(4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(137, 32);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Visible = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnRestaurar
            // 
            btnRestaurar.BackColor = Color.Silver;
            btnRestaurar.BackgroundImageLayout = ImageLayout.Zoom;
            btnRestaurar.Cursor = Cursors.Hand;
            btnRestaurar.Enabled = false;
            btnRestaurar.FlatAppearance.BorderSize = 0;
            btnRestaurar.FlatStyle = FlatStyle.Flat;
            btnRestaurar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnRestaurar.ForeColor = Color.Blue;
            btnRestaurar.ImageAlign = ContentAlignment.MiddleLeft;
            btnRestaurar.Location = new Point(476, 369);
            btnRestaurar.Margin = new Padding(4);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(137, 32);
            btnRestaurar.TabIndex = 68;
            btnRestaurar.Text = "Restaurar";
            btnRestaurar.UseVisualStyleBackColor = false;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Silver;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnSalir.ForeColor = Color.Blue;
            btnSalir.Location = new Point(568, 585);
            btnSalir.Margin = new Padding(4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(190, 33);
            btnSalir.TabIndex = 67;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmDescripcion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(804, 638);
            Controls.Add(btnRestaurar);
            Controls.Add(btnSalir);
            Controls.Add(groupBox1);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(btnNuevo);
            Controls.Add(dgvListado);
            Controls.Add(groupBox2);
            Controls.Add(lbnTitulo);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmDescripcion";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Load += frmCategoriaProducto_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListado).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudId).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbnTitulo;
        private GroupBox groupBox2;
        private TextBox txtBuscarDescripcion;
        private Label label6;
        private DataGridView dgvListado;
        private Button btnNuevo;
        private Button btnEliminar;
        private Button btnEditar;
        private GroupBox groupBox1;
        private NumericUpDown nudId;
        private Label label5;
        private TextBox txtDescripcion;
        private Label label4;
        private Button btnCancelar;
        private Button btnGuardar;
        private ComboBox cmbBuscarEstado;
        private Label label2;
        private Button btnRestaurar;
        private Button btnSalir;
    }
}