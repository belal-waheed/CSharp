namespace Task04
{
    internal class Program
    {
        public interface IRefundable
        {
            void Refund();
        }
        static void Main(string[] args)
        {
            PaymentMethod[] payments = new PaymentMethod[]
            {
                new CreditCardPayment(1500),
                new CashPayment(300)
            };
            for (int i = 0; i < payments.Length; i++)
            {
                PaymentMethod payment = payments[i];
                payment.Pay();
                payment.PrintReceipt();
                if (payment is IRefundable refundablePayment)
                {
                    refundablePayment.Refund();
                }
                if (i < payments.Length - 1)
                {
                    Console.WriteLine(new string('-', 50));
                }

            }
        }
    }
}
