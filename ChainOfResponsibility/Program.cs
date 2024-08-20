using ChainOfResponsibility.Models;
using ChainOfResponsibility.PaymentProcessors;

var user = new User() { Name = "User 1", Age = 18, SocialSecurityNumber = "ABC123" };

var processor = new UserProcessor();

var result = processor.Register(user);
Console.WriteLine(result);