using System.Windows.Forms;

namespace ArmyCanteenManagementSystemTyProject
{
    public partial class Main : Form
    {
        static RegistrationForm _registrationform = new RegistrationForm();
        static LoginForm _loginform = new LoginForm();
        public Main()
        {
            InitializeComponent();
            _loginform.MdiParent = this;
            _registrationform.MdiParent = this;
            loginFormOpener();
        }
        public static void loginFormOpener()
        {
            _loginform.Dock = DockStyle.Fill;
            _loginform.Show();
        }
        public static void loginFormCloser()
        {
            _loginform.Hide();
        }
        public static void registrationFormOpener()
        {
            _registrationform.Dock = DockStyle.Fill;
            _registrationform.Show();
        }
        public static void registrationFormCloser()
        {
            _registrationform.Hide();
        }

        private void closeButton_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void guna2TileButton1_Click(object sender, System.EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
