using ArmyCanteenManagementSystemTyProject.Customer_Forms;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ArmyCanteenManagementSystemTyProject.Counter_Staff_Forms
{
    public partial class CustomerLoginForm : Form
    {
        long customerCardNumber;
        int customerPassword;
        public CustomerLoginForm()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (cardNumberTextBox.Text == "")
            {
                MessageBox.Show("Card Number is Empty !! ", "Required Field Empty Error");
            }
            else if (passwordTextbox.Text == "")
            {
                MessageBox.Show("Password is Empty !! ", "Required Field Empty Error");
            }
            else
            {
                SqlConnection con = new SqlConnection(LoginForm.ConString);
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select * from registrationInfo where Id=@cNo and password=@pass and aprovalStatus=@ap", con);
                    cmd.Parameters.AddWithValue("@cNo", int.Parse(cardNumberTextBox.Text));
                    cmd.Parameters.AddWithValue("@pass", int.Parse(passwordTextbox.Text));
                    cmd.Parameters.AddWithValue("@ap", "approved");
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        customerCardNumber = int.Parse(cardNumberTextBox.Text);
                        customerPassword = int.Parse(passwordTextbox.Text);
                        MessageBox.Show("Welcome Back ", "Successfully Login");
                        CustomerHomeDashboard _customerHomeDashboard = new CustomerHomeDashboard();
                        _customerHomeDashboard.valueSetter(customerCardNumber, customerPassword);
                        _customerHomeDashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Card Number or Password is incorrect try again", "Login Failed");
                    }
                }
                catch (Exception temp)
                {
                    MessageBox.Show(temp.ToString(), "Error");
                }
                con.Close();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            CounterStaffDashboard _counterStaffDashBoard = new CounterStaffDashboard(CounterStaffDashboard.counterStaffCardNumber, CounterStaffDashboard.counterStaffPassword);
            _counterStaffDashBoard.Show();
            this.Hide();
        }
    }
}
