using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TRABAJO_P
{
    public partial class FrmBusquedaDeExpedientes : Form
    {
        // Guarda la instancia del formulario para evitar abrir varias ventanas de búsqueda.
        private static FrmBusquedaDeExpedientes instancia = null;

        // Reutiliza la ventana abierta o crea una nueva cuando todavía no existe.
        public static FrmBusquedaDeExpedientes ventana_unica()
        {
            if (instancia == null)
            {
                instancia = new FrmBusquedaDeExpedientes();
                return instancia;
            }
            return instancia;
        }

        // Inicializa los controles visuales del formulario.
        public FrmBusquedaDeExpedientes()
        {
            InitializeComponent();
        }

        // Busca expedientes por su código o por el número de documento y muestra coincidencias.
        void Buscar()
        {
            // Evita iniciar una búsqueda sin un dato de referencia.
            if (txtcodigoabuscar.Text == "")
            {
                MessageBox.Show("Ingrese un código o DNI");
                txtcodigoabuscar.Focus();
                return;
            }
            txasalida.Rows.Clear();
            bool encontrado = false;

            // Recorre los expedientes cargados y compara el texto con el código y el documento.
            for (int i = 0; i < FrmGestionExpedientes.cantidad; i++)
            {
                if (FrmGestionExpedientes.codigo[i] == txtcodigoabuscar.Text ||
                    FrmGestionExpedientes.numerodeldocumento[i] == txtcodigoabuscar.Text)
                {
                    txasalida.Rows.Add(FrmGestionExpedientes.codigo[i],
                        FrmGestionExpedientes.numerodeldocumento[i],
                        FrmGestionExpedientes.remitente[i],
                        FrmGestionExpedientes.asunto[i],
                        FrmGestionExpedientes.fechas[i],
                        FrmGestionExpedientes.estados[i]);
                    encontrado = true;
                }
            }

            // Informa al usuario cuando ningún expediente coincide con el dato ingresado.
            if (encontrado == false)
            {
                MessageBox.Show("No se encontró el expediente");
            }
        }

        // Ordena los expedientes por código y guarda el nuevo orden en el archivo TXT.
        void Ordenar()
        {
            // Ordenamiento burbuja: compara códigos vecinos y los intercambia si están desordenados.
            string aux;
            for (int i = 0; i < FrmGestionExpedientes.cantidad - 1; i++)
            {
                for (int j = 0; j < FrmGestionExpedientes.cantidad - 1 - i; j++)
                {
                    if (string.Compare(FrmGestionExpedientes.codigo[j], FrmGestionExpedientes.codigo[j + 1]) > 0)
                    {
                        // Intercambia los datos de todos los arreglos para que cada expediente conserve sus campos juntos.
                        aux = FrmGestionExpedientes.codigo[j];
                        FrmGestionExpedientes.codigo[j] = FrmGestionExpedientes.codigo[j + 1];
                        FrmGestionExpedientes.codigo[j + 1] = aux;

                        aux = FrmGestionExpedientes.remitente[j];
                        FrmGestionExpedientes.remitente[j] = FrmGestionExpedientes.remitente[j + 1];
                        FrmGestionExpedientes.remitente[j + 1] = aux;

                        aux = FrmGestionExpedientes.asunto[j];
                        FrmGestionExpedientes.asunto[j] = FrmGestionExpedientes.asunto[j + 1];
                        FrmGestionExpedientes.asunto[j + 1] = aux;

                        aux = FrmGestionExpedientes.tipodedocumento[j];
                        FrmGestionExpedientes.tipodedocumento[j] = FrmGestionExpedientes.tipodedocumento[j + 1];
                        FrmGestionExpedientes.tipodedocumento[j + 1] = aux;

                        aux = FrmGestionExpedientes.numerodeldocumento[j];
                        FrmGestionExpedientes.numerodeldocumento[j] = FrmGestionExpedientes.numerodeldocumento[j + 1];
                        FrmGestionExpedientes.numerodeldocumento[j + 1] = aux;

                        aux = FrmGestionExpedientes.fechas[j];
                        FrmGestionExpedientes.fechas[j] = FrmGestionExpedientes.fechas[j + 1];
                        FrmGestionExpedientes.fechas[j + 1] = aux;

                        aux = FrmGestionExpedientes.estados[j];
                        FrmGestionExpedientes.estados[j] = FrmGestionExpedientes.estados[j + 1];
                        FrmGestionExpedientes.estados[j + 1] = aux;
                    }
                }
            }

            // Si falla la escritura, muestra un mensaje para que el usuario sepa que el orden no se pudo guardar.
            try
            {
                FrmGestionExpedientes.GuardarExpedientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar el orden de los expedientes: " + ex.Message,
                    "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Actualiza la tabla para mostrar la lista completa con el orden nuevo.
            txasalida.Rows.Clear();
            for (int i = 0; i < FrmGestionExpedientes.cantidad; i++)
            {
                txasalida.Rows.Add(FrmGestionExpedientes.codigo[i],
                    FrmGestionExpedientes.numerodeldocumento[i],
                    FrmGestionExpedientes.remitente[i],
                    FrmGestionExpedientes.asunto[i],
                    FrmGestionExpedientes.fechas[i],
                    FrmGestionExpedientes.estados[i]);
            }
        }

        // Limpia el campo y la tabla, y devuelve el cursor al cuadro de búsqueda.
        void Limpiar()
        {
            txtcodigoabuscar.Clear();
            txasalida.Rows.Clear();
            txtcodigoabuscar.Focus();
        }

        // Evento sin lógica adicional, reservado para el clic en el título.
        private void lblbusquedadeexpedientes_Click(object sender, EventArgs e)
        {
        }

        // Libera la instancia al cerrar el formulario para poder crear otra después.
        private void FrmBusquedaDeExpedientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }

        // El botón Buscar ejecuta la búsqueda con el dato ingresado.
        private void bttbuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        // El botón Ordenar ejecuta el ordenamiento por código.
        private void bttordenarporcodigo_Click(object sender, EventArgs e)
        {
            Ordenar();
        }

        // El botón Limpiar restablece los campos del formulario.
        private void button1_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        // Evento de carga disponible para inicializaciones adicionales del formulario.
        private void FrmBusquedaDeExpedientes_Load(object sender, EventArgs e)
        {
        }
    }
}