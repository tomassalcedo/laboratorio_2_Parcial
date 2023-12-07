namespace Vista
{
    partial class FrmConfiguracion
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
            btnGuardar = new Button();
            cmbFuentes = new ComboBox();
            btnVolver = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cmbColores = new ComboBox();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(121, 242);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cmbFuentes
            // 
            cmbFuentes.FormattingEnabled = true;
            cmbFuentes.Location = new Point(96, 116);
            cmbFuentes.Name = "cmbFuentes";
            cmbFuentes.Size = new Size(121, 23);
            cmbFuentes.TabIndex = 1;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(121, 287);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 2;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 98);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 3;
            label1.Text = "Seleccione fuente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(78, 40);
            label2.Name = "label2";
            label2.Size = new Size(165, 28);
            label2.TabIndex = 4;
            label2.Text = "Configuraciones";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 173);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 5;
            label3.Text = "Seleccione color";
            // 
            // cmbColores
            // 
            cmbColores.FormattingEnabled = true;
            cmbColores.Location = new Point(96, 191);
            cmbColores.Name = "cmbColores";
            cmbColores.Size = new Size(121, 23);
            cmbColores.TabIndex = 6;
            // 
            // FrmConfiguracion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(331, 353);
            Controls.Add(cmbColores);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnVolver);
            Controls.Add(cmbFuentes);
            Controls.Add(btnGuardar);
            MaximizeBox = false;
            Name = "FrmConfiguracion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Configuraciones";
            Load += FrmConfiguracion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private ComboBox cmbFuentes;
        private Button btnVolver;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbColores;
    }
}