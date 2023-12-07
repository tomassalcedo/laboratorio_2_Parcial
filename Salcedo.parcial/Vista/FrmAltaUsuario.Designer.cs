namespace Vista
{
    partial class FrmAltaUsuario
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtBoxNombreUsuario = new TextBox();
            txtBoxPassword = new TextBox();
            cbCategoria = new ComboBox();
            btnAgregarUsuario = new Button();
            btnCancelar = new Button();
            label4 = new Label();
            lblUsuario = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 95);
            label1.Name = "label1";
            label1.Size = new Size(148, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese nombre de usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 180);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 1;
            label2.Text = "Ingrese password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 252);
            label3.Name = "label3";
            label3.Size = new Size(115, 15);
            label3.TabIndex = 2;
            label3.Text = "Seleccione categoria";
            // 
            // txtBoxNombreUsuario
            // 
            txtBoxNombreUsuario.Location = new Point(67, 113);
            txtBoxNombreUsuario.Name = "txtBoxNombreUsuario";
            txtBoxNombreUsuario.Size = new Size(148, 23);
            txtBoxNombreUsuario.TabIndex = 3;
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Location = new Point(67, 198);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.Size = new Size(148, 23);
            txtBoxPassword.TabIndex = 4;
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(67, 270);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(148, 23);
            cbCategoria.TabIndex = 5;
            // 
            // btnAgregarUsuario
            // 
            btnAgregarUsuario.Location = new Point(81, 325);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(115, 32);
            btnAgregarUsuario.TabIndex = 6;
            btnAgregarUsuario.Text = "Agregar usuario";
            btnAgregarUsuario.UseVisualStyleBackColor = true;
            btnAgregarUsuario.Click += btnAgregarUsuario_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(79, 384);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(117, 32);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(81, 46);
            label4.Name = "label4";
            label4.Size = new Size(122, 21);
            label4.TabIndex = 8;
            label4.Text = "ALTA USUARIO";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(37, 9);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(38, 15);
            lblUsuario.TabIndex = 9;
            lblUsuario.Text = "label5";
            // 
            // FrmAltaUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(290, 450);
            Controls.Add(lblUsuario);
            Controls.Add(label4);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregarUsuario);
            Controls.Add(cbCategoria);
            Controls.Add(txtBoxPassword);
            Controls.Add(txtBoxNombreUsuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmAltaUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alta usuario";
            Load += FrmAltaUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtBoxNombreUsuario;
        private TextBox txtBoxPassword;
        private ComboBox cbCategoria;
        private Button btnAgregarUsuario;
        private Button btnCancelar;
        private Label label4;
        private Label lblUsuario;
    }
}