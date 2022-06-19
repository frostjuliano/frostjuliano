using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course2.Entities
{
    internal class SavingsAccount : Account
    {
        public double InterestRate { get; set; }
        public SavingsAccount()
        {

        }
        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number,holder,balance)
        {
            InterestRate = interestRate;
        }
        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }
        public override void WithDraw(double amount)  
        {
            base.WithDraw(amount);
            Balance -= 2.0;
        }
    }
}
