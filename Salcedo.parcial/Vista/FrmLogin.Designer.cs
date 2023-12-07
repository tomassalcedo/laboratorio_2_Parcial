namespace Vista
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            pictureBox1 = new PictureBox();
            lblNombreUsuario = new Label();
            lblPassword = new Label();
            chkBoxMostrarPass = new CheckBox();
            txtBoxUsuario = new TextBox();
            txtBoxPassword = new TextBox();
            btnIngresar = new Button();
            btnSalir = new Button();
            btnRellenar = new Button();
            btnRellenarOperario = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(98, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 127);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Location = new Point(98, 154);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(87, 15);
            lblNombreUsuario.TabIndex = 1;
            lblNombreUsuario.Text = "Ingrese usuario";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(98, 221);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(98, 15);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Ingrese password";
            // 
            // chkBoxMostrarPass
            // 
            chkBoxMostrarPass.AutoSize = true;
            chkBoxMostrarPass.Location = new Point(98, 268);
            chkBoxMostrarPass.Name = "chkBoxMostrarPass";
            chkBoxMostrarPass.Size = new Size(120, 19);
            chkBoxMostrarPass.TabIndex = 4;
            chkBoxMostrarPass.Text = "Mostrar password";
            chkBoxMostrarPass.UseVisualStyleBackColor = true;
            chkBoxMostrarPass.CheckedChanged += chkBoxMostrarPass_CheckedChanged;
            // 
            // txtBoxUsuario
            // 
            txtBoxUsuario.Location = new Point(98, 172);
            txtBoxUsuario.Name = "txtBoxUsuario";
            txtBoxUsuario.Size = new Size(131, 23);
            txtBoxUsuario.TabIndex = 5;
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Location = new Point(98, 239);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.Size = new Size(131, 23);
            txtBoxPassword.TabIndex = 6;
            // 
            // btnIngresar
            // 
            btnIngresar.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 64, 0);
            btnIngresar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 64, 0);
            btnIngresar.Location = new Point(103, 306);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(100, 34);
            btnIngresar.TabIndex = 7;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(103, 346);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(100, 34);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnRellenar
            // 
            btnRellenar.Location = new Point(46, 386);
            btnRellenar.Name = "btnRellenar";
            btnRellenar.Size = new Size(100, 48);
            btnRellenar.TabIndex = 9;
            btnRellenar.Text = "Rellenar Supervisor";
            btnRellenar.UseVisualStyleBackColor = true;
            btnRellenar.Click += btnRellenar_Click;
            // 
            // btnRellenarOperario
            // 
            btnRellenarOperario.Location = new Point(171, 386);
            btnRellenarOperario.Name = "btnRellenarOperario";
            btnRellenarOperario.Size = new Size(100, 48);
            btnRellenarOperario.TabIndex = 10;
            btnRellenarOperario.Text = "Rellenar Operario";
            btnRellenarOperario.UseVisualStyleBackColor = true;
            btnRellenarOperario.Click += btnRellenarOperario_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(322, 460);
            Controls.Add(btnRellenarOperario);
            Controls.Add(btnRellenar);
            Controls.Add(btnSalir);
            Controls.Add(btnIngresar);
            Controls.Add(txtBoxPassword);
            Controls.Add(txtBoxUsuario);
            Controls.Add(chkBoxMostrarPass);
            Controls.Add(lblPassword);
            Controls.Add(lblNombreUsuario);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login -Salcedo Play-";
            Load += FrmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblNombreUsuario;
        private Label lblPassword;
        private CheckBox chkBoxMostrarPass;
        private TextBox txtBoxUsuario;
        private TextBox txtBoxPassword;
        private Button btnIngresar;
        private Button btnSalir;
        private Button btnRellenar;
        private Button btnRellenarOperario;
    }
}