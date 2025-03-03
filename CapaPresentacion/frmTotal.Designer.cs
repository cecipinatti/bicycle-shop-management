namespace CapaPresentacion
{
    partial class frmTotal
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
            dgvListadoAnual = new DataGridView();
            dgvListadoMensual = new DataGridView();
            label4 = new Label();
            label1 = new Label();
            nudBuscarAnio = new NumericUpDown();
            plotMensual = new ScottPlot.WinForms.FormsPlot();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvListadoAnual).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvListadoMensual).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudBuscarAnio).BeginInit();
            SuspendLayout();
            // 
            // dgvListadoAnual
            // 
            dgvListadoAnual.AllowUserToAddRows = false;
            dgvListadoAnual.AllowUserToDeleteRows = false;
            dgvListadoAnual.AllowUserToResizeColumns = false;
            dgvListadoAnual.AllowUserToResizeRows = false;
            dgvListadoAnual.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListadoAnual.BackgroundColor = Color.Silver;
            dgvListadoAnual.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvListadoAnual.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvListadoAnual.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvListadoAnual.DefaultCellStyle = dataGridViewCellStyle2;
            dgvListadoAnual.EnableHeadersVisualStyles = false;
            dgvListadoAnual.Location = new Point(646, 46);
            dgvListadoAnual.Margin = new Padding(5);
            dgvListadoAnual.MultiSelect = false;
            dgvListadoAnual.Name = "dgvListadoAnual";
            dgvListadoAnual.ReadOnly = true;
            dgvListadoAnual.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvListadoAnual.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvListadoAnual.RowHeadersVisible = false;
            dgvListadoAnual.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvListadoAnual.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListadoAnual.Size = new Size(530, 332);
            dgvListadoAnual.TabIndex = 15;
            dgvListadoAnual.RowPrePaint += dgvListadoAnual_RowPrePaint;
            dgvListadoAnual.SelectionChanged += dgvListadoAnual_SelectionChanged;
            // 
            // dgvListadoMensual
            // 
            dgvListadoMensual.AllowUserToAddRows = false;
            dgvListadoMensual.AllowUserToDeleteRows = false;
            dgvListadoMensual.AllowUserToResizeColumns = false;
            dgvListadoMensual.AllowUserToResizeRows = false;
            dgvListadoMensual.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListadoMensual.BackgroundColor = Color.Silver;
            dgvListadoMensual.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvListadoMensual.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvListadoMensual.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListadoMensual.DefaultCellStyle = dataGridViewCellStyle2;
            dgvListadoMensual.EnableHeadersVisualStyles = false;
            dgvListadoMensual.Location = new Point(14, 46);
            dgvListadoMensual.Margin = new Padding(5);
            dgvListadoMensual.MultiSelect = false;
            dgvListadoMensual.Name = "dgvListadoMensual";
            dgvListadoMensual.ReadOnly = true;
            dgvListadoMensual.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvListadoMensual.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvListadoMensual.RowHeadersVisible = false;
            dgvListadoMensual.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvListadoMensual.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListadoMensual.Size = new Size(622, 332);
            dgvListadoMensual.TabIndex = 16;
            dgvListadoMensual.CellFormatting += dgvListadoMensual_CellFormatting;
            dgvListadoMensual.RowPrePaint += dgvListadoMensual_RowPrePaint;
            dgvListadoMensual.SelectionChanged += dgvListadoMensual_SelectionChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Black", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(14, 19);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(202, 22);
            label4.TabIndex = 141;
            label4.Text = "TOTALES MENSUALES:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(646, 19);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(178, 22);
            label1.TabIndex = 142;
            label1.Text = "TOTALES ANUALES:";
            // 
            // nudBuscarAnio
            // 
            nudBuscarAnio.BorderStyle = BorderStyle.FixedSingle;
            nudBuscarAnio.Cursor = Cursors.Hand;
            nudBuscarAnio.Font = new Font("Microsoft Sans Serif", 11.25F);
            nudBuscarAnio.Location = new Point(225, 19);
            nudBuscarAnio.Margin = new Padding(4);
            nudBuscarAnio.Name = "nudBuscarAnio";
            nudBuscarAnio.Size = new Size(75, 24);
            nudBuscarAnio.TabIndex = 143;
            nudBuscarAnio.ValueChanged += nudBuscarAnio_ValueChanged;
            // 
            // plotMensual
            // 
            plotMensual.DisplayScale = 1F;
            plotMensual.Location = new Point(14, 411);
            plotMensual.Name = "plotMensual";
            plotMensual.Size = new Size(810, 262);
            plotMensual.TabIndex = 144;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(273, 395);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(301, 22);
            label2.TabIndex = 145;
            label2.Text = "GASTOS E INGRESOS MENSUALES";
            // 
            // frmTotal
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 248, 252);
            ClientSize = new Size(1190, 695);
            Controls.Add(label2);
            Controls.Add(plotMensual);
            Controls.Add(nudBuscarAnio);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(dgvListadoMensual);
            Controls.Add(dgvListadoAnual);
            Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "frmTotal";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmTotal_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListadoAnual).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvListadoMensual).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudBuscarAnio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvListadoAnual;
        private DataGridView dgvListadoMensual;
        private Label label4;
        private Label label1;
        private NumericUpDown nudBuscarAnio;
        private ScottPlot.WinForms.FormsPlot plotMensual;
        private Label label2;
    }
}