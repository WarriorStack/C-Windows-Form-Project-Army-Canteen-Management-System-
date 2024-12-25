using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ArmyCanteenManagementSystemTyProject.Admin_Forms
{
    public partial class orderManagementAndHistoryForm : Form
    {
        int temp;
        SqlConnection con = new SqlConnection(LoginForm.ConString);
        public orderManagementAndHistoryForm()
        {
            InitializeComponent();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from purchaseOrderHistory", con);
            gridViewSetter(cmd);
        }
        void gridViewSetter(SqlCommand cmd)
        {
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            orderHistoryDataGridView.DataSource = dt;
        }
        bool GetSelectedOrderNumber()
        {
            if (orderHistoryDataGridView.SelectedRows.Count > 0)
            {
                temp = orderHistoryDataGridView.SelectedRows[0].Index;
                return true;
            }
            else
            {
                return false;
            }
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from purchaseOrderHistory where State like @State + '%'", con);
            cmd.Parameters.AddWithValue("@State", SearchTextBox.Text.ToString());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            orderHistoryDataGridView.DataSource = dt;
        }

        private void alltimeradioButton_CheckedChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from purchaseOrderHistory", con);
            gridViewSetter(cmd);
        }

        private void thisMonthradioButton_CheckedChanged(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM purchaseOrderHistory WHERE MONTH(Order_Date) = MONTH(GETDATE())", con);
            gridViewSetter(cmd);
        }

        private void ThisWeekradioButton_CheckedChanged(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM purchaseOrderHistory WHERE DATEPART(wk, Order_Date) = DATEPART(wk, GETDATE())", con);
            gridViewSetter(cmd);
        }

        private void TodayradioButton_CheckedChanged(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM purchaseOrderHistory WHERE Order_Date = CONVERT(DATE, GETDATE())", con);
            gridViewSetter(cmd);
        }

        private void updateStateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (GetSelectedOrderNumber())
                {

                    // if (orderHistoryDataGridView.Rows[temp].Cells[6].Value.ToString() == "Pending")
                    //{
                    if (MessageBox.Show("Want To Update Order State To Delivered", "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        int a = 0;
                        SqlCommand cmd = new SqlCommand("UPDATE purchaseOrderHistory SET State = @newState WHERE Order_Number = @oNo", con);
                        cmd.Parameters.AddWithValue("@newState", "Delivered");
                        cmd.Parameters.AddWithValue("@oNo", int.Parse(orderHistoryDataGridView.Rows[temp].Cells[0].Value.ToString()));
                        a = cmd.ExecuteNonQuery();
                        if (a != 0)
                        {
                            MessageBox.Show("Successfully Changed");
                            SqlCommand cmd2 = new SqlCommand("Select * from purchaseOrderHistory", con);
                            gridViewSetter(cmd2);
                           
                        }
                    }
                    //}
                    //else if (orderHistoryDataGridView.Rows[temp].Cells[6].Value.ToString() == "Delivered")
                    //{
                    //    if (MessageBox.Show("Want To Update Order State To Pending", "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    //    {
                    //        int a = 0;
                    //        SqlCommand cmd = new SqlCommand("UPDATE purchaseOrderHistory SET State = @newState WHERE OrderNumber = @oNo", con);
                    //        cmd.Parameters.AddWithValue("@newState", "Pending");
                    //        cmd.Parameters.AddWithValue("@oNo", int.Parse(orderHistoryDataGridView.Rows[temp].Cells[0].Value.ToString()));
                    //        a = cmd.ExecuteNonQuery();
                    //        if (a != 0)
                    //        {
                    //            MessageBox.Show("Successfully Changed");
                    //        }
                    //    }
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Error");
                    //}
                }
                else
                {
                    MessageBox.Show("Select Row First");
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
    }
}
