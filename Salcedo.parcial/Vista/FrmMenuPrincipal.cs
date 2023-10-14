using Entidades;
using System.Runtime.CompilerServices;

namespace Vista
{
    public partial class FrmMenuPrincipal : Form
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
            this.lblUsuario.Text = $"Usuario: {usuarioLogueado.NombreUsuario}";
            this.lblFecha.Text = $"Fecha: {DateTime.Now.ToShortDateString()}";
            btnVerUsuarios.Visible = false;
            
            if (usuarioLogueado.EsAdmin == true)
            {
                btnVerUsuarios.Visible = true;
            }
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
            FrmProduccion frmProduccion = new FrmProduccion();
            frmProduccion.ShowDialog();
        }

        private void btnVerBodega_Click(object sender, EventArgs e)
        {
            FrmBodega frmBodega = new FrmBodega(usuarioLogueado);
            frmBodega.ShowDialog();
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Usuario estado: {usuarioLogueado.EsAdmin}");
        }

        private void FrmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnVerUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios frmUsuarios = new FrmUsuarios();
            frmUsuarios.ShowDialog();
        }

        private void btnCambiarUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
            this.Close();
          

        }
    }
}