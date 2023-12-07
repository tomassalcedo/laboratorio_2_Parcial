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
    public partial class FrmAgregarMateriales : Form, IConfiguraciones
    {
        public FrmAgregarMateriales()
        {
            InitializeComponent();
        }


        private void FrmAgregarMateriales_Load(object sender, EventArgs e)
        {
            AplicarConfiguraciones();
        }


        private void Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string material = string.Empty;
            int cantidad = Convert.ToInt32(numCantidad.Value);
            if (cbMateriales.SelectedItem != null && cantidad > 0)
            {
                material = cbMateriales.SelectedItem.ToString();


                switch (material)
                {
                    case "Cable":
                        Stock.AgregarCable(cantidad);
                        break;

                    case "Plastico":
                        Stock.AgregarPlastico(cantidad);
                        break;

                    case "Tornillos":
                        Stock.AgregarTornillos(cantidad);
                        break;

                    case "Placas":
                        Stock.AgregarPlacas(cantidad);
                        break;
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione un material/Cantidad");
            }
        }



        public void AplicarConfiguraciones()
        {
            Configuracion config = Archivos<Configuracion>.LeerConfiguracion("configuracion");
            FontFamily fontFamily = new FontFamily(config.Fuente);
            Font font = new Font(fontFamily, this.Font.Size, FontStyle.Regular);
            this.Font = font;
            this.BackColor = config.ColorFondo;


            numCantidad.Maximum = 5000;
            cbMateriales.Items.Add("Cable");
            cbMateriales.Items.Add("Plastico");
            cbMateriales.Items.Add("Tornillos");
            cbMateriales.Items.Add("Placas");
        }








    }
}
