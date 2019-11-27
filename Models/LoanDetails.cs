using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JR_Banqsoft.Models
{
    public class LoanDetails
    {
        public LoanDetails(double baseAmount, double totalAmount, double interestRate, double totalInterestAmount, IList<MonthlyPayment> monthlyPayments)
        {
            BaseAmount = baseAmount;
            TotalAmount = totalAmount;
            InterestRate = interestRate;
            TotalInterestAmount = totalInterestAmount;
            MonthlyPayments = monthlyPayments;
        }

        public double BaseAmount { get; set; }
        public double TotalAmount { get; set; }
        public double InterestRate { get; set; }
        public IList<MonthlyPayment> MonthlyPayments { get; set; }

        public double TotalInterestAmount { get; set; }
    }
}
