using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArmyCanteenManagementSystemTyProject.Admin_Forms
{
    public partial class AdminHome : Form
    {
        SqlConnection con = new SqlConnection(LoginForm.ConString);
        public static long adminCardNumber;
        public static int adminPasswored;
        public AdminHome()
        {
            InitializeComponent();
        }
        public void idSetter(long aCardNo, int pass)
        {
            adminCardNumber = aCardNo;
            adminPasswored = pass;
            valueSetter();
        }
        public void valueSetter()
        {
            con.Open();
            
            SqlCommand cmd = new SqlCommand("select * from registrationInfo where Id=@id and password=@pass", con);
            cmd.Parameters.AddWithValue("@id", adminCardNumber);
            cmd.Parameters.AddWithValue("@pass", adminPasswored);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cardNumberOfEmployeeLabel.Text = dt.Rows[0][0].ToString();
            nameOfEmployeeLabel.Text = dt.Rows[0][1].ToString();
            MobileNumberOfEmployeeLabel.Text = dt.Rows[0][2].ToString();
            postOfEmployeeLabel.Text = dt.Rows[0][3].ToString();
            PasswordOfEmployeeLabel.Text = dt.Rows[0][4].ToString();
            BirthDateXLabel.Text = dt.Rows[0][5].ToString();
            approvalStatusXLable.Text = dt.Rows[0][7].ToString();
            cardPictureBox.Load(dt.Rows[0][6].ToString());
        }
    }
}
