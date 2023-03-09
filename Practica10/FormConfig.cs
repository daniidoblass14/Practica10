/*
*PRÁCTICA.............: Práctica 10 (DLL).
* NOMBRE Y APELLIDOS...: Daniel Jesús Doblas Florido
* CURSO Y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO DE LA PRÁCTICA: Aplicaciones Formulario III. Puerto Serie y Uso Dll’s.
* FECHA DE ENTREGA.....: 22 de Febrero de 2023
*/

using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Windows.Forms;
using MiLibreriaP10;

namespace Practica10
{
    public partial class FormConfig : Form
    {
        public FormConfig()
        {
            InitializeComponent();
            CenterToScreen();

            string[] nombresDelPuerto = SerialPort.GetPortNames();
            for(int i = 0; i < nombresDelPuerto.Length; i++)
            {
                cbPuerto.Items.Add(nombresDelPuerto[i]);
            }
            cbPuerto.SelectedIndex = 0;

            cbNBit.Items.Add(5);
            cbNBit.Items.Add(6);
            cbNBit.Items.Add(7);
            cbNBit.Items.Add(8);
            cbNBit.SelectedIndex = 3;
            //8

            cbVelocidad.Items.Add(110);
            cbVelocidad.Items.Add(300);
            cbVelocidad.Items.Add(1200);
            cbVelocidad.Items.Add(2400);
            cbVelocidad.Items.Add(4800);
            cbVelocidad.Items.Add(9600);
            cbVelocidad.Items.Add(19200);
            cbVelocidad.Items.Add(38400);
            cbVelocidad.Items.Add(57600);
            cbVelocidad.Items.Add(115200);
            cbVelocidad.Items.Add(230400);
            cbVelocidad.Items.Add(460800);
            cbVelocidad.Items.Add(921600);
            cbVelocidad.SelectedIndex = 3;
            //2400

            Dictionary<Parity, string> dicParity = new Dictionary<Parity, string>
            {
                { Parity.Even, "Par" },
                { Parity.Odd, "Impar" },
                { Parity.None, "Ninguno" },
                { Parity.Mark, "Marca" },
                { Parity.Space, "Espacio" }
            };

            cbParidad.DataSource = new BindingSource(dicParity, null);
            cbParidad.DisplayMember = "Value";
            cbParidad.ValueMember = "Key";
            cbParidad.SelectedIndex = 2;

            Dictionary<StopBits, string> dicStopBits = new Dictionary<StopBits, string>
            {
                { StopBits.One, "1" },
                { StopBits.OnePointFive, "1.5" },
                { StopBits.Two, "2" }
            };

            cbBitStop.DataSource = new BindingSource(dicStopBits, null);
            cbBitStop.DisplayMember = "Value";
            cbBitStop.ValueMember = "Key";
            cbBitStop.SelectedIndex = 0;
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            serialPort.PortName = cbPuerto.Text;
            serialPort.DataBits = Convert.ToInt16(cbNBit.Text);
            serialPort.StopBits = ((KeyValuePair<StopBits, string>)cbBitStop.SelectedItem).Key;
            serialPort.BaudRate = Convert.ToInt32(cbVelocidad.Text);
            serialPort.Parity = ((KeyValuePair<Parity, string>)cbParidad.SelectedItem).Key;

            try
            {
                serialPort.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show("El puerto seleccionado ya está en uso. Por favor, seleccione otro puerto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            this.Hide();
            FormChat formChat = new FormChat(serialPort);
            formChat.ShowDialog();
        }

        private void FormConfig_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
