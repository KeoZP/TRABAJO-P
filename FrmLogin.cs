using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TRABAJO_P
{
    public partial class FrmLogin : Form
    {
        // Guarda la instancia para reutilizar el formulario de inicio de sesión.
        private static FrmLogin instancia = null;

        // Devuelve la ventana existente o crea una nueva.
        public static FrmLogin ventana_unica()
        {
            if (instancia == null)
            {
                instancia = new FrmLogin();
                return instancia;
            }
            return instancia;
        }

        // Inicializa los controles visuales del formulario.
        public FrmLogin()
        {
            InitializeComponent();
        }

        // Pide confirmación y cierra la aplicación si el usuario acepta.
        void Salir()
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

        // Comprueba las credenciales y, si son válidas, habilita las opciones de expedientes.
        void Ingresar()
        {
            if (txtusuario.Text == "adm" && txtcontrasena.Text == "1234")
            {
                MessageBox.Show("Bienvenido al sistema");

                // Comunica al menú principal que ya se inició sesión y oculta esta ventana.
                ((FrmMenuPrincipal)this.MdiParent).HabilitarOpcionesExpedientes();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        // El botón de ingreso valida el usuario y la contraseña escritos.
        private void button1_Click(object sender, EventArgs e)
        {
            Ingresar();
        }

        // El botón Salir solicita confirmación antes de cerrar el sistema.
        private void button2_Click(object sender, EventArgs e)
        {
            Salir();
        }

        // Evento sin lógica adicional, reservado para el clic en la imagen.
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        // Evento sin lógica adicional, reservado para el clic en la etiqueta.
        private void label6_Click(object sender, EventArgs e)
        {
        }

        // Libera la instancia al cerrar para permitir abrir una ventana nueva más adelante.
        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }

        // Alterna entre mostrar la contraseña y ocultarla.
        private void button3_Click(object sender, EventArgs e)
        {
            txtcontrasena.UseSystemPasswordChar =
                !txtcontrasena.UseSystemPasswordChar;
        }

        // Muestra un aviso indicando a quién contactar si se olvidan las credenciales.
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Comunícate con tu supervisor",
                "Advertencia",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}