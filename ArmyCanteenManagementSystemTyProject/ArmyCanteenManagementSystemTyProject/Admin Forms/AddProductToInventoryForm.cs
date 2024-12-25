using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ArmyCanteenManagementSystemTyProject.Admin_Forms
{
    public partial class AddProductToInventoryForm : Form
    {
        SqlConnection con = new SqlConnection(LoginForm.ConString);

        int Quantity = 0;
        int selectedrow;
        public AddProductToInventoryForm()
        {
            InitializeComponent();
            gridViewSetter();
            dataGridViewRefresher();
            con.Open();
        }
        void gridViewSetter()
        {
            warehouseviewer();
            productinShelfViewer();
        }
        void warehouseviewer()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT p.Index_Number, p.Product_Id, p.Quantity, p.Order_Number, o.ProductName, o.ProductPrice, o.AllotmentNo, o.MRP, o.Type, o.ImagePath  FROM orderProductsList o JOIN productInWarehouse p ON p.Product_Id = o.ProductId;", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ProductInWarehouseDataGridView.DataSource = dt;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString(), "Error");
            }
        }
        void productinShelfViewer()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT p.Index_Number, p.Product_Id, p.Quantity, o.ProductName, o.ProductPrice, o.AllotmentNo, o.MRP, o.Type, o.ImagePath  FROM orderProductsList o JOIN productinshelf p ON p.Product_Id = o.ProductId;", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                productinShelfDataGridView.DataSource = dt;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString(), "Error");
            }
        }
        void dataGridViewRefresher()
        {
            productinShelfDataGridView.ClearSelection();
            productinShelfDataGridView.Update();
            productinShelfDataGridView.Refresh();
            productinShelfViewer();

            ProductInWarehouseDataGridView.ClearSelection();
            ProductInWarehouseDataGridView.Update();
            productinShelfDataGridView.Refresh();
            warehouseviewer();
        }
        void quantityInputBoxOpener()
        {
            /*Here I Use InputBox */
            int.TryParse(Interaction.InputBox("Enter Product Quantity", "Product Quantity Selector", "1"), out Quantity);
        }
        bool isRowSelectedd()
        {
            if (ProductInWarehouseDataGridView.SelectedRows.Count > 0)
            {
                selectedrow = ProductInWarehouseDataGridView.SelectedRows[0].Index;
                return true;
            }
            else
            {
                return false;
            }
        }
        bool quantityVerifier()
        {
            quantityInputBoxOpener();
            int remain = int.Parse(ProductInWarehouseDataGridView.Rows[selectedrow].Cells[2].Value.ToString());
            if (remain >= Quantity)
            {
                SqlCommand cmd2 = new SqlCommand("update productInWarehouse set Quantity=@temp where Product_Id=@iNo", con);
                cmd2.Parameters.AddWithValue("@temp", remain - Quantity);
                cmd2.Parameters.AddWithValue("@iNo", ProductInWarehouseDataGridView.Rows[selectedrow].Cells[1].Value.ToString());
                cmd2.ExecuteNonQuery();
                warehouseviewer();
                productinShelfViewer();

                SqlCommand cmd3 = new SqlCommand("UPDATE productinshelf set Quantity = Quantity + @quantity where Product_Id=@iNo", con);
                cmd3.Parameters.AddWithValue("@quantity", Quantity);
                cmd3.Parameters.AddWithValue("@iNo", int.Parse(ProductInWarehouseDataGridView.Rows[selectedrow].Cells[1].Value.ToString()));
                cmd3.ExecuteNonQuery();
                MessageBox.Show("Updated !!", "Success");
                dataGridViewRefresher();
                gridViewSetter();
                return true;
            }
            else
            {
                MessageBox.Show("Insuffient Product");
                return false;
            }
        }
        bool alreadyPresentChecker()
        {
            SqlCommand cmd = new SqlCommand("Select * from productinshelf where Product_Id = @iNo", con);
            cmd.Parameters.AddWithValue("@iNo", int.Parse(ProductInWarehouseDataGridView.Rows[selectedrow].Cells[1].Value.ToString()));
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Close();
                return true;
            }
            else
            {
                dr.Close();
                return false;
            }
        }
        void updateButtonClicked()
        { 
            if (quantityVerifier())
            {
                SqlCommand cmd = new SqlCommand("UPDATE productinshelf set Quantity= (Quantity + @quantity) where Product_Id=@iNo", con);
                cmd.Parameters.AddWithValue("@quantity", Quantity);
                cmd.Parameters.AddWithValue("@iNo", int.Parse(ProductInWarehouseDataGridView.Rows[selectedrow].Cells[1].Value.ToString()));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated !!", "Success");
                dataGridViewRefresher();
            }
            else
            {
                MessageBox.Show("Insufficient product at warehouse");
            }
        }
        void removeButtonClicked()
        {
            int a = 0;
            if (productinShelfDataGridView.SelectedRows.Count > 0)
            {
                SqlCommand cmd = new SqlCommand("Delete From productinshelf where Product_Id=@iNo", con);
                cmd.Parameters.AddWithValue("@iNo", int.Parse(productinShelfDataGridView.Rows[selectedrow].Cells[1].Value.ToString()));
                a = cmd.ExecuteNonQuery();
                if (a != 0)
                {
                    MessageBox.Show("Row Deleted");
                    dataGridViewRefresher();
                }
            }
            else
            {
                MessageBox.Show("Select Row First");
            }
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (isRowSelectedd())
            {
                if (alreadyPresentChecker())
                {
                    try
                    {
                        MessageBox.Show("Already Present You can change only quantity");
                        quantityVerifier();

                        //SqlCommand cmd = new SqlCommand("Select * from productInWarehouse where Product_Id = @iNo", con);
                        //cmd.Parameters.AddWithValue("@iNo", int.Parse(ProductInWarehouseDataGridView.Rows[selectedrow].Cells[1].Value.ToString()));
                        //SqlDataReader dr = cmd.ExecuteReader();
                        //dr.Close(); // Close the data reader


                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.ToString());
                    }
                }
                else
                {
                    quantityVerifier();
                    SqlCommand cmd2 = new SqlCommand("Insert into productinshelf values(@ProductId, @quantity)", con);
                    cmd2.Parameters.AddWithValue("@ProductId", int.Parse(ProductInWarehouseDataGridView.Rows[selectedrow].Cells[1].Value.ToString()));
                    cmd2.Parameters.AddWithValue("@quantity", Quantity);
                    int a = cmd2.ExecuteNonQuery();
                    dataGridViewRefresher();

                }
            }
            else
            {
                MessageBox.Show("Please Select Row First ");
            }
            dataGridViewRefresher();

            dataGridViewRefresher();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            updateButtonClicked();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            removeButtonClicked();
        }



        private void ProductInWarehouseDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                ProductImage.ImageLocation = ProductInWarehouseDataGridView.Rows[row].Cells[9].Value.ToString();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from orderProductsList where Type = @type", con);
                cmd.Parameters.AddWithValue("@type", TypeComboBox.SelectedItem.ToString());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ProductInWarehouseDataGridView.DataSource = dt;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select * from productInWarehouse where Product_Id like @name + '%'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.SelectCommand.Parameters.AddWithValue("@name", SearchTextBox.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ProductInWarehouseDataGridView.DataSource = dt;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString(), "Error");
            }
        }

        private void AddProductToInventoryForm_Load(object sender, EventArgs e)
        {
            gridViewSetter();
        }

        private void TypeComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT p.Index_Number, p.Product_Id, p.Quantity, p.Order_Number, o.ProductName, o.ProductPrice, o.AllotmentNo, o.MRP, o.Type, o.ImagePath  FROM orderProductsList o JOIN productInWarehouse p ON p.Product_Id = o.ProductId And o.Type = @type", con);
                cmd.Parameters.AddWithValue("@type", TypeComboBox.SelectedItem.ToString());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ProductInWarehouseDataGridView.DataSource = dt;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString(), "Error");
            }
        }
    }
}
//p.Index_Number, p.Product_Id, p.Quantity, p.Order_Number, o.ProductName, o.ProductPrice, o.AllotmentNo, o.MRP, o.Type
//K:\Project With Design\ArmyCanteenManagementSystemTyProject\ArmyCanteenManagementSystemTyProject\Assets\Products\1.png                                