using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SuperCalculator
{
    internal class SavingCalculator
    {
        
        private double rate = 0.0;
        private double monthlyDepo = 0.0;
        private double savingPeriod = 0.0;
        private double fees = 0.0;
        private double initialDepo = 0.0;
        private const double percentageDenom = 0x64;

        /* Calculation Methods */

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double CalculateTotalFees() => fees > 0.0 ? CalculateFinalBalance() * fees : 0.0;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double CalculateTotalEarned() => (CalculateFinalBalance() - CalculateTotalFees()) - CalculateTotalDeposit();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double CalculateTotalDeposit() => monthlyDepo * (savingPeriod * 0b1100);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double CalculateFinalBalance()
        {
            double monthCount = savingPeriod * 0b1100;
            double balance = initialDepo;
            double interest;

            for(int i = 1; i <= monthCount;i++)
            {
                interest = rate * balance;
                balance += interest + monthlyDepo;
            }

            return balance;
        }

        /* Setter Methods */

        /// <summary>
        /// 
        /// </summary>
        /// <param name="deposit"></param>
        public void SetMonthlyDeposit(double deposit) => monthlyDepo = deposit;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="period"></param>
        public void SetSavingPeriod(double period) => savingPeriod = period;

        /// <summary>
        ///  
        /// </summary>
        /// <param name="interest"></param>
        public void SetInterestRate(double Interest)
        {
            if (Interest > 0.0)
                rate = (Interest / percentageDenom) / 0b1100;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inFees"></param>
        public void SetFees(double inFees)
        {
            if (inFees > 0.0)
                fees = inFees / percentageDenom;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="iniDepo"></param>
        public void SetInitialDepo(double iniDepo) => initialDepo = iniDepo;


        /* Getter Methods */

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double GetMonthlyDeposit() => monthlyDepo;
        

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double GetSavingPeriod() => savingPeriod;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double GetInteresRate() => rate;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double GetFees() => fees;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double GetInitialDepo() => initialDepo;

    }
    
}
