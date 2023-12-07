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
            btnVolver = new Button();
            btnVerInfo = new Button();
            btnEliminar = new Button();
            lblCategoria = new Label();
            btnOrdenarPorPrecio = new Button();
            label1 = new Label();
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
            // btnVolver
            // 
            btnVolver.Location = new Point(382, 254);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 2;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnVerInfo
            // 
            btnVerInfo.Location = new Point(25, 254);
            btnVerInfo.Name = "btnVerInfo";
            btnVerInfo.Size = new Size(75, 23);
            btnVerInfo.TabIndex = 4;
            btnVerInfo.Text = "Ver info";
            btnVerInfo.UseVisualStyleBackColor = true;
            btnVerInfo.Click += btnVerInfo_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(118, 254);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(12, 9);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(38, 15);
            lblCategoria.TabIndex = 6;
            lblCategoria.Text = "label1";
            // 
            // btnOrdenarPorPrecio
            // 
            btnOrdenarPorPrecio.Location = new Point(215, 254);
            btnOrdenarPorPrecio.Name = "btnOrdenarPorPrecio";
            btnOrdenarPorPrecio.Size = new Size(149, 23);
            btnOrdenarPorPrecio.TabIndex = 7;
            btnOrdenarPorPrecio.Text = "Ordenar por precio";
            btnOrdenarPorPrecio.UseVisualStyleBackColor = true;
            btnOrdenarPorPrecio.Click += btnOrdenarPorPrecio_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(346, 9);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 8;
            label1.Text = "Bodega";
            // 
            // FrmBodega
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(800, 307);
            Controls.Add(label1);
            Controls.Add(btnOrdenarPorPrecio);
            Controls.Add(lblCategoria);
            Controls.Add(btnEliminar);
            Controls.Add(btnVerInfo);
            Controls.Add(btnVolver);
            Controls.Add(dgvBodega);
            Name = "FrmBodega";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bodega";
            Load += FrmBodega_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBodega).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBodega;
        private Button btnVolver;
        private Button btnVerInfo;
        private Button btnEliminar;
        private Label lblCategoria;
        private Button btnOrdenarPorPrecio;
        private Label label1;
    }
}