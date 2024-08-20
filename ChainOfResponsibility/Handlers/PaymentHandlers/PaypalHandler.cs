using ChainOfResponsibility.Models;
using ChainOfResponsibility.Processors.PaymentProcessors;

namespace ChainOfResponsibility.Handlers.PaymentHandlers
{
    public class PaypalHandler : PaymentHandler
    {
        private PaypalPaymentProcessor PaypalPaymentProcessor { get; } = new PaypalPaymentProcessor();

        public override void Handle(Order order)
        {
            if (order.SelectedPayments.Any(x => x.PaymentProvider == PaymentProvider.Paypal))
            {
                PaypalPaymentProcessor.Finalize(order);
            }
            base.Handle(order);
        }
    }
}
