using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArmyCanteenManagementSystemTyProject
{
    public partial class CounterStaff : Form
    {
        public CounterStaff()
        {
            InitializeComponent();
            HomePanel.Visible = true;
            hideallPanels();         
        }
        void hideallPanels()
        {
            HomePanel.Visible = false;
            BillHistoryPanel.Visible = false;
            CustomerLoginPanel.Visible = false;
            AccountSettingPanel.Visible = false;
        }
        private void homeButton_Click(object sender, EventArgs e)
        {
            HomePanel.Visible = true;
            hideallPanels();           
        }

        private void BillHistoryButton_Click(object sender, EventArgs e)
        {
            BillHistoryPanel.Visible = true;
            hideallPanels();
        }

        private void CustomerLoginButton_Click(object sender, EventArgs e)
        {

            CustomerLoginPanel.Visible = true;
            hideallPanels();
        }

        private void AccountSettingButton_Click(object sender, EventArgs e)
        {

            AccountSettingPanel.Visible = true;
            hideallPanels();
        }
    }
}
