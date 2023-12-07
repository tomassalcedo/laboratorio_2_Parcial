namespace Vista
{
    partial class FrmEditarUsuario
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
            cbCamposAEditar = new ComboBox();
            lblCampos = new Label();
            dgvUsuario = new DataGridView();
            NombreUsuario = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            EsAdmin = new DataGridViewTextBoxColumn();
            txtNombreUsuario = new TextBox();
            lblNombre = new Label();
            txtPassword = new TextBox();
            lblPass = new Label();
            lblCategoria = new Label();
            cbCategoria = new ComboBox();
            btnGuardarCambios = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).BeginInit();
            SuspendLayout();
            // 
            // cbCamposAEditar
            // 
            cbCamposAEditar.FormattingEnabled = true;
            cbCamposAEditar.Location = new Point(22, 182);
            cbCamposAEditar.Name = "cbCamposAEditar";
            cbCamposAEditar.Size = new Size(145, 23);
            cbCamposAEditar.TabIndex = 0;
            cbCamposAEditar.SelectedIndexChanged += cbCamposAEditar_SelectedIndexChanged;
            // 
            // lblCampos
            // 
            lblCampos.AutoSize = true;
            lblCampos.Location = new Point(22, 164);
            lblCampos.Name = "lblCampos";
            lblCampos.Size = new Size(145, 15);
            lblCampos.TabIndex = 1;
            lblCampos.Text = "Seleccione campo a editar";
            // 
            // dgvUsuario
            // 
            dgvUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuario.Columns.AddRange(new DataGridViewColumn[] { NombreUsuario, Password, EsAdmin });
            dgvUsuario.Location = new Point(22, 93);
            dgvUsuario.Name = "dgvUsuario";
            dgvUsuario.RowTemplate.Height = 25;
            dgvUsuario.Size = new Size(600, 49);
            dgvUsuario.TabIndex = 2;
            // 
            // NombreUsuario
            // 
            NombreUsuario.HeaderText = "NombreUsuario";
            NombreUsuario.Name = "NombreUsuario";
            // 
            // Password
            // 
            Password.HeaderText = "Password";
            Password.Name = "Password";
            // 
            // EsAdmin
            // 
            EsAdmin.HeaderText = "EsAdmin";
            EsAdmin.Name = "EsAdmin";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(176, 182);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(126, 23);
            txtNombreUsuario.TabIndex = 3;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(176, 164);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(126, 15);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Ingrese nuevo nombre";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(317, 182);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(133, 23);
            txtPassword.TabIndex = 5;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(317, 164);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(133, 15);
            lblPass.TabIndex = 6;
            lblPass.Text = "Ingrese nueva password";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(472, 164);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(150, 15);
            lblCategoria.TabIndex = 7;
            lblCategoria.Text = "Seleccione nueva categoria";
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(471, 182);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(151, 23);
            cbCategoria.TabIndex = 8;
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.Location = new Point(37, 245);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(111, 43);
            btnGuardarCambios.TabIndex = 9;
            btnGuardarCambios.Text = "Guardar cambios";
            btnGuardarCambios.UseVisualStyleBackColor = true;
            btnGuardarCambios.Click += btnGuardarCambios_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(191, 245);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(111, 43);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(243, 40);
            label1.Name = "label1";
            label1.Size = new Size(140, 21);
            label1.TabIndex = 11;
            label1.Text = "EDITAR USUARIO";
            // 
            // FrmEditarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(634, 317);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardarCambios);
            Controls.Add(cbCategoria);
            Controls.Add(lblCategoria);
            Controls.Add(lblPass);
            Controls.Add(txtPassword);
            Controls.Add(lblNombre);
            Controls.Add(txtNombreUsuario);
            Controls.Add(dgvUsuario);
            Controls.Add(lblCampos);
            Controls.Add(cbCamposAEditar);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "FrmEditarUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar usuario";
            Load += FrmEditarUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbCamposAEditar;
        private Label lblCampos;
        private DataGridView dgvUsuario;
        private TextBox txtNombreUsuario;
        private Label lblNombre;
        private TextBox txtPassword;
        private Label lblPass;
        private Label lblCategoria;
        private ComboBox cbCategoria;
        private Button btnGuardarCambios;
        private Button btnCancelar;
        private DataGridViewTextBoxColumn NombreUsuario;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn EsAdmin;
        private Label label1;
    }
}