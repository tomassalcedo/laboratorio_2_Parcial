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
    public partial class FrmBodega : Form
    {
        Usuario user;
        static List<Consola> bodega;

        static FrmBodega()
        {
            bodega = Datos.HardCodearBodega();
        }
        public FrmBodega(Usuario user)
        {
            //  Datos.HardCodearBodega();
            InitializeComponent();
            this.user = user;
        }

        private void FrmBodega_Load(object sender, EventArgs e)
        {

            this.lblUsuario.Text = $"Usuario: {user.NombreUsuario}";
            dgvBodega.DataSource = bodega;
            

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvBodega.SelectedRows.Count > 0)//Si tengo seleccionado un elemento del dgv
            {
                Consola auxConsola;
                DataGridViewRow filaSeleccionada = dgvBodega.SelectedRows[0];
                string numeroSerie = filaSeleccionada.Cells["NumeroDeSerie"].Value.ToString(); //obtengo el numero de serie de la celda seleccionada
                auxConsola = Datos.BuscarConsolaPorNumeroDeSerie(numeroSerie);
                MessageBox.Show(auxConsola.MostrarConsola());
            }
            else
            {
                MessageBox.Show("Seleccione una consola");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVerInfo_Click(object sender, EventArgs e)
        {
            if (dgvBodega.SelectedRows.Count > 0)//Si tengo seleccionado un elemento del dgv
            {
                Consola auxConsola;
                DataGridViewRow filaSeleccionada = dgvBodega.SelectedRows[0];
                string numeroSerie = filaSeleccionada.Cells["NumeroDeSerie"].Value.ToString(); //obtengo el numero de serie de la celda seleccionada
                auxConsola = Datos.BuscarConsolaPorNumeroDeSerie(numeroSerie);
                MessageBox.Show(auxConsola.MostrarConsola());
            }
            else
            {
                MessageBox.Show("Seleccione una consola");
            }
        }
    }

}
