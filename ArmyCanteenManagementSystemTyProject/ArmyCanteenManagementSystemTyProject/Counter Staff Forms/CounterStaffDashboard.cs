using System;
using System.Windows.Forms;

namespace ArmyCanteenManagementSystemTyProject.Counter_Staff_Forms
{
    public partial class CounterStaffDashboard : Form
    {
        public static CustomerLoginForm _customerLoginForm = new CustomerLoginForm();
        AccountSetting _accountSetting = new AccountSetting();
        CounterStaffBillingHistory _counterStaffBillingHistory = new CounterStaffBillingHistory();
        public static long counterStaffCardNumber;
        public static int counterStaffPassword;
        public CounterStaffDashboard()
        {
            InitializeComponent();
        }
        public CounterStaffDashboard(long CounterStaffCardNo, int CounterStaffpass)
        {
            InitializeComponent();
            counterStaffCardNumber = CounterStaffCardNo;
            counterStaffPassword = CounterStaffpass;
            homeButtonClicked();
        }
        void hider()
        {
            ActiveMdiChild.Hide();
        }
        private void CustomerLoginButton_Click(object sender, EventArgs e)
        {
            _customerLoginForm.Dock = DockStyle.Fill;
            _customerLoginForm.Show();
            this.Hide();
        }

        private void BillHistoryButton_Click(object sender, EventArgs e)
        {
            _counterStaffBillingHistory.MdiParent = this;
            _counterStaffBillingHistory.Dock = DockStyle.Fill;
            hider();
            _counterStaffBillingHistory.Show();
            _counterStaffBillingHistory.historySetter();
        }

        private void homeButtonClicked()
        {
            Home _home = new Home(counterStaffCardNumber, counterStaffPassword);
            _home.MdiParent = this;
            _home.Dock = DockStyle.Fill;
            _home.Show();
        }
        private void AccountSettingButton_Click(object sender, EventArgs e)
        {
            _accountSetting.valueSetter(1);
            _accountSetting.MdiParent = this;
            _accountSetting.Dock = DockStyle.Fill;
            hider();
            _accountSetting.Show();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            hider();
            homeButtonClicked();
        }

        private void CounterStaffDashboard_Leave(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
