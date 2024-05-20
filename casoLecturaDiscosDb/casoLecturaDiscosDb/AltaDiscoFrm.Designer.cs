namespace casoLecturaDiscosDb
{
    partial class AltaDiscoFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaDiscoFrm));
            this.lbTitulo = new System.Windows.Forms.Label();
            this.tbxTitulo = new System.Windows.Forms.TextBox();
            this.lbCantidadCanciones = new System.Windows.Forms.Label();
            this.tbxCantidadCanciones = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lbEstilo = new System.Windows.Forms.Label();
            this.cbEstilo = new System.Windows.Forms.ComboBox();
            this.lbTipoEdicion = new System.Windows.Forms.Label();
            this.cbTipoEdicion = new System.Windows.Forms.ComboBox();
            this.lbFechaLanzamiento = new System.Windows.Forms.Label();
            this.dtpFechaLanzamiento = new System.Windows.Forms.DateTimePicker();
            this.lbUrlImagen = new System.Windows.Forms.Label();
            this.tbxUrlImagen = new System.Windows.Forms.TextBox();
            this.pbxUrlImagen = new System.Windows.Forms.PictureBox();
            this.btnAgregarImg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUrlImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Location = new System.Drawing.Point(111, 36);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(38, 13);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Título:";
            // 
            // tbxTitulo
            // 
            this.tbxTitulo.Location = new System.Drawing.Point(161, 33);
            this.tbxTitulo.Name = "tbxTitulo";
            this.tbxTitulo.Size = new System.Drawing.Size(121, 20);
            this.tbxTitulo.TabIndex = 0;
            // 
            // lbCantidadCanciones
            // 
            this.lbCantidadCanciones.AutoSize = true;
            this.lbCantidadCanciones.Location = new System.Drawing.Point(28, 132);
            this.lbCantidadCanciones.Name = "lbCantidadCanciones";
            this.lbCantidadCanciones.Size = new System.Drawing.Size(120, 13);
            this.lbCantidadCanciones.TabIndex = 2;
            this.lbCantidadCanciones.Text = "Cantidad de Canciones:";
            // 
            // tbxCantidadCanciones
            // 
            this.tbxCantidadCanciones.Location = new System.Drawing.Point(160, 129);
            this.tbxCantidadCanciones.Name = "tbxCantidadCanciones";
            this.tbxCantidadCanciones.Size = new System.Drawing.Size(121, 20);
            this.tbxCantidadCanciones.TabIndex = 3;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(251, 239);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(73, 239);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lbEstilo
            // 
            this.lbEstilo.AutoSize = true;
            this.lbEstilo.Location = new System.Drawing.Point(110, 172);
            this.lbEstilo.Name = "lbEstilo";
            this.lbEstilo.Size = new System.Drawing.Size(35, 13);
            this.lbEstilo.TabIndex = 6;
            this.lbEstilo.Text = "Estilo:";
            // 
            // cbEstilo
            // 
            this.cbEstilo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstilo.FormattingEnabled = true;
            this.cbEstilo.Location = new System.Drawing.Point(160, 164);
            this.cbEstilo.Name = "cbEstilo";
            this.cbEstilo.Size = new System.Drawing.Size(121, 21);
            this.cbEstilo.TabIndex = 4;
            // 
            // lbTipoEdicion
            // 
            this.lbTipoEdicion.AutoSize = true;
            this.lbTipoEdicion.Location = new System.Drawing.Point(76, 205);
            this.lbTipoEdicion.Name = "lbTipoEdicion";
            this.lbTipoEdicion.Size = new System.Drawing.Size(69, 13);
            this.lbTipoEdicion.TabIndex = 8;
            this.lbTipoEdicion.Text = "Tipo Edición:";
            // 
            // cbTipoEdicion
            // 
            this.cbTipoEdicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoEdicion.FormattingEnabled = true;
            this.cbTipoEdicion.Location = new System.Drawing.Point(160, 202);
            this.cbTipoEdicion.Name = "cbTipoEdicion";
            this.cbTipoEdicion.Size = new System.Drawing.Size(121, 21);
            this.cbTipoEdicion.TabIndex = 5;
            // 
            // lbFechaLanzamiento
            // 
            this.lbFechaLanzamiento.AutoSize = true;
            this.lbFechaLanzamiento.Location = new System.Drawing.Point(35, 67);
            this.lbFechaLanzamiento.Name = "lbFechaLanzamiento";
            this.lbFechaLanzamiento.Size = new System.Drawing.Size(114, 13);
            this.lbFechaLanzamiento.TabIndex = 10;
            this.lbFechaLanzamiento.Text = "Fecha de lanzamiento:";
            // 
            // dtpFechaLanzamiento
            // 
            this.dtpFechaLanzamiento.Location = new System.Drawing.Point(163, 69);
            this.dtpFechaLanzamiento.Name = "dtpFechaLanzamiento";
            this.dtpFechaLanzamiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaLanzamiento.TabIndex = 1;
            // 
            // lbUrlImagen
            // 
            this.lbUrlImagen.AutoSize = true;
            this.lbUrlImagen.Location = new System.Drawing.Point(87, 102);
            this.lbUrlImagen.Name = "lbUrlImagen";
            this.lbUrlImagen.Size = new System.Drawing.Size(61, 13);
            this.lbUrlImagen.TabIndex = 12;
            this.lbUrlImagen.Text = "Url Imagen:";
            // 
            // tbxUrlImagen
            // 
            this.tbxUrlImagen.Location = new System.Drawing.Point(161, 99);
            this.tbxUrlImagen.Name = "tbxUrlImagen";
            this.tbxUrlImagen.Size = new System.Drawing.Size(120, 20);
            this.tbxUrlImagen.TabIndex = 2;
            this.tbxUrlImagen.Leave += new System.EventHandler(this.tbxUrlImagen_Leave);
            // 
            // pbxUrlImagen
            // 
            this.pbxUrlImagen.Location = new System.Drawing.Point(414, 33);
            this.pbxUrlImagen.Name = "pbxUrlImagen";
            this.pbxUrlImagen.Size = new System.Drawing.Size(301, 243);
            this.pbxUrlImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxUrlImagen.TabIndex = 14;
            this.pbxUrlImagen.TabStop = false;
            // 
            // btnAgregarImg
            // 
            this.btnAgregarImg.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarImg.Image")));
            this.btnAgregarImg.Location = new System.Drawing.Point(288, 97);
            this.btnAgregarImg.Name = "btnAgregarImg";
            this.btnAgregarImg.Size = new System.Drawing.Size(38, 23);
            this.btnAgregarImg.TabIndex = 15;
            this.btnAgregarImg.UseVisualStyleBackColor = true;
            this.btnAgregarImg.Click += new System.EventHandler(this.btnAgregarImg_Click);
            // 
            // AltaDiscoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(727, 304);
            this.Controls.Add(this.btnAgregarImg);
            this.Controls.Add(this.pbxUrlImagen);
            this.Controls.Add(this.tbxUrlImagen);
            this.Controls.Add(this.lbUrlImagen);
            this.Controls.Add(this.dtpFechaLanzamiento);
            this.Controls.Add(this.lbFechaLanzamiento);
            this.Controls.Add(this.cbTipoEdicion);
            this.Controls.Add(this.lbTipoEdicion);
            this.Controls.Add(this.cbEstilo);
            this.Controls.Add(this.lbEstilo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.tbxCantidadCanciones);
            this.Controls.Add(this.lbCantidadCanciones);
            this.Controls.Add(this.tbxTitulo);
            this.Controls.Add(this.lbTitulo);
            this.Name = "AltaDiscoFrm";
            this.Text = "Nuevo Disco";
            this.Load += new System.EventHandler(this.AltaDiscoFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxUrlImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.TextBox tbxTitulo;
        private System.Windows.Forms.Label lbCantidadCanciones;
        private System.Windows.Forms.TextBox tbxCantidadCanciones;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lbEstilo;
        private System.Windows.Forms.ComboBox cbEstilo;
        private System.Windows.Forms.Label lbTipoEdicion;
        private System.Windows.Forms.ComboBox cbTipoEdicion;
        private System.Windows.Forms.Label lbFechaLanzamiento;
        private System.Windows.Forms.DateTimePicker dtpFechaLanzamiento;
        private System.Windows.Forms.Label lbUrlImagen;
        private System.Windows.Forms.TextBox tbxUrlImagen;
        private System.Windows.Forms.PictureBox pbxUrlImagen;
        private System.Windows.Forms.Button btnAgregarImg;
    }
}