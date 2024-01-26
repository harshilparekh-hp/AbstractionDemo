using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo
{
    internal class SpecializedAccount : Bank
    {

        public SpecializedAccount() : base(100) { }

        public override void DepositeAmount(double amount)
        {
            throw new NotImplementedException();
        }

        public override void WithdrawAmount(double amount)
        {
            throw new NotImplementedException();
        }

        //method overloading across the classes.
        public double CheckBalance(double amount)
        {
            return amount;
        }

        // here i am overriding the virtual method for transferring the balance too, but its optional
        public override void TransferBalance()
        {
            Console.WriteLine("added implementation for transferring the balance for specialized classes");
        }
    }
}
