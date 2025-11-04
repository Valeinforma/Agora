using Desktop.Views;

namespace Desktop.Views
{
    public partial class MenuPrincipalView : Form
    {
        public MenuPrincipalView()
        {
            InitializeComponent();
        }

        private void SubMenuSalirDelSistema_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubMenuUsuarios_Click(object sender, EventArgs e)
        {
            var usuariosView = new UsuariosView();
            usuariosView.MdiParent = this;
            usuariosView.Show();
        }

        private void SubMenuTipoInscripciones_Click(object sender, EventArgs e)
        {
            var tipoInscripcionView = new TipoInscripcionView();
            tipoInscripcionView.MdiParent = this;
            tipoInscripcionView.Show();

        }

        private void inscripcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var inscripcionesView = new InscripcionesView();
            inscripcionesView.MdiParent = this;
            inscripcionesView.Show();

        }

        private void SubMenuCapacitaciones_Click(object sender, EventArgs e)
        {
            var capacitacionesView = new CapacitacionesView();
            capacitacionesView.MdiParent = this;
            capacitacionesView.Show();

        }
    }
}
