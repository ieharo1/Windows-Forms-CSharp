namespace Reproductor_de_musica
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Reproductor = new AxWMPLib.AxWindowsMediaPlayer();
            this.lstcanciones = new System.Windows.Forms.ListBox();
            this.btnAdjuntar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdjuntar)).BeginInit();
            this.SuspendLayout();
            // 
            // Reproductor
            // 
            this.Reproductor.Enabled = true;
            this.Reproductor.Location = new System.Drawing.Point(3, 1);
            this.Reproductor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Reproductor.Name = "Reproductor";
            this.Reproductor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Reproductor.OcxState")));
            this.Reproductor.Size = new System.Drawing.Size(450, 70);
            this.Reproductor.TabIndex = 0;
            // 
            // lstcanciones
            // 
            this.lstcanciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstcanciones.FormattingEnabled = true;
            this.lstcanciones.Location = new System.Drawing.Point(2, 136);
            this.lstcanciones.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lstcanciones.Name = "lstcanciones";
            this.lstcanciones.Size = new System.Drawing.Size(448, 262);
            this.lstcanciones.TabIndex = 1;
            this.lstcanciones.SelectedIndexChanged += new System.EventHandler(this.lstcanciones_SelectedIndexChanged);
            // 
            // btnAdjuntar
            // 
            this.btnAdjuntar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdjuntar.Image")));
            this.btnAdjuntar.Location = new System.Drawing.Point(2, 77);
            this.btnAdjuntar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAdjuntar.Name = "btnAdjuntar";
            this.btnAdjuntar.Size = new System.Drawing.Size(58, 53);
            this.btnAdjuntar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAdjuntar.TabIndex = 2;
            this.btnAdjuntar.TabStop = false;
            this.btnAdjuntar.Click += new System.EventHandler(this.btnAdjuntar_Click);
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(451, 433);
            this.Controls.Add(this.btnAdjuntar);
            this.Controls.Add(this.lstcanciones);
            this.Controls.Add(this.Reproductor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "PODO MP3";
            this.TransparencyKey = System.Drawing.Color.DimGray;
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdjuntar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer Reproductor;
        private System.Windows.Forms.ListBox lstcanciones;
        private System.Windows.Forms.PictureBox btnAdjuntar;
    }
}

