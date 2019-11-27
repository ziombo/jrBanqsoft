using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JR_Banqsoft.Models;
using JR_Banqsoft.Service;
using Microsoft.AspNetCore.Mvc;

namespace JR_Banqsoft.Controllers
{
    public class LoanController : Controller
    {
        private readonly ILoanPaymentService _loanPaymentService;

        public LoanController(ILoanPaymentService loanPaymentService)
        {
            _loanPaymentService = loanPaymentService;
        }

        [HttpPost]
        public IActionResult CalculateLoanPlay([FromBody]LoanSpecRequest loanSpecRequest)
        {
            return Ok(_loanPaymentService.CalculateLoanPlan(loanSpecRequest));
        }
    }
}