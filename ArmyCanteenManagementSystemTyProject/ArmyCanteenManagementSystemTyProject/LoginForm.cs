using ArmyCanteenManagementSystemTyProject.Admin_Forms;
using ArmyCanteenManagementSystemTyProject.Counter_Staff_Forms;
using ArmyCanteenManagementSystemTyProject.Supplier;
using Microsoft.VisualBasic;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ArmyCanteenManagementSystemTyProject
{
    public partial class LoginForm : Form
    {
        //public static string ConString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=K:\\Project With Design\\ArmyCanteenManagementSystemTyProject\\ArmyCanteenManagementSystemTyProject\\StyledFormDatabse.mdf;Integrated Security = True";
        public static string ConString = "Data Source=DESKTOP-K3S0H2D\\SQLEXPRESS;Initial Catalog=ArmyCanteenManagementSystemDBSSMS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
        SqlConnection con = new SqlConnection(ConString);
        byte adminOrstaffcheacker = 0;
        int inputValidator;
        public static long cardNumber;
        public static int password;
        public LoginForm()
        {
            InitializeComponent();
            con.Open();
        }
        public bool digitVerifier()
        {
            if (int.TryParse(cardNoTextBox.Text.ToString(), out int temp2))
            {
                return true;
            }
            return false;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (FieldValidator.IsEmpty(cardNoTextBox.Text, "cardNoTextBox"))
            {
                CardNumberErrorProvider.SetError(cardNoTextBox, "Required Filled");
            }
            else if (FieldValidator.IsEmpty(passwordTextBox.Text, "passwordTextBox"))
            {
                passwordErroProvider.SetError(passwordTextBox, "Enter Password");
            }
            else if (FieldValidator.IsNumeric(cardNoTextBox.Text, "cardNumber"))
            {
                CardNumberErrorProvider.SetError(cardNoTextBox, "Enter Number Only");
            }
            else if (FieldValidator.IsNumeric(passwordTextBox.Text, "passwordTextBox"))
            {
                passwordErroProvider.SetError(passwordTextBox, "Enter Number Only");
            }
            else
            {
                if (adminOrstaffcheacker == 0)
                {
                    MessageBox.Show("Select The User First", "User Undifined");
                }
                else if (adminOrstaffcheacker == 1)
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("select * from registrationInfo where Id=@id and password=@pass and aprovalStatus='approved' and Post = 'Admin'", con);
                        cmd.Parameters.AddWithValue("@id", int.Parse(cardNoTextBox.Text));
                        cmd.Parameters.AddWithValue("@pass", int.Parse(passwordTextBox.Text));

                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            dr.Close();
                            cardNumber = long.Parse(cardNoTextBox.Text.ToString());
                            password = int.Parse(passwordTextBox.Text.ToString());
                            MessageBox.Show("Welcome Back Admin","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            AdminDashboard temp = new AdminDashboard(long.Parse(cardNoTextBox.Text.ToString()), int.Parse(passwordTextBox.Text.ToString()));
                            ActiveForm.Hide();
                            temp.Show();
                        }
                        else
                        {
                            MessageBox.Show("Something Wrong Please cheack password and card no else Approval is still pending");
                        }
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message);
                    }

                }
                else if (adminOrstaffcheacker == 2)
                {
                    try
                    {

                        SqlCommand cmd = new SqlCommand("select * from registrationInfo where Id=@id and password=@pass and aprovalStatus='approved' and Post = 'Counter_Staff'", con);

                        cmd.Parameters.AddWithValue("@id", int.Parse(cardNoTextBox.Text));
                        cmd.Parameters.AddWithValue("@pass", int.Parse(passwordTextBox.Text));
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            cardNumber = long.Parse(cardNoTextBox.Text.ToString());
                            password = int.Parse(passwordTextBox.Text.ToString());
                            MessageBox.Show("Welcome Back CounterStaff", "Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            CounterStaffDashboard temp = new CounterStaffDashboard(long.Parse(cardNoTextBox.Text), int.Parse(passwordTextBox.Text));
                            ActiveForm.Hide();
                            temp.Show();
                        }
                        else
                        {
                            MessageBox.Show("Failed to login");
                        }

                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message);
                    }

                }
                else if (adminOrstaffcheacker == 3)
                {

                    try
                    {
                        SqlCommand cmd = new SqlCommand("select * from registrationInfo where Id=@id and password=@pass and aprovalStatus='approved' and Post = 'Supplier' ", con);

                        cmd.Parameters.AddWithValue("@id", int.Parse(cardNoTextBox.Text));
                        cmd.Parameters.AddWithValue("@pass", int.Parse(passwordTextBox.Text));
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            cardNumber = long.Parse(cardNoTextBox.Text.ToString());
                            password = int.Parse(passwordTextBox.Text.ToString());
                            MessageBox.Show("Welcome Back Supplier", "Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            SupplierDashboard temp = new SupplierDashboard();
                            this.Hide();
                            temp.Show();
                            dr.Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed to login");
                        }
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message);
                    }
                }
            }
        }
        private void adminButton_Clicked(object sender, EventArgs e)
        {
            adminOrstaffcheacker = 1;
        }
        private void adminButton_MouseHover(object sender, EventArgs e)
        {
            adminButton.BackColor = Color.Red;
        }
        private void counterStaffButton_Clicked(object sender, EventArgs e)
        {
            adminOrstaffcheacker = 2;
        }
        private void counterStaffButton_MouseHover(object sender, EventArgs e)
        {
            counterStaffButton.BackColor = Color.Red;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm _registrationForm = new RegistrationForm();
            _registrationForm.Show();
            this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.Refresh();
            this.ResetText();
        }

        private void showPasswordButton_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordButton.Checked)
            {
                passwordTextBox.PasswordChar = '\0';
            }
            else
            {
                passwordTextBox.PasswordChar = '*';
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            adminOrstaffcheacker = 3;
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!digitVerifier())
            {
                MessageBox.Show("Enter Only number");
                cardNoTextBox.Text = "";
                passwordTextBox.Text = "";
            }
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Will Implement Soon", "Sorry For Your Inconvineus",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
