using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArmyCanteenManagementSystemTyProject.Supplier
{
    public partial class SupplierHome : Form
    {
        public SupplierHome()
        {
            InitializeComponent();
            personalInfoSetter();
        }
        void personalInfoSetter()
        {
            try
            {
                SqlConnection con = new SqlConnection(LoginForm.ConString);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Supplier where Id=@CardNo and password=@pass", con);
                da.SelectCommand.Parameters.AddWithValue("@CardNo", LoginForm.cardNumber);
                da.SelectCommand.Parameters.AddWithValue("@pass", LoginForm.password);
                DataTable dt = new DataTable();
                da.Fill(dt);

                lblHiUsername.Text = "Hi, " + dt.Rows[0][1].ToString();

                cardNumberOfEmployeeLabel.Text = dt.Rows[0][0].ToString();
                nameOfEmployeeLabel.Text = dt.Rows[0][1].ToString();
                MobileNumberOfEmployeeLabel.Text = dt.Rows[0][2].ToString();              
                PasswordOfEmployeeLabel.Text = dt.Rows[0][4].ToString();         
                con.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString(), "Error");
            }
        }
    }
}
