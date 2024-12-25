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

namespace ArmyCanteenManagementSystemTyProject.Customer_Forms
{
    public partial class CustomerBillHistory : Form
    {
        public CustomerBillHistory()
        {
            InitializeComponent();         
        }

        public void billHistoryManageMent()
        {
            try
            {
                SqlConnection con = new SqlConnection(LoginForm.ConString);
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from CustomerBillingHistory where Customer_Card_Number=@cardNum", con);
                cmd.Parameters.AddWithValue("@cardNum", CustomerHomeDashboard.CardNo);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                billingHistoryDataGridVies.DataSource = dt;
                if (dt.Rows.Count <= 0)
                {
                    MessageBox.Show("No Entry Found !! ");
                }
                con.Close();
            }catch(Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
    }
}
