using ChainOfResponsibility.Models;
using ChainOfResponsibility.Processors.PaymentProcessors;

namespace ChainOfResponsibility.Handlers.PaymentHandlers
{
    public class CreditCardHandler : PaymentHandler
    {
        private CreditCardPaymentProcessor CreditCardPaymentProcessor { get; } = new CreditCardPaymentProcessor();

        public override void Handle(Order order)
        {
            if (order.SelectedPayments.Any(x => x.PaymentProvider == PaymentProvider.CreditCard))
            {
                CreditCardPaymentProcessor.Finalize(order);
            }
            base.Handle(order);
        }
    }
}
