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

namespace ArmyCanteenManagementSystemTyProject.Counter_Staff_Forms
{
    public partial class CounterStaffBillingHistory : Form
    {
        SqlConnection con = new SqlConnection(LoginForm.ConString);

        public CounterStaffBillingHistory()
        {
            InitializeComponent();
        }
        public void historySetter()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from CustomerBillingHistory where Bill_Created_By = @CCNO", con);
                cmd.Parameters.AddWithValue("@CCNO", CounterStaffDashboard.counterStaffCardNumber);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                billHistorydataGridView.DataSource = dt;
            }
            catch (Exception ee) {
                MessageBox.Show(ee.ToString(), "Error");
            }
        }
    }
}
