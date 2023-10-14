namespace Vista
{
    partial class FrmBodega
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
            dgvBodega = new DataGridView();
            lblUsuario = new Label();
            btnVolver = new Button();
            btnVerInfo = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBodega).BeginInit();
            SuspendLayout();
            // 
            // dgvBodega
            // 
            dgvBodega.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBodega.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBodega.Location = new Point(25, 52);
            dgvBodega.Name = "dgvBodega";
            dgvBodega.ReadOnly = true;
            dgvBodega.RowTemplate.Height = 25;
            dgvBodega.Size = new Size(736, 150);
            dgvBodega.TabIndex = 0;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(12, 9);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(38, 15);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "label1";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(138, 270);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 2;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnVerInfo
            // 
            btnVerInfo.Location = new Point(25, 270);
            btnVerInfo.Name = "btnVerInfo";
            btnVerInfo.Size = new Size(75, 23);
            btnVerInfo.TabIndex = 4;
            btnVerInfo.Text = "Ver info";
            btnVerInfo.UseVisualStyleBackColor = true;
            btnVerInfo.Click += btnVerInfo_Click;
            // 
            // FrmBodega
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(800, 364);
            Controls.Add(btnVerInfo);
            Controls.Add(btnVolver);
            Controls.Add(lblUsuario);
            Controls.Add(dgvBodega);
            Name = "FrmBodega";
            Text = "Bodega";
            Load += FrmBodega_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBodega).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBodega;
        private Label lblUsuario;
        private Button btnVolver;
        private Button btnVerInfo;
    }
}