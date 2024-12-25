using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ArmyCanteenManagementSystemTyProject.Customer_Forms
{
    public partial class CustomerHome : Form
    {
        public static string post;
        public static long counterStaffCardNumber;
        public static int counterStaffPassword;
        public static int postInNumber;
        public CustomerHome()
        {
            InitializeComponent();
        }
        public void valueSetter(long cardNo, int password)
        {
            counterStaffCardNumber = cardNo;
            counterStaffPassword = password;
            personalInfoSetter();
            allotedProductGridViewDataSetter();
        }
        void personalInfoSetter()
        {
            try
            {

                SqlConnection con = new SqlConnection(LoginForm.ConString);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from registrationInfo where Id=@CardNo and password=@pass", con);
                da.SelectCommand.Parameters.AddWithValue("@CardNo", counterStaffCardNumber);
                da.SelectCommand.Parameters.AddWithValue("@pass", counterStaffPassword);
                DataTable dt = new DataTable();
                da.Fill(dt);

                lblHiUsername.Text = "Hi, " + dt.Rows[0][1].ToString();

                cardNumberOfEmployeeLabel.Text = dt.Rows[0][0].ToString();
                nameOfEmployeeLabel.Text = dt.Rows[0][1].ToString();
                MobileNumberOfEmployeeLabel.Text = dt.Rows[0][2].ToString();
                postOfEmployeeLabel.Text = dt.Rows[0][3].ToString();
                post = dt.Rows[0][3].ToString();
                PasswordOfEmployeeLabel.Text = dt.Rows[0][4].ToString();
                BirthDateXLabel.Text = dt.Rows[0][5].ToString();
                cardPictureBox.ImageLocation = dt.Rows[0][6].ToString();
                con.Close();             
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString(), "Error");
            }
        }
//Customer
//Army_Officer
//Nevy_Officer
//Civil_Officer
        void allotedProductGridViewDataSetter()
        {

            try
            {
                if (post == "Customer")
                {
                    postInNumber = 0;
                }
                else if(post == "Army_Officer")
                {
                    postInNumber = 1;
                }
                else if(post == "Nevy_Officer")
                {
                    postInNumber = 1;
                }
                else if(post == "Civil_Officer")
                {
                    postInNumber = 2;
                }

                SqlConnection con = new SqlConnection(LoginForm.ConString);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT o.Id, 0.ProductId, o.ProductName, o.ProductPrice, o.AllotmentNo, o.MRP, o.Type  FROM orderProductsList o JOIN productinshelf p ON p.Product_Id = o.ProductId and o.AllotmentNo=@postInNumber", con);
                da.SelectCommand.Parameters.AddWithValue("@postInNumber", postInNumber);
                DataTable dt = new DataTable();
                da.Fill(dt);
                allotedProductDataGridView.DataSource = dt;
                con.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString(), "Error");
            }
        }

        private void personalInfoGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
