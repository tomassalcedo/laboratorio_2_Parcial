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
    public partial class FrmStock : Form, IConfiguraciones
    {
        Usuario user;


        public FrmStock(Usuario user)
        {
            InitializeComponent();
            this.user = user;
        }



        private void FrmStock_Load(object sender, EventArgs e)
        {
            AplicarConfiguraciones();
            CargarDatosEnDataGridView();
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
                StockDao.ActualizarStock();
                CargarDatosEnDataGridView();

            }
        }



        /// <summary>
        /// Carga el datagridview con la cantidad de stock.
        /// </summary>
        private void CargarDatosEnDataGridView()
        {
            dgvStockMateriales.Rows.Clear(); // Limpio las filas existentes para que no se repitan.
            // Agrego nuevamente los datos desde Stock con los valores ya cargados de la db
            int n = dgvStockMateriales.Rows.Add();
            dgvStockMateriales.Rows[n].Cells[0].Value = Stock.MetrosDeCable;
            dgvStockMateriales.Rows[n].Cells[1].Value = Stock.CantidadDePlastico;
            dgvStockMateriales.Rows[n].Cells[2].Value = Stock.CantidadDeTornillos;
            dgvStockMateriales.Rows[n].Cells[3].Value = Stock.CantidadDePlacas;
        }


        public void AplicarConfiguraciones()
        {
            Configuracion config = Archivos<Configuracion>.LeerConfiguracion("configuracion");
            FontFamily fontFamily = new FontFamily(config.Fuente);
            Font font = new Font(fontFamily, this.Font.Size, FontStyle.Regular);
            this.Font = font;
            this.BackColor = config.ColorFondo;

            btnAgregarMateriales.Visible = false;
            if (user.EsAdmin)
            {
                btnAgregarMateriales.Visible = true;
            }

        }



    }
}

