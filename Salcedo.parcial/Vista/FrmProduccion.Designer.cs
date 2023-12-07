namespace Vista
{
    partial class FrmProduccion
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
            cmbConsolas = new ComboBox();
            pbConsola = new PictureBox();
            label1 = new Label();
            pbProduccion = new PictureBox();
            btnProducirMueble = new Button();
            btnColocarPlasticos = new Button();
            btnColocarCableado = new Button();
            btnEnviarABodega = new Button();
            btnCancelar = new Button();
            lblPlacaWifi = new Label();
            cmbPlacaWifi = new ComboBox();
            rtbInfoConsola = new RichTextBox();
            txtPrecio = new TextBox();
            lblPrecio = new Label();
            lblConsolaTerminada = new Label();
            btnArmarPlaca = new Button();
            cbAlmacenamiento = new ComboBox();
            lblAlmacenamiento = new Label();
            btnEnsamblarPoly = new Button();
            btnFinalizarPoly = new Button();
            btnEnsamblarEsfera = new Button();
            btnColocarCircuitos = new Button();
            btnFinalizarJuegosfera = new Button();
            label2 = new Label();
            nudJugadores = new NumericUpDown();
            lblNombre = new Label();
            txtNombre = new TextBox();
            btnGuardarDatos = new Button();
            lblUsuario = new Label();
            ((System.ComponentModel.ISupportInitialize)pbConsola).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbProduccion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudJugadores).BeginInit();
            SuspendLayout();
            // 
            // cmbConsolas
            // 
            cmbConsolas.FormattingEnabled = true;
            cmbConsolas.Location = new Point(28, 48);
            cmbConsolas.Name = "cmbConsolas";
            cmbConsolas.Size = new Size(117, 23);
            cmbConsolas.TabIndex = 0;
            cmbConsolas.SelectedIndexChanged += cmbConsolas_SelectedIndexChanged;
            // 
            // pbConsola
            // 
            pbConsola.Location = new Point(12, 77);
            pbConsola.Name = "pbConsola";
            pbConsola.Size = new Size(313, 226);
            pbConsola.SizeMode = PictureBoxSizeMode.StretchImage;
            pbConsola.TabIndex = 1;
            pbConsola.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 30);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 2;
            label1.Text = "Seleccione consola";
            // 
            // pbProduccion
            // 
            pbProduccion.Location = new Point(438, 111);
            pbProduccion.Name = "pbProduccion";
            pbProduccion.Size = new Size(156, 192);
            pbProduccion.SizeMode = PictureBoxSizeMode.StretchImage;
            pbProduccion.TabIndex = 9;
            pbProduccion.TabStop = false;
            // 
            // btnProducirMueble
            // 
            btnProducirMueble.Location = new Point(381, 48);
            btnProducirMueble.Name = "btnProducirMueble";
            btnProducirMueble.Size = new Size(104, 47);
            btnProducirMueble.TabIndex = 10;
            btnProducirMueble.Text = "Producir mueble";
            btnProducirMueble.UseVisualStyleBackColor = true;
            btnProducirMueble.Click += btnProducirMueble_Click;
            // 
            // btnColocarPlasticos
            // 
            btnColocarPlasticos.Location = new Point(536, 48);
            btnColocarPlasticos.Name = "btnColocarPlasticos";
            btnColocarPlasticos.Size = new Size(104, 47);
            btnColocarPlasticos.TabIndex = 11;
            btnColocarPlasticos.Text = "Colocar plasticos";
            btnColocarPlasticos.UseVisualStyleBackColor = true;
            btnColocarPlasticos.Click += btnColocarPlasticos_Click;
            // 
            // btnColocarCableado
            // 
            btnColocarCableado.Location = new Point(466, 330);
            btnColocarCableado.Name = "btnColocarCableado";
            btnColocarCableado.Size = new Size(104, 48);
            btnColocarCableado.TabIndex = 12;
            btnColocarCableado.Text = "Colocar cableado";
            btnColocarCableado.UseVisualStyleBackColor = true;
            btnColocarCableado.Click += btnColocarCableado_Click;
            // 
            // btnEnviarABodega
            // 
            btnEnviarABodega.Location = new Point(921, 375);
            btnEnviarABodega.Name = "btnEnviarABodega";
            btnEnviarABodega.Size = new Size(104, 48);
            btnEnviarABodega.TabIndex = 13;
            btnEnviarABodega.Text = "Enviar a bodega";
            btnEnviarABodega.UseVisualStyleBackColor = true;
            btnEnviarABodega.Click += btnEnviarABodega_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(724, 375);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(104, 48);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblPlacaWifi
            // 
            lblPlacaWifi.AutoSize = true;
            lblPlacaWifi.Location = new Point(12, 392);
            lblPlacaWifi.Name = "lblPlacaWifi";
            lblPlacaWifi.Size = new Size(57, 15);
            lblPlacaWifi.TabIndex = 15;
            lblPlacaWifi.Text = "Placa wifi";
            // 
            // cmbPlacaWifi
            // 
            cmbPlacaWifi.FormattingEnabled = true;
            cmbPlacaWifi.Location = new Point(12, 410);
            cmbPlacaWifi.Name = "cmbPlacaWifi";
            cmbPlacaWifi.Size = new Size(123, 23);
            cmbPlacaWifi.TabIndex = 16;
            // 
            // rtbInfoConsola
            // 
            rtbInfoConsola.Location = new Point(724, 77);
            rtbInfoConsola.Name = "rtbInfoConsola";
            rtbInfoConsola.ReadOnly = true;
            rtbInfoConsola.Size = new Size(301, 268);
            rtbInfoConsola.TabIndex = 17;
            rtbInfoConsola.Text = "";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(12, 471);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(121, 23);
            txtPrecio.TabIndex = 18;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(12, 453);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 19;
            lblPrecio.Text = "Precio";
            // 
            // lblConsolaTerminada
            // 
            lblConsolaTerminada.AutoSize = true;
            lblConsolaTerminada.Font = new Font("Soloist Gradient", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            lblConsolaTerminada.ForeColor = Color.Ivory;
            lblConsolaTerminada.Location = new Point(771, 57);
            lblConsolaTerminada.Name = "lblConsolaTerminada";
            lblConsolaTerminada.Size = new Size(205, 17);
            lblConsolaTerminada.TabIndex = 20;
            lblConsolaTerminada.Text = "Consola terminada";
            // 
            // btnArmarPlaca
            // 
            btnArmarPlaca.Location = new Point(381, 47);
            btnArmarPlaca.Name = "btnArmarPlaca";
            btnArmarPlaca.Size = new Size(104, 48);
            btnArmarPlaca.TabIndex = 25;
            btnArmarPlaca.Text = "Armar placa";
            btnArmarPlaca.UseVisualStyleBackColor = true;
            btnArmarPlaca.Click += btnArmarPlaca_Click;
            // 
            // cbAlmacenamiento
            // 
            cbAlmacenamiento.FormattingEnabled = true;
            cbAlmacenamiento.Location = new Point(12, 348);
            cbAlmacenamiento.Name = "cbAlmacenamiento";
            cbAlmacenamiento.Size = new Size(121, 23);
            cbAlmacenamiento.TabIndex = 26;
            // 
            // lblAlmacenamiento
            // 
            lblAlmacenamiento.AutoSize = true;
            lblAlmacenamiento.Location = new Point(12, 330);
            lblAlmacenamiento.Name = "lblAlmacenamiento";
            lblAlmacenamiento.Size = new Size(155, 15);
            lblAlmacenamiento.TabIndex = 27;
            lblAlmacenamiento.Text = "Seleccione almacenamiento";
            // 
            // btnEnsamblarPoly
            // 
            btnEnsamblarPoly.Location = new Point(536, 48);
            btnEnsamblarPoly.Name = "btnEnsamblarPoly";
            btnEnsamblarPoly.Size = new Size(104, 48);
            btnEnsamblarPoly.TabIndex = 28;
            btnEnsamblarPoly.Text = "Ensamblar consola";
            btnEnsamblarPoly.UseVisualStyleBackColor = true;
            btnEnsamblarPoly.Click += btnEnsamblarPoly_Click;
            // 
            // btnFinalizarPoly
            // 
            btnFinalizarPoly.Location = new Point(466, 330);
            btnFinalizarPoly.Name = "btnFinalizarPoly";
            btnFinalizarPoly.Size = new Size(104, 48);
            btnFinalizarPoly.TabIndex = 29;
            btnFinalizarPoly.Text = "Finalizar consola";
            btnFinalizarPoly.UseVisualStyleBackColor = true;
            btnFinalizarPoly.Click += btnFinalizarPoly_Click;
            // 
            // btnEnsamblarEsfera
            // 
            btnEnsamblarEsfera.Location = new Point(381, 47);
            btnEnsamblarEsfera.Name = "btnEnsamblarEsfera";
            btnEnsamblarEsfera.Size = new Size(104, 48);
            btnEnsamblarEsfera.TabIndex = 31;
            btnEnsamblarEsfera.Text = "Ensamblar esfera";
            btnEnsamblarEsfera.UseVisualStyleBackColor = true;
            btnEnsamblarEsfera.Click += btnEnsamblarEsfera_Click;
            // 
            // btnColocarCircuitos
            // 
            btnColocarCircuitos.Location = new Point(536, 48);
            btnColocarCircuitos.Name = "btnColocarCircuitos";
            btnColocarCircuitos.Size = new Size(104, 48);
            btnColocarCircuitos.TabIndex = 32;
            btnColocarCircuitos.Text = "Colocar circuitos";
            btnColocarCircuitos.UseVisualStyleBackColor = true;
            btnColocarCircuitos.Click += btnColocarCircuitos_Click;
            // 
            // btnFinalizarJuegosfera
            // 
            btnFinalizarJuegosfera.Location = new Point(466, 330);
            btnFinalizarJuegosfera.Name = "btnFinalizarJuegosfera";
            btnFinalizarJuegosfera.Size = new Size(104, 48);
            btnFinalizarJuegosfera.TabIndex = 33;
            btnFinalizarJuegosfera.Text = "Finalizar consola";
            btnFinalizarJuegosfera.UseVisualStyleBackColor = true;
            btnFinalizarJuegosfera.Click += btnFinalizarJuegosfera_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(220, 330);
            label2.Name = "label2";
            label2.Size = new Size(149, 15);
            label2.TabIndex = 34;
            label2.Text = "Ingrese cantidad jugadores";
            // 
            // nudJugadores
            // 
            nudJugadores.Location = new Point(221, 348);
            nudJugadores.Name = "nudJugadores";
            nudJugadores.Size = new Size(120, 23);
            nudJugadores.TabIndex = 35;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(231, 392);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 36;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(220, 410);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(121, 23);
            txtNombre.TabIndex = 37;
            // 
            // btnGuardarDatos
            // 
            btnGuardarDatos.Location = new Point(220, 446);
            btnGuardarDatos.Name = "btnGuardarDatos";
            btnGuardarDatos.Size = new Size(121, 48);
            btnGuardarDatos.TabIndex = 38;
            btnGuardarDatos.Text = "Guardar datos";
            btnGuardarDatos.UseVisualStyleBackColor = true;
            btnGuardarDatos.Click += btnGuardarDatos_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(881, 495);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(38, 15);
            lblUsuario.TabIndex = 39;
            lblUsuario.Text = "label3";
            // 
            // FrmProduccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(1067, 560);
            Controls.Add(lblUsuario);
            Controls.Add(btnGuardarDatos);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(nudJugadores);
            Controls.Add(label2);
            Controls.Add(btnFinalizarJuegosfera);
            Controls.Add(btnColocarCircuitos);
            Controls.Add(btnEnsamblarEsfera);
            Controls.Add(btnFinalizarPoly);
            Controls.Add(btnEnsamblarPoly);
            Controls.Add(lblAlmacenamiento);
            Controls.Add(cbAlmacenamiento);
            Controls.Add(btnArmarPlaca);
            Controls.Add(lblConsolaTerminada);
            Controls.Add(lblPrecio);
            Controls.Add(txtPrecio);
            Controls.Add(rtbInfoConsola);
            Controls.Add(cmbPlacaWifi);
            Controls.Add(lblPlacaWifi);
            Controls.Add(btnCancelar);
            Controls.Add(btnEnviarABodega);
            Controls.Add(btnColocarCableado);
            Controls.Add(btnColocarPlasticos);
            Controls.Add(btnProducirMueble);
            Controls.Add(pbProduccion);
            Controls.Add(label1);
            Controls.Add(pbConsola);
            Controls.Add(cmbConsolas);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "FrmProduccion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Produccion";
            Load += FrnProduccion_Load;
            ((System.ComponentModel.ISupportInitialize)pbConsola).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbProduccion).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudJugadores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbConsolas;
        private PictureBox pbConsola;
        private Label label1;
        private ComboBox cbCantJuegosArcadium;
        private PictureBox pbProduccion;
        private Button btnProducirMueble;
        private Button btnColocarPlasticos;
        private Button btnColocarCableado;
        private Button btnEnviarABodega;
        private Button btnCancelar;
        private Label lblPlacaWifi;
        private ComboBox cmbPlacaWifi;
        private RichTextBox rtbInfoConsola;
        private TextBox txtPrecio;
        private Label lblPrecio;
        private Label lblConsolaTerminada;
        private Button btnArmarPlaca;
        private ComboBox cbAlmacenamiento;
        private Label lblAlmacenamiento;
        private Button btnEnsamblarPoly;
        private Button btnFinalizarPoly;
        private Button btnEnsamblarEsfera;
        private Button btnColocarCircuitos;
        private Button btnFinalizarJuegosfera;
        private Label label2;
        private NumericUpDown nudJugadores;
        private Label lblNombre;
        private TextBox txtNombre;
        private Button btnGuardarDatos;
        private Label lblUsuario;
    }
}