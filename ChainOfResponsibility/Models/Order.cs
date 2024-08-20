using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Models
{
    public class Order()
    {
        public List<Item> Items { get; set; }
        public List<Payment> SelectedPayments { get; set; }

        public double AmountDue { get; set; }
        public string Status { get; set; }
    }

    public class Item()
    {
        public string Name { get; set; }
        public double Amount { get; set; }
    }


    public enum PaymentProvider
    {
        Paypal = 0,
        Invoice = 1,
        CreditCard = 2,
    }

    public enum Status
    {
        WaitForPaying = 0,
        ReadyForShippment = 1,
    }

    public class Payment()
    {
        public PaymentProvider PaymentProvider { get; set; }
        public double Amount { get; set; }
    }

}
