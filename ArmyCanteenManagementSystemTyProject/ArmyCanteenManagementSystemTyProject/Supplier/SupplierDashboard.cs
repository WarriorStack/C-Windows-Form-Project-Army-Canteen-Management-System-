using ArmyCanteenManagementSystemTyProject.Counter_Staff_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArmyCanteenManagementSystemTyProject.Supplier
{
    public partial class SupplierDashboard : Form
    {
        SupplierHome _supplierHome = new SupplierHome();
        AccountSetting _accountSetting = new AccountSetting();

        public SupplierDashboard()
        {
            InitializeComponent();
            formInitializer();
            _supplierHome.Show();
        }
        private void allFormHider()
        {
            _supplierHome.Hide();
        }
        private void formInitializer()
        {
            _supplierHome.MdiParent = this;
            _supplierHome.Dock = DockStyle.Fill;

            _accountSetting.MdiParent = this;
            _accountSetting.Dock = DockStyle.Fill;
        }
        private void homeButton_Click(object sender, EventArgs e)
        {
           
            allFormHider();
            _supplierHome.Show();
        }

        private void accountSettingButton_Click(object sender, EventArgs e)
        {
            
            allFormHider();
            _accountSetting.Show();
        }
    }
}
