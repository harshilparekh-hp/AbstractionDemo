using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo
{
    internal class CheckingAccount : IBank
    {
        public string AccountName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Balance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int CheckBalance()
        {
            throw new NotImplementedException();
        }

        public void DepositeAmount()
        {
            throw new NotImplementedException();
        }

        public void WithdrawAmount()
        {
            throw new NotImplementedException();
        }
    }
}
