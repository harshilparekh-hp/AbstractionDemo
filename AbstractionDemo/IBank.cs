using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo
{
    internal interface IBank
    {
        string AccountName { get; set; }

        double Balance { get; set; }

        void WithdrawAmount();

        void DepositeAmount();

        int CheckBalance();
    }
}
