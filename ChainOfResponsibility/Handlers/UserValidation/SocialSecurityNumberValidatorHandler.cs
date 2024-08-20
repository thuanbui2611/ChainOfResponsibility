using ChainOfResponsibility.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Handlers.UserValidation
{
    public class SocialSecurityNumberValidatorHandler : Handler<User>
    {
        public override void Handle(User user)
        {
            Console.WriteLine("Start validating SSM");
            if (user.SocialSecurityNumber != null) {
                Console.WriteLine("--Validate SSM processing--");
                ParallelLoopResult result = Parallel.For(1, 20, ValidateSocialSecurityNumber);
                Console.WriteLine("--Validate SSM done--");
            }

            base.Handle(user);
        }

        private void ValidateSocialSecurityNumber(int i)
        {
            PintInfo($"Start {i,3}");
            Task.Delay(100).Wait();
            PintInfo($"Finish {i,3}");
        }

        private void PintInfo(string info)
        {
            Console.WriteLine($"{info,10} - Task: {Task.CurrentId,3} - Thread: {Thread.CurrentThread.ManagedThreadId}");
        }
    }
}
