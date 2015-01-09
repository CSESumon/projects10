using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobleRechargeServicesApp
{
    class Retailer
    {
        public string MobileNo { set; get; }
        public double RechargeAmount { set; get; }
        public double UsedAmount { set; get; }
        
        
        public Company RetailerCompany { set; get; }

        public double ShowCurrentBalance()
        {
            return RetailerCompany.Balance - UsedBalance();
        }

        public double UsedBalance()
        {
            
            return  UsedAmount+RechargeAmount;
        }
    }
}
