using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ArmyCanteenManagementSystemTyProject.Supplier
{
    public partial class addProductForm : Form
    {
        SqlConnection con = new SqlConnection(LoginForm.ConString);
        string imagePath="";
        public addProductForm()
        {
            InitializeComponent();
            con.Open();
            dataGridViewSetter();
        }
        void dataGridViewSetter()
        {
            SqlCommand cmd = new SqlCommand("Select * from orderProductsList", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvAllProduct.DataSource = dt;
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            if (txtAllotmentNumber.Text == "" || txtId.Text == "" || txtMRP.Text == "" || txtName.Text == "" && txtPrice.Text == "")
            {
                MessageBox.Show("All Fields Are Required");
            }
            else
            {
                int dr = 0;
                SqlCommand cmd = new SqlCommand("Insert into orderProductsList values(@productId, @productName, @productPrice, @allotmentNumber, @MRP, @Type, @imagePath)", con);
                cmd.Parameters.AddWithValue("@productId", int.Parse(txtId.Text.ToString()));
                cmd.Parameters.AddWithValue("@productName", (txtName.Text.ToString()));
                cmd.Parameters.AddWithValue("@productPrice", int.Parse(txtPrice.Text.ToString()));
                cmd.Parameters.AddWithValue("@allotmentNumber", int.Parse(txtAllotmentNumber.Text.ToString()));
                cmd.Parameters.AddWithValue("@MRP", int.Parse(txtMRP.Text.ToString()));
                cmd.Parameters.AddWithValue("@Type", TypeComboBox.Text.ToString());
                cmd.Parameters.AddWithValue("@imagePath", imagePath);
                dr = cmd.ExecuteNonQuery();
                if (dr != 0)
                {
                    MessageBox.Show("Success");
                    dgvAllProduct.Update();
                    dgvAllProduct.Refresh();
                    dataGridViewSetter();
                }
                else
                {
                    MessageBox.Show("Failed");
                }
                
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            txtAllotmentNumber.Text = "";
            txtId.Text = "";
            txtMRP.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvAllProduct.Update();
            dgvAllProduct.Refresh();
        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select * from orderProductsList where ProductName like @name + '%'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.SelectCommand.Parameters.AddWithValue("@name", txtSearchProduct.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvAllProduct.DataSource = dt;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString(), "Error");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fd = new OpenFileDialog();
                fd.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.gif;*.png)|*.bmp;*.jpg;*.jpeg;*.gif;*.png";

                if (fd.ShowDialog() == DialogResult.OK)
                {
                    imagePath = fd.FileName;
                    pbImage.ImageLocation = imagePath;
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("Error" + ee.ToString());
            }
        }
    }
}
