namespace TRABAJO_P
{
    public partial class FrmMenuPrincipal : Form
    {
        // Prepara el menú principal y deja bloqueadas las opciones que requieren iniciar sesión.
        public FrmMenuPrincipal()
        {
            InitializeComponent();
            rEGISTRODEEXPEDIENTESToolStripMenuItem.Enabled = false;
            bUSQUEDADEEXPEDIENTESToolStripMenuItem1.Enabled = false;
        }

        // Abre o trae al frente la ventana de inicio de sesión.
        private void iNICIODESESIÓNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;

            FrmLogin frmLogin = FrmLogin.ventana_unica();
            frmLogin.MdiParent = this;
            frmLogin.Show();
            frmLogin.BringToFront();
        }

        // Abre el formulario para registrar expedientes después del inicio de sesión.
        private void rEGISTRODEEXPEDIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;

            FrmGestionExpedientes frmGest = FrmGestionExpedientes.ventana_unica();
            frmGest.MdiParent = this;
            frmGest.Show();
            frmGest.BringToFront();
        }

        // Abre el formulario de búsqueda de expedientes.
        private void bUSQUEDADEEXPEDIENTESToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;

            FrmBusquedaDeExpedientes frmBusq = FrmBusquedaDeExpedientes.ventana_unica();
            frmBusq.MdiParent = this;
            frmBusq.Show();
            frmBusq.BringToFront();
        }

        // Solicita confirmación y cierra el sistema si el usuario acepta.
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

        // Evento sin lógica adicional, disponible para acciones futuras del menú.
        private void gESTIONDEEXPEDIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        // Evento de carga disponible para inicializar el menú cuando se muestra.
        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
        }

        // Activa las opciones de registro y búsqueda después de iniciar sesión correctamente.
        public void HabilitarOpcionesExpedientes()
        {
            rEGISTRODEEXPEDIENTESToolStripMenuItem.Enabled = true;
            bUSQUEDADEEXPEDIENTESToolStripMenuItem1.Enabled = true;
        }

        // Evento sin lógica adicional, reservado para la opción Inicio del menú.
        private void iNICIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}