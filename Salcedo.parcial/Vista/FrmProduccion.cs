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
    public partial class FrmProduccion : Form
    {
        public FrmProduccion()
        {
            InitializeComponent();
        }

        private void FrnProduccion_Load(object sender, EventArgs e)
        {
            cmbConsolas.Items.Add("Juegosfera");
            cmbConsolas.Items.Add("SuperArcadium2000");
            cmbConsolas.Items.Add("PolyStation5");

            cbAlmacenamiento.Items.Add(250);
            cbAlmacenamiento.Items.Add(500);
            cbAlmacenamiento.Items.Add(1000);
            cbTipoJuegosfera.Items.Add(ETiposJuegosfera.HDMI);
            cbTipoJuegosfera.Items.Add(ETiposJuegosfera.RCA);
            numCantidadNucleos.Minimum = 4;
            numCantidadNucleos.Maximum = 16;
            cbTipoJuegosfera.Visible = false;
            cmbPlacaWifi.Items.Add("Si");
            cmbPlacaWifi.Items.Add("No");
            pbConsola.Image = Properties.Resources.LogoEmpresa;


            cbCantJuegosArcadium.Items.Add(500);
            cbCantJuegosArcadium.Items.Add(1000);
            cbCantJuegosArcadium.Visible = false;
            btnFinalizarJuegosfera.Visible = false;
            lblCantJuegosArcadium.Visible = false;
            lblPlacaWifi.Visible = false;
            lblCantidadNucleos.Visible = false;
            lblTipoPoly.Visible = false;
            btnProducirMueble.Visible = false;
            btnColocarCircuitos.Visible = false;
            btnColocarPlasticos.Visible = false;
            btnColocarCableado.Visible = false;
            btnFinalizarPoly.Visible = false;
            btnEnviarABodega.Visible = false;
            cmbPlacaWifi.Visible = false;
            lblConsolaTerminada.Visible = false;
            numCantidadNucleos.Visible = false;
            cbTipoPoly.Visible = false;
            btnEnsamblarEsfera.Visible = false;
            pbProduccion.Visible = false;
            rtbInfoConsola.Visible = false;
            btnEnsamblarPoly.Visible = false;
            btnArmarPlaca.Visible = false;
            cbAlmacenamiento.Visible = false;
            lblAlmacenamiento.Visible = false;

            cbTipoPoly.Items.Add(ETiposPolyStation.Digital);
            cbTipoPoly.Items.Add(ETiposPolyStation.LectoraCD);
        }

        private void cmbConsolas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string consola = cmbConsolas.SelectedItem.ToString();

            if (consola == "SuperArcadium2000")
            {
                pbConsola.Image = Properties.Resources.SuperArcadiumV2;
                cbCantJuegosArcadium.Visible = true;
                lblCantJuegosArcadium.Visible = true;
                lblPlacaWifi.Visible = true;
                btnEnsamblarPoly.Visible = false;
                btnEnsamblarEsfera.Visible = false;
                numCantidadNucleos.Visible = false;
                lblCantidadNucleos.Visible = false;
                cbTipoJuegosfera.Visible = false;
                lblTipoPoly.Visible = false;
                cbTipoPoly.Visible = false;
                cmbPlacaWifi.Visible = true;
                btnFinalizarPoly.Visible = false;
                btnProducirMueble.Visible = true;
                lblAlmacenamiento.Visible = false;
                btnArmarPlaca.Visible = false;
                cbAlmacenamiento.Visible = false;

            }
            else if (consola == "Juegosfera")
            {
                cbCantJuegosArcadium.Visible = false;
                lblCantJuegosArcadium.Visible = false;
                btnProducirMueble.Visible = false;
                lblPlacaWifi.Visible = true;
                lblTipoPoly.Visible = true;
                btnFinalizarPoly.Visible = false;
                btnEnsamblarPoly.Visible = false;
                cbTipoJuegosfera.Visible = true;
                lblCantidadNucleos.Visible = true;
                btnEnsamblarEsfera.Visible = true;
                numCantidadNucleos.Visible = true;
                cbTipoPoly.Visible = true;
                lblAlmacenamiento.Visible = true;
                cmbPlacaWifi.Visible = true;
                numCantidadNucleos.Visible = false;
                lblCantidadNucleos.Visible = false;
                lblTipoPoly.Visible = true;
                cbTipoPoly.Visible = false;
                btnArmarPlaca.Visible = false;
                cbAlmacenamiento.Visible = true;
                pbConsola.Image = Properties.Resources.Juegosfera;
            }
            else if (consola == "PolyStation5")
            {
                numCantidadNucleos.Visible = true;
                lblTipoPoly.Visible = true;
                cbTipoPoly.Visible = true;
                btnEnsamblarEsfera.Visible = false;
                cbCantJuegosArcadium.Visible = false;
                lblCantJuegosArcadium.Visible = false;
                btnProducirMueble.Visible = false;
                cbTipoJuegosfera.Visible = false;
                lblAlmacenamiento.Visible = true;
                lblPlacaWifi.Visible = true;
                cbAlmacenamiento.Visible = true;
                cmbPlacaWifi.Visible = true;
                btnArmarPlaca.Visible = true;
                lblCantidadNucleos.Visible = true;
                pbConsola.Image = Properties.Resources.PolyStatation;
            }
        }

        private void btnProducirMueble_Click(object sender, EventArgs e)
        {
            if (Datos.CantidadTornillosDisponibles > 50)
            {

                if (!Decimal.TryParse(txtBoxPrecio.Text, out _))
                {
                    MessageBox.Show("Precio invalido.");
                    txtBoxPrecio.Focus();
                }
                pbProduccion.Visible = true;
                pbProduccion.Image = Properties.Resources.mueble;
                btnColocarPlasticos.Visible = true;
                Datos.DescontarTornillos(50);
            }
            else
            {
                MessageBox.Show("Sin tornillos para el mueble,hable con un supervisor");
            }
        }

        private void btnColocarPlasticos_Click(object sender, EventArgs e)
        {
            if (Datos.CantidadPlasticoDisponible > 100)
            {
                pbProduccion.Image = Properties.Resources.SuperArcadium;
                btnColocarCableado.Visible = true;
                btnProducirMueble.Visible = false;
                Datos.DescontarPlastico(100);
            }
            else
            {
                MessageBox.Show("Sin plastico para la consola,hable con un supervisor");
            }

        }

        private void btnColocarCableado_Click(object sender, EventArgs e)
        {
            if (Datos.MetrosDeCableDisponible > 500)
            {
                btnColocarPlasticos.Visible = false;
                MessageBox.Show("Colocando cables...Espere confirmacion");
                Thread.Sleep(1000);
                MessageBox.Show("Cables colados correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnColocarCableado.Visible = false;


                decimal precio;
                if (!Decimal.TryParse(txtBoxPrecio.Text, out precio))
                {
                    MessageBox.Show("Precio invalido.");
                    txtBoxPrecio.Focus();

                }
                float almacenamiento = 20;
                int cantidadJugadores = 2;
                string numeroDeSerie = Consola.GenerarNumeroDeSerieUnico();
                string conectividadInternet = cmbPlacaWifi.SelectedItem.ToString();
                int cantidadJuegos = (int)cbCantJuegosArcadium.SelectedItem;
                SuperArcadium2000 arcadium = new SuperArcadium2000(numeroDeSerie, precio, almacenamiento, cantidadJugadores, conectividadInternet, cantidadJuegos);
                Datos.DescontarCable(50);


                rtbInfoConsola.Visible = true;
                rtbInfoConsola.Text = arcadium.MostrarConsola();
                lblConsolaTerminada.Visible = true;
                btnCancelar.Enabled = false;
                btnEnviarABodega.Visible = true;
                Datos.EnviarConsolaABodega(arcadium);
            }
            else
            {
                MessageBox.Show("No hay cable disponible,hable con un supervisor");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnviarABodega_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnArmarPlaca_Click(object sender, EventArgs e)
        {
            if (Datos.CantidadDePlacasDisponibles > 1)
            {
                if (!Decimal.TryParse(txtBoxPrecio.Text, out _))
                {
                    MessageBox.Show("Precio invalido.");
                    txtBoxPrecio.Focus();
                }
                pbProduccion.Visible = true;
                pbProduccion.Image = Properties.Resources.placaPoly;
                btnEnsamblarPoly.Visible = true;
                Datos.DescontarPlacas(1);
            }
            else
            {
                MessageBox.Show("No hay placas disponibles,hable con un supervisor");
            }

        }

        private void btnEnsamblarPoly_Click(object sender, EventArgs e)
        {
            if (Datos.CantidadPlasticoDisponible > 100)
            {
                pbProduccion.Image = Properties.Resources.ensamblePoly;
                btnArmarPlaca.Visible = false;
                btnFinalizarPoly.Visible = true;
                Datos.DescontarPlastico(100);
            }
            else
            {
                MessageBox.Show("Sin plastico para la consola,hable con un supervisor");
            }

        }

        private void btnFinalizarPoly_Click(object sender, EventArgs e)
        {

            if (Datos.MetrosDeCableDisponible > 70)
            {
                btnEnsamblarPoly.Visible = false;
                MessageBox.Show("PolyStation finalizada");
                btnFinalizarPoly.Visible = false;
                string numeroDeSerie = Consola.GenerarNumeroDeSerieUnico();
                decimal precio;
                if (!Decimal.TryParse(txtBoxPrecio.Text, out precio))
                {
                    MessageBox.Show("El precio ingresado no es valido");
                }
                //= Convert.ToDecimal(txtBoxPrecio.Text);
                float almacenamiento = Convert.ToSingle(cbAlmacenamiento.SelectedItem);
                string conectividad = cmbPlacaWifi.SelectedItem.ToString();
                int cantNucleosProcesador = (int)numCantidadNucleos.Value;
                ETiposPolyStation tipo = (ETiposPolyStation)cbTipoPoly.SelectedItem;
                PolyStation_5 polyStation = new PolyStation_5(numeroDeSerie, precio, almacenamiento, 4, conectividad, cantNucleosProcesador, tipo);
                rtbInfoConsola.Visible = true;
                rtbInfoConsola.Text = polyStation.MostrarConsola();
                lblConsolaTerminada.Visible = true;
                btnCancelar.Enabled = false;
                btnEnviarABodega.Visible = true;
                Datos.EnviarConsolaABodega(polyStation);
                Datos.DescontarCable(70);
            }
            else
            {
                MessageBox.Show("No hay cable disponible,hable con un supervisor");
            }
        }

        private void btnEnsamblarEsfera_Click(object sender, EventArgs e)
        {
            if (Datos.CantidadPlasticoDisponible > 100)
            {
                if (!Decimal.TryParse(txtBoxPrecio.Text, out _))
                {
                    MessageBox.Show("Precio invalido.");
                    txtBoxPrecio.Focus();
                }
                pbProduccion.Visible = true;
                pbProduccion.Image = Properties.Resources.esfera;
                btnColocarCircuitos.Visible = true;
                Datos.DescontarPlastico(100);
            }
            else
            {
                MessageBox.Show("No hay materiales disponibles,hable con un supervisor");
            }

        }

        private void btnColocarCircuitos_Click(object sender, EventArgs e)
        {
            if (Datos.MetrosDeCableDisponible > 80)
            {
                pbProduccion.Image = Properties.Resources.juegosfera1;
                btnEnsamblarEsfera.Visible = false;
                btnFinalizarJuegosfera.Visible = true;
            }
            else
            {
                MessageBox.Show("No hay cable disponible,hable con un supervisor");
            }

        }

        private void btnFinalizarJuegosfera_Click(object sender, EventArgs e)
        {
            if (Datos.CantidadDePlacasDisponibles > 1)
            {
                btnColocarCircuitos.Visible = false;
                MessageBox.Show("Juegosfera finalizada");
                btnFinalizarJuegosfera.Visible = false;
                string numeroDeSerie = Consola.GenerarNumeroDeSerieUnico();
                decimal precio = Convert.ToDecimal(txtBoxPrecio.Text);
                float almacenamiento = Convert.ToSingle(cbAlmacenamiento.SelectedItem);
                string conectividad = cmbPlacaWifi.SelectedItem.ToString();
                ETiposJuegosfera tipo = (ETiposJuegosfera)cbTipoJuegosfera.SelectedItem;
                Juegosfera juegosfera = new Juegosfera(numeroDeSerie, precio, almacenamiento, 2, conectividad, tipo);
                rtbInfoConsola.Visible = true;
                rtbInfoConsola.Text = juegosfera.MostrarConsola();
                lblConsolaTerminada.Visible = true;
                btnCancelar.Enabled = false;
                btnEnviarABodega.Visible = true;
                Datos.DescontarPlacas(1);
                Datos.EnviarConsolaABodega(juegosfera);
            }
            else
            {
                MessageBox.Show("Sin materiales para finalizar consola,hable con un supervisor");
            }

        }




    }
}
