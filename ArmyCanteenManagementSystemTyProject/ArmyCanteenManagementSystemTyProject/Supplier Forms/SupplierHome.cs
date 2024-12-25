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
                SqlCommand cmd = new SqlCommand("select * from Supplier where cardNumber=@CardNo and password=@pass", con);
                cmd.Parameters.AddWithValue("@CardNo", LoginForm.cardNumber);
                cmd.Parameters.AddWithValue("@pass", LoginForm.password);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                lblHiUsername.Text = "Hi, " + dt.Rows[0][2].ToString();

                cardNumberOfEmployeeLabel.Text = dt.Rows[0][0].ToString();
                nameOfEmployeeLabel.Text = dt.Rows[0][2].ToString();
                MobileNumberOfEmployeeLabel.Text = dt.Rows[0][3].ToString();              
                PasswordOfEmployeeLabel.Text = dt.Rows[0][1].ToString();         
                con.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString(), "Error");
            }
        }
    }
}
