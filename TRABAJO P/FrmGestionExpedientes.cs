using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TRABAJO_P
{
    public partial class FrmGestionExpedientes : Form
    {
        private static FrmGestionExpedientes instancia = null;
        public static FrmGestionExpedientes ventana_unica()
        {
            if (instancia == null)
            {
                instancia = new FrmGestionExpedientes();
                return instancia;
            }
            return instancia;
        }

        //Arreglos para almacenar los datos (limite de 50 registros)
        public static string[] codigo = new string[50];
        public static string[] remitente = new string[50];
        public static string[] asunto = new string[50];
        public static string[] tipodedocumento = new string[50];
        public static string[] numerodeldocumento = new string[50];
        public static string[] fechas = new string[50];
        public static string[] estados = new string[50];
        public static int cantidad = 0;


        public FrmGestionExpedientes()
        {
            InitializeComponent();
        }
        void Registrar()
        {
            if (cantidad < codigo.Length)
            {
                codigo[cantidad] = txtcodigo.Text;
                remitente[cantidad] = txtremitente.Text;
                asunto[cantidad] = txtasunto.Text;
                tipodedocumento[cantidad] = cbtipodedocumento.Text;
                numerodeldocumento[cantidad] = txtnumerodeldocumento.Text;
                fechas[cantidad] = DateTime.Now.ToString("dd/MM/yyyy");
                estados[cantidad] = "Registrado";
                cantidad++;

                // Agrega el expediente a la tabla.
                txasalida.Rows.Add(txtcodigo.Text,
                              txtremitente.Text,
                              txtasunto.Text,
                              cbtipodedocumento.Text,
                              txtnumerodeldocumento.Text);

                Limpiar();
            }
            else
            {
                MessageBox.Show("Se alcanzó el límite de registros");
            }
        }

        bool Validar()
        {
            //Verificar que el txt no este vacio
            if (txtcodigo.Text == "")
            {
                MessageBox.Show("Ingrese el código");
                txtcodigo.Focus();
                return false;
            }
            if (txtremitente.Text == "")
            {
                MessageBox.Show("Ingrese el remitente");
                txtremitente.Focus();
                return false;
            }
            if (txtasunto.Text == "")
            {
                MessageBox.Show("Ingrese el asunto");
                txtasunto.Focus();
                return false;
            }
            if (cbtipodedocumento.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el tipo de documento");
                cbtipodedocumento.Focus();
                return false;
            }
            if (txtnumerodeldocumento.Text == "")
            {
                MessageBox.Show("Ingrese el número del documento");
                txtnumerodeldocumento.Focus();
                return false;
            }

            //Verificar que el numero tenga solo digitos
            long numero;
            if (long.TryParse(txtnumerodeldocumento.Text, out numero) == false)
            {
                MessageBox.Show("El número del documento solo debe tener dígitos");
                txtnumerodeldocumento.Focus();
                return false;
            }

            //Verificar la cantidad de cifras segun el tipo de documento
            if (cbtipodedocumento.Text == "DNI" && txtnumerodeldocumento.Text.Length != 8)
            {
                MessageBox.Show("El DNI debe tener 8 dígitos");
                txtnumerodeldocumento.Focus();
                return false;
            }
            if (cbtipodedocumento.Text == "RUC" && txtnumerodeldocumento.Text.Length != 11)
            {
                MessageBox.Show("El RUC debe tener 11 dígitos");
                txtnumerodeldocumento.Focus();
                return false;
            }

            //Verificar que el codigo no este repetido
            for (int i = 0; i < cantidad; i++)
            {
                if (codigo[i] == txtcodigo.Text)
                {
                    MessageBox.Show("Ese código ya está registrado");
                    txtcodigo.Focus();
                    return false;
                }
            }

            return true;
        }

        void Limpiar()
        {
            txtcodigo.Clear();
            txtremitente.Clear();
            txtasunto.Clear();
            cbtipodedocumento.SelectedIndex = -1;
            txtnumerodeldocumento.Clear();
            txtcodigo.Focus();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmGestionExpedientes_Load(object sender, EventArgs e)
        {
            //Mostrar en la tabla los expedientes que ya estaban registrados a pesar de cerrar la ventana y
            //abrirla nuevamente ( no se borra los datos registrados en la tabla)
            for (int i = 0; i < cantidad; i++)
            {
                txasalida.Rows.Add(codigo[i],
                    remitente[i],
                    asunto[i],
                    tipodedocumento[i],
                    numerodeldocumento[i]);
            }
        }

        private void FrmGestionExpedientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }

        private void bttregistrar_Click(object sender, EventArgs e)
        {
            if (Validar() == true)
            {
                Registrar();
            }
        }

        private void bttvalidar_Click(object sender, EventArgs e)
        {
            if (Validar() == true)
            {
                MessageBox.Show("Los datos son correctos");
            }
        }

        private void txtnumerodeldocumento_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
