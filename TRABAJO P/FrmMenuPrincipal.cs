namespace TRABAJO_P
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
            rEGISTRODEEXPEDIENTESToolStripMenuItem.Enabled = false;
            bUSQUEDADEEXPEDIENTESToolStripMenuItem1.Enabled = false;
        }

        private void iNICIODESESIÓNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;

            
            FrmLogin frmLogin = FrmLogin.ventana_unica();
            frmLogin.MdiParent = this;
            frmLogin.Show();
            frmLogin.BringToFront();
        }

        private void rEGISTRODEEXPEDIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;

            FrmGestionExpedientes frmGest = FrmGestionExpedientes.ventana_unica();
            frmGest.MdiParent = this;
            frmGest.Show();
            frmGest.BringToFront();
        }

        private void bUSQUEDADEEXPEDIENTESToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;

            FrmBusquedaDeExpedientes frmBusq = FrmBusquedaDeExpedientes.ventana_unica();
            frmBusq.MdiParent = this;
            frmBusq.Show();
            frmBusq.BringToFront();
        }


        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Estas seguro de salir?",
                                         "Mensaje de confirmación.",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void gESTIONDEEXPEDIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }
        public void HabilitarOpcionesExpedientes()
        {
            rEGISTRODEEXPEDIENTESToolStripMenuItem.Enabled = true;
            bUSQUEDADEEXPEDIENTESToolStripMenuItem1.Enabled = true;
        }
        private void iNICIOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
