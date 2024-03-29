using Entidades;
using System.Runtime.CompilerServices;

namespace Vista
{
    public partial class FrmMenuPrincipal : Form, IConfiguraciones
    {
        Usuario usuarioLogueado;


        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        public FrmMenuPrincipal(Usuario usuario) : this()
        {
            this.usuarioLogueado = usuario;
        }


        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            AplicarConfiguraciones();
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStockMateriales_Click(object sender, EventArgs e)
        {
            FrmStock frmStock = new FrmStock(usuarioLogueado);
            frmStock.ShowDialog();
        }

        private void btnProducirConsola_Click(object sender, EventArgs e)
        {
            FrmProduccion frmProduccion = new FrmProduccion(usuarioLogueado);
            frmProduccion.ShowDialog();
        }

        private void btnVerBodega_Click(object sender, EventArgs e)
        {
            FrmBodega frmBodega = new FrmBodega(usuarioLogueado);
            frmBodega.ShowDialog();
        }


        private void FrmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnVerUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios frmUsuarios = new FrmUsuarios(usuarioLogueado);
            frmUsuarios.ShowDialog();
        }

        private void btnCambiarUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
            this.Close();


        }


        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            FrmConfiguracion frmConfiguracion = new FrmConfiguracion(usuarioLogueado);
            frmConfiguracion.ShowDialog();
            if (frmConfiguracion.DialogResult == DialogResult.OK)
            {
                AplicarConfiguraciones();
            }

        }


        public void AplicarConfiguraciones()
        {
            Configuracion config = Archivos<Configuracion>.LeerConfiguracion("configuracion");
            FontFamily fontFamily = new FontFamily(config.Fuente);
            Font font = new Font(fontFamily, this.Font.Size, FontStyle.Regular);
            this.Font = font;
            this.BackColor = config.ColorFondo;

            lblCategoria.Text = LogicaNegocio.ConsuntarCategoria(usuarioLogueado);
            this.lblFecha.Text = $"Fecha: {DateTime.Now.ToShortDateString()}";
            btnVerUsuarios.Visible = false;

            if (usuarioLogueado.EsAdmin)
            {
                btnVerUsuarios.Visible = true;
            }
        }


    }
}