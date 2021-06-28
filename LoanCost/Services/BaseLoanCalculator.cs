using LoanCost.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
