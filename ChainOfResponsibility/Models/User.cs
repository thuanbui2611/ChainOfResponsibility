using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Models
{
    public class User
    {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public string SocialSecurityNumber { get; set; } = string.Empty;
    }
}
