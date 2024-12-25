using ArmyCanteenManagementSystemTyProject.Counter_Staff_Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ArmyCanteenManagementSystemTyProject.Admin_Forms
{
    public partial class AdminDashboard : Form
    {
        AccountSetting _accountSetting = new AccountSetting();
        AdminHome _adminHome = new AdminHome();
        AddProductToInventoryForm _addProductToInventoryForm = new AddProductToInventoryForm();
        billHistoryManager _billHistoryManager = new billHistoryManager();
        purchaseOrderForm _purchaseOrderForm = new purchaseOrderForm();
        orderManagementAndHistoryForm _orderManagementAndHistoryForm = new orderManagementAndHistoryForm();
        approvalForm _approvalForm = new approvalForm();
        BalaceSheetForm _balaceSheetform = new BalaceSheetForm();

        public AdminDashboard(long adminCardNumber, int password)
        {
            InitializeComponent();
            _adminHome.MdiParent = this;
            _adminHome.Dock = DockStyle.Fill;
            _adminHome.idSetter(adminCardNumber, password);
            _adminHome.Show();
        }
        void allFormHider()
        {
            _approvalForm.Hide();
            _accountSetting.Hide();
            _adminHome.Hide();
            _addProductToInventoryForm.Hide();
            _billHistoryManager.Hide();
            _purchaseOrderForm.Hide();
            _orderManagementAndHistoryForm.Hide();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            allFormHider();
            _adminHome.Show();
        }

        private void addProductToInventoryButton_Click(object sender, EventArgs e)
        {
            _addProductToInventoryForm.MdiParent = this;
            _addProductToInventoryForm.Dock = DockStyle.Fill;
            allFormHider();
            _addProductToInventoryForm.Show();
        }

        private void billHistoryButton_Click(object sender, EventArgs e)
        {
            _billHistoryManager.MdiParent = this;
            _billHistoryManager.Dock = DockStyle.Fill;
            allFormHider();
            _billHistoryManager.Show();
        }

        private void givePurchaseOrderButton_Click(object sender, EventArgs e)
        {
            _purchaseOrderForm.MdiParent = this;
            _purchaseOrderForm.Dock = DockStyle.Fill;
            allFormHider();
            _purchaseOrderForm.Show();
        }

        private void orderManagementAndHistoryButton_Click(object sender, EventArgs e)
        {
            _orderManagementAndHistoryForm.MdiParent = this;
            _orderManagementAndHistoryForm.Dock = DockStyle.Fill;
            allFormHider();
            _orderManagementAndHistoryForm.Show();
        }

        private void accountSettingButton_Click(object sender, EventArgs e)
        {
            _accountSetting.valueSetter(0);
            _accountSetting.MdiParent = this;
            _accountSetting.Dock = DockStyle.Fill;
            allFormHider();
            _accountSetting.Show();
        }

        private void registrationManagementButton_Click(object sender, EventArgs e)
        {
            _approvalForm.MdiParent = this;
            _approvalForm.Dock = DockStyle.Fill;
            allFormHider();
            _approvalForm.Show();
        }

        private void AdminDashboard_Leave(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void balanceSheetButton_Click(object sender, EventArgs e)
        {
            _balaceSheetform.MdiParent = this;
            _balaceSheetform.Dock = DockStyle.Fill;
            allFormHider();
            _balaceSheetform.Show();
        }
    }
}
