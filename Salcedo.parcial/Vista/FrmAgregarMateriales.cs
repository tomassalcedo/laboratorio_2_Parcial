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
    public partial class FrmAgregarMateriales : Form
    {
        public FrmAgregarMateriales()
        {
            InitializeComponent();
        }


        private void FrmAgregarMateriales_Load(object sender, EventArgs e)
        {
            numCantidad.Maximum = 5000;
            cbMateriales.Items.Add("Cable");
            cbMateriales.Items.Add("Plastico");
            cbMateriales.Items.Add("Tornillos");
            cbMateriales.Items.Add("Placas");
        }


        private void Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int cantidad = (int)numCantidad.Value;
            string material = cbMateriales.SelectedItem.ToString();

            switch (material)
            {
                case "Cable":
                    Datos.AgregarCable(cantidad);
                    break;

                case "Plastico":
                    Datos.AgregarPlastico(cantidad);
                    break;

                case "Tornillos":
                    Datos.AgregarTornillos(cantidad);
                    //Datos.CantidadTornillosDisponibles -= cantidad;
                    break;

                case "Placas":
                    Datos.AgregarPlacas(cantidad);
                    break;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
