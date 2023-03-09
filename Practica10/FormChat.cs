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
            serialPort.WriteLine(textBoxMensajes.Text);
        }

        private void enviarFicheroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                DialogResult result = MessageBox.Show("Desea visualizar el contenido?", "Mensaje", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Nombre del archivo a enviar
                        string fileName = openFileDialog.FileName;

                        // Abrir el archivo
                        using (FileStream fs = new FileStream(fileName, FileMode.Open))
                        {
                            // Leer los bytes del archivo
                            byte[] buffer = new byte[fs.Length];
                            fs.Read(buffer, 0, (int)fs.Length);

                            // Enviar los bytes del archivo a través del puerto serie
                            serialPort.Write(buffer, 0, buffer.Length);
                        }

                        MessageBox.Show("El archivo ha sido enviado correctamente.");

                        SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                        saveFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
                        saveFileDialog1.FilterIndex = 1;
                        saveFileDialog1.RestoreDirectory = true;

                        // Obtener el nombre del archivo seleccionado con la extensión
                        string nombreArchivo = Path.GetFileName(openFileDialog.FileName);

                        // Establecer el nombre de archivo predeterminado en el diálogo "Guardar como"
                        saveFileDialog1.FileName = nombreArchivo;

                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            // Guardar el archivo en la ruta seleccionada
                            string ruta_archivo = saveFileDialog1.FileName;

                            // Abrir el archivo seleccionado en el diálogo de "Abrir"
                            using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open))
                            {
                                // Leer los bytes del archivo
                                byte[] buffer = new byte[fs.Length];
                                fs.Read(buffer, 0, (int)fs.Length);

                                // Escribir los bytes del archivo en el archivo guardado
                                using (FileStream fs2 = new FileStream(ruta_archivo, FileMode.Create))
                                {
                                    fs2.Write(buffer, 0, buffer.Length);
                                }
                            }
                            MessageBox.Show("El archivo se ha guardado exitosamente en la siguiente ruta: " + ruta_archivo, "Mensaje", MessageBoxButtons.OK);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al enviar el archivo: " + ex.Message);
                    }
                }
                else if (result == DialogResult.No)
                {
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                    saveFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
                    saveFileDialog1.FilterIndex = 1;
                    saveFileDialog1.RestoreDirectory = true;

                    // Obtener el nombre del archivo seleccionado con la extensión
                    string nombreArchivo = Path.GetFileName(openFileDialog.FileName);

                    // Establecer el nombre de archivo predeterminado en el diálogo "Guardar como"
                    saveFileDialog1.FileName = nombreArchivo;

                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        // Guardar el archivo en la ruta seleccionada
                        string ruta_archivo = saveFileDialog1.FileName;

                        // Abrir el archivo seleccionado en el diálogo de "Abrir"
                        using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open))
                        {
                            // Leer los bytes del archivo
                            byte[] buffer = new byte[fs.Length];
                            fs.Read(buffer, 0, (int)fs.Length);

                            // Escribir los bytes del archivo en el archivo guardado
                            using (FileStream fs2 = new FileStream(ruta_archivo, FileMode.Create))
                            {
                                fs2.Write(buffer, 0, buffer.Length);
                            }
                        }
                        MessageBox.Show("El archivo se ha guardado exitosamente en la siguiente ruta: " + ruta_archivo, "Mensaje", MessageBoxButtons.OK);
                    }
                }
            }
        }


        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

            dll.MessageSalir();
        }

        private void configConexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nuevaConexion();
        }

        private void nuevaConexion()
        {
           new FormConfig().ShowDialog();
        }
    }
}
