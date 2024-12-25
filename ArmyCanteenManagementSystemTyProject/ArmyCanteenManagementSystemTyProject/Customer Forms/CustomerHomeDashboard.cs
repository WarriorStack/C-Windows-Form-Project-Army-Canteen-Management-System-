using ArmyCanteenManagementSystemTyProject.Counter_Staff_Forms;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ArmyCanteenManagementSystemTyProject.Customer_Forms
{
    public partial class CustomerHomeDashboard : Form
    {
        CustomerHome _customerHome = new CustomerHome();
        CustomerBilling _customerBilling = new CustomerBilling();
        CustomerBillHistory _customerbillHistory = new CustomerBillHistory();
        AccountSetting _accountSetting = new AccountSetting();
        public static long CardNo;
        public static int Password;
        public CustomerHomeDashboard()
        {
            InitializeComponent();
        }

        public void valueSetter(long cardNo, int password)
        {
            CardNo = cardNo;
            Password = password;
            _customerHome.MdiParent = this;
            _customerHome.valueSetter(cardNo, password);
            _customerHome.Dock = DockStyle.Fill;
            _customerHome.Show();
        }
        void hideAllForms()
        {
            _customerBilling.Hide();
            _customerHome.Hide();
            _customerbillHistory.Hide();
            _accountSetting.Hide();
        }
        private void homeButton_Click(object sender, EventArgs e)
        {
            hideAllForms();
            _customerHome.MdiParent = this;
            _customerHome.Show();
        }

        private void billButton_Click(object sender, EventArgs e)
        {
            hideAllForms();
            _customerBilling.MdiParent = this;
            _customerBilling.Dock = DockStyle.Fill;
            _customerBilling.Show();
        }
        private void billHistoryButton_Click(object sender, EventArgs e)
        {
            hideAllForms();
            _customerbillHistory.billHistoryManageMent();
            _customerbillHistory.MdiParent = this;
            _customerbillHistory.Dock = DockStyle.Fill;
            _customerbillHistory.Show();
        }
        private void CustomerHomeDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void homeButton_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)(sender as Button);
            btn.BackColor = Color.White;
            btn.ForeColor = Color.Black;
        }

        private void homeButton_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)(sender as Button);
            btn.BackColor = leftPanel.BackColor;
            btn.ForeColor = Color.White;
        }

        private void accountSettingButton_Click(object sender, EventArgs e)
        {
            _accountSetting.valueSetter(2);
            _accountSetting.MdiParent = this;
            _accountSetting.Dock = DockStyle.Fill;
            hideAllForms();
            _accountSetting.Show(); 
        }

        private void CustomerHomeDashboard_Leave(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
