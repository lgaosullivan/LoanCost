using LoanCost.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoanCost.Interfaces;

namespace LoanCost.Services
{
    public class OtherLoanCalulator : ICreateOtherLoan
    {
        public IEnumerable<MonthlyPaybackPlan> Create(MonthlyPaybackPlan model)
        {
            throw new NotImplementedException();
        }
    }
}
