using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JR_Banqsoft.Models
{
    public class DecreasingInstallmentCalculationsModel
    {
        public DecreasingInstallmentCalculationsModel(int numberOfInstallmentsInYear, double interestRateInPercent, int totalNumberOfInstallments, int amount, int installmentNumber)
        {
            NumberOfInstallmentsInYear = numberOfInstallmentsInYear;
            InterestRateInPercent = interestRateInPercent;
            TotalNumberOfInstallments = totalNumberOfInstallments;
            Amount = amount;
            InstallmentNumber = installmentNumber;
        }

        public int NumberOfInstallmentsInYear { get; set; }
        public double InterestRateInPercent { get; set; }
        public int TotalNumberOfInstallments { get; set; }
        public int Amount { get; set; }
        public int InstallmentNumber { get; set; }
    }
}
