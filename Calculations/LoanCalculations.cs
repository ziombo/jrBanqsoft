using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JR_Banqsoft.Models;

namespace JR_Banqsoft.Calculations
{
    public class LoanCalculations : ILoanCalculations
    {
        public double CalculateLoanPayment(DecreasingInstallmentCalculationsModel calculationsSpec)
        {
            // Decreasing installments http://matematykafinansowa.pl/jak-wyliczyc-rate-malejaca-kredytu/
            var paymentAmount = (calculationsSpec.Amount / (double)calculationsSpec.TotalNumberOfInstallments) *
                                    (1 + 
                                        ((calculationsSpec.TotalNumberOfInstallments - calculationsSpec.InstallmentNumber + 1) 
                                            * calculationsSpec.InterestRateInPercent / calculationsSpec.NumberOfInstallmentsInYear));

            return Math.Round(paymentAmount, 2);

        }
    }
}
