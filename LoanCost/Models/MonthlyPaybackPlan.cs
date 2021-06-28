using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using LoanCost.Services;
using static LoanCost.Services.LoanType;

namespace LoanCost.Models
{
    public class MonthlyPaybackPlan
    {
        [DisplayName("Amount Remaining")]
        public int Amount { get; set; }

        [DisplayName("Payback Time (in years)")]
        public int PaybackTime { get; set; }

        [DisplayName("Interest Type")]
        public LoanType.Interest InterestType { get; set; }

        [DisplayName("Fixed interest during complete payback time")]
        public double InterestRate { get; set; }

        [DisplayName("Amount To Pay Per Month")]
        public double AmountToPayPerMonth { get; set; }


    }
}
