using ArmyCanteenManagementSystemTyProject.Admin_Forms;
using ArmyCanteenManagementSystemTyProject.Counter_Staff_Forms;
using ArmyCanteenManagementSystemTyProject.Crystal_Reports;
using ArmyCanteenManagementSystemTyProject.Customer_Forms;
using ArmyCanteenManagementSystemTyProject.Supplier;
using System;
using System.Windows.Forms;

namespace ArmyCanteenManagementSystemTyProject
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}