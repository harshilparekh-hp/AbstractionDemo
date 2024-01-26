using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo
{
    internal class SavingsAccount : Bank
    {
        public SavingsAccount() : base(100)
        {

        }

        public override void DepositeAmount(double amount)
        {
            throw new NotImplementedException();
        }

        public override void WithdrawAmount(double amount)
        {
            throw new NotImplementedException();
        }
    }
}
