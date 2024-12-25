using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ArmyCanteenManagementSystemTyProject
{
    public partial class RegistrationForm : Form
    {
        SqlConnection con = new SqlConnection(LoginForm.ConString);
        string imagePath = "";
        public RegistrationForm()
        {
            InitializeComponent();
            con.Open();
            customrcardNumberSetter();
        }
        void customrcardNumberSetter()
        {
            Random rand = new Random();
            long tempcardNo = long.Parse(rand.Next(1,999999).ToString("D6"));
            SqlCommand cmd = new SqlCommand("select * from registrationInfo where id=@tempcardNo",con);
            cmd.Parameters.AddWithValue("@tempcardNo", tempcardNo);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                customrcardNumberSetter();
                dr.Close();
            }
            else
            {
                cardNuTextBox.Text = rand.Next(1,999999).ToString("D6");
            }
            dr.Close();
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm _loginForm = new LoginForm();
            _loginForm.Show();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            // Check if card number is required
            if (fullNameTextBox.Text == "")
            {
                fullNameErrorProvider.SetError(fullNameTextBox, "Required Field");
                return;
            }
            else if (mobileNuTextBox.Text == "")
            {
                mobileNuErrorProvider.SetError(mobileNuTextBox, "Required Field");
                return;
            }
            else if (!long.TryParse(mobileNuTextBox.Text, out _))
            {
                MessageBox.Show("Mobile number should be numeric.");
                return;
            }
            else if (!int.TryParse(cardNuTextBox.Text, out _))
            {
                MessageBox.Show("Card number should be numeric.");
                return;
            }
            else if (cardNuTextBox.Text == "")
            {
                passErrorProvider.SetError(passTextBox, "Required Field");
                return;
            }
            else if (passTextBox.Text == "")
            {
                passErrorProvider.SetError(passTextBox, "Required Field");
                return;
            }
            else if (repassTextBox.Text == "")
            {
                repassErrorProvider.SetError(repassTextBox, "Required Field");
                return;
            }
            else if (imagePath == "")
            {
                MessageBox.Show("Please Select Card Image First");
                return;
            }
            else if (passTextBox.Text != repassTextBox.Text)
            {
                MessageBox.Show("Password Mismatch Please try again", "Password Mismatch");
                passTextBox.Text = "";
                repassTextBox.Text = "";
                return;
            }
            else
            {
                SqlCommand cmd = new SqlCommand("Insert into registrationInfo values(@id, @fullname, @mobileNo, @post, @password, @bdate, @file_path, @aprovalStatus)", con);
                cmd.Parameters.AddWithValue("@id", int.Parse(cardNuTextBox.Text));
                cmd.Parameters.AddWithValue("@fullname", fullNameTextBox.Text);
                cmd.Parameters.AddWithValue("@mobileNo", long.Parse(mobileNuTextBox.Text));
                cmd.Parameters.AddWithValue("@post", postComboBox.Text);
                cmd.Parameters.AddWithValue("@password", passTextBox.Text);
                cmd.Parameters.AddWithValue("@bdate", birthDatePicker.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@file_path", imagePath);
                cmd.Parameters.AddWithValue("@aprovalStatus", "pending");
                int temp = cmd.ExecuteNonQuery();
                
                if (postComboBox.Text == "Customer")
                {
                    SqlCommand cmd4 = new SqlCommand("Insert into Customer values(@cardNumber, @password, @post, @ap)", con);
                    cmd4.Parameters.AddWithValue("@cardNumber", int.Parse(cardNuTextBox.Text));
                    cmd4.Parameters.AddWithValue("@password", passTextBox.Text);
                    cmd4.Parameters.AddWithValue("@post", postComboBox.Text);
                    cmd4.Parameters.AddWithValue("@ap", "pending");
                    int temp2 = cmd4.ExecuteNonQuery();
                }
                else if (postComboBox.Text == "Army_Officer")
                {
                    SqlCommand cmd4 = new SqlCommand("Insert into Customer values(@cardNumber, @password, @post, @ap)", con);
                    cmd4.Parameters.AddWithValue("@cardNumber", int.Parse(cardNuTextBox.Text));
                    cmd4.Parameters.AddWithValue("@password", passTextBox.Text);
                    cmd4.Parameters.AddWithValue("@post", postComboBox.Text);
                    cmd4.Parameters.AddWithValue("@ap", "pending");
                    int temp2 = cmd4.ExecuteNonQuery();
                }
                else if (postComboBox.Text == "Nevy_Officer")
                {
                    SqlCommand cmd4 = new SqlCommand("Insert into Customer values(@cardNumber, @password, @post, @ap)", con);
                    cmd4.Parameters.AddWithValue("@cardNumber", int.Parse(cardNuTextBox.Text));
                    cmd4.Parameters.AddWithValue("@password", passTextBox.Text);
                    cmd4.Parameters.AddWithValue("@post", postComboBox.Text);
                    cmd4.Parameters.AddWithValue("@ap", "pending");
                    int temp2 = cmd4.ExecuteNonQuery();
                }
                else if (postComboBox.Text == "Civil_Officer")
                {
                    SqlCommand cmd4 = new SqlCommand("Insert into Customer values(@cardNumber, @password, @post, @ap)", con);
                    cmd4.Parameters.AddWithValue("@cardNumber", int.Parse(cardNuTextBox.Text));
                    cmd4.Parameters.AddWithValue("@password", passTextBox.Text);
                    cmd4.Parameters.AddWithValue("@post", postComboBox.Text);
                    cmd4.Parameters.AddWithValue("@ap", "pending");
                    int temp2 = cmd4.ExecuteNonQuery();
                }
                else if (postComboBox.Text == "Supplier")
                {
                    SqlCommand cmd4 = new SqlCommand("Insert into Supplier values(@cardNumber, @password, @name, @mobileNumber)", con);
                    cmd4.Parameters.AddWithValue("@cardNumber", int.Parse(cardNuTextBox.Text));
                    cmd4.Parameters.AddWithValue("@password", passTextBox.Text);
                    cmd4.Parameters.AddWithValue("@name", fullNameTextBox.Text);
                    cmd4.Parameters.AddWithValue("@mobileNumber", long.Parse(mobileNuTextBox.Text.ToString()));
                    int temp2 = cmd4.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Please Select valid option");
                    SqlCommand cmd10 = new SqlCommand("delete from registrationInfo where id = @cno", con);
                    cmd10.Parameters.AddWithValue("@cno", int.Parse(cardNuTextBox.Text));
                    cmd10.ExecuteNonQuery();
                }
                if (temp > 0)
                {
                    MessageBox.Show("Successfully Registered", "Success");
                    LoginForm _loginForm = new LoginForm();
                    _loginForm.Show();
                    this.Hide();
                }
            }
        }

        private void UplodeButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fd = new OpenFileDialog();
                fd.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.gif;*.png)|*.bmp;*.jpg;*.jpeg;*.gif;*.png";
                
                if(fd.ShowDialog() == DialogResult.OK)
                {
                    imagePath = fd.FileName;
                    CardImageBox.ImageLocation = imagePath;
                }
            }catch(Exception ee)
            {
                MessageBox.Show("Error" + ee.ToString());
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
