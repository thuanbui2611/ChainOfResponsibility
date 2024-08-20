using ChainOfResponsibility.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Processors.PaymentProcessors
{
    public interface IPaymentProcessor
    {
        void Finalize(Order order);
    }
}
