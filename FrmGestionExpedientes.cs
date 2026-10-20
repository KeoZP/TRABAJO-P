using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace TRABAJO_P
{
    public partial class FrmGestionExpedientes : Form
    {
        // Mantiene una sola ventana de gestión abierta a la vez.
        private static FrmGestionExpedientes instancia = null;
        // Devuelve la ventana existente o crea una nueva si todavía no existe.
        public static FrmGestionExpedientes ventana_unica()
        {
            if (instancia == null)
            {
                instancia = new FrmGestionExpedientes();
                return instancia;
            }
            return instancia;
        }

        // Arreglos para almacenar los datos (límite de 50 registros). Cada posición representa un expediente; los arreglos se mantienen sincronizados por índice.
        public static string[] codigo = new string[50];
        public static string[] remitente = new string[50];
        public static string[] asunto = new string[50];
        public static string[] tipodedocumento = new string[50];
        public static string[] numerodeldocumento = new string[50];
        public static string[] fechas = new string[50];
        public static string[] estados = new string[50];
        // Indica cuántas posiciones de los arreglos contienen expedientes válidos.
        public static int cantidad = 0;
        // Guarda los archivos de datos en la carpeta local del usuario, fuera de la carpeta del programa.
        private static readonly string carpetaDatos = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "TrabajoP");
        private static readonly string archivoDatos = Path.Combine(carpetaDatos, "expedientes.txt");
        private static readonly string archivoDatosJsonAnterior = Path.Combine(carpetaDatos, "expedientes.json");

        // Al iniciar la clase, recupera los expedientes guardados para mostrarlos en la aplicación.
        static FrmGestionExpedientes()
        {
            CargarExpedientes();
        }

        // Lee primero el TXT actual. Si todavía no existe, intenta recuperar los datos del JSON anterior.
        private static void CargarExpedientes()
        {
            try
            {
                // Cada línea del TXT corresponde a un expediente; la primera línea contiene los nombres de las columnas.
                if (File.Exists(archivoDatos))
                {
                    var lineas = File.ReadAllLines(archivoDatos, Encoding.UTF8);
                    cantidad = Math.Min(Math.Max(lineas.Length - 1, 0), codigo.Length);
                    for (int i = 0; i < cantidad; i++)
                    {
                        var campos = ParsearLinea(lineas[i + 1]);
                        if (campos.Length != 7)
                            throw new FormatException($"La línea {i + 2} no contiene los 7 campos esperados.");

                        codigo[i] = campos[0];
                        remitente[i] = campos[1];
                        asunto[i] = campos[2];
                        tipodedocumento[i] = campos[3];
                        numerodeldocumento[i] = campos[4];
                        fechas[i] = campos[5];
                        estados[i] = campos[6];
                    }
                    return;
                }

                // Compatibilidad: si solo existe el archivo JSON anterior, conservar sus datos.
                if (File.Exists(archivoDatosJsonAnterior))
                    CargarJsonAnterior();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los expedientes: " + ex.Message,
                    "Error de lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Lee el formato JSON usado por versiones anteriores para no perder los expedientes existentes.
        private static void CargarJsonAnterior()
        {
            using var documento = System.Text.Json.JsonDocument.Parse(File.ReadAllText(archivoDatosJsonAnterior));
            var raiz = documento.RootElement;
            // Obtiene una lista de valores del JSON; si una propiedad no existe, devuelve una lista vacía.
            string[] LeerCampo(string nombre) => raiz.TryGetProperty(nombre, out var valor)
                ? valor.EnumerateArray().Select(elemento => elemento.GetString() ?? "").ToArray()
                : Array.Empty<string>();

            var codigos = LeerCampo("Codigo");
            cantidad = Math.Min(codigos.Length, codigo.Length);
            Array.Copy(codigos, codigo, cantidad);
            Copiar(LeerCampo("Remitente"), remitente);
            Copiar(LeerCampo("Asunto"), asunto);
            Copiar(LeerCampo("TipoDocumento"), tipodedocumento);
            Copiar(LeerCampo("NumeroDocumento"), numerodeldocumento);
            Copiar(LeerCampo("Fecha"), fechas);
            Copiar(LeerCampo("Estado"), estados);
        }

        // Copia solo los elementos que caben en el arreglo de destino.
        private static void Copiar(string[] origen, string[] destino)
        {
            Array.Copy(origen, destino, Math.Min(origen.Length, destino.Length));
        }

        // Escribe todos los expedientes en un TXT separado por | para que pueda leerse fácilmente.
        public static void GuardarExpedientes()
        {
            Directory.CreateDirectory(carpetaDatos);
            var lineas = new List<string>
            {
                "Codigo|Remitente|Asunto|TipoDocumento|NumeroDocumento|Fecha|Estado"
            };

            for (int i = 0; i < cantidad; i++)
            {
                lineas.Add(string.Join("|", new[]
                {
                    codigo[i], remitente[i], asunto[i], tipodedocumento[i],
                    numerodeldocumento[i], fechas[i], estados[i]
                }.Select(EscaparCampo)));
            }

            File.WriteAllLines(archivoDatos, lineas, new UTF8Encoding(false));
        }

        // Protege los caracteres especiales para que |, barra invertida o saltos de línea no rompan el formato.
        private static string EscaparCampo(string valor)
        {
            return (valor ?? "").Replace("\\", "\\\\")
                .Replace("|", "\\|").Replace("\r", "\\r").Replace("\n", "\\n");
        }

        // Separa una línea en sus siete campos y restaura los caracteres especiales escapados.
        private static string[] ParsearLinea(string linea)
        {
            var campos = new List<string>();
            var campo = new StringBuilder();
            bool escapado = false;

            // Lee carácter por carácter para distinguir separadores reales de los que pertenecen al contenido.
            foreach (char caracter in linea)
            {
                if (escapado)
                {
                    campo.Append(caracter switch
                    {
                        'n' => '\n',
                        'r' => '\r',
                        _ => caracter
                    });
                    escapado = false;
                }
                else if (caracter == '\\')
                {
                    escapado = true;
                }
                else if (caracter == '|')
                {
                    campos.Add(campo.ToString());
                    campo.Clear();
                }
                else
                {
                    campo.Append(caracter);
                }
            }

            if (escapado) campo.Append('\\');
            campos.Add(campo.ToString());
            return campos.ToArray();
        }
        // Inicializa los controles visuales definidos por el diseñador de Windows Forms.
        public FrmGestionExpedientes()
        {
            InitializeComponent();
        }
        // Valida el espacio disponible, agrega los datos de los controles y los guarda en el archivo.
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

        // Revisa que los campos estén completos, que el documento tenga el formato correcto y que el código no se repita.
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

        // Deja el formulario listo para ingresar un expediente nuevo.
        void Limpiar()
        {
            txtcodigo.Clear();
            txtremitente.Clear();
            txtasunto.Clear();
            cbtipodedocumento.SelectedIndex = -1;
            txtnumerodeldocumento.Clear();
            txtcodigo.Focus();
        }
        // Evento sin lógica adicional, reservado para el clic en la etiqueta.
        private void label3_Click(object sender, EventArgs e)
        {

        }

        // Al abrir el formulario, llena la tabla con los expedientes cargados en memoria.
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

        // Libera la referencia a esta ventana para que pueda abrirse otra vez más adelante.
        private void FrmGestionExpedientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }

        // El botón registra solo cuando todos los datos pasan la validación.
        private void bttregistrar_Click(object sender, EventArgs e)
        {
            if (Validar() == true)
            {
                Registrar();
            }
        }

        // El botón de validar comprueba los datos sin guardarlos todavía.
        private void bttvalidar_Click(object sender, EventArgs e)
        {
            if (Validar() == true)
            {
                MessageBox.Show("Los datos son correctos");
            }
        }

        // Evento disponible si se necesita reaccionar cuando cambia el número de documento.
        private void txtnumerodeldocumento_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
