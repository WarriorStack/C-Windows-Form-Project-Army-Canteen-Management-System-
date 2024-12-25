using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting; // Add this line

namespace ArmyCanteenManagementSystemTyProject.Admin_Forms
{
    public partial class BalaceSheetForm : Form
    {
        SqlConnection con = new SqlConnection(LoginForm.ConString);
        bool checker = true;
        int TotalSalesAmountToday = 100;
        double TotalProfitAmountToday = 50;
        int TotalExpenceAmountToday = 50;

        bool isChecked()
        {
            if (checker)
            {
                checker = false;
                return true;
            }
            else
            {
                checker = true;
                return false;
            }
        }

        Chart pieChart; // Declare a Chart instance for the pie chart

        public BalaceSheetForm()
        {
            InitializeComponent();
            con.Open();
            InitializePieChart(); // Call to initialize the pie chart
            setData();
        }

        void InitializePieChart()
        {
            pieChart = new Chart();
            pieChart.Size = new System.Drawing.Size(400, 300);
            pieChart.Location = new System.Drawing.Point(358, 106); // Adjust the location as needed
            pieChart.ChartAreas.Add(new ChartArea("MainArea"));

            // Add a series to the chart
            Series series = new Series("ProfitLoss");
            series.ChartType = SeriesChartType.Pie; // Set the chart type to Pie
            pieChart.Series.Add(series);

            Controls.Add(pieChart); // Add the chart to the form's controls
        }

        void setData()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("Select * from Payment where Payment.Type = 'Customer_Bill' ", con);
                //SqlCommand cmd = new SqlCommand("Select * from Payment where (DATEDIFF(day, Date_Time, GETDATE()) <= 31) AND Payment.Type = 'Customer_Bill' ", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                SalesDataGridView.DataSource = dt;

                SqlCommand cmd2 = new SqlCommand("Select * from Payment where Payment.Type = 'Purchse_Order'", con);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                ExpenceDataGridView.DataSource = dt2;
                // Your existing data fetching code...

                for (int i = 0; i < SalesDataGridView.RowCount; i++)
                {
                    int temp = 0;
                    int.TryParse(SalesDataGridView.Rows[i].Cells[3].Value.ToString(), out temp);
                    TotalSalesAmountToday += temp;
                    TotalProfitAmountToday = TotalSalesAmountToday * (1 + (purchaseOrderForm.CanteenDiscountRate / 100.0));
                }

                for (int i = 0; i < ExpenceDataGridView.RowCount; i++)
                {
                    int temp = 0;
                    int.TryParse(ExpenceDataGridView.Rows[i].Cells[3].Value.ToString(), out temp);
                    TotalExpenceAmountToday += temp;
                }
                totalProfitTextBox.Text = TotalProfitAmountToday.ToString();
                totalExpenceTextBox.Text = TotalExpenceAmountToday.ToString();
                totalTransTextBox.Text = (TotalExpenceAmountToday+TotalProfitAmountToday).ToString();
                // Update the pie chart
                UpdatePieChart();
                UpdateBarCharts();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        void UpdatePieChart()
        {
            // Clear the existing data points
            pieChart.Series["ProfitLoss"].Points.Clear();

            // Calculate total profit and loss
            float profit = float.Parse(TotalProfitAmountToday.ToString());
            float loss = float.Parse(TotalExpenceAmountToday.ToString());

            // Add data points to the pie chart
            pieChart.Titles.Add("Pie Chart For Profit And Loss");
            pieChart.Series["ProfitLoss"].Points.AddXY("Profit" + ((profit / (profit + loss)) * 100) , ( profit / (profit + loss)) * 100);
            pieChart.Series["ProfitLoss"].Points.AddXY("Loss"+ ((loss / (loss + profit)) * 100), (loss / (loss + profit)) * 100);

            // Optional: You can set the chart title, legends and other properties here
            pieChart.Titles.Clear();
            pieChart.Titles.Add("Profit and Loss Chart");
            pieChart.Legends.Add(new Legend("Legend"));
            pieChart.Legends["Legend"].Docking = Docking.Top;
        }
        void UpdateBarCharts()
        {
            // Update the sales bar chart
            salesBarChart.Series["Sales"].Points.Clear();
            salesBarChart.Series["Sales"].Points.AddXY("Total Sales Today", TotalSalesAmountToday);

            // Update the expense bar chart
            expenseBarChart.Series["Expenses"].Points.Clear();
            expenseBarChart.Series["Expenses"].Points.AddXY("Total Expense Today", TotalExpenceAmountToday);

            // Optional: Customize appearance
            salesBarChart.Titles.Clear();
            salesBarChart.Titles.Add("Sales Chart");
            expenseBarChart.Titles.Clear();
            expenseBarChart.Titles.Add("Expense Chart");
        }
    }
}
