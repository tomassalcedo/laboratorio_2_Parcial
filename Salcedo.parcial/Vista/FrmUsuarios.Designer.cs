﻿namespace Vista
{
    partial class FrmUsuarios
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
            dgvUsuarios = new DataGridView();
            btnAgregarUsuario = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnVolver = new Button();
            btnSerializarUsuarios = new Button();
            lblUsuario = new Label();
            lblUsuarios = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(12, 59);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowTemplate.Height = 25;
            dgvUsuarios.Size = new Size(776, 193);
            dgvUsuarios.TabIndex = 0;
            // 
            // btnAgregarUsuario
            // 
            btnAgregarUsuario.Location = new Point(12, 317);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(114, 35);
            btnAgregarUsuario.TabIndex = 1;
            btnAgregarUsuario.Text = "Agregar usuario";
            btnAgregarUsuario.UseVisualStyleBackColor = true;
            btnAgregarUsuario.Click += btnAgregarUsuario_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(144, 317);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(114, 35);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(278, 317);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(114, 35);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(411, 317);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(114, 35);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnSerializarUsuarios
            // 
            btnSerializarUsuarios.Location = new Point(543, 317);
            btnSerializarUsuarios.Name = "btnSerializarUsuarios";
            btnSerializarUsuarios.Size = new Size(114, 35);
            btnSerializarUsuarios.TabIndex = 5;
            btnSerializarUsuarios.Text = "Serializar usuarios";
            btnSerializarUsuarios.UseVisualStyleBackColor = true;
            btnSerializarUsuarios.Click += btnSerializarUsuarios_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(12, 9);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(38, 15);
            lblUsuario.TabIndex = 6;
            lblUsuario.Text = "label1";
            // 
            // lblUsuarios
            // 
            lblUsuarios.AutoSize = true;
            lblUsuarios.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsuarios.Location = new Point(314, 23);
            lblUsuarios.Name = "lblUsuarios";
            lblUsuarios.Size = new Size(187, 21);
            lblUsuarios.TabIndex = 7;
            lblUsuarios.Text = "USUARIOS EN SISTEMA";
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(800, 450);
            Controls.Add(lblUsuarios);
            Controls.Add(lblUsuario);
            Controls.Add(btnSerializarUsuarios);
            Controls.Add(btnVolver);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregarUsuario);
            Controls.Add(dgvUsuarios);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "FrmUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Usuarios";
            Load += FrmUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsuarios;
        private Button btnAgregarUsuario;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnVolver;
        private Button btnSerializarUsuarios;
        private Label lblUsuario;
        private Label lblUsuarios;
    }
}