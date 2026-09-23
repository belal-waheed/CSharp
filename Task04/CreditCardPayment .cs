using System;
using System.Collections.Generic;
using System.Text;
using static Task04.Program;

namespace Task04
{
    internal class CreditCardPayment : PaymentMethod, IRefundable
    {
        public CreditCardPayment(decimal amount) : base(amount)
        {
        }
        public override void Pay()
        {
            Console.WriteLine($"Paying {Amount} With Credit Card");
        }
        public void Refund()
        {
            Console.WriteLine($"Refunding {Amount} To Credit Card");
        }
    }
}
