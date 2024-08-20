using ChainOfResponsibility.Models;
using ChainOfResponsibility.Processors.PaymentProcessors;

namespace ChainOfResponsibility.Handlers.PaymentHandlers
{
    public class InvoiceHandler : PaymentHandler
    {
        private InvoicePaymentProcessor InvoicePaymentProcessor { get; } = new InvoicePaymentProcessor();

        public override void Handle(Order order)
        {
            if (order.SelectedPayments.Any(x => x.PaymentProvider == PaymentProvider.Invoice))
            {
                InvoicePaymentProcessor.Finalize(order);
            }
            base.Handle(order);
        }
    }

}
