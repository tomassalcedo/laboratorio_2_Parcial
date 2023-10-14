using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmStock : Form
    {
        Usuario user;
        public FrmStock(Usuario user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void FrmStock_Load(object sender, EventArgs e)
        {

            CargarDatosEnDataGridView();
            if (user.EsAdmin)
            {
                btnAgregarMateriales.Visible = true;
            }
            else
            {
                btnAgregarMateriales.Visible = false;
            }

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarMateriales_Click(object sender, EventArgs e)
        {
            FrmAgregarMateriales frmAgregarMateriales = new FrmAgregarMateriales();
            frmAgregarMateriales.ShowDialog();

            if (frmAgregarMateriales.DialogResult == DialogResult.OK)
            {
                CargarDatosEnDataGridView();
            }
        }



        /// <summary>
        /// Carga el datagridview con la cantidad de stock.
        /// </summary>
        private void CargarDatosEnDataGridView()
        {
            dgvStockMateriales.Rows.Clear(); // Limpia las filas existentes para que no se repitan

            // Agrega nuevamente los datos desde Datos
            int n = dgvStockMateriales.Rows.Add();
            dgvStockMateriales.Rows[n].Cells[0].Value = Datos.MetrosDeCableDisponible;
            dgvStockMateriales.Rows[n].Cells[1].Value = Datos.CantidadPlasticoDisponible;
            dgvStockMateriales.Rows[n].Cells[2].Value = Datos.CantidadTornillosDisponibles;
            dgvStockMateriales.Rows[n].Cells[3].Value = Datos.CantidadDePlacasDisponibles;
        }



    }
}
