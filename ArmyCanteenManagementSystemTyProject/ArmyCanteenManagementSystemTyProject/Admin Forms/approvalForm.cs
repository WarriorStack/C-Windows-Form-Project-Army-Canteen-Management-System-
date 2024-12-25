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
    public partial class approvalForm : Form
    {
        SqlConnection con = new SqlConnection(LoginForm.ConString);
        int rowindex;
        public approvalForm()
        {
            InitializeComponent();
            con.Open();
            setComponents();
        }
        void setComponents()
        {
            if(StatuscomboBox.SelectedIndex == 0)
            {
                SqlCommand cmd = new SqlCommand("select * from registrationInfo", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                registrationTableViewerDataGridView.DataSource = dt;
            }
            else if(StatuscomboBox.SelectedIndex == 1)
            {
                SqlCommand cmd = new SqlCommand("select * from registrationInfo where aprovalStatus = @approved",con);
                cmd.Parameters.AddWithValue("@pending", "approved");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                registrationTableViewerDataGridView.DataSource = dt;
            }
            else if (StatuscomboBox.SelectedIndex == 2)
            {
                SqlCommand cmd = new SqlCommand("select * from registrationInfo where aprovalStatus = @pending", con);
                cmd.Parameters.AddWithValue("@pending", "pending");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                registrationTableViewerDataGridView.DataSource = dt;
            }
        }

        private void registrationTableViewerDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
            rowindex = e.RowIndex;
            string file_path = registrationTableViewerDataGridView.Rows[rowindex].Cells[6].Value.ToString();
            cardPictureBox.Load(file_path);
            }catch(Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void giveApprovalButton_Click(object sender, EventArgs e)
        {
            try
            {
                int a = 0;
                int id = int.Parse(registrationTableViewerDataGridView.Rows[rowindex].Cells[0].Value.ToString());
                SqlCommand cmd = new SqlCommand("Update registrationInfo set aprovalStatus = @approved where Id = @id",con);
                cmd.Parameters.AddWithValue("@approved", "approved");
                cmd.Parameters.AddWithValue("@id", id);
                if(MessageBox.Show("Are You Sure To Approve it", "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if ((a = cmd.ExecuteNonQuery()) != 0)
                    {
                        MessageBox.Show("Updated Successfully");
                        setComponents();
                    }
                }
            }catch(Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
    }
}
