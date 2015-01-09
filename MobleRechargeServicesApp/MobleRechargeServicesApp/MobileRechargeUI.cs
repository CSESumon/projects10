using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobleRechargeServicesApp
{
    public partial class MobileRechargeUI : Form
    {
        public MobileRechargeUI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Retailer aRetailer=new Retailer();
        private void saveButton_Click(object sender, EventArgs e)
        {
            aRetailer.MobileNo = mobileNoTextBox.Text;
            Company aCompany=new Company();
            aRetailer.RetailerCompany = aCompany;
            aRetailer.RetailerCompany.Balance = Convert.ToDouble(balanceTextBox.Text);
            
        }

        private void rechargeButton_Click(object sender, EventArgs e)
        {
            aRetailer.RechargeAmount = Convert.ToDouble(rechargeTextBox.Text);

           

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            showCurrentbalanceTextBox.Text = aRetailer.ShowCurrentBalance().ToString();
            showUsedBalanceTextBox.Text = aRetailer.UsedBalance().ToString();
            aRetailer.UsedAmount = Convert.ToDouble(showUsedBalanceTextBox.Text);
        }
    }
}
