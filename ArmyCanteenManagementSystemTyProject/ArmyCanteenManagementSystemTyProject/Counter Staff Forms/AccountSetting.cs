using ArmyCanteenManagementSystemTyProject.Admin_Forms;
using ArmyCanteenManagementSystemTyProject.Customer_Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ArmyCanteenManagementSystemTyProject.Counter_Staff_Forms
{
    public partial class AccountSetting : Form
    {
        int formNo = 0;
        SqlConnection con = new SqlConnection(LoginForm.ConString);
        public AccountSetting()
        {
            InitializeComponent();
            con.Open();
        }
        public void valueSetter(int num)
        {
            this.formNo = num;
            PersonalInfoSetter();
        }
        void enabler()
        {
            enterNameTextBox.Enabled = true;
            confirmPasswordTextBox.Enabled = true;
            mobileNoTextBox.Enabled = true;
            newPasswordTextBox.Enabled = true;
            postTextBox.Enabled = true;
        }
        void PersonalInfoSetter()
        {
            //string cmd = "select * from registrationInfo where Id=@cNo and password=@pass";
            //SqlDataAdapter da = new SqlDataAdapter(cmd, con);
            //DataTable dt = new DataTable();
            switch (formNo)
            {
                case 0:
                    string cmd = "select * from registrationInfo where Id=@cNo and password=@pass";
                    SqlDataAdapter da = new SqlDataAdapter(cmd, con);
                    DataTable dt = new DataTable();
                    da.SelectCommand.Parameters.AddWithValue("@cNo", AdminHome.adminCardNumber);
                    da.SelectCommand.Parameters.AddWithValue("@pass", AdminHome.adminPasswored);
                    da.Fill(dt);
                    cardNumberOfEmployeeLabel.Text = dt.Rows[0][0].ToString();
                    nameOfEmployeeLabel.Text = dt.Rows[0][1].ToString();
                    MobileNumberOfEmployeeLabel.Text = dt.Rows[0][2].ToString();
                    postOfEmployeeLabel.Text = dt.Rows[0][3].ToString();
                    PasswordOfEmployeeLabel.Text = dt.Rows[0][4].ToString();
                    break;
                case 1:
                    string cmd1 = "select * from registrationInfo where Id=@cNo and password=@pass";
                    SqlDataAdapter da1 = new SqlDataAdapter(cmd1, con);
                    DataTable dt1 = new DataTable();
                    da1.SelectCommand.Parameters.AddWithValue("@cNo", CounterStaffDashboard.counterStaffCardNumber);
                    da1.SelectCommand.Parameters.AddWithValue("@pass", CounterStaffDashboard.counterStaffPassword);
                    da1.Fill(dt1);
                    cardNumberOfEmployeeLabel.Text = dt1.Rows[0][0].ToString();
                    nameOfEmployeeLabel.Text = dt1.Rows[0][1].ToString();
                    MobileNumberOfEmployeeLabel.Text = dt1.Rows[0][2].ToString();
                    postOfEmployeeLabel.Text = dt1.Rows[0][3].ToString();
                    PasswordOfEmployeeLabel.Text = dt1.Rows[0][4].ToString();
                    break;
                case 2:
                    string cmd2 = "select * from registrationInfo where Id=@cNo and password=@pass";
                    SqlDataAdapter da2 = new SqlDataAdapter(cmd2, con);
                    DataTable dt2 = new DataTable();
                    da2.SelectCommand.Parameters.AddWithValue("@cNo", CustomerHomeDashboard.CardNo);
                    da2.SelectCommand.Parameters.AddWithValue("@pass", CustomerHomeDashboard.Password);
                    da2.Fill(dt2);
                    cardNumberOfEmployeeLabel.Text = dt2.Rows[0][0].ToString();
                    nameOfEmployeeLabel.Text = dt2.Rows[0][1].ToString();
                    MobileNumberOfEmployeeLabel.Text = dt2.Rows[0][2].ToString();
                    postOfEmployeeLabel.Text = dt2.Rows[0][3].ToString();
                    PasswordOfEmployeeLabel.Text = dt2.Rows[0][4].ToString();
                    break;

            }

            //cardNumberOfEmployeeLabel.Text = dt.Rows[0][0].ToString();
            //nameOfEmployeeLabel.Text = dt.Rows[0][1].ToString();
            //MobileNumberOfEmployeeLabel.Text = dt.Rows[0][2].ToString();
            //postOfEmployeeLabel.Text = dt.Rows[0][3].ToString();
            //PasswordOfEmployeeLabel.Text = dt.Rows[0][4].ToString();
        }

        private void changeInfoButton_Click(object sender, EventArgs e)
        {
            enabler();
        }

        private void Confirmbutton_Click(object sender, EventArgs e)
        {
            if (!(enterNameTextBox.Text == "" && mobileNoTextBox.Text == "" && postTextBox.Text == "" && newPasswordTextBox.Text == "" && confirmPasswordTextBox.Text == ""))
            {

            if (newPasswordTextBox.Text == confirmPasswordTextBox.Text)
            {

                SqlCommand command = new SqlCommand("UPDATE registrationInfo SET FullName = @name, MobileNumber = @mobileNo, Post = @post, password = @password WHERE Id = @cardNo AND password = @password", con);
                command.Parameters.AddWithValue("@name", enterNameTextBox.Text);
                command.Parameters.AddWithValue("@mobileNo", long.Parse(mobileNoTextBox.Text.ToString()));
                command.Parameters.AddWithValue("@post", postTextBox.Text);
                command.Parameters.AddWithValue("@cardNo", long.Parse(cardNumberOfEmployeeLabel.Text.ToString()));
                command.Parameters.AddWithValue("@password", PasswordOfEmployeeLabel.Text);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Records updated successfully!");
                }
                else
                {
                    MessageBox.Show("No records found with matching cardNo and password.");
                }
            }
            else
            {
                MessageBox.Show("Both Passsword Mismatched try again", "Password Mismatch");
            }
            }
            else
            {
                MessageBox.Show("Wrong Input");
            }
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            new LoginForm().Show(); 
        }
    }

}
