using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo
{

    /// <summary>
    /// Interface -	
    /// contract that enforces others to implement the methods and properties.
    /// And Interface does not have the feature to include implementations 
    /// (Concrete methods). To overcome this, we have Abstract classes.
    /// 
    /// Abstract Class - Abstract class will have abstract as well as non-abstract (Concrete) methods.
    /// Here, Abstract methods will be enforced to implement to those classes whoever 
    /// will inherit. However, If we dont want to enforce all the abstract methods to 
    /// the class. we can have non-abstract as well as Virtual methods.
    /// 
    /// Here, The idea of having a virtual method is -  we can have default implementation 
    /// which we can override (but no force). Its completely optional to 
    /// implement/override the virtual methods.
    /// </summary>
    internal abstract class Bank
    {

        string AccountName { get; set; }

        double Balance { get; set; }


        // constructor overloading - polymorphism
        public Bank(double balance)
        {
            this.Balance = balance;
            Console.WriteLine("parameterized constructor");

        }

        // constructor overloading - polymorphism
        public Bank()
        {
            Console.WriteLine("default constructor");
            
        }

        public abstract void WithdrawAmount(double amount);

        public abstract void DepositeAmount(double amount);

        public double CheckBalance()
        {
            // code
            // code
            Console.WriteLine("some logic to check balance");
            return (int)Balance;
        }

        public virtual void TransferBalance()
        {
            Console.WriteLine("default implementation for Transferring the balance");
        }
    }
}
