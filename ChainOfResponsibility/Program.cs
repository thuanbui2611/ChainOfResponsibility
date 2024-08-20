using ChainOfResponsibility.Handlers.PaymentHandlers;
using ChainOfResponsibility.Models;

//User
//var user = new User() { Name = "User 1", Age = 18, SocialSecurityNumber = "ABC123" };

//var processor = new UserProcessor();

//var result = processor.Register(user);
//Console.WriteLine(result);

//Payment
Console.WriteLine("--Order Payment--");

var order = new Order()
{
    Items = [
        new Item() { Name = "Item 1", Amount = 1000 },
        new Item() { Name = "Item 2", Amount = 2000 }
    ],
    SelectedPayments = [
        new Payment() { Amount = 1000, PaymentProvider = PaymentProvider.Paypal },
        new Payment() { Amount = 2000, PaymentProvider = PaymentProvider.CreditCard }
    ],
    AmountDue = 3000,
    Status = Status.WaitForPaying.ToString(),
};

Console.WriteLine("**Order**");
Console.WriteLine(order.AmountDue);
Console.WriteLine(order.Status);
Console.WriteLine("--------");

// Payment flow: Paypal -> CreditCard -> Invoice
var handler = new PaypalHandler();
handler
    .SetNext(new CreditCardHandler())
    .SetNext(new InvoiceHandler());
handler.Handle(order);

Console.WriteLine("--Order--");
Console.WriteLine(order.AmountDue);
Console.WriteLine(order.Status);
Console.WriteLine("--------");
