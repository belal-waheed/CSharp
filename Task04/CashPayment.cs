using System;
using System.Collections.Generic;
using System.Text;

namespace Task04
{
    internal class CashPayment : PaymentMethod
    {
        public CashPayment(decimal amount) : base(amount)
        {
        }
        public override void Pay()
        {
            Console.WriteLine($"Paying {Amount} in Cash");
        }
    }
}
