using System;
using System.Collections.Generic;
using System.Text;

namespace Task04
{
     internal abstract class PaymentMethod
    {
        public decimal Amount { get; }
        protected PaymentMethod(decimal amount)
        {
            Amount = amount;
        }
        public void PrintReceipt()
        {
            Console.WriteLine($"    Receipt: {GetType().Name} paid ${Amount}");
        }
        public abstract void Pay();
    }

}
