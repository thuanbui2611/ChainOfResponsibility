using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Handlers.PaymentHandlers
{
    public class PaymentHandler : Handler<Order>
    {
        public override void Handle(Order order)
        {
            Console.WriteLine($"Running: {GetType().Name}");

            if (Next == null && order.AmountDue > 0)
            {
                throw new Exception("Do not enough money to pay through 3 payment options");
            }

            if (order.AmountDue > 0)
            {
                Next.Handle(order);
            }
            else
            {
                order.Status = Status.ReadyForShippment.ToString();
            }

        }
    }

}
