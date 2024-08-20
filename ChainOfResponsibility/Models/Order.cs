using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Models
{
    public class Order()
    {
        public string Name { get; set; }
        public PaymentProvider PaymentProvider { get; set; }
        public double Amount { get; set; }
    }

    public enum PaymentProvider
    {
        Paypal = 0,
        Invoice = 1,
        CreditCard = 2,
    }
}
