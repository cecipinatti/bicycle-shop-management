namespace CapaPresentacion
{
    partial class frmPrincipal
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            menuVertical = new Panel();
            btnProducto = new Button();
            lbnHora = new Label();
            lbnFecha = new Label();
            label1 = new Label();
            btnTotal = new Button();
            btnGastoProveedor = new Button();
            btnGastoGeneral = new Button();
            btnVenta = new Button();
            panelContenedor = new Panel();
            horaFecha = new System.Windows.Forms.Timer(components);
            menuVertical.SuspendLayout();
            SuspendLayout();
            // 
            // menuVertical
            // 
            menuVertical.BackColor = Color.FromArgb(0, 0, 64);
            menuVertical.Controls.Add(btnProducto);
            menuVertical.Controls.Add(lbnHora);
            menuVertical.Controls.Add(lbnFecha);
            menuVertical.Controls.Add(label1);
            menuVertical.Controls.Add(btnTotal);
            menuVertical.Controls.Add(btnGastoProveedor);
            menuVertical.Controls.Add(btnGastoGeneral);
            menuVertical.Controls.Add(btnVenta);
            menuVertical.Dock = DockStyle.Left;
            menuVertical.Location = new Point(0, 0);
            menuVertical.Name = "menuVertical";
            menuVertical.Size = new Size(163, 681);
            menuVertical.TabIndex = 1;
            // 
            // btnProducto
            // 
            btnProducto.Cursor = Cursors.Hand;
            btnProducto.FlatAppearance.BorderSize = 0;
            btnProducto.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            btnProducto.FlatStyle = FlatStyle.Flat;
            btnProducto.Font = new Font("Arial Black", 9.75F, FontStyle.Bold);
            btnProducto.ForeColor = Color.White;
            btnProducto.Location = new Point(3, 202);
            btnProducto.Name = "btnProducto";
            btnProducto.Size = new Size(163, 57);
            btnProducto.TabIndex = 7;
            btnProducto.Text = "LISTAS Y PRODUCTOS";
            btnProducto.UseVisualStyleBackColor = true;
            btnProducto.Click += btnListaProducto_Click;
            // 
            // lbnHora
            // 
            lbnHora.AutoSize = true;
            lbnHora.Font = new Font("Century Gothic", 33.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbnHora.ForeColor = Color.Silver;
            lbnHora.Location = new Point(8, 555);
            lbnHora.Name = "lbnHora";
            lbnHora.Size = new Size(152, 55);
            lbnHora.TabIndex = 6;
            lbnHora.Text = "HORA";
            lbnHora.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbnFecha
            // 
            lbnFecha.AutoSize = true;
            lbnFecha.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbnFecha.ForeColor = Color.Silver;
            lbnFecha.Location = new Point(39, 619);
            lbnFecha.Name = "lbnFecha";
            lbnFecha.Size = new Size(60, 19);
            lbnFecha.TabIndex = 5;
            lbnFecha.Text = "FECHA";
            lbnFecha.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(21, 31);
            label1.Name = "label1";
            label1.Size = new Size(124, 33);
            label1.TabIndex = 4;
            label1.Text = "GESTOR";
            // 
            // btnTotal
            // 
            btnTotal.Cursor = Cursors.Hand;
            btnTotal.FlatAppearance.BorderSize = 0;
            btnTotal.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            btnTotal.FlatStyle = FlatStyle.Flat;
            btnTotal.Font = new Font("Arial Black", 9.75F, FontStyle.Bold);
            btnTotal.ForeColor = Color.White;
            btnTotal.Location = new Point(3, 391);
            btnTotal.Name = "btnTotal";
            btnTotal.Size = new Size(163, 57);
            btnTotal.TabIndex = 3;
            btnTotal.Text = "TOTALES";
            btnTotal.UseVisualStyleBackColor = true;
            btnTotal.Click += btnTotal_Click;
            // 
            // btnGastoProveedor
            // 
            btnGastoProveedor.Cursor = Cursors.Hand;
            btnGastoProveedor.FlatAppearance.BorderSize = 0;
            btnGastoProveedor.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            btnGastoProveedor.FlatStyle = FlatStyle.Flat;
            btnGastoProveedor.Font = new Font("Arial Black", 9.75F, FontStyle.Bold);
            btnGastoProveedor.ForeColor = Color.White;
            btnGastoProveedor.Location = new Point(3, 328);
            btnGastoProveedor.Name = "btnGastoProveedor";
            btnGastoProveedor.Size = new Size(163, 57);
            btnGastoProveedor.TabIndex = 2;
            btnGastoProveedor.Text = "GASTOS PROVEEDORES";
            btnGastoProveedor.UseVisualStyleBackColor = true;
            btnGastoProveedor.Click += btnGastoProveedor_Click;
            // 
            // btnGastoGeneral
            // 
            btnGastoGeneral.Cursor = Cursors.Hand;
            btnGastoGeneral.FlatAppearance.BorderSize = 0;
            btnGastoGeneral.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            btnGastoGeneral.FlatStyle = FlatStyle.Flat;
            btnGastoGeneral.Font = new Font("Arial Black", 9.75F, FontStyle.Bold);
            btnGastoGeneral.ForeColor = Color.White;
            btnGastoGeneral.Location = new Point(3, 265);
            btnGastoGeneral.Name = "btnGastoGeneral";
            btnGastoGeneral.Size = new Size(163, 57);
            btnGastoGeneral.TabIndex = 1;
            btnGastoGeneral.Text = "GASTOS GENERALES";
            btnGastoGeneral.UseVisualStyleBackColor = true;
            btnGastoGeneral.Click += btnGastoGeneral_Click;
            // 
            // btnVenta
            // 
            btnVenta.Cursor = Cursors.Hand;
            btnVenta.FlatAppearance.BorderSize = 0;
            btnVenta.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            btnVenta.FlatStyle = FlatStyle.Flat;
            btnVenta.Font = new Font("Arial Black", 9.75F, FontStyle.Bold);
            btnVenta.ForeColor = Color.White;
            btnVenta.Location = new Point(3, 139);
            btnVenta.Name = "btnVenta";
            btnVenta.Size = new Size(163, 57);
            btnVenta.TabIndex = 0;
            btnVenta.Text = "INGRESOS POR VENTAS";
            btnVenta.UseVisualStyleBackColor = true;
            btnVenta.Click += btnVenta_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(163, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1201, 681);
            panelContenedor.TabIndex = 2;
            // 
            // horaFecha
            // 
            horaFecha.Enabled = true;
            horaFecha.Tick += horaFecha_Tick;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(247, 248, 252);
            ClientSize = new Size(1364, 681);
            Controls.Add(panelContenedor);
            Controls.Add(menuVertical);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmPrincipal_Load;
            menuVertical.ResumeLayout(false);
            menuVertical.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel menuVertical;
        private Panel panelContenedor;
        private Button btnVenta;
        private Button btnTotal;
        private Button btnGastoProveedor;
        private Button btnGastoGeneral;
        private Label label1;
        private Label lbnHora;
        private Label lbnFecha;
        private System.Windows.Forms.Timer horaFecha;
        private Button btnProducto;
    }
}