﻿namespace Vista
{
    partial class FrmAgregarMateriales
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
            lblMateriales = new Label();
            lblIngreseCant = new Label();
            btnGuardar = new Button();
            Volver = new Button();
            numCantidad = new NumericUpDown();
            cbMateriales = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            SuspendLayout();
            // 
            // lblMateriales
            // 
            lblMateriales.AutoSize = true;
            lblMateriales.Location = new Point(91, 46);
            lblMateriales.Name = "lblMateriales";
            lblMateriales.Size = new Size(109, 15);
            lblMateriales.TabIndex = 0;
            lblMateriales.Text = "Seleccione material";
            // 
            // lblIngreseCant
            // 
            lblIngreseCant.AutoSize = true;
            lblIngreseCant.Location = new Point(91, 157);
            lblIngreseCant.Name = "lblIngreseCant";
            lblIngreseCant.Size = new Size(94, 15);
            lblIngreseCant.TabIndex = 4;
            lblIngreseCant.Text = "Ingrese cantidad";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(100, 242);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(91, 23);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // Volver
            // 
            Volver.Location = new Point(100, 295);
            Volver.Name = "Volver";
            Volver.Size = new Size(91, 23);
            Volver.TabIndex = 6;
            Volver.Text = "Volver";
            Volver.UseVisualStyleBackColor = true;
            Volver.Click += Volver_Click;
            // 
            // numCantidad
            // 
            numCantidad.Location = new Point(82, 204);
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(120, 23);
            numCantidad.TabIndex = 7;
            // 
            // cbMateriales
            // 
            cbMateriales.FormattingEnabled = true;
            cbMateriales.Location = new Point(91, 64);
            cbMateriales.Name = "cbMateriales";
            cbMateriales.Size = new Size(121, 23);
            cbMateriales.TabIndex = 8;
            // 
            // FrmAgregarMateriales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(317, 405);
            Controls.Add(cbMateriales);
            Controls.Add(numCantidad);
            Controls.Add(Volver);
            Controls.Add(btnGuardar);
            Controls.Add(lblIngreseCant);
            Controls.Add(lblMateriales);
            Name = "FrmAgregarMateriales";
            Text = "Agregar materiales";
            Load += FrmAgregarMateriales_Load;
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMateriales;
        private Label lblIngreseCant;
        private Button btnGuardar;
        private Button Volver;
        private NumericUpDown numCantidad;
        private ComboBox cbMateriales;
    }
}