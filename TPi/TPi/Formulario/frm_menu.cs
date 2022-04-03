using TPi.Formulario;
namespace TPi
{
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        private void frm_menu_Load(object sender, EventArgs e)
        {
            frm_login login = new frm_login();
            login.ShowDialog();
        }
    }
}