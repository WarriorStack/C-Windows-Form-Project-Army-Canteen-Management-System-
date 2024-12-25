using ArmyCanteenManagementSystemTyProject.Counter_Staff_Forms;
using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace ArmyCanteenManagementSystemTyProject.Customer_Forms
{
    public partial class CustomerBilling : Form
    {
        SqlConnection con = new SqlConnection(LoginForm.ConString);
        int SelectedRowNo = 0;
        int SelectedRowNoInGrid2 = 0;
        int SelectedRowNoForCustomer = 0;
        int Quantity;

        public CustomerBilling()
        {
            InitializeComponent();
            ProductListDisplay();
            clearBillTable();
            customerBillGridViewRefresher();
            productListGridViewRefresher();
        }
        void ProductListDisplay()
        {
            try
            { 
                //SqlCommand cmd = new SqlCommand("SELECT p.Index_Number,  p.Quantity FROM productinshelf p JOIN orderProductsList o ON p.Product_Id = o.ProductId;", con);
                SqlCommand cmd = new SqlCommand("SELECT p.Index_Number, p.Product_Id, p.Quantity, o.ProductName, o.ProductPrice, o.AllotmentNo, o.MRP, o.Type, o.ImagePath  FROM orderProductsList o JOIN productinshelf p ON p.Product_Id = o.ProductId;", con);
                //cmd.Parameters.AddWithValue("@allNo", CustomerHome.postInNumber);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                productListGridView.DataSource = dt;


            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString(), "Error");
            }
        }
        void CustomerBillDisplay()
        {
            try
            {
                SqlConnection con = new SqlConnection(LoginForm.ConString);
                SqlCommand cmd = new SqlCommand("SELECT p.Index_Number, p.Product_Id, p.Quantity, o.ProductName, o.ProductPrice, o.AllotmentNo, o.MRP, o.Type, p.Total_Amount, o.ImagePath FROM orderProductsList o JOIN CustomerBill p ON p.Product_Id = o.ProductId;", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                CustomerBillGridView.DataSource = dt;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString(), "Error");
            }
        }
        bool isRowSelected()
        {
            if (SelectedRowNo > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        bool isRowSelectedForCustomerGridView()
        {
            if (SelectedRowNoForCustomer > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        void clearBillTable()
        {

            SqlConnection con = new SqlConnection(LoginForm.ConString);
            con.Open();

            int a = 0;
            SqlCommand cmd = new SqlCommand("TRUNCATE table CustomerBill", con);
            a = cmd.ExecuteNonQuery();
            CustomerBillDisplay();
            con.Close();
        }
        void quantityInputBoxOpener()
        {
            /*Here I Use InputBox */
            int.TryParse(Interaction.InputBox("Enter Product Quantity", "Product Quantity Selector", "1"), out Quantity);
        }
        void rowUpdate()
        {
            try
            {
                SqlConnection con = new SqlConnection(LoginForm.ConString);
                con.Open();
                if (SelectedRowNo>0 || SelectedRowNoInGrid2>0)
                {
                    int a = 0;
                    quantityInputBoxOpener();
                    SqlCommand cmd = new SqlCommand("UPDATE CustomerBill set Quantity=@quantity, Total_Amount=@totalAmt where Product_Id=@proNo", con);
                    cmd.Parameters.AddWithValue("@quantity", Quantity);
                    cmd.Parameters.AddWithValue("@totalAmt", float.Parse(CustomerBillGridView.Rows[SelectedRowNoForCustomer].Cells[8].Value.ToString()) * Quantity);
                    cmd.Parameters.AddWithValue("@proNo", int.Parse(CustomerBillGridView.Rows[SelectedRowNoForCustomer].Cells[1].Value.ToString()));
                    a = cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated !!", "Success");
                    CustomerBillDisplay();
                    customerBillGridViewRefresher();
                    con.Close();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString(), "Error");
            }

        }
        void customerBillGridViewRefresher()
        {
            CustomerBillGridView.ClearSelection();
            CustomerBillGridView.Update();
            CustomerBillGridView.Refresh();
        }
        void productListGridViewRefresher()
        {
            productListGridView.ClearSelection();
            productListGridView.Update();
            productListGridView.Refresh();
        }
        void TotalAmtCalCulator()
        {
            int totalRows = CustomerBillGridView.RowCount;
            float totalAmt = 0;
            float discountedAmt = 0;
            int totalProduct = 0;
            for (int i = 0; i < totalRows; i++)
            {
                totalAmt += float.Parse(CustomerBillGridView.Rows[i].Cells[2].Value.ToString()) * float.Parse(CustomerBillGridView.Rows[i].Cells[6].Value.ToString()); //mrp * quantity
                discountedAmt += float.Parse(CustomerBillGridView.Rows[i].Cells[2].Value.ToString()) * float.Parse(CustomerBillGridView.Rows[i].Cells[4].Value.ToString()); //canteenprice * quanity
                totalProduct = totalRows;
            }
            totalBillTextBox.Text = totalAmt.ToString();
            AfterDiscountBillTextBox.Text = discountedAmt.ToString();
            totalProductTextBox.Text = totalProduct.ToString();
        }

        bool postChecker()
        {
            if (int.Parse(productListGridView.Rows[SelectedRowNo].Cells[5].Value.ToString()) == 0)
            {
                return true;
            }
            else if (int.Parse(productListGridView.Rows[SelectedRowNo].Cells[5].Value.ToString()) == CustomerHome.postInNumber)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            printPreviewDialog.Document = printDocument;
            Font font = new Font("Arial", 12);
            Brush brush = new SolidBrush(Color.Black);

            // Create a new graphics object
            Graphics g = e.Graphics;

            // Draw the header
            font = new Font("Arial", 20, FontStyle.Bold);
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            g.DrawString("!! Wecome To ARMY CANTEEN !!", font, brush, (e.PageSettings.PrintableArea.Width - g.MeasureString("!! Wecome To ARMY CANTEEN !!", font).Width) / 2, 10);

            g.DrawLine(new Pen(Color.Black, 1), 10, 40, e.PageSettings.PrintableArea.Width - 10, 40);
            g.DrawLine(new Pen(Color.Black, 1), 10, 45, e.PageSettings.PrintableArea.Width - 10, 45);

            font = new Font("Arial", 13, FontStyle.Bold);
            g.DrawString("Customer Card Number: " + CustomerHomeDashboard.CardNo, font, brush, 10, 50);
            g.DrawString("Date: " + DateTime.Now.ToString(), font, brush, 10, 70);
            g.DrawString("Bill Created By: " + CustomerHome.counterStaffCardNumber, font, brush, (e.PageSettings.PrintableArea.Width - g.MeasureString("Bill Created By:" + 12, font).Width) / 2, 50);

            g.DrawLine(new Pen(Color.Black, 1), 10, 95, e.PageSettings.PrintableArea.Width - 10, 95);

            // Draw the product grid
            int y = 150;
            font = new Font("Arial", 10);
            float x = 10;
            float[] x2 = new float[CustomerBillGridView.Columns.Count];
            for (int i = 0; i < CustomerBillGridView.Columns.Count; i++)
            {
                string text = CustomerBillGridView.Columns[i].HeaderText;
                float textWidth = g.MeasureString(text, font).Width;
                g.DrawString(text, font, brush, x, y);
                x2[i] = x;
                x += textWidth + 20;
            }
            y += 25; // add some gap between the header and the product data

            for (int i = 0; i < CustomerBillGridView.Rows.Count; i++)
            {
                //x = 10;
                for (int j = 0; j < CustomerBillGridView.Columns.Count; j++)
                {
                    string text = CustomerBillGridView.Rows[i].Cells[j].Value.ToString();
                    float textWidth = g.MeasureString(text, font).Width;
                    g.DrawString(text, font, brush, x2[j], y);
                    x += textWidth + 20;
                }
                y += 25; // add some gap between each row
            }

            g.DrawLine(new Pen(Color.Black, 1), 10, y + 10, e.PageSettings.PrintableArea.Width - 10, y + 10);
            // Draw the total price and discount
            font = new Font("Arial", 12);
            g.DrawString("Total Bill with MRP : " + totalBillTextBox.Text + " Rs.", font, brush, x2[x2.Length - 1] - 120, y + 25);
            g.DrawString("After Discount Bill Is : " + AfterDiscountBillTextBox.Text + " Rs.", font, brush, x2[x2.Length - 1] - 120, y + 50);
            g.DrawString("***** Thank you *****", font, brush, x2[x2.Length - 1] - 120, y + 100);

            // Dispose of the objects
            font.Dispose();
            brush.Dispose();

            printPreviewDialog.Show();
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            rowUpdate();
            TotalAmtCalCulator();
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            int productId = int.Parse(CustomerBillGridView.SelectedRows[0].Cells[1].Value.ToString());
            try
            {
                SqlConnection con = new SqlConnection(LoginForm.ConString);
                con.Open();
                if (SelectedRowNoInGrid2 > 0)
                {
                    int a = 0;
                    SqlCommand cmd = new SqlCommand("Delete from CustomerBill where Product_Id=@PNo", con);
                    cmd.Parameters.AddWithValue("@PNo", productId);
                    a = cmd.ExecuteNonQuery();
                    CustomerBillDisplay();
                    MessageBox.Show("Deleted !!", "Success");
                    customerBillGridViewRefresher();
                    TotalAmtCalCulator();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Select Row First");
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString(), "Error");
            }

        }
        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(LoginForm.ConString);
                con.Open();
                if (isRowSelected())
                {
                    int productId = int.Parse(productListGridView.Rows[SelectedRowNo].Cells[1].Value.ToString());
                    SqlCommand cmdd = new SqlCommand("Select * from CustomerBill where Product_Id=@PNo", con);
                    cmdd.Parameters.AddWithValue("@PNo", productId);
                    SqlDataReader dr = cmdd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        dr.Close();
                        MessageBox.Show("Product already Added To Bill change quantity only");
                        rowUpdate();
                    }
                    else
                    {
                        if (postChecker())
                        {

                            dr.Close();
                            /*Here I Use InputBox */
                            //Quantity = int.Parse(Interaction.InputBox("Enter Product Quantity", "Product Quantity Selector", "1"));
                            quantityInputBoxOpener();
                            int a = 0;
                            SqlCommand cmd = new SqlCommand("Select * from productinshelf where Product_Id=@ino and Quantity >= @quant", con);
                            cmd.Parameters.AddWithValue("@ino", int.Parse(productListGridView.Rows[SelectedRowNo].Cells[1].Value.ToString()));
                            cmd.Parameters.AddWithValue("@quant", Quantity);
                            SqlDataReader dr2 = cmd.ExecuteReader();
                            if (!dr2.HasRows)
                            {
                                dr2.Close();
                                MessageBox.Show("No product available for this quantity");
                                return;
                            }
                            else
                            {
                                dr2.Close();
                                cmd = new SqlCommand("Insert into CustomerBill values(@ProdNo, @Quantity, @Total)", con);

                                cmd.Parameters.AddWithValue("@ProdNo", int.Parse(productListGridView.Rows[SelectedRowNo].Cells[1].Value.ToString()));
                                cmd.Parameters.AddWithValue("@Quantity", Quantity);
                                cmd.Parameters.AddWithValue("@Total", float.Parse(productListGridView.Rows[SelectedRowNo].Cells[4].Value.ToString()) * Quantity);
                                dr.Close();
                                a = cmd.ExecuteNonQuery();

                                SqlCommand cmd2 = new SqlCommand("Update productinshelf set Quantity = Quantity - @quant where Product_Id = @ino", con);
                                cmd2.Parameters.AddWithValue("@quant", Quantity);
                                cmd2.Parameters.AddWithValue("@ino", int.Parse(productListGridView.Rows[SelectedRowNo].Cells[1].Value.ToString()));
                                cmd2.ExecuteNonQuery();


                                if (a == 0)
                                {
                                    MessageBox.Show("You Cannot Buy This Iteam");
                                }
                                CustomerBillDisplay();
                                customerBillGridViewRefresher();
                                ProductListDisplay();
                                productListGridViewRefresher();

                                TotalAmtCalCulator();
                                con.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("You Cannot purchase this product");
                        }
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString(), "Error");
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            productListGridViewRefresher();
            customerBillGridViewRefresher();
        }

        private void procedToPayButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You Sure You Cannot Change Bill After This Hit Ok to Proceed", "Confirmation", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                try
                {
                    int temppaymentId = new Random().Next(999999999);
                    SqlConnection con = new SqlConnection(LoginForm.ConString);
                    con.Open();
                    SqlCommand cmd2 = new SqlCommand("Insert into Payment values(@pId, @type, @amt, @dateTime, @cId, @billBy)",con);
                    cmd2.Parameters.AddWithValue("@pId", temppaymentId);
                    cmd2.Parameters.AddWithValue("@type", "Customer_Bill");
                    cmd2.Parameters.AddWithValue("@amt", AfterDiscountBillTextBox.Text);
                    cmd2.Parameters.AddWithValue("@dateTime", System.DateTime.Now);
                    cmd2.Parameters.AddWithValue("@cId", CustomerHomeDashboard.CardNo);
                    cmd2.Parameters.AddWithValue("@billBy", CounterStaffDashboard.counterStaffCardNumber);
                    int a = cmd2.ExecuteNonQuery();
                    if (a==0)
                    {
                        MessageBox.Show("Error", "Error");
                    }
                    Random rand = new Random();
                    SqlCommand cmd = new SqlCommand("Insert into CustomerBillingHistory values(@billAmount, @billDate, @totalProduct,  @billBy, @cardNumber,@paymentId)", con);
                    //
                    cmd.Parameters.AddWithValue("@billAmount", float.Parse(totalBillTextBox.Text));
                    cmd.Parameters.AddWithValue("@billDate", System.DateTime.Now.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@totalProduct", int.Parse(totalProductTextBox.Text));
                    cmd.Parameters.AddWithValue("@billBy", CounterStaffDashboard.counterStaffCardNumber);
                    cmd.Parameters.AddWithValue("@cardNumber", CustomerHomeDashboard.CardNo);
                    cmd.Parameters.AddWithValue("@paymentId", temppaymentId);
                    int aa = cmd.ExecuteNonQuery();
                    if (aa > 0)
                    {
                        MessageBox.Show("Bill Created", "Success");


                        // Create a print document                       
                        printDocument.DocumentName = "Customer Bill";

                        // Define the print page event handler
                        printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);

                        // Print the bill
                        printPreviewDialog.Document = printDocument;
                        printPreviewDialog.ShowDialog();

                    }
                    con.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString(), "Error");
                }
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(LoginForm.ConString);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT p.Index_Number, p.Product_Id, p.Quantity, o.ProductName, o.ProductPrice, o.AllotmentNo, o.MRP, o.Type, o.ImagePath  FROM orderProductsList o JOIN productinshelf p ON p.Product_Id = o.ProductId;", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.SelectCommand.Parameters.AddWithValue("@name", searchTextBox.Text);
                DataTable dt = new DataTable();
                //p.Index_Number, p.Product_Id, p.Quantity, o.ProductName, o.ProductPrice, o.AllotmentNo, o.MRP, o.Type, p.Total_Amt
                da.Fill(dt);
                productListGridView.DataSource = dt;
                con.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString(), "Error");
            }
        }

        private void productListGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                SelectedRowNo = row;
                ProductImage.ImageLocation = productListGridView.Rows[row].Cells[8].Value.ToString();
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
                if(TypeComboBox.SelectedItem.ToString() == "All")
                {
                    ProductListDisplay();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("Select * from orderProductsList where Type = @type", con);
                    cmd.Parameters.AddWithValue("@type", TypeComboBox.SelectedItem.ToString());
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    productListGridView.DataSource = dt;
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void CustomerBillGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                SelectedRowNoInGrid2 = row;
                ProductImage.ImageLocation = CustomerBillGridView.Rows[row].Cells[8].Value.ToString();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
    }
}
