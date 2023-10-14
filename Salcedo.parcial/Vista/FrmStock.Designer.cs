namespace Vista
{
    partial class FrmStock
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
            dgvStockMateriales = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            CantidadTornillosDisponibles = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            btnAgregarMateriales = new Button();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStockMateriales).BeginInit();
            SuspendLayout();
            // 
            // dgvStockMateriales
            // 
            dgvStockMateriales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStockMateriales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStockMateriales.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, CantidadTornillosDisponibles, Column4 });
            dgvStockMateriales.Location = new Point(12, 83);
            dgvStockMateriales.Name = "dgvStockMateriales";
            dgvStockMateriales.RowTemplate.Height = 25;
            dgvStockMateriales.Size = new Size(776, 150);
            dgvStockMateriales.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Cable disponible";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Plastico disponible";
            Column2.Name = "Column2";
            // 
            // CantidadTornillosDisponibles
            // 
            CantidadTornillosDisponibles.DataPropertyName = "CantidadTornillosDisponibles";
            CantidadTornillosDisponibles.HeaderText = "Tornillos disponibles";
            CantidadTornillosDisponibles.Name = "CantidadTornillosDisponibles";
            // 
            // Column4
            // 
            Column4.HeaderText = "Placas disponibles";
            Column4.Name = "Column4";
            // 
            // btnAgregarMateriales
            // 
            btnAgregarMateriales.Location = new Point(12, 271);
            btnAgregarMateriales.Name = "btnAgregarMateriales";
            btnAgregarMateriales.Size = new Size(98, 43);
            btnAgregarMateriales.TabIndex = 1;
            btnAgregarMateriales.Text = "Agregar materiales";
            btnAgregarMateriales.UseVisualStyleBackColor = true;
            btnAgregarMateriales.Click += btnAgregarMateriales_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(146, 271);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(98, 43);
            btnVolver.TabIndex = 2;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FrmStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(btnAgregarMateriales);
            Controls.Add(dgvStockMateriales);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "FrmStock";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stock";
            Load += FrmStock_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStockMateriales).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvStockMateriales;
        private Button btnAgregarMateriales;
        private Button btnVolver;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn CantidadTornillosDisponibles;
        private DataGridViewTextBoxColumn Column4;
    }
}