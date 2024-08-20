using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Processors.PaymentProcessors
{
    public class CreditCardPaymentProcessor : IPaymentProcessor
    {
        public void Finalize(Order order)
        {
            var creditCardPayment = order.SelectedPayments.FirstOrDefault(x => x.PaymentProvider == PaymentProvider.CreditCard);
            order.AmountDue -= creditCardPayment.Amount;
            Console.WriteLine("Credit Card Payment Done");
        }
    }
}
