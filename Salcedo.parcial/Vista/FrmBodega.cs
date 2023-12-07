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
    public partial class FrmBodega : Form, IConfiguraciones
    {
        Usuario user;

        public FrmBodega(Usuario user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void FrmBodega_Load(object sender, EventArgs e)
        {
            AplicarConfiguraciones();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVerInfo_Click(object sender, EventArgs e)
        {
            if (dgvBodega.SelectedRows.Count > 0)
            {
                Consola auxConsola;
                DataGridViewRow filaSeleccionada = dgvBodega.SelectedRows[0];
                int id = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);
                try
                {
                    auxConsola = ConsolaDao.Leer(id);
                    MessageBox.Show(auxConsola.ToString());
                }
                catch (ConsolaNoEncontradException ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una consola");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvBodega.SelectedRows.Count > 0)
            {
                Consola auxConsola;
                DataGridViewRow filaSeleccionada = dgvBodega.SelectedRows[0];
                int id = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);
                try
                {
                    auxConsola = ConsolaDao.Leer(id);
                    DialogResult resultado = MessageBox.Show(auxConsola.ToString() + "\n¿Desea eliminar consola del sistema?", "Eliminar consola", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (resultado == DialogResult.OK)
                    {
                        ConsolaDao.Eliminar(auxConsola.Id);
                    }

                    dgvBodega.DataSource = null;
                    dgvBodega.DataSource = ConsolaDao.Leer();
                }
                catch (ConsolaNoEncontradException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Seleccione una consola para eliminar");
            }
        }



        public void AplicarConfiguraciones()
        {
            Configuracion config = Archivos<Configuracion>.LeerConfiguracion("configuracion");
            FontFamily fontFamily = new FontFamily(config.Fuente);
            Font font = new Font(fontFamily, this.Font.Size, FontStyle.Regular);
            this.Font = font;
            this.BackColor = config.ColorFondo;



            dgvBodega.DataSource = ConsolaDao.Leer();
            btnEliminar.Visible = false;
            lblCategoria.Text = LogicaNegocio.ConsuntarCategoria(user);

            if (user.EsAdmin)
            {
                btnEliminar.Visible = true;
            }

        }

        private void btnOrdenarPorPrecio_Click(object sender, EventArgs e)
        {
            dgvBodega.DataSource = null;
            dgvBodega.DataSource = LogicaNegocio.OrdenarPorPrecio();
        }
    }

}
