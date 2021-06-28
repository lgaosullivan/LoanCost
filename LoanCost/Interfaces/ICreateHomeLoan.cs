using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoanCost.Models;

namespace LoanCost.Interfaces
{
    public interface ICreateHomeLoan
    {
        public IEnumerable<MonthlyPaybackPlan> Create(MonthlyPaybackPlan model);
    }
}
