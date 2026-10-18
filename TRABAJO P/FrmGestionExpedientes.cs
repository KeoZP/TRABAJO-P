using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Text.Json;
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

        // Arreglos para almacenar los datos (límite de 50 registros).
        public static string[] codigo = new string[50];
        public static string[] remitente = new string[50];
        public static string[] asunto = new string[50];
        public static string[] tipodedocumento = new string[50];
        public static string[] numerodeldocumento = new string[50];
        public static string[] fechas = new string[50];
        public static string[] estados = new string[50];
        public static int cantidad = 0;
        private static readonly string archivoDatos = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "TrabajoP", "expedientes.json");

        private class DatosExpedientes
        {
            public string[] Codigo { get; set; } = Array.Empty<string>();
            public string[] Remitente { get; set; } = Array.Empty<string>();
            public string[] Asunto { get; set; } = Array.Empty<string>();
            public string[] TipoDocumento { get; set; } = Array.Empty<string>();
            public string[] NumeroDocumento { get; set; } = Array.Empty<string>();
            public string[] Fecha { get; set; } = Array.Empty<string>();
            public string[] Estado { get; set; } = Array.Empty<string>();
        }

        static FrmGestionExpedientes()
        {
            CargarExpedientes();
        }

        private static void CargarExpedientes()
        {
            try
            {
                if (!File.Exists(archivoDatos)) return;
                var datos = JsonSerializer.Deserialize<DatosExpedientes>(File.ReadAllText(archivoDatos));
                if (datos == null) return;

                cantidad = Math.Min(datos.Codigo.Length, codigo.Length);
                Array.Copy(datos.Codigo, codigo, cantidad);
                Copiar(datos.Remitente, remitente);
                Copiar(datos.Asunto, asunto);
                Copiar(datos.TipoDocumento, tipodedocumento);
                Copiar(datos.NumeroDocumento, numerodeldocumento);
                Copiar(datos.Fecha, fechas);
                Copiar(datos.Estado, estados);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los expedientes: " + ex.Message,
                    "Error de lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void Copiar(string[] origen, string[] destino)
        {
            Array.Copy(origen, destino, Math.Min(origen.Length, destino.Length));
        }

        public static void GuardarExpedientes()
        {
            Directory.CreateDirectory(Path.GetDirectoryName(archivoDatos)!);
            var datos = new DatosExpedientes
            {
                Codigo = codigo.Take(cantidad).ToArray(),
                Remitente = remitente.Take(cantidad).ToArray(),
                Asunto = asunto.Take(cantidad).ToArray(),
                TipoDocumento = tipodedocumento.Take(cantidad).ToArray(),
                NumeroDocumento = numerodeldocumento.Take(cantidad).ToArray(),
                Fecha = fechas.Take(cantidad).ToArray(),
                Estado = estados.Take(cantidad).ToArray()
            };
            File.WriteAllText(archivoDatos, JsonSerializer.Serialize(datos,
                new JsonSerializerOptions { WriteIndented = true }));
        }


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
                try
                {
                    GuardarExpedientes();
                }
                catch (Exception ex)
                {
                    cantidad--;
                    MessageBox.Show("No se pudo guardar el expediente: " + ex.Message,
                        "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

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
            txasalida.Rows.Clear();
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
