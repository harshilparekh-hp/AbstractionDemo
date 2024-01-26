using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.Add("hello", "world"); // example of method overloading. static polymorphism

            // example of method overriding, dynamic polymorphism
            Bank sa = new SpecializedAccount(); // o/p - added implementation for transferring the balance for specialized classes
            sa.TransferBalance();

            Console.ReadKey();
        }

        public void Add(int a, int b)
        {
            Console.WriteLine(a + ", " + b);
        }

        public void Add(float x, float y)
        {
            Console.WriteLine(x + ", " + y);
        }

        public void Add(string x, string y)
        {
            Console.WriteLine(x + ", " + y);
        }
    }
}
