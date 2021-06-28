using LoanCost.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoanCost.Interfaces;

namespace LoanCost.Services
{
    public class HomeLoanCalculator : ICreateHomeLoan
    {
        public IEnumerable<MonthlyPaybackPlan> Create(MonthlyPaybackPlan model)
        {
            var highInterestRate = new CalculateHighInterestLoan(model);
            var mediumInterestRate = new CalculateMediumInterestLoan(model);
            var lowInterestRate = new CalculateLowInterestLoan(model);
            var list = new List<MonthlyPaybackPlan>();
            list.Add(new MonthlyPaybackPlan()
            {
                Amount = model.Amount,
                PaybackTime = model.PaybackTime,
                InterestType = LoanType.Interest.High,
                InterestRate= Math.Round((double)LoanType.Interest.High, 2),
                AmountToPayPerMonth = Math.Round(highInterestRate.CalculateLoan(), 2)
            });

            list.Add(new MonthlyPaybackPlan()
            {
                Amount = model.Amount,
                PaybackTime = model.PaybackTime,
                InterestType = LoanType.Interest.Medium,
                InterestRate = Math.Round((double)LoanType.Interest.Medium, 2),
                AmountToPayPerMonth = Math.Round(mediumInterestRate.CalculateLoan(), 2)
            });

            list.Add(new MonthlyPaybackPlan()
            {
                Amount = model.Amount,
                PaybackTime = model.PaybackTime,
                InterestType = LoanType.Interest.Low,
                InterestRate = Math.Round((double)LoanType.Interest.Low, 2),
                AmountToPayPerMonth = Math.Round(lowInterestRate.CalculateLoan(), 2)
            });

            return list;
        }
    }

    public class CalculateHighInterestLoan : BaseLoanCalculator
    {
        public CalculateHighInterestLoan(MonthlyPaybackPlan plan)
            : base(plan)
        {
        }

        public override double CalculateLoan()
        {

            double amountPerMonth = (double)(MonthlyPaybackPlan.Amount / MonthlyPaybackPlan.PaybackTime / 12);

            double interestPerMonth = (double)LoanType.Interest.High / 100 / 12;
            //return the amount per month plus calculated interest per month
            return amountPerMonth + (amountPerMonth * ((double)LoanType.Interest.High / 100 / 12));
        }
    }

    public class CalculateMediumInterestLoan : BaseLoanCalculator
    {
        public CalculateMediumInterestLoan(MonthlyPaybackPlan plan)
            : base(plan)
        {
        }

        public override double CalculateLoan()
        {

            int amountPerMonth = MonthlyPaybackPlan.Amount / MonthlyPaybackPlan.PaybackTime / 12;
            return amountPerMonth + (amountPerMonth * ((double)LoanType.Interest.Medium / 100 / 12));
        }
    }

    public class CalculateLowInterestLoan : BaseLoanCalculator
    {
        public CalculateLowInterestLoan(MonthlyPaybackPlan plan)
            : base(plan)
        {
        }

        public override double CalculateLoan()
        {
            int amountPerMonth = MonthlyPaybackPlan.Amount / MonthlyPaybackPlan.PaybackTime / 12;
            return amountPerMonth + (amountPerMonth * ((double)LoanType.Interest.Low / 100 / 12));
        }
    }

    public static class LoanType
    {
        //The interest should be connected to the loan type in such a manner
        //that different loan types can have different interests
        public enum Interest
        {
            High = 10,
            Medium = 5,
            Low = (int)3.5
        }
    }
}
