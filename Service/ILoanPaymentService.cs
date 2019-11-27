using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JR_Banqsoft.Models;

namespace JR_Banqsoft.Service
{
    public interface ILoanPaymentService
    {
        LoanDetails CalculateLoanPlan(LoanSpecRequest loanSpec);
    }
}
