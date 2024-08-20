using ChainOfResponsibility.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Handlers.UserValidation
{
    public class AgeValidationHandler : Handler<User>
    {
        public override void Handle(User user)
        {
            if(user.Age < 18)
            {
                throw new Exception("User below 18 years old");
            }
            Console.WriteLine("Validate age success!");
            base.Handle(user);
        }
    }
}
