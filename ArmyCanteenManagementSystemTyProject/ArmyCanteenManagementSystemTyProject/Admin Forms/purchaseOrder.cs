using ArmyCanteenManagementSystemTyProject.Counter_Staff_Forms;
using ArmyCanteenManagementSystemTyProject.Customer_Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ArmyCanteenManagementSystemTyProject.Admin_Forms
{
    public partial class purchaseOrderForm : Form
    {
        bool firstTime = true;
        int UpdaterTimes = 0;
        int tempPaymentId = 0;
        public static double CanteenDiscountRate = 5;
        SqlConnection con = new SqlConnection(LoginForm.ConString);
        int SelectedRowNo = 0;
        int totalProducts = 0;
        double billAmt = 0;
        int rand;
        int tempOrderNo= 0;
        public purchaseOrderForm()
        {
            InitializeComponent();
            con.Open();
            clearner();
            gridViewDisplayer();
        }
        void clearner()
        {
            SqlCommand cmd = new SqlCommand("Truncate table orderProducts", con);
            cmd.ExecuteNonQuery();
        }
        void gridViewDisplayer()
        {
            YourOrderDataGridView.Refresh();
            YourOrderDataGridView.Update();
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from orderProductsList", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                productCanOrderDataGridView.DataSource = dt;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from orderProducts", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                YourOrderDataGridView.DataSource = dt;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
        bool isRowSelected()
        {
            if (productCanOrderDataGridView.SelectedRows.Count > 0)
            {
                SelectedRowNo = productCanOrderDataGridView.SelectedRows[0].Index;
                return true;
            }
            else
            {
                return false;
            }
        }
        bool isAlreadyPresent()
        {
            for (int i = 0; i < YourOrderDataGridView.Rows.Count-1; i++)
            {
                if (int.Parse(productCanOrderDataGridView.Rows[SelectedRowNo].Cells[1].Value.ToString()) == int.Parse(YourOrderDataGridView.Rows[i].Cells[1].Value.ToString()))
                {
                    MessageBox.Show("Returning true");
                    return true;
                }
            }
            return false;
        }
        void totalCalculator()
        {
            totalProducts = YourOrderDataGridView.Rows.Count;
            TotalProductsTextBox.Text = totalProducts.ToString();         
            for (int i = 0; i < totalProducts; i++)
            {
                billAmt += (double.Parse(YourOrderDataGridView.Rows[i].Cells[3].Value.ToString()) - (double.Parse(YourOrderDataGridView.Rows[i].Cells[3].Value.ToString()) / CanteenDiscountRate)) * 100;
            }
            totalAmtTextBox.Text = billAmt.ToString();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            if (firstTime)
            {
                rand = new Random().Next(999999);
                firstTime = false;
            }
            try
            {
                try
                {
                    if (isRowSelected())
                    {
                        if (!isAlreadyPresent())
                        {
                            SqlCommand cmd = new SqlCommand("insert into orderProducts values(@ProductId, @ProductName, @ProductPrice, @allotmentNo, @MRP, @Type)", con);
                            cmd.Parameters.AddWithValue("@ProductId", int.Parse(productCanOrderDataGridView.Rows[SelectedRowNo].Cells[1].Value.ToString()));
                            cmd.Parameters.AddWithValue("@ProductName", productCanOrderDataGridView.Rows[SelectedRowNo].Cells[2].Value.ToString());
                            cmd.Parameters.AddWithValue("@ProductPrice", float.Parse(productCanOrderDataGridView.Rows[SelectedRowNo].Cells[3].Value.ToString()));
                            cmd.Parameters.AddWithValue("@allotmentNo", int.Parse(productCanOrderDataGridView.Rows[SelectedRowNo].Cells[4].Value.ToString()));
                            cmd.Parameters.AddWithValue("@MRP", int.Parse(productCanOrderDataGridView.Rows[SelectedRowNo].Cells[5].Value.ToString()));
                            cmd.Parameters.AddWithValue("@Type", productCanOrderDataGridView.Rows[SelectedRowNo].Cells[6].Value.ToString());
                            cmd.ExecuteNonQuery();
                            totalCalculator();
                            gridViewDisplayer();

                            // Check if product is already in productInWarehouse table
                            SqlCommand checkCmd = new SqlCommand("SELECT * FROM productInWarehouse WHERE Product_Id = @ProductId", con);
                            checkCmd.Parameters.AddWithValue("@ProductId", int.Parse(productCanOrderDataGridView.Rows[SelectedRowNo].Cells[1].Value.ToString()));
                            SqlDataReader reader = checkCmd.ExecuteReader();
                            if (reader.HasRows)
                            {
                                // Update quantity if product is already present
                                int newQuantity = 0;
                                reader.Read();
                                int existingQuantity = int.Parse(reader["Quantity"].ToString());
                                newQuantity = existingQuantity + 100;
                                SqlCommand updateCmd = new SqlCommand("UPDATE productInWarehouse SET Quantity = @newQuantity WHERE Product_Id = @ProductId", con);
                                updateCmd.Parameters.AddWithValue("@newQuantity", newQuantity);
                                updateCmd.Parameters.AddWithValue("@ProductId", int.Parse(productCanOrderDataGridView.Rows[SelectedRowNo].Cells[1].Value.ToString()));
                                reader.Close();
                                updateCmd.ExecuteNonQuery();
                            }
                            else
                            {
                                reader.Close();
                                purchaseOrderHistoryInserter();                                
                                SqlCommand insertCmd = new SqlCommand("INSERT INTO productInWarehouse  VALUES (@ProductId, @quant,  @OrderNo)", con);
                                insertCmd.Parameters.AddWithValue("@ProductId", int.Parse(productCanOrderDataGridView.Rows[SelectedRowNo].Cells[1].Value.ToString()));
                                insertCmd.Parameters.AddWithValue("@OrderNo", rand);
                                insertCmd.Parameters.AddWithValue("@quant", 100);
                                insertCmd.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Product is already");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Select Row First");
                    }
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
        void purchaseOrderHistoryInserter()
        {
            if(UpdaterTimes == 0)
            {

                tempPaymentId = new Random().Next(999999);
                int a = 0;
                SqlCommand cmd2 = new SqlCommand("Insert into Payment values(@pId, @type, @amt, @dateTime, @cId, @billBy)", con);
                cmd2.Parameters.AddWithValue("@pId", tempPaymentId);
                cmd2.Parameters.AddWithValue("@type", "Purchse_Order");
                cmd2.Parameters.AddWithValue("@amt", float.Parse(totalAmtTextBox.Text.ToString()));
                cmd2.Parameters.AddWithValue("@dateTime", System.DateTime.Now);
                cmd2.Parameters.AddWithValue("@cId", AdminHome.adminCardNumber);
                cmd2.Parameters.AddWithValue("@billBy", AdminHome.adminCardNumber);

                a = cmd2.ExecuteNonQuery();
                if (a != 0)
                {
                    MessageBox.Show("Order Placed Successfully");

                }
                SqlCommand cmd = new SqlCommand("insert into purchaseOrderHistory values(@orderNo, @totalPro, @totalAmt, @orderDate, @state, @ACardNo, @Supplier, @paymentId)", con);
                cmd.Parameters.AddWithValue("@orderNo", rand);
                cmd.Parameters.AddWithValue("@Supplier", 138189);
                cmd.Parameters.AddWithValue("@totalPro", TotalProductsTextBox.Text.ToString());
                cmd.Parameters.AddWithValue("@totalAmt", float.Parse(totalAmtTextBox.Text.ToString()));
                cmd.Parameters.AddWithValue("@orderDate", System.DateTime.Now.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@ACardNo", AdminHome.adminCardNumber);
                cmd.Parameters.AddWithValue("@state", "pending");
                cmd.Parameters.AddWithValue("@paymentId", tempPaymentId);
                cmd.ExecuteNonQuery();
                UpdaterTimes++;
            }
            else
            {
                int a = 0;
                SqlCommand cmd2 = new SqlCommand("Update Payment set Amount = @amt where Payment_Id = @pId", con);
                cmd2.Parameters.AddWithValue("@pId", tempPaymentId);
                cmd2.Parameters.AddWithValue("@amt", float.Parse(totalAmtTextBox.Text.ToString()));
                
                a = cmd2.ExecuteNonQuery();
               

                SqlCommand cmd = new SqlCommand("Update purchaseOrderHistory Set Total_Product = @totalPro, Total_Amount = @totalAmt where Order_Number = @orderNo", con);
                cmd.Parameters.AddWithValue("orderNo", rand);
                cmd.Parameters.AddWithValue("@totalPro", TotalProductsTextBox.Text.ToString());
                cmd.Parameters.AddWithValue("@totalAmt", float.Parse(totalAmtTextBox.Text.ToString()));
                cmd.ExecuteNonQuery();           
                    MessageBox.Show("Order Placed Successfully");
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select * from orderProductsList where ProductName like @name + '%'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.SelectCommand.Parameters.AddWithValue("@name", SearchTextBox.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);
                productCanOrderDataGridView.DataSource = dt;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString(), "Error");
            }
        }

        private void placeOrderButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You Sure Want To Place Order", "Conformation", MessageBoxButtons.OKCancel) == DialogResult.OK){
                purchaseOrderHistoryInserter();
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
                productCanOrderDataGridView.DataSource = dt;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void productCanOrderDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            { 
                int row = e.RowIndex;
                ProductImage.ImageLocation = productCanOrderDataGridView.Rows[row].Cells[7].Value.ToString();
            }catch(Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void YourOrderDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                ProductImage.ImageLocation = YourOrderDataGridView.Rows[row].Cells[7].Value.ToString();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void purchaseOrderForm_Load(object sender, EventArgs e)
        {
            gridViewDisplayer();
        }

        private void TypeComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from orderProductsList where Type = @type", con);
                cmd.Parameters.AddWithValue("@type", TypeComboBox.SelectedItem.ToString());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                productCanOrderDataGridView.DataSource = dt;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
            YourOrderDataGridView.Refresh();
            YourOrderDataGridView.Update();
        }
    }
}
