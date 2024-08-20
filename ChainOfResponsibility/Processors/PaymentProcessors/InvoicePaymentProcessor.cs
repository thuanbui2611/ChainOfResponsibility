using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Processors.PaymentProcessors
{
    public class InvoicePaymentProcessor : IPaymentProcessor
    {
        public void Finalize(Order order)
        {
            var invoicePayment = order.SelectedPayments.FirstOrDefault(x => x.PaymentProvider == PaymentProvider.Invoice);
            order.AmountDue -= invoicePayment.Amount;
            Console.WriteLine("Invoice Payment Done");
        }
    }
}
