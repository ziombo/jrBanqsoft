using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JR_Banqsoft.Calculations;
using JR_Banqsoft.Models;
using Microsoft.VisualBasic.CompilerServices;

namespace JR_Banqsoft.Service
{
    public class LoanPaymentService : ILoanPaymentService
    {
        private readonly ILoanCalculations _loanCalculations;

        public LoanPaymentService(ILoanCalculations loanCalculations)
        {
            _loanCalculations = loanCalculations;
        }

        public LoanDetails CalculateLoanPlan(LoanSpecRequest loanSpec)
        {
            var payments = GetLoanPayments(loanSpec);
            var paymentTotal = Math.Round(payments.Sum(p => p.Amount), 2);
            var interestTotal = Math.Round(paymentTotal - loanSpec.Amount, 2);

            var loanDetails = new LoanDetails(loanSpec.Amount, paymentTotal, loanSpec.InterestRate, interestTotal, payments);
            return loanDetails;
        }

        private IList<MonthlyPayment> GetLoanPayments(LoanSpecRequest loanSpec)
        {
            const int NumberOfInstallmentsInYear = 12;
            var interestInPercent = loanSpec.InterestRate / 100;
            var totalNumberOfInstallments = loanSpec.Years * NumberOfInstallmentsInYear;

            var payments = new List<MonthlyPayment>();
            for (int installmentNumber = 1; installmentNumber <= totalNumberOfInstallments; installmentNumber++)
            {
                var decreasingInstallmentsCalculationsModel = new DecreasingInstallmentCalculationsModel(NumberOfInstallmentsInYear, interestInPercent, totalNumberOfInstallments, loanSpec.Amount, installmentNumber);

                var paymentAmount = _loanCalculations.CalculateLoanPayment(decreasingInstallmentsCalculationsModel);

                var payment = new MonthlyPayment(installmentNumber, paymentAmount);
                payments.Add(payment);
            }

            return payments;
        }
    }
}
