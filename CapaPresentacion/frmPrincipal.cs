using CapaEntidad;

namespace CapaPresentacion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

            var productos = new List<CEProductoVenta>();
            frmVenta frmVenta = new frmVenta(this, productos);
            AbrirFormEnPanel(frmVenta, BotonVenta);
        }

        internal void AbrirFormEnPanel(object formHijo, Button botonActivo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();

            foreach (Control control in this.menuVertical.Controls)
            {
                if (control is Button btn)
                {
                    btn.BackColor = Color.FromArgb(0, 0, 64);
                    btn.ForeColor = Color.White;
                }
            }

            botonActivo.BackColor = Color.FromArgb(247, 248, 252);
            botonActivo.ForeColor = Color.Black;

        }

        internal Button BotonVenta => btnVenta;
        internal Button BotonProducto => btnProducto;

        private void btnVenta_Click(object sender, EventArgs e)
        {
            var productos = new List<CEProductoVenta>();
            frmVenta frmVenta = new frmVenta(this, productos);
            AbrirFormEnPanel(frmVenta, BotonVenta);
        }
        private void btnListaProducto_Click(object sender, EventArgs e)
        {
            //AbrirFormEnPanel(new frmProducto(), btnProducto);
            frmProducto frmListaProducto = new frmProducto(this);
            AbrirFormEnPanel(frmListaProducto, BotonProducto);
        }

        private void btnGastoGeneral_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmGastoGeneral(), btnGastoGeneral);
        }

        private void btnGastoProveedor_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmGastoProveedor(), btnGastoProveedor);
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmTotal(), btnTotal);
        }

        private void horaFecha_Tick(object sender, EventArgs e)
        {
            lbnHora.Text = DateTime.Now.ToShortTimeString();
            lbnFecha.Text = DateTime.Now.ToString("dd/MM/yy");
        }

    }
}
