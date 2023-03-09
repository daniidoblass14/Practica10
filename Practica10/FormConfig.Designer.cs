namespace Practica10
{
    partial class FormConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfig));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbBitStop = new System.Windows.Forms.ComboBox();
            this.labelBitStop = new System.Windows.Forms.Label();
            this.cbNBit = new System.Windows.Forms.ComboBox();
            this.labelNBit = new System.Windows.Forms.Label();
            this.cbPuerto = new System.Windows.Forms.ComboBox();
            this.labelPuerto = new System.Windows.Forms.Label();
            this.cbParidad = new System.Windows.Forms.ComboBox();
            this.labelParidad = new System.Windows.Forms.Label();
            this.cbVelocidad = new System.Windows.Forms.ComboBox();
            this.labelVelocidad = new System.Windows.Forms.Label();
            this.btnConectar = new System.Windows.Forms.Button();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConectar);
            this.groupBox1.Controls.Add(this.cbParidad);
            this.groupBox1.Controls.Add(this.labelParidad);
            this.groupBox1.Controls.Add(this.cbVelocidad);
            this.groupBox1.Controls.Add(this.labelVelocidad);
            this.groupBox1.Controls.Add(this.cbBitStop);
            this.groupBox1.Controls.Add(this.labelBitStop);
            this.groupBox1.Controls.Add(this.cbNBit);
            this.groupBox1.Controls.Add(this.labelNBit);
            this.groupBox1.Controls.Add(this.cbPuerto);
            this.groupBox1.Controls.Add(this.labelPuerto);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 229);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuracion del Puerto";
            // 
            // cbBitStop
            // 
            this.cbBitStop.FormattingEnabled = true;
            this.cbBitStop.Location = new System.Drawing.Point(97, 163);
            this.cbBitStop.Name = "cbBitStop";
            this.cbBitStop.Size = new System.Drawing.Size(82, 24);
            this.cbBitStop.TabIndex = 5;
            // 
            // labelBitStop
            // 
            this.labelBitStop.AutoSize = true;
            this.labelBitStop.Location = new System.Drawing.Point(7, 166);
            this.labelBitStop.Name = "labelBitStop";
            this.labelBitStop.Size = new System.Drawing.Size(68, 16);
            this.labelBitStop.TabIndex = 4;
            this.labelBitStop.Text = "BIT STOP";
            // 
            // cbNBit
            // 
            this.cbNBit.FormattingEnabled = true;
            this.cbNBit.Location = new System.Drawing.Point(97, 98);
            this.cbNBit.Name = "cbNBit";
            this.cbNBit.Size = new System.Drawing.Size(82, 24);
            this.cbNBit.TabIndex = 3;
            // 
            // labelNBit
            // 
            this.labelNBit.AutoSize = true;
            this.labelNBit.Location = new System.Drawing.Point(7, 101);
            this.labelNBit.Name = "labelNBit";
            this.labelNBit.Size = new System.Drawing.Size(46, 16);
            this.labelNBit.TabIndex = 2;
            this.labelNBit.Text = "Nº BIT";
            // 
            // cbPuerto
            // 
            this.cbPuerto.FormattingEnabled = true;
            this.cbPuerto.Location = new System.Drawing.Point(97, 39);
            this.cbPuerto.Name = "cbPuerto";
            this.cbPuerto.Size = new System.Drawing.Size(82, 24);
            this.cbPuerto.TabIndex = 1;
            // 
            // labelPuerto
            // 
            this.labelPuerto.AutoSize = true;
            this.labelPuerto.Location = new System.Drawing.Point(7, 42);
            this.labelPuerto.Name = "labelPuerto";
            this.labelPuerto.Size = new System.Drawing.Size(64, 16);
            this.labelPuerto.TabIndex = 0;
            this.labelPuerto.Text = "PUERTO";
            // 
            // cbParidad
            // 
            this.cbParidad.FormattingEnabled = true;
            this.cbParidad.Location = new System.Drawing.Point(350, 98);
            this.cbParidad.Name = "cbParidad";
            this.cbParidad.Size = new System.Drawing.Size(82, 24);
            this.cbParidad.TabIndex = 9;
            // 
            // labelParidad
            // 
            this.labelParidad.AutoSize = true;
            this.labelParidad.Location = new System.Drawing.Point(241, 101);
            this.labelParidad.Name = "labelParidad";
            this.labelParidad.Size = new System.Drawing.Size(67, 16);
            this.labelParidad.TabIndex = 8;
            this.labelParidad.Text = "PARIDAD";
            // 
            // cbVelocidad
            // 
            this.cbVelocidad.FormattingEnabled = true;
            this.cbVelocidad.Location = new System.Drawing.Point(350, 39);
            this.cbVelocidad.Name = "cbVelocidad";
            this.cbVelocidad.Size = new System.Drawing.Size(82, 24);
            this.cbVelocidad.TabIndex = 7;
            // 
            // labelVelocidad
            // 
            this.labelVelocidad.AutoSize = true;
            this.labelVelocidad.Location = new System.Drawing.Point(241, 42);
            this.labelVelocidad.Name = "labelVelocidad";
            this.labelVelocidad.Size = new System.Drawing.Size(83, 16);
            this.labelVelocidad.TabIndex = 6;
            this.labelVelocidad.Text = "VELOCIDAD";
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(316, 155);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(128, 39);
            this.btnConectar.TabIndex = 10;
            this.btnConectar.Text = "CONECTAR";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 257);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormConfig";
            this.Text = "Configuracion del Puerto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelPuerto;
        private System.Windows.Forms.ComboBox cbNBit;
        private System.Windows.Forms.Label labelNBit;
        private System.Windows.Forms.ComboBox cbPuerto;
        private System.Windows.Forms.ComboBox cbBitStop;
        private System.Windows.Forms.Label labelBitStop;
        private System.Windows.Forms.ComboBox cbParidad;
        private System.Windows.Forms.Label labelParidad;
        private System.Windows.Forms.ComboBox cbVelocidad;
        private System.Windows.Forms.Label labelVelocidad;
        private System.Windows.Forms.Button btnConectar;
        private System.IO.Ports.SerialPort serialPort;
    }
}