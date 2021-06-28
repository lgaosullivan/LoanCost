using System.ComponentModel;
using LoanCost.Services;

namespace LoanCost.Models
{
    public class MonthlyPaybackPlan
    {
        [DisplayName("Amount Remaining")]
        public int Amount { get; set; }

        [DisplayName("Payback Time (in years)")]
        public int PaybackTime { get; set; }

        [DisplayName("Interest Type")]
        public string InterestType { get; set; }

        [DisplayName("Fixed interest during complete payback time")]
        public double InterestRate { get; set; }

        [DisplayName("Amount To Pay Per Month")]
        public double AmountToPayPerMonth { get; set; }


    }
}
