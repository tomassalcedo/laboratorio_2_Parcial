namespace Vista
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            lblUsuario = new Label();
            lblFecha = new Label();
            btnStockMateriales = new Button();
            btnProducirConsola = new Button();
            btnVerUsuarios = new Button();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            btnSalir = new Button();
            btnVerBodega = new Button();
            btnCambiarUsuario = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(259, 9);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(38, 15);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "label1";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(259, 59);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 6;
            lblFecha.Text = "label7";
            // 
            // btnStockMateriales
            // 
            btnStockMateriales.Location = new Point(67, 223);
            btnStockMateriales.Name = "btnStockMateriales";
            btnStockMateriales.Size = new Size(95, 40);
            btnStockMateriales.TabIndex = 7;
            btnStockMateriales.Text = "Ver Stock materiales";
            btnStockMateriales.UseVisualStyleBackColor = true;
            btnStockMateriales.Click += btnStockMateriales_Click;
            // 
            // btnProducirConsola
            // 
            btnProducirConsola.Location = new Point(67, 158);
            btnProducirConsola.Name = "btnProducirConsola";
            btnProducirConsola.Size = new Size(95, 40);
            btnProducirConsola.TabIndex = 8;
            btnProducirConsola.Text = "Producir Consola";
            btnProducirConsola.UseVisualStyleBackColor = true;
            btnProducirConsola.Click += btnProducirConsola_Click;
            // 
            // btnVerUsuarios
            // 
            btnVerUsuarios.Location = new Point(348, 223);
            btnVerUsuarios.Name = "btnVerUsuarios";
            btnVerUsuarios.Size = new Size(95, 40);
            btnVerUsuarios.TabIndex = 11;
            btnVerUsuarios.Text = "Ver usuarios";
            btnVerUsuarios.UseVisualStyleBackColor = true;
            btnVerUsuarios.Click += btnVerUsuarios_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(-2, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(246, 131);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(465, 334);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnVerBodega
            // 
            btnVerBodega.Location = new Point(348, 158);
            btnVerBodega.Name = "btnVerBodega";
            btnVerBodega.Size = new Size(95, 40);
            btnVerBodega.TabIndex = 14;
            btnVerBodega.Text = "Ver Bodega";
            btnVerBodega.UseVisualStyleBackColor = true;
            btnVerBodega.Click += btnVerBodega_Click;
            // 
            // btnCambiarUsuario
            // 
            btnCambiarUsuario.Location = new Point(202, 290);
            btnCambiarUsuario.Name = "btnCambiarUsuario";
            btnCambiarUsuario.Size = new Size(95, 40);
            btnCambiarUsuario.TabIndex = 15;
            btnCambiarUsuario.Text = "Cambiar de usuario";
            btnCambiarUsuario.UseVisualStyleBackColor = true;
            btnCambiarUsuario.Click += btnCambiarUsuario_Click;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(564, 369);
            Controls.Add(btnCambiarUsuario);
            Controls.Add(btnVerBodega);
            Controls.Add(btnSalir);
            Controls.Add(pictureBox1);
            Controls.Add(btnVerUsuarios);
            Controls.Add(btnProducirConsola);
            Controls.Add(btnStockMateriales);
            Controls.Add(lblFecha);
            Controls.Add(lblUsuario);
            Name = "FrmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            FormClosing += FrmMenuPrincipal_FormClosing;
            Load += FrmMenuPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Label lblFecha;
        private Button btnStockMateriales;
        private Button btnProducirConsola;
        private Button btnVerUsuarios;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Button btnSalir;
        private Button btnVerBodega;
        private Button btnCambiarUsuario;
    }
}