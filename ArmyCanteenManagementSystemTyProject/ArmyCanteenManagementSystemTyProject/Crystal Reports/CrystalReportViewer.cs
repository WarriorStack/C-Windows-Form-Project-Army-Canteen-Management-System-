using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace ArmyCanteenManagementSystemTyProject.Crystal_Reports
{
    public partial class CrystalReportViewer : Form
    {
        int inpValue = 0;
        public CrystalReportViewer()
        {
            InitializeComponent();
            //userChoiceInputBoxOpener();
        }
        //void userChoiceInputBoxOpener()
        //{
        //    /*Here I Use InputBox */
        //    int.TryParse(Interaction.InputBox("-- Enter index only --\n 1. Registration Information Cystal Report ", "Product Quantity Selector", "1"), out inpValue);
        //    manager();
        //}
        //void manager()
        //{
        //    if (inpValue == 0)
        //    {
        //        MessageBox.Show("Enter Valid Choice");
        //        userChoiceInputBoxOpener();
        //    }
        //    else if (inpValue == 1)
        //    {
        //        crystalReportViewer1.ReportSource = new RegistrationReport();
        //    }
        //}
    }
}
