using LoanCost.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanCost.Interfaces
{
    public interface ICreateOtherLoan
    {
        public IEnumerable<MonthlyPaybackPlan> Create(MonthlyPaybackPlan model);
    }
}
