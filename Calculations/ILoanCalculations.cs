using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JR_Banqsoft.Models;

namespace JR_Banqsoft.Calculations
{
    public interface ILoanCalculations
    {
        double CalculateLoanPayment(DecreasingInstallmentCalculationsModel loanSpec);
    }
}
