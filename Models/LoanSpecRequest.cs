using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JR_Banqsoft.Models
{
    public class LoanSpecRequest
    {
        public int Years { get; set; }
        public int Amount { get; set; }
        public double InterestRate { get; set; }

    }
}
