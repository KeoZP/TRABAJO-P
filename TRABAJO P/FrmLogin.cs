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
        //creamos una funcion para que reutilize la instancia de una ventana para evitar abrir varias iguales
        private static FrmLogin instancia = null;
        public static FrmLogin ventana_unica()
        {
            if (instancia == null)
            {
                instancia = new FrmLogin();
                return instancia;
            }
            return instancia;
        }
        public FrmLogin()
        {
            InitializeComponent();
        }
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
        void Ingresar()
        {
            if (txtusuario.Text == "adm" && txtcontrasena.Text == "1234")
            {
                MessageBox.Show("Bienvenido al sistema");

                //Habilita Registro de Expedientes y Busqueda despues de inicar sesión
                ((FrmMenuPrincipal)this.MdiParent).HabilitarOpcionesExpedientes();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Ingresar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtcontrasena.UseSystemPasswordChar =
            !txtcontrasena.UseSystemPasswordChar;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
       "Comunícate con tu supervisor",
       "Advertencia",
       MessageBoxButtons.OK,
       MessageBoxIcon.Warning
   );
        }
    }
}
