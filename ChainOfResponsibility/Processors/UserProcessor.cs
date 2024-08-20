using ChainOfResponsibility.Handlers.UserValidation;
using ChainOfResponsibility.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.PaymentProcessors
{
    public class UserProcessor
    {
        public bool Register(User user)
        {
			try
			{
                var handler = new SocialSecurityNumberValidatorHandler();

                handler
                    .SetNext(new AgeValidationHandler())
                    .SetNext(new NameValidationHandler());

                handler.Handle(user);
            }
			catch (Exception)
			{

				return false;
			}

            return true;
        }
    }
}
