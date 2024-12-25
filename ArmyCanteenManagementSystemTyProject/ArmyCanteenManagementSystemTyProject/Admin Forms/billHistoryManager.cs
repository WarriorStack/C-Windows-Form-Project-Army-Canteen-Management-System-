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

namespace ArmyCanteenManagementSystemTyProject.Admin_Forms
{
    public partial class billHistoryManager : Form
    {
        private SqlConnection con = new SqlConnection(LoginForm.ConString);
        public billHistoryManager()
        {
            InitializeComponent();
            con.Open();
            alltimeRadioButton_CheckedChanged(null, null);
        }

        private void gridViewSetter(SqlCommand cmd)
        {
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            billhistoryDataGridView.DataSource = dt;
        }

        private void alltimeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from CustomerBillingHistory", con);
            gridViewSetter(cmd);
        }

        private void weakRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from CustomerBillingHistory where (DATEDIFF(day, Bill_Date, GETDATE()) <= 7)", con);
            gridViewSetter(cmd);
        }

        private void todayRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from CustomerBillingHistory where (DATEDIFF(day, Bill_Date, GETDATE()) <= 1)", con);
            gridViewSetter(cmd);
        }
    }
}