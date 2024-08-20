using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Processors.PaymentProcessors
{
    public class PaypalPaymentProcessor : IPaymentProcessor
    {
        public void Finalize(Order order)
        {
            var paypalPayment = order.SelectedPayments.FirstOrDefault(x => x.PaymentProvider == PaymentProvider.Paypal);
            order.AmountDue -= paypalPayment.Amount;
            Console.WriteLine("Paypal Payment Done");
        }
    }
}
