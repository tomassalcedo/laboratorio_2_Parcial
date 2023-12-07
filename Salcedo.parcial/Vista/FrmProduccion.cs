using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmProduccion : Form, IConfiguraciones
    {

        private SuperArcadium2000 arcadium;
        private PolyStation_5 poly;
        private Juegosfera juegosfera;
        private Usuario usuario;

        public FrmProduccion(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void FrnProduccion_Load(object sender, EventArgs e)
        {
            AplicarConfiguraciones();

        }

        private void cmbConsolas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string consola = cmbConsolas.SelectedItem.ToString();

            if (consola == "SuperArcadium2000")
            {
                pbConsola.Image = Properties.Resources.SuperArcadiumV2;
                txtNombre.Text = "SuperArcadium2000";

                btnEnsamblarPoly.Visible = false;
                btnEnsamblarEsfera.Visible = false;
                btnFinalizarPoly.Visible = false;
                btnArmarPlaca.Visible = false;
            }
            else if (consola == "Juegosfera")
            {
                btnProducirMueble.Visible = false;
                btnFinalizarPoly.Visible = false;
                btnEnsamblarPoly.Visible = false;
                txtNombre.Text = "Juegosfera";
                btnArmarPlaca.Visible = false;
                pbConsola.Image = Properties.Resources.Juegosfera;
            }
            else if (consola == "PolyStation5")
            {
                txtNombre.Text = "Polystation5";
                btnEnsamblarEsfera.Visible = false;
                btnProducirMueble.Visible = false;
                pbConsola.Image = Properties.Resources.PolyStatation;
            }
        }

        private void btnProducirMueble_Click(object sender, EventArgs e)
        {
            try
            {
                Stock.DescontarTornillos(50);
                pbProduccion.Visible = true;
                pbProduccion.Image = Properties.Resources.mueble;
                btnColocarPlasticos.Visible = true;
                btnProducirMueble.Visible = false;
            }
            catch (MiExcepcion ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnColocarPlasticos_Click(object sender, EventArgs e)
        {
            try
            {
                Stock.DescontarPlastico(40);
                pbProduccion.Image = Properties.Resources.SuperArcadium;
                btnColocarCableado.Visible = true;
                btnProducirMueble.Visible = false;
                btnColocarPlasticos.Visible = false;

            }
            catch (StockInsuficienteExeption ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnColocarCableado_Click(object sender, EventArgs e)
        {
            try
            {
                Stock.DescontarCable(50);
                btnColocarPlasticos.Visible = false;
                MessageBox.Show("Cables colados correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnColocarCableado.Visible = false;
                rtbInfoConsola.Visible = true;
                rtbInfoConsola.Text = arcadium.ToString();
                lblConsolaTerminada.Visible = true;
                btnCancelar.Enabled = false;
                btnEnviarABodega.Visible = true;
                ConsolaDao.Guardar(arcadium);
            }
            catch (StockInsuficienteExeption ex)
            {
                MessageBox.Show(ex.Message);
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
            try
            {
                Stock.DescontarPlacas(1);
                pbProduccion.Visible = true;
                pbProduccion.Image = Properties.Resources.placaPoly;
                btnEnsamblarPoly.Visible = true;
                btnArmarPlaca.Visible = false;
            }
            catch (StockInsuficienteExeption ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEnsamblarPoly_Click(object sender, EventArgs e)
        {
            try
            {
                Stock.DescontarPlastico(30);
                pbProduccion.Image = Properties.Resources.ensamblePoly;
                btnFinalizarPoly.Visible = true;
                btnEnsamblarPoly.Visible = false;
            }
            catch (StockInsuficienteExeption ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFinalizarPoly_Click(object sender, EventArgs e)
        {

            try
            {
                Stock.DescontarCable(70);
                MessageBox.Show("PolyStation finalizada");
                btnFinalizarPoly.Visible = false;
                rtbInfoConsola.Visible = true;
                rtbInfoConsola.Text = poly.ToString();
                lblConsolaTerminada.Visible = true;
                btnCancelar.Enabled = false;
                btnEnviarABodega.Visible = true;
                ConsolaDao.Guardar(poly);

            }
            catch (StockInsuficienteExeption ex)
            {
                MessageBox.Show(ex.Message);
            }





        }

        private void btnEnsamblarEsfera_Click(object sender, EventArgs e)
        {
            try
            {
                Stock.DescontarPlastico(40);
                pbProduccion.Visible = true;
                pbProduccion.Image = Properties.Resources.esfera;
                btnColocarCircuitos.Visible = true;

                btnEnsamblarEsfera.Visible = false;
            }
            catch (MiExcepcion ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnColocarCircuitos_Click(object sender, EventArgs e)
        {
            try
            {
                Stock.DescontarCable(5);
                pbProduccion.Image = Properties.Resources.juegosfera1;
                btnColocarCircuitos.Visible = false;
                btnFinalizarJuegosfera.Visible = true;
            }
            catch (MiExcepcion ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFinalizarJuegosfera_Click(object sender, EventArgs e)
        {
            try
            {
                Stock.DescontarPlacas(1);
                MessageBox.Show("Juegosfera finalizada");
                btnFinalizarJuegosfera.Visible = false;
                rtbInfoConsola.Visible = true;
                rtbInfoConsola.Text = juegosfera.ToString();
                lblConsolaTerminada.Visible = true;
                btnCancelar.Enabled = false;
                btnEnviarABodega.Visible = true;

                ConsolaDao.Guardar(juegosfera);
            }
            catch (MiExcepcion ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnGuardarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                int almacenamiento = Convert.ToInt32(cbAlmacenamiento.SelectedItem);
                DateTime fechaProduccion = DateTime.Now;
                int cantidadJugadores = (int)nudJugadores.Value;
                string nombre = txtNombre.Text;
                bool wifi = false;

                if (cmbPlacaWifi.SelectedItem == "Si")
                {
                    wifi = true;
                }

                if (almacenamiento != 0 && cantidadJugadores != 0)
                {
                    if (cmbConsolas.SelectedItem == "SuperArcadium2000")
                    {
                        cmbConsolas.Enabled = false;
                        btnProducirMueble.Visible = true;
                        btnGuardarDatos.Enabled = false;
                        arcadium = new SuperArcadium2000(0, fechaProduccion, 0, almacenamiento, cantidadJugadores, wifi, nombre);
                        arcadium.CalcularPrecio();
                        txtPrecio.Text = arcadium.Precio.ToString();

                    }
                    else if (cmbConsolas.SelectedItem == "PolyStation5")
                    {
                        cmbConsolas.Enabled = false;
                        btnArmarPlaca.Visible = true;
                        btnGuardarDatos.Enabled = false;
                        poly = new PolyStation_5(0, fechaProduccion, 0, almacenamiento, cantidadJugadores, wifi, nombre);
                        poly.CalcularPrecio();
                        txtPrecio.Text = poly.Precio.ToString();
                    }
                    else if (cmbConsolas.SelectedItem == "Juegosfera")
                    {
                        cmbConsolas.Enabled = false;
                        btnEnsamblarEsfera.Visible = true;
                        btnGuardarDatos.Enabled = false;
                        juegosfera = new Juegosfera(0, fechaProduccion, 0, almacenamiento, cantidadJugadores, wifi, nombre);
                        juegosfera.CalcularPrecio();
                        txtPrecio.Text = juegosfera.Precio.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor llene todos los campos");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        public void AplicarConfiguraciones()
        {
            Configuracion config = Archivos<Configuracion>.LeerConfiguracion("configuracion");
            FontFamily fontFamily = new FontFamily(config.Fuente);
            Font font = new Font(fontFamily, this.Font.Size, FontStyle.Regular);
            this.Font = font;
            this.BackColor = config.ColorFondo;

            cmbConsolas.Items.Add("Juegosfera");
            cmbConsolas.Items.Add("SuperArcadium2000");
            cmbConsolas.Items.Add("PolyStation5");
            cbAlmacenamiento.Items.Add(64);
            cbAlmacenamiento.Items.Add(128);
            cbAlmacenamiento.Items.Add(256);
            txtNombre.Enabled = false;
            txtPrecio.Enabled = false;
            cmbPlacaWifi.Items.Add("Si");
            cmbPlacaWifi.Items.Add("No");
            pbConsola.Image = Properties.Resources.LogoEmpresa;
            btnFinalizarJuegosfera.Visible = false;
            btnProducirMueble.Visible = false;
            btnColocarCircuitos.Visible = false;
            btnColocarPlasticos.Visible = false;
            btnColocarCableado.Visible = false;
            btnFinalizarPoly.Visible = false;
            btnEnviarABodega.Visible = false;
            lblConsolaTerminada.Visible = false;
            lblUsuario.Text = LogicaNegocio.ConsuntarCategoria(usuario);
            btnEnsamblarEsfera.Visible = false;
            pbProduccion.Visible = false;
            rtbInfoConsola.Visible = false;
            btnEnsamblarPoly.Visible = false;
            btnArmarPlaca.Visible = false;
        }




    }
}
