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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica10
{
    public partial class FormularioSplash : Form
    {
        public FormularioSplash()
        {
            InitializeComponent();
        }

        private void Cronometro_Tick(object sender, EventArgs e)
        {
            barraCarga.Increment(2);
            if(barraCarga.Value == 100)
            {
                this.Hide();
                Cronometro.Stop();
                FormConfig formConfig = new FormConfig();
                formConfig.Show();
            }
        }
    }
}
