
using Service.Interfaces;

namespace CapaPresentacion.Vistas
{
    public partial class Login : Form
    {
        private readonly IUsuarios _usuarios;
        public Login()
        {
            InitializeComponent();

        }

        private async void RegisterButton_Click(object sender, EventArgs e)
        {
        }

        private async void Login_Load(object sender, EventArgs e) { 
        }
    }
}
