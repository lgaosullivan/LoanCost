using LoanCost.Models;

namespace LoanCost.Services
{
    public abstract class BaseLoanCalculator
    {
        protected MonthlyPaybackPlan MonthlyPaybackPlan { get; private set; }

        public BaseLoanCalculator(MonthlyPaybackPlan monthlyPaybackPlan)
        {
            MonthlyPaybackPlan = monthlyPaybackPlan;
        }
        public abstract double CalculateLoan();
    }
}
