namespace Practica10
{
    partial class FormularioSplash
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioSplash));
            this.Cronometro = new System.Windows.Forms.Timer(this.components);
            this.barraCarga = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // Cronometro
            // 
            this.Cronometro.Enabled = true;
            this.Cronometro.Tick += new System.EventHandler(this.Cronometro_Tick);
            // 
            // barraCarga
            // 
            this.barraCarga.Location = new System.Drawing.Point(45, 367);
            this.barraCarga.Name = "barraCarga";
            this.barraCarga.Size = new System.Drawing.Size(299, 23);
            this.barraCarga.TabIndex = 0;
            // 
            // FormularioSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Practica10.Properties.Resources.ICONO__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(399, 418);
            this.Controls.Add(this.barraCarga);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormularioSplash";
            this.Text = "Splash";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Cronometro;
        private System.Windows.Forms.ProgressBar barraCarga;
    }
}

