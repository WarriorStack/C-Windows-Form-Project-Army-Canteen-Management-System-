using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ArmyCanteenManagementSystemTyProject.Counter_Staff_Forms
{
    public partial class Home : Form
    {
        long userCardNumber;
        int userPassword;
        public Home()
        {
            InitializeComponent();
        }
        public Home(long cardNumber, int pass)
        {
            InitializeComponent();
            userCardNumber = cardNumber;
            userPassword = pass;
            PersonalInfoSetter();
        }
        void PersonalInfoSetter()
        {
            SqlConnection con = new SqlConnection(LoginForm.ConString);
            con.Open();
            string cmd = "select * from registrationInfo where Id=@cNo and password=@pass";
            SqlDataAdapter da = new SqlDataAdapter(cmd, con);
            da.SelectCommand.Parameters.AddWithValue("@cNo", userCardNumber);
            da.SelectCommand.Parameters.AddWithValue("@pass", userPassword);
            DataTable dt = new DataTable();
            da.Fill(dt);

            lblHiUsername.Text = "Hi, " + dt.Rows[0][1].ToString();
            cardNumberOfEmployeeLabel.Text = dt.Rows[0][0].ToString();
            nameOfEmployeeLabel.Text = dt.Rows[0][1].ToString();
            MobileNumberOfEmployeeLabel.Text = dt.Rows[0][2].ToString();
            postOfEmployeeLabel.Text = dt.Rows[0][3].ToString();
            PasswordOfEmployeeLabel.Text = dt.Rows[0][4].ToString();
            BirthdateXlabel.Text = dt.Rows[0][5].ToString();
            cardPictureBox.ImageLocation = dt.Rows[0][6].ToString();
        }

        private void guna2CustomGradientPanel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
