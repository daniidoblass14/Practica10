/*
*PRÁCTICA.............: Práctica 10 (DLL).
* NOMBRE Y APELLIDOS...: Daniel Jesús Doblas Florido
* CURSO Y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO DE LA PRÁCTICA: Aplicaciones Formulario III. Puerto Serie y Uso Dll’s.
* FECHA DE ENTREGA.....: 22 de Febrero de 2023
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiLibreriaP10;

namespace Practica10
{
    public partial class FormChat : Form
    {
        private MiLibreriaMessage dll = new MiLibreriaMessage();
        public FormChat(SerialPort puertoSerie)
        {
            InitializeComponent();
            CenterToScreen();
            this.serialPort = puertoSerie;
            this.serialPort.DataReceived += new SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            CheckForIllegalCrossThreadCalls = false;
        }

        private void FormChat_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("App realizada por Daniel Jesús Doblas Florido\n" +
                "Versión 1.0","Acerca de...",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            richText.Text += serialPort.ReadLine();
        }

        private void btnEnviarMensaje_Click(object sender, EventArgs e)
        {
           serialPort.WriteLine($"[{DateTime.Now}] {textBoxMensajes.Text}{Environment.NewLine}");
        }

        private void enviarFicheroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (serialPort != null)
            {
                if (!serialPort.IsOpen)
                {
                    try
                    {
                        serialPort.Open();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo abrir el puerto serie: " + ex.Message);
                        return;
                    }
                }

                // Mostrar el diálogo para seleccionar el archivo
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Leer el archivo
                    byte[] contenido = File.ReadAllBytes(openFileDialog.FileName);

                    // Preguntar si el usuario quiere descargar el archivo
                    if (MessageBox.Show("¿Quieres descargar el archivo?", "Descargar archivo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        // Mostrar el diálogo para seleccionar la ruta de descarga
                        serialPort.Write("Archivo recibido");
                        SaveFileDialog saveFileDialog = new SaveFileDialog();

                        saveFileDialog.Filter = "Archivos PNG (*.png)|*.png|Archivos JPEG (*.jpeg;*.jpg)|*.jpeg;*.jpg|Archivos de texto (*.txt)|*.txt|Archivos PDF (*.pdf)|*.pdf|Documentos Word (*.docx)|*.docx|Hojas de cálculo Excel (*.xlsx)|*.xlsx|Archivos de audio MP3 (*.mp3)|*.mp3|Archivos de audio WAV (*.wav)|*.wav|Accesos directos de Windows (*.lnk)|*.lnk";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            // Escribir el contenido del archivo en la ruta seleccionada
                            File.WriteAllBytes(saveFileDialog.FileName, contenido);

                            Invoke(new Action(() => richText.AppendText($"Yo: [archivo enviado] ({DateTime.Now.ToString()})\n")));
                            richText.Refresh();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("El puerto serie no está conectado.");
                textBoxMensajes.Clear();
                textBoxMensajes.Refresh();
            }
        }


        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

            dll.MessageSalir();
        }
    }
}
