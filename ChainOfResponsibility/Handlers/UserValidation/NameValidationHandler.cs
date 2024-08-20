using ChainOfResponsibility.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Handlers.UserValidation
{
    public class NameValidationHandler : Handler<User>
    {
        public override void Handle(User user)
        {
            if(user.Name.Length < 1)
            {
                throw new Exception("Name not valid!");
            }
            Console.WriteLine("Validate Name Done");
            base.Handle(user);
        }
    }
}
