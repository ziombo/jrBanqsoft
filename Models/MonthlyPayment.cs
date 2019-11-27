using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JR_Banqsoft.Models
{
    public class MonthlyPayment
    {
        public MonthlyPayment(int orderNo, double amount)
        {
            OrderNo = orderNo;
            Amount = amount;
        }

        public int OrderNo { get; set; }
        public double Amount { get; set; }
    }
}
