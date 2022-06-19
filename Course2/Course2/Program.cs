using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Course2.Entities;
using System.Globalization;

namespace Course2
{
    internal class Program
    {
        static void Main(string[] args)
        {
          List<Account> list = new List<Account>();
            list.Add(new SavingsAccount(1001,"Alex",500.0,0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
            list.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
            list.Add(new BusinessAccount(1004, "Anna", 500.0, 500.0));
            double sum = 0.0;
            foreach (Account acc in list)
            {
                sum = sum + acc.Balance;
            }
            Console.WriteLine("Balance Total "+ sum.ToString("F2",CultureInfo.InvariantCulture));
            foreach (Account acc in list)
            {
                acc.WithDraw(10.0);
            }
            foreach (Account acc in list)
            {
                Console.WriteLine("Update balance for account "
                    + acc.Number + ": "
                    +acc.Balance.ToString("F2", CultureInfo.InvariantCulture) );
            }
        }
    }
}
