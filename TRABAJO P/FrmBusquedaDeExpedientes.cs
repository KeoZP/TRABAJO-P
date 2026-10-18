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
        private static FrmBusquedaDeExpedientes instancia = null;
        public static FrmBusquedaDeExpedientes ventana_unica()
        {
            if (instancia == null)
            {
                instancia = new FrmBusquedaDeExpedientes();
                return instancia;
            }
            return instancia;
        }



        public FrmBusquedaDeExpedientes()
        {
            InitializeComponent();
        }

        void Buscar()
        {
            //Verificar que el txt no este vacio
            if (txtcodigoabuscar.Text == "")
            {
                MessageBox.Show("Ingrese un código o DNI");
                txtcodigoabuscar.Focus();
                return;
            }
            txasalida.Rows.Clear();
            bool encontrado = false;

            //Recorrer el arreglo de codigos para buscar el codigo ingresado
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
            if (encontrado == false)
            {
                MessageBox.Show("No se encontró el expediente");
            }
        }

        void Ordenar()
        {
            //MÉTODO BURBUJA (USAMOS VARIABLE AUXILIAR PARA INTERCAMBIAR LOS VALORES DE LOS ARRREGLOS)

            string aux;
            for (int i = 0; i < FrmGestionExpedientes.cantidad - 1; i++)
            {
                for (int j = 0; j < FrmGestionExpedientes.cantidad - 1 - i; j++)
                {
                    //string.Compare(a, b) compara dos textos alfabéticamente
                    if (string.Compare(FrmGestionExpedientes.codigo[j], FrmGestionExpedientes.codigo[j + 1]) > 0)
                    {
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

            try
            {
                FrmGestionExpedientes.GuardarExpedientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar el orden de los expedientes: " + ex.Message,
                    "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Mostrar todos los expedientes ya ordenados
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
        void Limpiar()
        {
            txtcodigoabuscar.Clear();
            txasalida.Rows.Clear();
            txtcodigoabuscar.Focus();
            //.Focus() es un método de los controles de Windows Forms que coloca el cursor dentro de ese control, que en 
            // este caso seria el txtcodigoabuscar 
        }
        private void lblbusquedadeexpedientes_Click(object sender, EventArgs e)
        {

        }

        private void FrmBusquedaDeExpedientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }

        private void bttbuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void bttordenarporcodigo_Click(object sender, EventArgs e)
        {
            Ordenar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void FrmBusquedaDeExpedientes_Load(object sender, EventArgs e)
        {

        }
    }
}
